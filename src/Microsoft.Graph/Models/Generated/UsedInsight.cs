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
    /// The type Used Insight.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class UsedInsight : Entity
    {
    
		///<summary>
		/// The UsedInsight constructor
		///</summary>
        public UsedInsight()
        {
            this.ODataType = "microsoft.graph.usedInsight";
        }
	
        /// <summary>
        /// Gets or sets last used.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastUsed", Required = Newtonsoft.Json.Required.Default)]
        public UsageDetails LastUsed { get; set; }
    
        /// <summary>
        /// Gets or sets resource visualization.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "resourceVisualization", Required = Newtonsoft.Json.Required.Default)]
        public ResourceVisualization ResourceVisualization { get; set; }
    
        /// <summary>
        /// Gets or sets resource reference.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "resourceReference", Required = Newtonsoft.Json.Required.Default)]
        public ResourceReference ResourceReference { get; set; }
    
        /// <summary>
        /// Gets or sets resource.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "resource", Required = Newtonsoft.Json.Required.Default)]
        public Entity Resource { get; set; }
    
    }
}

