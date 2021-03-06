// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Microsoft.IdentityModel.Clients.ActiveDirectory;
using MigAz.Azure.Interface;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigAz.Azure
{
    public class AzureTenant
    {
        private AzureContext _AzureContext;
        private JObject _TenantJson;
        private List<AzureDomain> _Domains;
        private List<AzureSubscription> _Subscriptions;
        private ITokenProvider _TokenProvider;

        internal AzureTenant(AzureContext azureContext, JObject tenantsJson)
        {
            _AzureContext = azureContext;
            _TenantJson = tenantsJson;
        }

        public AzureContext AzureContext
        {
            get { return _AzureContext; }
        }

        public string Id
        {
            get { return (string)_TenantJson["id"]; }
        }
        public Guid TenantId
        {
            get { return new Guid((string)_TenantJson["tenantId"]); }
        }
        public AzureDomain DefaultDomain
        {
            get
            {
                if (Domains == null)
                    return null;

                foreach (AzureDomain azureDomain in Domains)
                {
                    if (azureDomain.IsDefault)
                        return azureDomain;
                }

                return null;
            }
        }

        public override string ToString()
        {
            if (DefaultDomain == null)
                return TenantId.ToString();
            else
                return DefaultDomain.Name + " (" + TenantId + ")";
        }

        public List<AzureDomain> Domains
        {
            get { return _Domains; }
        }

        public List<AzureSubscription> Subscriptions
        {
            get { return _Subscriptions; }
        }

        public ITokenProvider TokenProvider
        {
            get { return _TokenProvider; }
            set { _TokenProvider = value; }
        }

        public async Task InitializeChildren(AzureContext azureContext, bool allowRestCacheUse = false)
        {
            _Domains = await this.GetAzureARMDomains(azureContext, allowRestCacheUse);
            _Subscriptions = await this.GetAzureARMSubscriptions(azureContext, allowRestCacheUse);
        }


        public async Task<List<AzureDomain>> GetAzureARMDomains(AzureContext azureContext, bool allowRestCacheUse = false)
        {
            azureContext.LogProvider.WriteLog("GetAzureARMDomains", "Start");

            if (this == null)
                throw new ArgumentNullException("AzureContext is null.  Unable to call Azure API without Azure Context.");
            if (azureContext.TokenProvider == null)
                throw new ArgumentNullException("TokenProvider Context is null.  Unable to call Azure API without TokenProvider.");

            String domainUrl = azureContext.AzureEnvironment.GraphEndpoint + "myorganization/domains?api-version=1.6";

            AuthenticationResult tenantAuthenticationResult = await azureContext.TokenProvider.GetToken(azureContext.AzureEnvironment.GraphEndpoint, this.TenantId, PromptBehavior.Never);

            azureContext.StatusProvider.UpdateStatus("BUSY: Getting Tenant Domain details from Graph...");

            AzureRestRequest azureRestRequest = new AzureRestRequest(domainUrl, tenantAuthenticationResult, "GET", allowRestCacheUse);
            AzureRestResponse azureRestResponse = await azureContext.AzureRetriever.GetAzureRestResponse(azureRestRequest);
            JObject domainsJson = JObject.Parse(azureRestResponse.Response);

            var domains = from domain in domainsJson["value"]
                          select domain;

            List<AzureDomain> armTenantDomains = new List<AzureDomain>();

            foreach (JObject domainJson in domains)
            {
                AzureDomain azureDomain = new AzureDomain(this, domainJson);
                armTenantDomains.Add(azureDomain);
            }

            return armTenantDomains;
        }

        /// <summary>
        /// Get Azure Subscriptions within the provided Azure Tenant
        /// </summary>
        /// <param name="azureTenant">Azure Tenant for which Azure Subscriptions should be retrieved</param>
        /// <param name="allowRestCacheUse">False in production use so that Azure Token Content is Tenant specific.  True in Unit Tests to allow offline (no actual URL querying).</param>
        /// <returns></returns>
        public async Task<List<AzureSubscription>> GetAzureARMSubscriptions(AzureContext azureContext, bool allowRestCacheUse = false)
        {
            azureContext.LogProvider.WriteLog("GetAzureARMSubscriptions", "Start - azureTenant: " + this.ToString());

            azureContext.StatusProvider.UpdateStatus("BUSY: Getting Auth Token to Query Subscriptions");

            String subscriptionsUrl = azureContext.AzureEnvironment.ResourceManagerEndpoint + "subscriptions?api-version=2015-01-01";
            AuthenticationResult authenticationResult = await azureContext.TokenProvider.GetToken(azureContext.AzureEnvironment.ResourceManagerEndpoint, this.TenantId);

            azureContext.StatusProvider.UpdateStatus("BUSY: Querying Subscriptions");

            AzureRestRequest azureRestRequest = new AzureRestRequest(subscriptionsUrl, authenticationResult, "GET", allowRestCacheUse);
            AzureRestResponse azureRestResponse = await azureContext.AzureRetriever.GetAzureRestResponse(azureRestRequest);
            JObject subscriptionsJson = JObject.Parse(azureRestResponse.Response);

            var subscriptions = from subscription in subscriptionsJson["value"]
                                select subscription;

            azureContext.StatusProvider.UpdateStatus("BUSY: Instantiating Subscriptions");

            List<AzureSubscription> azureSubscriptions = new List<AzureSubscription>();

            foreach (JObject azureSubscriptionJson in subscriptions)
            {
                AzureSubscription azureSubscription = new AzureSubscription(azureSubscriptionJson, this, azureContext.AzureEnvironment, azureContext.GetARMServiceManagementUrl(), azureContext.GetARMTokenResourceUrl());
                azureSubscriptions.Add(azureSubscription);

                azureContext.StatusProvider.UpdateStatus("BUSY: Loaded Subscription " + azureSubscription.ToString());
            }

            azureContext.StatusProvider.UpdateStatus("BUSY: Getting Subscriptions Completed");

            return azureSubscriptions;
        }

        public static bool operator ==(AzureTenant lhs, AzureTenant rhs)
        {
            bool status = false;
            if (((object)lhs == null && (object)rhs == null) ||
                    ((object)lhs != null && (object)rhs != null && lhs.TenantId == rhs.TenantId))
            {
                status = true;
            }
            return status;
        }

        public static bool operator !=(AzureTenant lhs, AzureTenant rhs)
        {
            return !(lhs == rhs);
        }
    }
}

