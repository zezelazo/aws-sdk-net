/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Contains the results of the <a>RebootWorkspaces</a> operation.
    /// </summary>
    public partial class RebootWorkspacesResponse : AmazonWebServiceResponse
    {
        private List<FailedWorkspaceChangeRequest> _failedRequests = new List<FailedWorkspaceChangeRequest>();

        /// <summary>
        /// Gets and sets the property FailedRequests. 
        /// <para>
        /// An array of structures representing any WorkSpaces that could not be rebooted.
        /// </para>
        /// </summary>
        public List<FailedWorkspaceChangeRequest> FailedRequests
        {
            get { return this._failedRequests; }
            set { this._failedRequests = value; }
        }

        // Check to see if FailedRequests property is set
        internal bool IsSetFailedRequests()
        {
            return this._failedRequests != null && this._failedRequests.Count > 0; 
        }

    }
}