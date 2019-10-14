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
    /// The type Organization.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Organization : DirectoryObject
    {
    
		///<summary>
		/// The Organization constructor
		///</summary>
        public Organization()
        {
            this.ODataType = "microsoft.graph.organization";
        }
	
        /// <summary>
        /// Gets or sets assigned plans.
        /// The collection of service plans associated with the tenant. Not nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "assignedPlans", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<AssignedPlan> AssignedPlans { get; set; }
    
        /// <summary>
        /// Gets or sets business phones.
        /// Telephone number for the organization. NOTE: Although this is a string collection, only one number can be set for this property.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "businessPhones", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> BusinessPhones { get; set; }
    
        /// <summary>
        /// Gets or sets city.
        /// City name of the address for the organization.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "city", Required = Newtonsoft.Json.Required.Default)]
        public string City { get; set; }
    
        /// <summary>
        /// Gets or sets country.
        /// Country/region name of the address for the organization.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "country", Required = Newtonsoft.Json.Required.Default)]
        public string Country { get; set; }
    
        /// <summary>
        /// Gets or sets country letter code.
        /// Country/region abbreviation for the organization.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "countryLetterCode", Required = Newtonsoft.Json.Required.Default)]
        public string CountryLetterCode { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// Timestamp of when the organization was created. The value cannot be modified and is automatically populated when the organization is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The display name for the tenant.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets marketing notification emails.
        /// Not nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "marketingNotificationEmails", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> MarketingNotificationEmails { get; set; }
    
        /// <summary>
        /// Gets or sets on premises last sync date time.
        /// The time and date at which the tenant was last synced with the on-premise directory. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "onPremisesLastSyncDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? OnPremisesLastSyncDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets on premises sync enabled.
        /// true if this object is synced from an on-premises directory; false if this object was originally synced from an on-premises directory but is no longer synced; null if this object has never been synced from an on-premises directory (default).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "onPremisesSyncEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? OnPremisesSyncEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets postal code.
        /// Postal code of the address for the organization.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "postalCode", Required = Newtonsoft.Json.Required.Default)]
        public string PostalCode { get; set; }
    
        /// <summary>
        /// Gets or sets preferred language.
        /// The preferred language for the organization. Should follow ISO 639-1 Code; for example 'en'.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "preferredLanguage", Required = Newtonsoft.Json.Required.Default)]
        public string PreferredLanguage { get; set; }
    
        /// <summary>
        /// Gets or sets privacy profile.
        /// The privacy profile of an organization.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "privacyProfile", Required = Newtonsoft.Json.Required.Default)]
        public PrivacyProfile PrivacyProfile { get; set; }
    
        /// <summary>
        /// Gets or sets provisioned plans.
        /// Not nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "provisionedPlans", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<ProvisionedPlan> ProvisionedPlans { get; set; }
    
        /// <summary>
        /// Gets or sets security compliance notification mails.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "securityComplianceNotificationMails", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> SecurityComplianceNotificationMails { get; set; }
    
        /// <summary>
        /// Gets or sets security compliance notification phones.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "securityComplianceNotificationPhones", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> SecurityComplianceNotificationPhones { get; set; }
    
        /// <summary>
        /// Gets or sets state.
        /// State name of the address for the organization.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "state", Required = Newtonsoft.Json.Required.Default)]
        public string State { get; set; }
    
        /// <summary>
        /// Gets or sets street.
        /// Street name of the address for organization.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "street", Required = Newtonsoft.Json.Required.Default)]
        public string Street { get; set; }
    
        /// <summary>
        /// Gets or sets technical notification mails.
        /// Not nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "technicalNotificationMails", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> TechnicalNotificationMails { get; set; }
    
        /// <summary>
        /// Gets or sets verified domains.
        /// The collection of domains associated with this tenant. Not nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "verifiedDomains", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<VerifiedDomain> VerifiedDomains { get; set; }
    
        /// <summary>
        /// Gets or sets mobile device management authority.
        /// Mobile device management authority. Possible values are: unknown, intune, sccm, office365.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mobileDeviceManagementAuthority", Required = Newtonsoft.Json.Required.Default)]
        public MdmAuthority? MobileDeviceManagementAuthority { get; set; }
    
        /// <summary>
        /// Gets or sets extensions.
        /// The collection of open extensions defined for the organization. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "extensions", Required = Newtonsoft.Json.Required.Default)]
        public IOrganizationExtensionsCollectionPage Extensions { get; set; }
    
    }
}

