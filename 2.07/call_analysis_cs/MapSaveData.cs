using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class MapSaveData
{
	public Dictionary<string, string> m_MapSaveDataDict;

	public Dictionary<string, string> m_DetailSurveyPositions;

	public Dictionary<string, float> m_DetailSurveyLastUpdateTimes;

	public Dictionary<string, string> m_SurveyedVistaLocations;

	public List<string> m_DelayedMapElementRemovals;

	public List<string> m_UnlockedRegionNames;

	public bool m_HasBeenUpdated;

	public Guid m_Guid;

	[CalledBy(Type = typeof(Panel_Map), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public MapSaveData()
	{
	}
}
