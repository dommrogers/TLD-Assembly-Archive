using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class WaterSourceSaveList
{
	public List<WaterSourceSaveData> m_SerializedWaterSources;

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(WaterSourceManager), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public WaterSourceSaveList()
	{
	}
}
