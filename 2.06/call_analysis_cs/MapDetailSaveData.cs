using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class MapDetailSaveData
{
	public Dictionary<string, bool> m_MapDetailUnlockedStates;

	public Dictionary<string, MapDetailStateData> m_NewMapDetailStates;

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(MapDetailManager), Member = ".cctor")]
	[CallsUnknownMethods(Count = 11)]
	public MapDetailSaveData()
	{
	}
}
