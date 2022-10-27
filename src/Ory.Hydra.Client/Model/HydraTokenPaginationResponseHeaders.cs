/*
 * Ory Hydra API
 *
 * Documentation for all of Ory Hydra's APIs. 
 *
 * The version of the OpenAPI document: v2.0.1
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
    /// The &#x60;Link&#x60; HTTP header contains multiple links (&#x60;first&#x60;, &#x60;next&#x60;, &#x60;last&#x60;, &#x60;previous&#x60;) formatted as: &#x60;&lt;https://{project-slug}.projects.oryapis.com/admin/clients?limit&#x3D;{limit}&amp;offset&#x3D;{offset}&gt;; rel&#x3D;\&quot;{page}\&quot;&#x60;  For details on pagination please head over to the [pagination documentation](https://www.ory.sh/docs/ecosystem/api-design#pagination).
    /// </summary>
    [DataContract(Name = "tokenPaginationResponseHeaders")]
    public partial class HydraTokenPaginationResponseHeaders : IEquatable<HydraTokenPaginationResponseHeaders>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HydraTokenPaginationResponseHeaders" /> class.
        /// </summary>
        /// <param name="link">The Link HTTP Header  The &#x60;Link&#x60; header contains a comma-delimited list of links to the following pages:  first: The first page of results. next: The next page of results. prev: The previous page of results. last: The last page of results.  Pages are omitted if they do not exist. For example, if there is no next page, the &#x60;next&#x60; link is omitted. Examples:  &lt;/clients?limit&#x3D;5&amp;offset&#x3D;0&gt;; rel&#x3D;\&quot;first\&quot;,&lt;/clients?limit&#x3D;5&amp;offset&#x3D;15&gt;; rel&#x3D;\&quot;next\&quot;,&lt;/clients?limit&#x3D;5&amp;offset&#x3D;5&gt;; rel&#x3D;\&quot;prev\&quot;,&lt;/clients?limit&#x3D;5&amp;offset&#x3D;20&gt;; rel&#x3D;\&quot;last\&quot;.</param>
        /// <param name="xTotalCount">The X-Total-Count HTTP Header  The &#x60;X-Total-Count&#x60; header contains the total number of items in the collection..</param>
        public HydraTokenPaginationResponseHeaders(string link = default(string), long xTotalCount = default(long))
        {
            this.Link = link;
            this.XTotalCount = xTotalCount;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The Link HTTP Header  The &#x60;Link&#x60; header contains a comma-delimited list of links to the following pages:  first: The first page of results. next: The next page of results. prev: The previous page of results. last: The last page of results.  Pages are omitted if they do not exist. For example, if there is no next page, the &#x60;next&#x60; link is omitted. Examples:  &lt;/clients?limit&#x3D;5&amp;offset&#x3D;0&gt;; rel&#x3D;\&quot;first\&quot;,&lt;/clients?limit&#x3D;5&amp;offset&#x3D;15&gt;; rel&#x3D;\&quot;next\&quot;,&lt;/clients?limit&#x3D;5&amp;offset&#x3D;5&gt;; rel&#x3D;\&quot;prev\&quot;,&lt;/clients?limit&#x3D;5&amp;offset&#x3D;20&gt;; rel&#x3D;\&quot;last\&quot;
        /// </summary>
        /// <value>The Link HTTP Header  The &#x60;Link&#x60; header contains a comma-delimited list of links to the following pages:  first: The first page of results. next: The next page of results. prev: The previous page of results. last: The last page of results.  Pages are omitted if they do not exist. For example, if there is no next page, the &#x60;next&#x60; link is omitted. Examples:  &lt;/clients?limit&#x3D;5&amp;offset&#x3D;0&gt;; rel&#x3D;\&quot;first\&quot;,&lt;/clients?limit&#x3D;5&amp;offset&#x3D;15&gt;; rel&#x3D;\&quot;next\&quot;,&lt;/clients?limit&#x3D;5&amp;offset&#x3D;5&gt;; rel&#x3D;\&quot;prev\&quot;,&lt;/clients?limit&#x3D;5&amp;offset&#x3D;20&gt;; rel&#x3D;\&quot;last\&quot;</value>
        [DataMember(Name = "link", EmitDefaultValue = false)]
        public string Link { get; set; }

        /// <summary>
        /// The X-Total-Count HTTP Header  The &#x60;X-Total-Count&#x60; header contains the total number of items in the collection.
        /// </summary>
        /// <value>The X-Total-Count HTTP Header  The &#x60;X-Total-Count&#x60; header contains the total number of items in the collection.</value>
        [DataMember(Name = "x-total-count", EmitDefaultValue = false)]
        public long XTotalCount { get; set; }

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
            sb.Append("class HydraTokenPaginationResponseHeaders {\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
            sb.Append("  XTotalCount: ").Append(XTotalCount).Append("\n");
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
            return this.Equals(input as HydraTokenPaginationResponseHeaders);
        }

        /// <summary>
        /// Returns true if HydraTokenPaginationResponseHeaders instances are equal
        /// </summary>
        /// <param name="input">Instance of HydraTokenPaginationResponseHeaders to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HydraTokenPaginationResponseHeaders input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Link == input.Link ||
                    (this.Link != null &&
                    this.Link.Equals(input.Link))
                ) && 
                (
                    this.XTotalCount == input.XTotalCount ||
                    this.XTotalCount.Equals(input.XTotalCount)
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
                if (this.Link != null)
                {
                    hashCode = (hashCode * 59) + this.Link.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.XTotalCount.GetHashCode();
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
