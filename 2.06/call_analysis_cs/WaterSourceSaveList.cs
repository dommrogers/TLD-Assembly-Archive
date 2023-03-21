using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class WaterSourceSaveList
{
	public List<WaterSourceSaveData> m_SerializedWaterSources;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public WaterSourceSaveList()
	{
	}
}
