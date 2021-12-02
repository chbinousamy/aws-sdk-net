/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Container for the parameters to the DescribePrincipalMapping operation.
    /// Describes the processing of <code>PUT</code> and <code>DELETE</code> actions for mapping
    /// users to their groups. This includes information on the status of actions currently
    /// processing or yet to be processed, when actions were last updated, when actions were
    /// received by Amazon Kendra, the latest action that should process and apply after other
    /// actions, and useful error messages if an action could not be processed.
    /// 
    ///  
    /// <para>
    ///  <code>DescribePrincipalMapping</code> is currently not supported in the Amazon Web
    /// Services GovCloud (US-West) region.
    /// </para>
    /// </summary>
    public partial class DescribePrincipalMappingRequest : AmazonKendraRequest
    {
        private string _dataSourceId;
        private string _groupId;
        private string _indexId;

        /// <summary>
        /// Gets and sets the property DataSourceId. 
        /// <para>
        /// The identifier of the data source to check the processing of <code>PUT</code> and
        /// <code>DELETE</code> actions for mapping users to their groups.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string DataSourceId
        {
            get { return this._dataSourceId; }
            set { this._dataSourceId = value; }
        }

        // Check to see if DataSourceId property is set
        internal bool IsSetDataSourceId()
        {
            return this._dataSourceId != null;
        }

        /// <summary>
        /// Gets and sets the property GroupId. 
        /// <para>
        /// The identifier of the group required to check the processing of <code>PUT</code> and
        /// <code>DELETE</code> actions for mapping users to their groups.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string GroupId
        {
            get { return this._groupId; }
            set { this._groupId = value; }
        }

        // Check to see if GroupId property is set
        internal bool IsSetGroupId()
        {
            return this._groupId != null;
        }

        /// <summary>
        /// Gets and sets the property IndexId. 
        /// <para>
        /// The identifier of the index required to check the processing of <code>PUT</code> and
        /// <code>DELETE</code> actions for mapping users to their groups.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string IndexId
        {
            get { return this._indexId; }
            set { this._indexId = value; }
        }

        // Check to see if IndexId property is set
        internal bool IsSetIndexId()
        {
            return this._indexId != null;
        }

    }
}