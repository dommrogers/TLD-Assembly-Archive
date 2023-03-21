using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class MapDetailSaveData
{
	public Dictionary<string, bool> m_MapDetailUnlockedStates;

	public Dictionary<string, MapDetailStateData> m_NewMapDetailStates;

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public MapDetailSaveData()
	{
	}
}
