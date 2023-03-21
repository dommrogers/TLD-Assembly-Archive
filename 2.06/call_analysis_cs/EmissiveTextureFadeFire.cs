using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class EmissiveTextureFadeFire : MonoBehaviour
{
	public Fire m_SourceFire;

	public bool m_StartOff;

	public bool m_UseFireIgnitionFirst;

	public bool m_AutoSwitchAfterIngnition;

	public float m_FullOnMinutes;

	public float m_FullOffMinutes;

	private float m_MaxTimeSec;

	private float m_MinTimeSec;

	private float m_IgnitionDuration;

	private float m_FireTime;

	private float m_FadeTimeNormalized;

	private float m_FadeTimeDifference;

	private float m_FadeTimeStep;

	private Material m_ThisMaterial;

	private int m_ThisEmissiveID;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(EmissiveTextureFadeFire), Member = "SetNewMaxTime")]
	[CallsUnknownMethods(Count = 3)]
	private void Start()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void LateUpdate()
	{
	}

	[CalledBy(Type = typeof(EmissiveTextureFadeFire), Member = "Start")]
	[CallerCount(Count = 1)]
	public void SetNewMaxTime(float newMax)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public EmissiveTextureFadeFire()
	{
	}
}
