/*
 * Ory Hydra API
 *
 * Documentation for all of Ory Hydra's APIs. 
 *
 * The version of the OpenAPI document: v2.4.0-alpha.1
 * Contact: hi@ory.sh
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Ory.Hydra.Client.Client.OpenAPIDateConverter;

namespace Ory.Hydra.Client.Model
{
    /// <summary>
    /// HydraDeviceUserAuthRequest
    /// </summary>
    [DataContract(Name = "DeviceUserAuthRequest")]
    public partial class HydraDeviceUserAuthRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HydraDeviceUserAuthRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected HydraDeviceUserAuthRequest()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="HydraDeviceUserAuthRequest" /> class.
        /// </summary>
        /// <param name="challenge">ID is the identifier (\&quot;device challenge\&quot;) of the device grant request. It is used to identify the session. (required).</param>
        /// <param name="varClient">varClient.</param>
        /// <param name="handledAt">handledAt.</param>
        /// <param name="requestUrl">RequestURL is the original Device Authorization URL requested..</param>
        /// <param name="requestedAccessTokenAudience">requestedAccessTokenAudience.</param>
        /// <param name="requestedScope">requestedScope.</param>
        public HydraDeviceUserAuthRequest(string challenge = default(string), HydraOAuth2Client varClient = default(HydraOAuth2Client), DateTime handledAt = default(DateTime), string requestUrl = default(string), List<string> requestedAccessTokenAudience = default(List<string>), List<string> requestedScope = default(List<string>))
        {
            // to ensure "challenge" is required (not null)
            if (challenge == null)
            {
                throw new ArgumentNullException("challenge is a required property for HydraDeviceUserAuthRequest and cannot be null");
            }
            this.Challenge = challenge;
            this.VarClient = varClient;
            this.HandledAt = handledAt;
            this.RequestUrl = requestUrl;
            this.RequestedAccessTokenAudience = requestedAccessTokenAudience;
            this.RequestedScope = requestedScope;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// ID is the identifier (\&quot;device challenge\&quot;) of the device grant request. It is used to identify the session.
        /// </summary>
        /// <value>ID is the identifier (\&quot;device challenge\&quot;) of the device grant request. It is used to identify the session.</value>
        [DataMember(Name = "challenge", IsRequired = true, EmitDefaultValue = true)]
        public string Challenge { get; set; }

        /// <summary>
        /// Gets or Sets VarClient
        /// </summary>
        [DataMember(Name = "client", EmitDefaultValue = false)]
        public HydraOAuth2Client VarClient { get; set; }

        /// <summary>
        /// Gets or Sets HandledAt
        /// </summary>
        [DataMember(Name = "handled_at", EmitDefaultValue = false)]
        public DateTime HandledAt { get; set; }

        /// <summary>
        /// RequestURL is the original Device Authorization URL requested.
        /// </summary>
        /// <value>RequestURL is the original Device Authorization URL requested.</value>
        [DataMember(Name = "request_url", EmitDefaultValue = false)]
        public string RequestUrl { get; set; }

        /// <summary>
        /// Gets or Sets RequestedAccessTokenAudience
        /// </summary>
        [DataMember(Name = "requested_access_token_audience", EmitDefaultValue = false)]
        public List<string> RequestedAccessTokenAudience { get; set; }

        /// <summary>
        /// Gets or Sets RequestedScope
        /// </summary>
        [DataMember(Name = "requested_scope", EmitDefaultValue = false)]
        public List<string> RequestedScope { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class HydraDeviceUserAuthRequest {\n");
            sb.Append("  Challenge: ").Append(Challenge).Append("\n");
            sb.Append("  VarClient: ").Append(VarClient).Append("\n");
            sb.Append("  HandledAt: ").Append(HandledAt).Append("\n");
            sb.Append("  RequestUrl: ").Append(RequestUrl).Append("\n");
            sb.Append("  RequestedAccessTokenAudience: ").Append(RequestedAccessTokenAudience).Append("\n");
            sb.Append("  RequestedScope: ").Append(RequestedScope).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
