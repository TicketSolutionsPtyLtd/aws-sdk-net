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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the GetPolicyVersion operation.
    /// Retrieves information about the specified version of the specified managed policy,
    /// including the policy document. 
    /// 
    ///  
    /// <para>
    /// To list the available versions for a policy, use <a>ListPolicyVersions</a>. 
    /// </para>
    ///  
    /// <para>
    /// This API retrieves information about managed policies. To retrieve information about
    /// an inline policy that is embedded in a user, group, or role, use the <a>GetUserPolicy</a>,
    /// <a>GetGroupPolicy</a>, or <a>GetRolePolicy</a> API. 
    /// </para>
    ///  
    /// <para>
    /// For more information about the types of policies, refer to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
    /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>. 
    /// </para>
    /// </summary>
    public partial class GetPolicyVersionRequest : AmazonIdentityManagementServiceRequest
    {
        private string _policyArn;
        private string _versionId;

        /// <summary>
        /// Gets and sets the property PolicyArn.
        /// </summary>
        public string PolicyArn
        {
            get { return this._policyArn; }
            set { this._policyArn = value; }
        }

        // Check to see if PolicyArn property is set
        internal bool IsSetPolicyArn()
        {
            return this._policyArn != null;
        }

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// Identifies the policy version to retrieve.
        /// </para>
        /// </summary>
        public string VersionId
        {
            get { return this._versionId; }
            set { this._versionId = value; }
        }

        // Check to see if VersionId property is set
        internal bool IsSetVersionId()
        {
            return this._versionId != null;
        }

    }
}