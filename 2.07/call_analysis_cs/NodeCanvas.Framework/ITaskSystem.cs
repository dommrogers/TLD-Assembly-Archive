using Cpp2ILInjected.CallAnalysis;
using ParadoxNotion;
using UnityEngine;

namespace NodeCanvas.Framework;

public interface ITaskSystem
{
	Component agent
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101261)]
		get;
	}

	IBlackboard blackboard
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101261)]
		get;
	}

	float elapsedTime
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101261)]
		get;
	}

	Object contextObject
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101261)]
		get;
	}

	[CallerCount(Count = 101261)]
	[DeduplicatedMethod]
	void SendTaskOwnerDefaults();

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	void SendEvent(EventData eventData, object sender);

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	void RecordUndo(string name);
}
