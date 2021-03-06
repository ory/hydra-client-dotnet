/*
 * Ory Hydra API
 *
 * Documentation for all of Ory Hydra's APIs. 
 *
 * The version of the OpenAPI document: v1.11.8
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
    /// HydraRefreshTokenHookResponse
    /// </summary>
    [DataContract(Name = "refreshTokenHookResponse")]
    public partial class HydraRefreshTokenHookResponse : IEquatable<HydraRefreshTokenHookResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HydraRefreshTokenHookResponse" /> class.
        /// </summary>
        /// <param name="session">session.</param>
        public HydraRefreshTokenHookResponse(HydraConsentRequestSession session = default(HydraConsentRequestSession))
        {
            this.Session = session;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Session
        /// </summary>
        [DataMember(Name = "session", EmitDefaultValue = false)]
        public HydraConsentRequestSession Session { get; set; }

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
            sb.Append("class HydraRefreshTokenHookResponse {\n");
            sb.Append("  Session: ").Append(Session).Append("\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as HydraRefreshTokenHookResponse);
        }

        /// <summary>
        /// Returns true if HydraRefreshTokenHookResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of HydraRefreshTokenHookResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HydraRefreshTokenHookResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Session == input.Session ||
                    (this.Session != null &&
                    this.Session.Equals(input.Session))
                )
                && (this.AdditionalProperties.Count == input.AdditionalProperties.Count && !this.AdditionalProperties.Except(input.AdditionalProperties).Any());
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Session != null)
                {
                    hashCode = (hashCode * 59) + this.Session.GetHashCode();
                }
                if (this.AdditionalProperties != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalProperties.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
