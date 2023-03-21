using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees;

public class BehaviourTreeOwner : GraphOwner<BehaviourTree>
{
	public bool repeat
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(bool);
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public float updateInterval
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(float);
		}
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		set
		{
		}
	}

	public Status rootStatus
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(Status);
		}
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	public Status Tick()
	{
		return default(Status);
	}

	[Calls(Type = typeof(GraphOwner), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public BehaviourTreeOwner()
	{
		((GraphOwner<>)(object)this)._002Ector();
	}
}
