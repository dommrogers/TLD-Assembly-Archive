using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class WaterSourceSaveList
{
	public List<WaterSourceSaveData> m_SerializedWaterSources;

	[CalledBy(Type = typeof(WaterSourceManager), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public WaterSourceSaveList()
	{
	}
}
