using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.BehaviourTrees;
using NodeCanvas.Framework;

public class TLDBehaviourTreeOwner : BehaviourTreeOwner
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GraphOwner), Member = "Initialize")]
	[CallsUnknownMethods(Count = 2)]
	protected new void Awake()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GraphOwner), Member = "OnDestroy")]
	protected new void OnDestroy()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public void Serializes()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void Deserialize()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GraphOwner), Member = ".ctor")]
	public TLDBehaviourTreeOwner()
	{
	}
}
