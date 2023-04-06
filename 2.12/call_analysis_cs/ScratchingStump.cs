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
	[Calls(Type = typeof(List<>), Member = "Remove")]
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

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeSelectScratchingStump")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	public static ScratchingStump SelectRandomStump(float radius, Vector3 currentAiPos)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public ScratchingStump()
	{
	}
}
