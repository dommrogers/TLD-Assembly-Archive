using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class MapDetailSaveData
{
	public Dictionary<string, bool> m_MapDetailUnlockedStates;

	public Dictionary<string, MapDetailStateData> m_NewMapDetailStates;

	[CalledBy(Type = typeof(MapDetailManager), Member = ".cctor")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 16)]
	public MapDetailSaveData()
	{
	}
}
