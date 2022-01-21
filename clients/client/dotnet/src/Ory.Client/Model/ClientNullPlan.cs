/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.0.1-alpha.58
 * Contact: support@ory.sh
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
using OpenAPIDateConverter = Ory.Client.Client.OpenAPIDateConverter;

namespace Ory.Client.Model
{
    /// <summary>
    /// Defines NullPlan
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ClientNullPlan
    {
        /// <summary>
        /// Enum Unknown for value: unknown
        /// </summary>
        [EnumMember(Value = "unknown")]
        Unknown = 1,

        /// <summary>
        /// Enum Free for value: free
        /// </summary>
        [EnumMember(Value = "free")]
        Free = 2,

        /// <summary>
        /// Enum StartUpMonthly for value: start_up_monthly
        /// </summary>
        [EnumMember(Value = "start_up_monthly")]
        StartUpMonthly = 3,

        /// <summary>
        /// Enum StartUpYearly for value: start_up_yearly
        /// </summary>
        [EnumMember(Value = "start_up_yearly")]
        StartUpYearly = 4,

        /// <summary>
        /// Enum Custom for value: custom
        /// </summary>
        [EnumMember(Value = "custom")]
        Custom = 5

    }

}
