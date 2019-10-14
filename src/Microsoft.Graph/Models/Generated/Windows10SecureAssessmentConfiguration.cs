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
    /// The type Windows10Secure Assessment Configuration.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Windows10SecureAssessmentConfiguration : DeviceConfiguration
    {
    
		///<summary>
		/// The Windows10SecureAssessmentConfiguration constructor
		///</summary>
        public Windows10SecureAssessmentConfiguration()
        {
            this.ODataType = "microsoft.graph.windows10SecureAssessmentConfiguration";
        }
	
        /// <summary>
        /// Gets or sets launch uri.
        /// Url link to an assessment that's automatically loaded when the secure assessment browser is launched. It has to be a valid Url (http[s]://msdn.microsoft.com/).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "launchUri", Required = Newtonsoft.Json.Required.Default)]
        public string LaunchUri { get; set; }
    
        /// <summary>
        /// Gets or sets configuration account.
        /// The account used to configure the Windows device for taking the test. The user can be a domain account (domain/user), an AAD account (username@tenant.com) or a local account (username).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "configurationAccount", Required = Newtonsoft.Json.Required.Default)]
        public string ConfigurationAccount { get; set; }
    
        /// <summary>
        /// Gets or sets allow printing.
        /// Indicates whether or not to allow the app from printing during the test.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowPrinting", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowPrinting { get; set; }
    
        /// <summary>
        /// Gets or sets allow screen capture.
        /// Indicates whether or not to allow screen capture capability during a test.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowScreenCapture", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowScreenCapture { get; set; }
    
        /// <summary>
        /// Gets or sets allow text suggestion.
        /// Indicates whether or not to allow text suggestions during the test.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowTextSuggestion", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowTextSuggestion { get; set; }
    
    }
}

