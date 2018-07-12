// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Data factory name for linked integration runtime request.
    /// </summary>
    public partial class LinkedIntegrationRuntimeRequest
    {
        /// <summary>
        /// Initializes a new instance of the LinkedIntegrationRuntimeRequest
        /// class.
        /// </summary>
        public LinkedIntegrationRuntimeRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LinkedIntegrationRuntimeRequest
        /// class.
        /// </summary>
        /// <param name="linkedFactoryName">The data factory name for linked
        /// integration runtime.</param>
        public LinkedIntegrationRuntimeRequest(string linkedFactoryName)
        {
            LinkedFactoryName = linkedFactoryName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the data factory name for linked integration runtime.
        /// </summary>
        [JsonProperty(PropertyName = "factoryName")]
        public string LinkedFactoryName { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (LinkedFactoryName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "LinkedFactoryName");
            }
        }
    }
}
