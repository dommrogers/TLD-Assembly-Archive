using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SnowDepth : MonoBehaviour
{
	public const float DEFAULT_DEPTH = 0.25f;

	public const float DEEP_DEPTH_RANGE = 0.75f;

	public float m_Depth;

	public float m_BorderSize;

	public bool m_BorderIsFractionOfSize;

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(FootstepTrail), Member = "OnOwnerEnterSnowDepthTrigger")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	private void OnTriggerEnter(Collider c)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 10)]
	private void OnTriggerExit(Collider c)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public SnowDepth()
	{
	}
}
