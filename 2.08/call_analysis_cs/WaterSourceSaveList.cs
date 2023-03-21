using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class WaterSourceSaveList
{
	public List<WaterSourceSaveData> m_SerializedWaterSources;

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public WaterSourceSaveList()
	{
	}
}
