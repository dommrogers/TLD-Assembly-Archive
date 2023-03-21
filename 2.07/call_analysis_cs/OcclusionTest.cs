using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class OcclusionTest : MonoBehaviour
{
	private float m_OcclusionPollIntervalSeconds;

	private bool m_IsOccluded;

	private float m_CurrentTime;

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(OcclusionTest), Member = "CheckOcclusion")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Wind), Member = "IsPositionOccludedFromWind")]
	[CalledBy(Type = typeof(OcclusionTest), Member = "Update")]
	private bool CheckOcclusion()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool IsOccluded()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public OcclusionTest()
	{
	}
}
