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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(HeadLights), Member = "ProcessHeadLightsReaction")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(HeadLights), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(HeadLights), Member = "MaybeInvestigateHeadLights")]
	[Calls(Type = typeof(HeadLights), Member = "MaybeFleeHeadLights")]
	[CallsUnknownMethods(Count = 1)]
	private void ProcessHeadLightsReaction(BaseAi bai)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private bool ShouldReactToHeadLights(BaseAi bai)
	{
		return false;
	}

	[CalledBy(Type = typeof(HeadLights), Member = "ProcessHeadLightsReaction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	private void MaybeInvestigateHeadLights(BaseAi bai)
	{
	}

	[CalledBy(Type = typeof(HeadLights), Member = "ProcessHeadLightsReaction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	private void MaybeFleeHeadLights(BaseAi bai)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public HeadLights()
	{
	}
}
