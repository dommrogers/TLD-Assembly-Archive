using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class OcclusionTest : MonoBehaviour
{
	private float m_OcclusionPollIntervalSeconds;

	private bool m_IsOccluded;

	private float m_CurrentTime;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(OcclusionTest), Member = "CheckOcclusion")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(OcclusionTest), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Wind), Member = "IsPositionOccludedFromWind")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 9)]
	private bool CheckOcclusion()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsOccluded()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public OcclusionTest()
	{
	}
}
