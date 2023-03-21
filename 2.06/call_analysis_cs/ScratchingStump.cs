using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ScratchingStump : MonoBehaviour
{
	public float m_ApproachRadiusDistance;

	public float m_FinalRadiusDistance;

	public float m_OffsetTowardStump;

	private static List<ScratchingStump> m_ScratchingStumpList;

	private static List<ScratchingStump> m_SelectedScratchingStumpList;

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void ResetStumps()
	{
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeSelectScratchingStump")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 15)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	public static ScratchingStump SelectRandomStump(float radius, Vector3 currentAiPos)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public ScratchingStump()
	{
	}
}
