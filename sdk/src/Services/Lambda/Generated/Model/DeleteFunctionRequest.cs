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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteFunction operation.
    /// Deletes the specified Lambda function code and configuration.
    /// 
    ///  
    /// <para>
    /// If you don't specify a function version, AWS Lambda will delete the function, including
    /// all its versions, and any aliases pointing to the function versions.
    /// </para>
    ///  
    /// <para>
    /// When you delete a function the associated resource policy is also deleted. You will
    /// need to delete the event source mappings explicitly.
    /// </para>
    ///  
    /// <para>
    /// For information about function versioning, see <a href="http://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases-v2.html">AWS
    /// Lambda Function Versioning and Aliases</a>.
    /// </para>
    ///  
    /// <para>
    /// This operation requires permission for the <code>lambda:DeleteFunction</code> action.
    /// </para>
    /// </summary>
    public partial class DeleteFunctionRequest : AmazonLambdaRequest
    {
        private string _functionName;
        private string _qualifier;

        /// <summary>
        /// Gets and sets the property FunctionName. 
        /// <para>
        /// The Lambda function to delete.
        /// </para>
        ///  
        /// <para>
        ///  You can specify an unqualified function name (for example, "Thumbnail") or you can
        /// specify Amazon Resource Name (ARN) of the function (for example, "arn:aws:lambda:us-west-2:account-id:function:ThumbNail").
        /// AWS Lambda also allows you to specify only the account ID qualifier (for example,
        /// "account-id:Thumbnail"). Note that the length constraint applies only to the ARN.
        /// If you specify only the function name, it is limited to 64 character in length. 
        /// </para>
        /// </summary>
        public string FunctionName
        {
            get { return this._functionName; }
            set { this._functionName = value; }
        }

        // Check to see if FunctionName property is set
        internal bool IsSetFunctionName()
        {
            return this._functionName != null;
        }

        /// <summary>
        /// Gets and sets the property Qualifier. 
        /// <para>
        /// Using this optional parameter you can specify a function version (but not the $LATEST
        /// version) to direct AWS Lambda to delete a specific function version. If the function
        /// version has one or more aliases pointing to it, you will get an error because you
        /// cannot have aliases pointing to it. You can delete any function version but not the
        /// $LATEST, that is, you cannot specify $LATEST as the value of this parameter. The $LATEST
        /// version can be deleted only when you want to delete all the function versions and
        /// aliases.
        /// </para>
        ///  
        /// <para>
        /// You can only specify a function version and not alias name using this parameter. You
        /// cannot delete a function version using its alias.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify this parameter, AWS Lambda will delete the function, including
        /// all its versions and aliases.
        /// </para>
        /// </summary>
        public string Qualifier
        {
            get { return this._qualifier; }
            set { this._qualifier = value; }
        }

        // Check to see if Qualifier property is set
        internal bool IsSetQualifier()
        {
            return this._qualifier != null;
        }

    }
}