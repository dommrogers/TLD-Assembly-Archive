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

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnDestroy()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public static void ResetStumps()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeSelectScratchingStump")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static ScratchingStump SelectRandomStump(float radius, Vector3 currentAiPos)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public ScratchingStump()
	{
	}
}
