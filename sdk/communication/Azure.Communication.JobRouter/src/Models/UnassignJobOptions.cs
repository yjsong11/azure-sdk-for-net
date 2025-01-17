﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    /// <summary>
    /// Options for unassigning a job.
    /// </summary>
    public partial class UnassignJobOptions
    {
        /// <summary> Initializes a new instance of UnassignJobOptions. </summary>
        internal UnassignJobOptions()
        {
        }

        /// <param name="jobId"> Id of the job. </param>
        /// <param name="assignmentId"> Id of the assignment. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> or <paramref name="assignmentId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="jobId"/> or <paramref name="assignmentId"/> is an empty string, and was expected to be non-empty. </exception>

        public UnassignJobOptions(string jobId, string assignmentId)
        {
            Argument.AssertNotNullOrEmpty(jobId, nameof(jobId));
            Argument.AssertNotNullOrEmpty(assignmentId, nameof(assignmentId));

            JobId = jobId;
            AssignmentId = assignmentId;
        }

        /// <summary>
        /// Id of the job to un-assign.
        /// </summary>
        public string JobId { get; }

        /// <summary>
        /// Id of the assignment to un-assign.
        /// </summary>
        public string AssignmentId { get; }

        /// <summary>
        /// If SuspendMatching is true, then the job is not queued for re-matching with a
        /// worker.
        /// </summary>
        public bool? SuspendMatching { get; set; }
    }
}
