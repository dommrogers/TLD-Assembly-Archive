using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class OcclusionTest : MonoBehaviour
{
	private float m_OcclusionPollIntervalSeconds;

	private bool m_IsOccluded;

	private float m_CurrentTime;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(OcclusionTest), Member = "CheckOcclusion")]
	[CallsUnknownMethods(Count = 2)]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(OcclusionTest), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Wind), Member = "IsPositionOccludedFromWind")]
	private bool CheckOcclusion()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
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
