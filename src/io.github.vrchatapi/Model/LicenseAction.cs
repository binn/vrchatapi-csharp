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
    /// Defines LicenseAction
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum LicenseAction
    {
        /// <summary>
        /// Enum Wear for value: wear
        /// </summary>
        [EnumMember(Value = "wear")]
        Wear = 1,

        /// <summary>
        /// Enum Have for value: have
        /// </summary>
        [EnumMember(Value = "have")]
        Have = 2

    }

}
