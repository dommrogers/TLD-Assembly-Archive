using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class FlareGunRoundSaveData
{
	public int m_InstanceID;

	public string m_HostGuid;

	public string m_LocalName;

	public Vector3 m_LocalPosition;

	public Vector3 m_LocalAngles;

	public float m_EmbeddedDepth;

	public float m_BurnTimer;

	public float m_HoursPlayed;

	public FlareGunRoundItem.FlightStatus m_FlightStatus;

	public int m_ObjectLayer;

	public bool m_IsRendererEnabled;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public FlareGunRoundSaveData()
	{
	}
}
