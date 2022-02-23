/*
 * Ory Oathkeeper API
 *
 * Documentation for all of Ory Oathkeeper's APIs. 
 *
 * The version of the OpenAPI document: v1.11.6
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
    /// HydraRequestWasHandledResponse
    /// </summary>
    [DataContract(Name = "requestWasHandledResponse")]
    public partial class HydraRequestWasHandledResponse : IEquatable<HydraRequestWasHandledResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HydraRequestWasHandledResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected HydraRequestWasHandledResponse()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="HydraRequestWasHandledResponse" /> class.
        /// </summary>
        /// <param name="redirectTo">Original request URL to which you should redirect the user if request was already handled. (required).</param>
        public HydraRequestWasHandledResponse(string redirectTo = default(string))
        {
            // to ensure "redirectTo" is required (not null)
            if (redirectTo == null) {
                throw new ArgumentNullException("redirectTo is a required property for HydraRequestWasHandledResponse and cannot be null");
            }
            this.RedirectTo = redirectTo;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Original request URL to which you should redirect the user if request was already handled.
        /// </summary>
        /// <value>Original request URL to which you should redirect the user if request was already handled.</value>
        [DataMember(Name = "redirect_to", IsRequired = true, EmitDefaultValue = false)]
        public string RedirectTo { get; set; }

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
            sb.Append("class HydraRequestWasHandledResponse {\n");
            sb.Append("  RedirectTo: ").Append(RedirectTo).Append("\n");
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
            return this.Equals(input as HydraRequestWasHandledResponse);
        }

        /// <summary>
        /// Returns true if HydraRequestWasHandledResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of HydraRequestWasHandledResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HydraRequestWasHandledResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RedirectTo == input.RedirectTo ||
                    (this.RedirectTo != null &&
                    this.RedirectTo.Equals(input.RedirectTo))
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
                if (this.RedirectTo != null)
                {
                    hashCode = (hashCode * 59) + this.RedirectTo.GetHashCode();
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
