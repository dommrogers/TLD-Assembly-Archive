using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class WorldMapSaveData
{
	public List<string> m_UnlockedDetails;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public WorldMapSaveData()
	{
	}
}
