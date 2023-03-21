using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.BehaviourTrees;
using NodeCanvas.Framework;

public class TLDBehaviourTreeOwner : BehaviourTreeOwner
{
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GraphOwner), Member = "Initialize")]
	protected new void Awake()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GraphOwner), Member = "OnDestroy")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected new void OnDestroy()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void Serializes()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public void Deserialize()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public TLDBehaviourTreeOwner()
	{
	}
}
