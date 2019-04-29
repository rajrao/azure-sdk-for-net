// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Billing
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// BillingRoleAssignmentsOperations operations.
    /// </summary>
    public partial interface IBillingRoleAssignmentsOperations
    {
        /// <summary>
        /// Get the role assignment for the caller
        /// </summary>
        /// <param name='billingAccountName'>
        /// billing Account Id.
        /// </param>
        /// <param name='billingRoleAssignmentName'>
        /// role assignment id.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<BillingRoleAssignment>> GetByBillingAccountWithHttpMessagesAsync(string billingAccountName, string billingRoleAssignmentName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete the role assignment on this billing account
        /// </summary>
        /// <param name='billingAccountName'>
        /// billing Account Id.
        /// </param>
        /// <param name='billingRoleAssignmentName'>
        /// role assignment id.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<BillingRoleAssignment>> DeleteByBillingAccountNameWithHttpMessagesAsync(string billingAccountName, string billingRoleAssignmentName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get the role assignment for the caller on the invoice Section
        /// </summary>
        /// <param name='billingAccountName'>
        /// billing Account Id.
        /// </param>
        /// <param name='invoiceSectionName'>
        /// InvoiceSection Id.
        /// </param>
        /// <param name='billingRoleAssignmentName'>
        /// role assignment id.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<BillingRoleAssignment>> GetByInvoiceSectionNameWithHttpMessagesAsync(string billingAccountName, string invoiceSectionName, string billingRoleAssignmentName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete the role assignment on the invoice Section
        /// </summary>
        /// <param name='billingAccountName'>
        /// billing Account Id.
        /// </param>
        /// <param name='invoiceSectionName'>
        /// InvoiceSection Id.
        /// </param>
        /// <param name='billingRoleAssignmentName'>
        /// role assignment id.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<BillingRoleAssignment>> DeleteByInvoiceSectionNameWithHttpMessagesAsync(string billingAccountName, string invoiceSectionName, string billingRoleAssignmentName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get the role assignment for the caller on the Billing Profile
        /// </summary>
        /// <param name='billingAccountName'>
        /// billing Account Id.
        /// </param>
        /// <param name='billingProfileName'>
        /// Billing Profile Id.
        /// </param>
        /// <param name='billingRoleAssignmentName'>
        /// role assignment id.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<BillingRoleAssignment>> GetByBillingProfileNameWithHttpMessagesAsync(string billingAccountName, string billingProfileName, string billingRoleAssignmentName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete the role assignment on this Billing Profile
        /// </summary>
        /// <param name='billingAccountName'>
        /// billing Account Id.
        /// </param>
        /// <param name='billingProfileName'>
        /// Billing Profile Id.
        /// </param>
        /// <param name='billingRoleAssignmentName'>
        /// role assignment id.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<BillingRoleAssignment>> DeleteByBillingProfileNameWithHttpMessagesAsync(string billingAccountName, string billingProfileName, string billingRoleAssignmentName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get the role assignments on the Billing Account
        /// </summary>
        /// <param name='billingAccountName'>
        /// billing Account Id.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<BillingRoleAssignmentListResult>> ListByBillingAccountNameWithHttpMessagesAsync(string billingAccountName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The operation to add a role assignment to a billing account.
        /// </summary>
        /// <param name='billingAccountName'>
        /// billing Account Id.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<BillingRoleAssignmentListResult>> AddByBillingAccountNameWithHttpMessagesAsync(string billingAccountName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get the role assignments on the invoice Section
        /// </summary>
        /// <param name='billingAccountName'>
        /// billing Account Id.
        /// </param>
        /// <param name='invoiceSectionName'>
        /// InvoiceSection Id.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<BillingRoleAssignmentListResult>> ListByInvoiceSectionNameWithHttpMessagesAsync(string billingAccountName, string invoiceSectionName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The operation to add a role assignment to a invoice Section.
        /// </summary>
        /// <param name='billingAccountName'>
        /// billing Account Id.
        /// </param>
        /// <param name='invoiceSectionName'>
        /// InvoiceSection Id.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<BillingRoleAssignmentListResult>> AddByInvoiceSectionNameWithHttpMessagesAsync(string billingAccountName, string invoiceSectionName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get the role assignments on the Billing Profile
        /// </summary>
        /// <param name='billingAccountName'>
        /// billing Account Id.
        /// </param>
        /// <param name='billingProfileName'>
        /// Billing Profile Id.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<BillingRoleAssignmentListResult>> ListByBillingProfileNameWithHttpMessagesAsync(string billingAccountName, string billingProfileName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The operation to add a role assignment to a billing profile.
        /// </summary>
        /// <param name='billingAccountName'>
        /// billing Account Id.
        /// </param>
        /// <param name='billingProfileName'>
        /// Billing Profile Id.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<BillingRoleAssignmentListResult>> AddByBillingProfileNameWithHttpMessagesAsync(string billingAccountName, string billingProfileName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}