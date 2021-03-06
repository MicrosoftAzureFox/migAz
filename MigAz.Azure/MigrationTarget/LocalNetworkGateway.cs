﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MigAz.Core;
using MigAz.Core.ArmTemplate;
using MigAz.Core.Interface;

namespace MigAz.Azure.MigrationTarget
{
    public class LocalNetworkGateway : Core.MigrationTarget
    {
        private ILocalNetworkGateway _SourceLocalNetworkGateway;

        #region Constructors

        private LocalNetworkGateway() : base(ArmConst.MicrosoftNetwork, ArmConst.LocalNetworkGateways) { }

        public LocalNetworkGateway(ILocalNetworkGateway localNetworkGateway, TargetSettings targetSettings) : base(ArmConst.MicrosoftNetwork, ArmConst.LocalNetworkGateways)
        {
            this._SourceLocalNetworkGateway = localNetworkGateway;
            this.SetTargetName(this.SourceName, targetSettings);
        }

        #endregion

        public ILocalNetworkGateway SourceLocalNetworkGateway { get { return _SourceLocalNetworkGateway; } }

        public String SourceName
        {
            get
            {
                if (this.SourceLocalNetworkGateway == null)
                    return String.Empty;
                else
                    return this.SourceLocalNetworkGateway.ToString();
            }
        }


        public override string ImageKey { get { return "LocalNetworkGateway"; } }

        public override string FriendlyObjectName { get { return "Local Network Gateway"; } }

        public override void SetTargetName(string targetName, TargetSettings targetSettings)
        {
            this.TargetName = targetName.Trim().Replace(" ", String.Empty);
            this.TargetNameResult = this.TargetName;
        }
    }
}
