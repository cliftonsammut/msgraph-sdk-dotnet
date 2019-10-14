// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Managed Device Mobile App Configuration User Summary.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ManagedDeviceMobileAppConfigurationUserSummary : Entity
    {
    
		///<summary>
		/// The ManagedDeviceMobileAppConfigurationUserSummary constructor
		///</summary>
        public ManagedDeviceMobileAppConfigurationUserSummary()
        {
            this.ODataType = "microsoft.graph.managedDeviceMobileAppConfigurationUserSummary";
        }
	
        /// <summary>
        /// Gets or sets pending count.
        /// Number of pending Users
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pendingCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PendingCount { get; set; }
    
        /// <summary>
        /// Gets or sets not applicable count.
        /// Number of not applicable users
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "notApplicableCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? NotApplicableCount { get; set; }
    
        /// <summary>
        /// Gets or sets success count.
        /// Number of succeeded Users
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "successCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? SuccessCount { get; set; }
    
        /// <summary>
        /// Gets or sets error count.
        /// Number of error Users
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "errorCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? ErrorCount { get; set; }
    
        /// <summary>
        /// Gets or sets failed count.
        /// Number of failed Users
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "failedCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? FailedCount { get; set; }
    
        /// <summary>
        /// Gets or sets last update date time.
        /// Last update time
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastUpdateDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastUpdateDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets configuration version.
        /// Version of the policy for that overview
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "configurationVersion", Required = Newtonsoft.Json.Required.Default)]
        public Int32? ConfigurationVersion { get; set; }
    
    }
}

