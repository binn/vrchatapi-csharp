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
    /// Download links for various development assets.
    /// </summary>
    [DataContract(Name = "DownloadURLList")]
    public partial class DownloadURLList : IEquatable<DownloadURLList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadURLList" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DownloadURLList() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadURLList" /> class.
        /// </summary>
        /// <param name="sdk2">Download link for legacy SDK2 (required).</param>
        /// <param name="sdk3Avatars">Download link for SDK3 for Avatars (required).</param>
        /// <param name="sdk3Worlds">Download link for SDK3 for Worlds (required).</param>
        public DownloadURLList(string sdk2 = default(string), string sdk3Avatars = default(string), string sdk3Worlds = default(string))
        {
            // to ensure "sdk2" is required (not null)
            if (sdk2 == null) {
                throw new ArgumentNullException("sdk2 is a required property for DownloadURLList and cannot be null");
            }
            this.Sdk2 = sdk2;
            // to ensure "sdk3Avatars" is required (not null)
            if (sdk3Avatars == null) {
                throw new ArgumentNullException("sdk3Avatars is a required property for DownloadURLList and cannot be null");
            }
            this.Sdk3Avatars = sdk3Avatars;
            // to ensure "sdk3Worlds" is required (not null)
            if (sdk3Worlds == null) {
                throw new ArgumentNullException("sdk3Worlds is a required property for DownloadURLList and cannot be null");
            }
            this.Sdk3Worlds = sdk3Worlds;
        }

        /// <summary>
        /// Download link for legacy SDK2
        /// </summary>
        /// <value>Download link for legacy SDK2</value>
        [DataMember(Name = "sdk2", IsRequired = true, EmitDefaultValue = false)]
        [Obsolete]
        public string Sdk2 { get; set; }

        /// <summary>
        /// Download link for SDK3 for Avatars
        /// </summary>
        /// <value>Download link for SDK3 for Avatars</value>
        [DataMember(Name = "sdk3-avatars", IsRequired = true, EmitDefaultValue = false)]
        public string Sdk3Avatars { get; set; }

        /// <summary>
        /// Download link for SDK3 for Worlds
        /// </summary>
        /// <value>Download link for SDK3 for Worlds</value>
        [DataMember(Name = "sdk3-worlds", IsRequired = true, EmitDefaultValue = false)]
        public string Sdk3Worlds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DownloadURLList {\n");
            sb.Append("  Sdk2: ").Append(Sdk2).Append("\n");
            sb.Append("  Sdk3Avatars: ").Append(Sdk3Avatars).Append("\n");
            sb.Append("  Sdk3Worlds: ").Append(Sdk3Worlds).Append("\n");
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
            return this.Equals(input as DownloadURLList);
        }

        /// <summary>
        /// Returns true if DownloadURLList instances are equal
        /// </summary>
        /// <param name="input">Instance of DownloadURLList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DownloadURLList input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Sdk2 == input.Sdk2 ||
                    (this.Sdk2 != null &&
                    this.Sdk2.Equals(input.Sdk2))
                ) && 
                (
                    this.Sdk3Avatars == input.Sdk3Avatars ||
                    (this.Sdk3Avatars != null &&
                    this.Sdk3Avatars.Equals(input.Sdk3Avatars))
                ) && 
                (
                    this.Sdk3Worlds == input.Sdk3Worlds ||
                    (this.Sdk3Worlds != null &&
                    this.Sdk3Worlds.Equals(input.Sdk3Worlds))
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
                if (this.Sdk2 != null)
                    hashCode = hashCode * 59 + this.Sdk2.GetHashCode();
                if (this.Sdk3Avatars != null)
                    hashCode = hashCode * 59 + this.Sdk3Avatars.GetHashCode();
                if (this.Sdk3Worlds != null)
                    hashCode = hashCode * 59 + this.Sdk3Worlds.GetHashCode();
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
            // Sdk2 (string) minLength
            if(this.Sdk2 != null && this.Sdk2.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Sdk2, length must be greater than 1.", new [] { "Sdk2" });
            }

            // Sdk3Avatars (string) minLength
            if(this.Sdk3Avatars != null && this.Sdk3Avatars.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Sdk3Avatars, length must be greater than 1.", new [] { "Sdk3Avatars" });
            }

            // Sdk3Worlds (string) minLength
            if(this.Sdk3Worlds != null && this.Sdk3Worlds.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Sdk3Worlds, length must be greater than 1.", new [] { "Sdk3Worlds" });
            }

            yield break;
        }
    }

}
