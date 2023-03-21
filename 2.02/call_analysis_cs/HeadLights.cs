using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class HeadLights : MonoBehaviour
{
	public float m_AttractDistance;

	public float m_FleeDistance;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void Start()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(HeadLights), Member = "ProcessHeadLightsReaction")]
	private void Update()
	{
	}

	[Calls(Type = typeof(HeadLights), Member = "MaybeFleeHeadLights")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(HeadLights), Member = "MaybeInvestigateHeadLights")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(HeadLights), Member = "Update")]
	private void ProcessHeadLightsReaction(BaseAi bai)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private bool ShouldReactToHeadLights(BaseAi bai)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(HeadLights), Member = "ProcessHeadLightsReaction")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	private void MaybeInvestigateHeadLights(BaseAi bai)
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(HeadLights), Member = "ProcessHeadLightsReaction")]
	private void MaybeFleeHeadLights(BaseAi bai)
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public HeadLights()
	{
	}
}
