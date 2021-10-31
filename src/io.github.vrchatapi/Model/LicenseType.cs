/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.5.2
 * Contact: me@ruby.js.org
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = io.github.vrchatapi.Client.OpenAPIDateConverter;

namespace io.github.vrchatapi.Model
{
    /// <summary>
    /// Defines LicenseType
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum LicenseType
    {
        /// <summary>
        /// Enum Avatar for value: avatar
        /// </summary>
        [EnumMember(Value = "avatar")]
        Avatar = 1,

        /// <summary>
        /// Enum LicenseGroup for value: licenseGroup
        /// </summary>
        [EnumMember(Value = "licenseGroup")]
        LicenseGroup = 2,

        /// <summary>
        /// Enum Permission for value: permission
        /// </summary>
        [EnumMember(Value = "permission")]
        Permission = 3,

        /// <summary>
        /// Enum Product for value: product
        /// </summary>
        [EnumMember(Value = "product")]
        Product = 4

    }

}
