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
    /// Container for the parameters to the ClearQuerySuggestions operation.
    /// Clears existing query suggestions from an index.
    /// 
    ///  
    /// <para>
    /// This deletes existing suggestions only, not the queries in the query log. After you
    /// clear suggestions, Amazon Kendra learns new suggestions based on new queries added
    /// to the query log from the time you cleared suggestions. If you do not see any new
    /// suggestions, then please allow Amazon Kendra to collect enough queries to learn new
    /// suggestions.
    /// </para>
    ///  
    /// <para>
    ///  <code>ClearQuerySuggestions</code> is currently not supported in the Amazon Web Services
    /// GovCloud (US-West) region.
    /// </para>
    /// </summary>
    public partial class ClearQuerySuggestionsRequest : AmazonKendraRequest
    {
        private string _indexId;

        /// <summary>
        /// Gets and sets the property IndexId. 
        /// <para>
        /// The identifier of the index you want to clear query suggestions from.
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