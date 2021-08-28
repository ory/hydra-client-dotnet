/*
 * ORY Hydra
 *
 * Welcome to the ORY Hydra HTTP API documentation. You will find documentation for all HTTP APIs here.
 *
 * The version of the OpenAPI document: v1.10.6
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
    /// PluginConfigInterface The interface between Docker and the plugin
    /// </summary>
    [DataContract(Name = "PluginConfigInterface")]
    public partial class HydraPluginConfigInterface : IEquatable<HydraPluginConfigInterface>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HydraPluginConfigInterface" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected HydraPluginConfigInterface()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="HydraPluginConfigInterface" /> class.
        /// </summary>
        /// <param name="socket">socket (required).</param>
        /// <param name="types">types (required).</param>
        public HydraPluginConfigInterface(string socket = default(string), List<HydraPluginInterfaceType> types = default(List<HydraPluginInterfaceType>))
        {
            // to ensure "socket" is required (not null)
            this.Socket = socket ?? throw new ArgumentNullException("socket is a required property for HydraPluginConfigInterface and cannot be null");
            // to ensure "types" is required (not null)
            this.Types = types ?? throw new ArgumentNullException("types is a required property for HydraPluginConfigInterface and cannot be null");
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// socket
        /// </summary>
        /// <value>socket</value>
        [DataMember(Name = "Socket", IsRequired = true, EmitDefaultValue = false)]
        public string Socket { get; set; }

        /// <summary>
        /// types
        /// </summary>
        /// <value>types</value>
        [DataMember(Name = "Types", IsRequired = true, EmitDefaultValue = false)]
        public List<HydraPluginInterfaceType> Types { get; set; }

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
            var sb = new StringBuilder();
            sb.Append("class HydraPluginConfigInterface {\n");
            sb.Append("  Socket: ").Append(Socket).Append("\n");
            sb.Append("  Types: ").Append(Types).Append("\n");
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
            return this.Equals(input as HydraPluginConfigInterface);
        }

        /// <summary>
        /// Returns true if HydraPluginConfigInterface instances are equal
        /// </summary>
        /// <param name="input">Instance of HydraPluginConfigInterface to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HydraPluginConfigInterface input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Socket == input.Socket ||
                    (this.Socket != null &&
                    this.Socket.Equals(input.Socket))
                ) && 
                (
                    this.Types == input.Types ||
                    this.Types != null &&
                    input.Types != null &&
                    this.Types.SequenceEqual(input.Types)
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
                if (this.Socket != null)
                    hashCode = hashCode * 59 + this.Socket.GetHashCode();
                if (this.Types != null)
                    hashCode = hashCode * 59 + this.Types.GetHashCode();
                if (this.AdditionalProperties != null)
                    hashCode = hashCode * 59 + this.AdditionalProperties.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
