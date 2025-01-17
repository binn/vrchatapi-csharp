/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.6.0
 * Contact: me@ruby.js.org
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
using OpenAPIDateConverter = VRChat.API.Client.OpenAPIDateConverter;

namespace VRChat.API.Model
{
    /// <summary>
    /// InviteRequest
    /// </summary>
    [DataContract(Name = "InviteRequest")]
    public partial class InviteRequest : IEquatable<InviteRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InviteRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InviteRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InviteRequest" /> class.
        /// </summary>
        /// <param name="instanceId">InstanceID be \&quot;offline\&quot; on User profiles if you are not friends with that user. (required).</param>
        public InviteRequest(string instanceId = default(string))
        {
            // to ensure "instanceId" is required (not null)
            if (instanceId == null) {
                throw new ArgumentNullException("instanceId is a required property for InviteRequest and cannot be null");
            }
            this.InstanceId = instanceId;
        }

        /// <summary>
        /// InstanceID be \&quot;offline\&quot; on User profiles if you are not friends with that user.
        /// </summary>
        /// <value>InstanceID be \&quot;offline\&quot; on User profiles if you are not friends with that user.</value>
        [DataMember(Name = "instanceId", IsRequired = true, EmitDefaultValue = false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InviteRequest {\n");
            sb.Append("  InstanceId: ").Append(InstanceId).Append("\n");
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
            return this.Equals(input as InviteRequest);
        }

        /// <summary>
        /// Returns true if InviteRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of InviteRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InviteRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                );
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
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
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
            // InstanceId (string) minLength
            if(this.InstanceId != null && this.InstanceId.Length < 41)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InstanceId, length must be greater than 41.", new [] { "InstanceId" });
            }

            // InstanceId (string) pattern
            Regex regexInstanceId = new Regex(@"(offline|(wrld|wld)_[0-9a-fA-F]{8}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{12}:(\\d+)(~region\\(([\\w]+)\\))?(~([\\w]+)\\(usr_([\\w-]+)\\)((\\~canRequestInvite)?)(~region\\(([\\w].+)\\))?~nonce\\((.+)\\))?)", RegexOptions.CultureInvariant);
            if (false == regexInstanceId.Match(this.InstanceId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InstanceId, must match a pattern of " + regexInstanceId, new [] { "InstanceId" });
            }

            yield break;
        }
    }

}
