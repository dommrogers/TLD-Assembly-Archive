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
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(OcclusionTest), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(Wind), Member = "IsPositionOccludedFromWind")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 13)]
	private bool CheckOcclusion()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public bool IsOccluded()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public OcclusionTest()
	{
	}
}
