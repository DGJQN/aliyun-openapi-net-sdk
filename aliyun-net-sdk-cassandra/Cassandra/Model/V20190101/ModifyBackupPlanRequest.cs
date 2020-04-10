/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Cassandra.Transform;
using Aliyun.Acs.Cassandra.Transform.V20190101;

namespace Aliyun.Acs.Cassandra.Model.V20190101
{
    public class ModifyBackupPlanRequest : RpcAcsRequest<ModifyBackupPlanResponse>
    {
        public ModifyBackupPlanRequest()
            : base("Cassandra", "2019-01-01", "ModifyBackupPlan", "Cassandra", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private int? retentionPeriod;

		private string dataCenterId;

		private bool? active;

		private string clusterId;

		private string backupTime;

		private string backupPeriod;

		public int? RetentionPeriod
		{
			get
			{
				return retentionPeriod;
			}
			set	
			{
				retentionPeriod = value;
				DictionaryUtil.Add(QueryParameters, "RetentionPeriod", value.ToString());
			}
		}

		public string DataCenterId
		{
			get
			{
				return dataCenterId;
			}
			set	
			{
				dataCenterId = value;
				DictionaryUtil.Add(QueryParameters, "DataCenterId", value);
			}
		}

		public bool? Active
		{
			get
			{
				return active;
			}
			set	
			{
				active = value;
				DictionaryUtil.Add(QueryParameters, "Active", value.ToString());
			}
		}

		public string ClusterId
		{
			get
			{
				return clusterId;
			}
			set	
			{
				clusterId = value;
				DictionaryUtil.Add(QueryParameters, "ClusterId", value);
			}
		}

		public string BackupTime
		{
			get
			{
				return backupTime;
			}
			set	
			{
				backupTime = value;
				DictionaryUtil.Add(QueryParameters, "BackupTime", value);
			}
		}

		public string BackupPeriod
		{
			get
			{
				return backupPeriod;
			}
			set	
			{
				backupPeriod = value;
				DictionaryUtil.Add(QueryParameters, "BackupPeriod", value);
			}
		}

        public override ModifyBackupPlanResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyBackupPlanResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
