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
    /// The type Mobile App Content.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class MobileAppContent : Entity
    {
    
		///<summary>
		/// The MobileAppContent constructor
		///</summary>
        public MobileAppContent()
        {
            this.ODataType = "microsoft.graph.mobileAppContent";
        }
	
        /// <summary>
        /// Gets or sets files.
        /// The list of files for this app content version.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "files", Required = Newtonsoft.Json.Required.Default)]
        public IMobileAppContentFilesCollectionPage Files { get; set; }
    
    }
}

