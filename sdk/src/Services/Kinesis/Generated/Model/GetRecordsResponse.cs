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
 * Do not modify this file. This file is generated from the kinesis-2013-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// Represents the output for <a>GetRecords</a>.
    /// </summary>
    public partial class GetRecordsResponse : AmazonWebServiceResponse
    {
        private long? _millisBehindLatest;
        private string _nextShardIterator;
        private List<Record> _records = new List<Record>();

        /// <summary>
        /// Gets and sets the property MillisBehindLatest. 
        /// <para>
        /// The number of milliseconds the <a>GetRecords</a> response is from the tip of the stream,
        /// indicating how far behind current time the consumer is. A value of zero indicates
        /// record processing is caught up, and there are no new records to process at this moment.
        /// </para>
        /// </summary>
        public long MillisBehindLatest
        {
            get { return this._millisBehindLatest.GetValueOrDefault(); }
            set { this._millisBehindLatest = value; }
        }

        // Check to see if MillisBehindLatest property is set
        internal bool IsSetMillisBehindLatest()
        {
            return this._millisBehindLatest.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextShardIterator. 
        /// <para>
        /// The next position in the shard from which to start sequentially reading data records.
        /// If set to <code>null</code>, the shard has been closed and the requested iterator
        /// will not return any more data. 
        /// </para>
        /// </summary>
        public string NextShardIterator
        {
            get { return this._nextShardIterator; }
            set { this._nextShardIterator = value; }
        }

        // Check to see if NextShardIterator property is set
        internal bool IsSetNextShardIterator()
        {
            return this._nextShardIterator != null;
        }

        /// <summary>
        /// Gets and sets the property Records. 
        /// <para>
        /// The data records retrieved from the shard.
        /// </para>
        /// </summary>
        public List<Record> Records
        {
            get { return this._records; }
            set { this._records = value; }
        }

        // Check to see if Records property is set
        internal bool IsSetRecords()
        {
            return this._records != null && this._records.Count > 0; 
        }

    }
}