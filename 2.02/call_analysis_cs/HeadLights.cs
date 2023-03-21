using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class HeadLights : MonoBehaviour
{
	public float m_AttractDistance;

	public float m_FleeDistance;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(HeadLights), Member = "ProcessHeadLightsReaction")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(HeadLights), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(HeadLights), Member = "MaybeInvestigateHeadLights")]
	[Calls(Type = typeof(HeadLights), Member = "MaybeFleeHeadLights")]
	[CallsDeduplicatedMethods(Count = 1)]
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
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 13)]
	private void MaybeInvestigateHeadLights(BaseAi bai)
	{
	}

	[CalledBy(Type = typeof(HeadLights), Member = "ProcessHeadLightsReaction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 13)]
	private void MaybeFleeHeadLights(BaseAi bai)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public HeadLights()
	{
	}
}
