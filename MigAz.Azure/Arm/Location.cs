﻿using Newtonsoft.Json.Linq;
using MigAz.Azure.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;
using MigAz.Core.Interface;

namespace MigAz.Azure.Arm
{
    public class Location : ILocation
    {
        private AzureContext _AzureContext;
        private AzureSubscription _AzureSubscription;
        private JToken _LocationToken;
        private List<VMSize> _VMSizes;

        #region Constructors

        private Location() { }

        public Location(AzureContext azureContext, AzureSubscription azureSubscription, JToken locationToken)
        {
            this._AzureContext = azureContext;
            this._AzureSubscription = azureSubscription;
            this._LocationToken = locationToken;
        }

        internal async Task InitializeChildrenAsync()
        {
            await this.AzureSubscription.GetResourceManagerProviders();
            await this.AzureSubscription.GetAzureARMLocationVMSizes(this);
        }

        #endregion

        #region Properties

        public string Id
        {
            get { return (string)_LocationToken["id"]; }
        }

        public string DisplayName
        {
            get { return (string)_LocationToken["displayName"]; }
        }

        public string Longitude
        {
            get { return (string)_LocationToken["longitude"]; }
        }

        public string Latitude
        {
            get { return (string)_LocationToken["latitude"]; }
        }

        public string Name
        {
            get { return (string)_LocationToken["name"]; }
        }


        public AzureSubscription AzureSubscription
        {
            get { return _AzureSubscription; }
        }

        public List<VMSize> VMSizes
        {
            get { return _VMSizes; }
            set { _VMSizes = value; }
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return this.DisplayName;
        }

        #endregion
    }
}
