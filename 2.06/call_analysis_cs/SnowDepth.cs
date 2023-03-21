using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SnowDepth : MonoBehaviour
{
	public const float DEFAULT_DEPTH = 0.25f;

	public const float DEEP_DEPTH_RANGE = 0.75f;

	public float m_Depth;

	public float m_BorderSize;

	public bool m_BorderIsFractionOfSize;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FootstepTrail), Member = "OnOwnerEnterSnowDepthTrigger")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void OnTriggerEnter(Collider c)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(List<>), Member = "RemoveAt")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private void OnTriggerExit(Collider c)
	{
	}

	[CallerCount(Count = 0)]
	public SnowDepth()
	{
	}
}
