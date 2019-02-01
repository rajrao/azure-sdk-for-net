// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorageSync.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// ServerEndpoint Health object.
    /// </summary>
    public partial class ServerEndpointHealth
    {
        /// <summary>
        /// Initializes a new instance of the ServerEndpointHealth class.
        /// </summary>
        public ServerEndpointHealth()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServerEndpointHealth class.
        /// </summary>
        /// <param name="downloadHealth">Download Health Status. Possible
        /// values include: 'Healthy', 'Error', 'SyncBlockedForRestore',
        /// 'SyncBlockedForChangeDetectionPostRestore', 'NoActivity'</param>
        /// <param name="uploadHealth">Upload Health Status. Possible values
        /// include: 'Healthy', 'Error', 'SyncBlockedForRestore',
        /// 'SyncBlockedForChangeDetectionPostRestore', 'NoActivity'</param>
        /// <param name="combinedHealth">Combined Health Status. Possible
        /// values include: 'Healthy', 'Error', 'SyncBlockedForRestore',
        /// 'SyncBlockedForChangeDetectionPostRestore', 'NoActivity'</param>
        /// <param name="lastUpdatedTimestamp">Last Updated Timestamp</param>
        /// <param name="uploadStatus">Upload Status</param>
        /// <param name="downloadStatus">Download Status</param>
        /// <param name="currentProgress">Current progress</param>
        /// <param name="offlineDataTransferStatus">Offline Data Transfer
        /// State. Possible values include: 'InProgress', 'Stopping',
        /// 'NotRunning', 'Complete'</param>
        public ServerEndpointHealth(string downloadHealth = default(string), string uploadHealth = default(string), string combinedHealth = default(string), System.DateTime? lastUpdatedTimestamp = default(System.DateTime?), SyncSessionStatus uploadStatus = default(SyncSessionStatus), SyncSessionStatus downloadStatus = default(SyncSessionStatus), SyncProgressStatus currentProgress = default(SyncProgressStatus), string offlineDataTransferStatus = default(string))
        {
            DownloadHealth = downloadHealth;
            UploadHealth = uploadHealth;
            CombinedHealth = combinedHealth;
            LastUpdatedTimestamp = lastUpdatedTimestamp;
            UploadStatus = uploadStatus;
            DownloadStatus = downloadStatus;
            CurrentProgress = currentProgress;
            OfflineDataTransferStatus = offlineDataTransferStatus;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets download Health Status. Possible values include:
        /// 'Healthy', 'Error', 'SyncBlockedForRestore',
        /// 'SyncBlockedForChangeDetectionPostRestore', 'NoActivity'
        /// </summary>
        [JsonProperty(PropertyName = "downloadHealth")]
        public string DownloadHealth { get; set; }

        /// <summary>
        /// Gets or sets upload Health Status. Possible values include:
        /// 'Healthy', 'Error', 'SyncBlockedForRestore',
        /// 'SyncBlockedForChangeDetectionPostRestore', 'NoActivity'
        /// </summary>
        [JsonProperty(PropertyName = "uploadHealth")]
        public string UploadHealth { get; set; }

        /// <summary>
        /// Gets or sets combined Health Status. Possible values include:
        /// 'Healthy', 'Error', 'SyncBlockedForRestore',
        /// 'SyncBlockedForChangeDetectionPostRestore', 'NoActivity'
        /// </summary>
        [JsonProperty(PropertyName = "combinedHealth")]
        public string CombinedHealth { get; set; }

        /// <summary>
        /// Gets or sets last Updated Timestamp
        /// </summary>
        [JsonProperty(PropertyName = "lastUpdatedTimestamp")]
        public System.DateTime? LastUpdatedTimestamp { get; set; }

        /// <summary>
        /// Gets or sets upload Status
        /// </summary>
        [JsonProperty(PropertyName = "uploadStatus")]
        public SyncSessionStatus UploadStatus { get; set; }

        /// <summary>
        /// Gets or sets download Status
        /// </summary>
        [JsonProperty(PropertyName = "downloadStatus")]
        public SyncSessionStatus DownloadStatus { get; set; }

        /// <summary>
        /// Gets or sets current progress
        /// </summary>
        [JsonProperty(PropertyName = "currentProgress")]
        public SyncProgressStatus CurrentProgress { get; set; }

        /// <summary>
        /// Gets or sets offline Data Transfer State. Possible values include:
        /// 'InProgress', 'Stopping', 'NotRunning', 'Complete'
        /// </summary>
        [JsonProperty(PropertyName = "offlineDataTransferStatus")]
        public string OfflineDataTransferStatus { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (UploadStatus != null)
            {
                UploadStatus.Validate();
            }
            if (DownloadStatus != null)
            {
                DownloadStatus.Validate();
            }
            if (CurrentProgress != null)
            {
                CurrentProgress.Validate();
            }
        }
    }
}