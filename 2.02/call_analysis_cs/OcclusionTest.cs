using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class OcclusionTest : MonoBehaviour
{
	private float m_OcclusionPollIntervalSeconds;

	private bool m_IsOccluded;

	private float m_CurrentTime;

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(OcclusionTest), Member = "CheckOcclusion")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	private void Update()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(Wind), Member = "IsPositionOccludedFromWind")]
	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(OcclusionTest), Member = "Update")]
	private bool CheckOcclusion()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public bool IsOccluded()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public OcclusionTest()
	{
	}
}
