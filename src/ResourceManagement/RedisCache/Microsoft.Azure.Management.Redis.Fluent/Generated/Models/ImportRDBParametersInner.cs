// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Redis.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// Parameters for redis import operation.
    /// </summary>
    public partial class ImportRDBParametersInner
    {
        /// <summary>
        /// Initializes a new instance of the ImportRDBParametersInner class.
        /// </summary>
        public ImportRDBParametersInner() { }

        /// <summary>
        /// Initializes a new instance of the ImportRDBParametersInner class.
        /// </summary>
        /// <param name="files">files to import</param>
        /// <param name="format">File format.</param>
        public ImportRDBParametersInner(System.Collections.Generic.IList<string> files, string format = default(string))
        {
            Format = format;
            Files = files;
        }

        /// <summary>
        /// Gets or sets file format.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "format")]
        public string Format { get; set; }

        /// <summary>
        /// Gets or sets files to import
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "files")]
        public System.Collections.Generic.IList<string> Files { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Files == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Files");
            }
        }
    }
}