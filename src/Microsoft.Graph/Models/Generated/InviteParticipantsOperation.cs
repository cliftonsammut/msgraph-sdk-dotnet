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
    /// The type Invite Participants Operation.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class InviteParticipantsOperation : CommsOperation
    {
    
		///<summary>
		/// The InviteParticipantsOperation constructor
		///</summary>
        public InviteParticipantsOperation()
        {
            this.ODataType = "microsoft.graph.inviteParticipantsOperation";
        }
	
        /// <summary>
        /// Gets or sets participants.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "participants", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<InvitationParticipantInfo> Participants { get; set; }
    
    }
}

