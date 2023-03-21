using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.BehaviourTrees;
using NodeCanvas.Framework;

public class TLDBehaviourTreeOwner : BehaviourTreeOwner
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GraphOwner), Member = "Initialize")]
	[CallsUnknownMethods(Count = 1)]
	protected override void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GraphOwner), Member = "OnDestroy")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnDestroy()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Serializes()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Deserialize()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GraphOwner), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 1)]
	public TLDBehaviourTreeOwner()
	{
	}
}
