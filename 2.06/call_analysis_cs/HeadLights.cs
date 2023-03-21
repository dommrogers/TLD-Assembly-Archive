using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class HeadLights : MonoBehaviour
{
	public float m_AttractDistance;

	public float m_FleeDistance;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void Start()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(HeadLights), Member = "ProcessHeadLightsReaction")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(HeadLights), Member = "MaybeInvestigateHeadLights")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(HeadLights), Member = "MaybeFleeHeadLights")]
	[CalledBy(Type = typeof(HeadLights), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	private void ProcessHeadLightsReaction(BaseAi bai)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private bool ShouldReactToHeadLights(BaseAi bai)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(HeadLights), Member = "ProcessHeadLightsReaction")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	private void MaybeInvestigateHeadLights(BaseAi bai)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(HeadLights), Member = "ProcessHeadLightsReaction")]
	[CallsUnknownMethods(Count = 9)]
	private void MaybeFleeHeadLights(BaseAi bai)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public HeadLights()
	{
	}
}
