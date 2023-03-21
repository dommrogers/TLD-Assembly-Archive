using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class FireSaveDataProxy
{
	public float m_HoursPlayed;

	public Vector3 m_Position;

	public Quaternion m_Rotation;

	public FireState m_FireStateProxy;

	public float m_ElapsedOnTODSecondsProxy;

	public float m_ElapsedOnTODSecondsUnmodifiedProxy;

	public float m_MaxOnTODSecondsProxy;

	public string m_HeatSourceSerialized;

	public string m_CampfireSerialized;

	public float m_FuelHeatIncrease;

	public float m_EmberTimer;

	public bool m_FullBurnTriggered;

	public bool m_StartedByPlayer;

	public int m_NumGeneratedCharcoalPieces;

	public bool m_HasCollectedCharcoal;

	public string[] m_TrackedBurntItems;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public FireSaveDataProxy()
	{
	}
}
