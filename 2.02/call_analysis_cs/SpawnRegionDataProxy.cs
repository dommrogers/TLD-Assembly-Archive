using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class SpawnRegionDataProxy
{
	public float m_HoursPlayed;

	public float m_ElapsedHoursAtLastActiveReRoll;

	public bool m_IsActive;

	public List<SpawnDataProxy> m_ActiveSpawns;

	public int m_NumRespawnsPending;

	public float m_ElapasedHoursNextRespawnAllowed;

	public int m_NumTrapped;

	public float m_HoursNextTrapReset;

	public int m_SpawnGuidCounter;

	public int m_CurrentWaypointPathIndex;

	public WildlifeMode m_WildlifeMode;

	public bool m_HasBeenDisabledByAurora;

	public bool m_WasActiveBeforeAurora;

	[CalledBy(Type = typeof(SpawnRegion), Member = ".cctor")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public SpawnRegionDataProxy()
	{
	}
}
