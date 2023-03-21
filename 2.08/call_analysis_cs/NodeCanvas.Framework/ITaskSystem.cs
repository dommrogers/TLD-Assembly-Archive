using Cpp2ILInjected.CallAnalysis;
using ParadoxNotion;
using UnityEngine;

namespace NodeCanvas.Framework;

public interface ITaskSystem
{
	Component agent
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101262)]
		get;
	}

	IBlackboard blackboard
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101262)]
		get;
	}

	float elapsedTime
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101262)]
		get;
	}

	Object contextObject
	{
		[CallerCount(Count = 101262)]
		[DeduplicatedMethod]
		get;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	void SendTaskOwnerDefaults();

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	void SendEvent(EventData eventData, object sender);

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	void RecordUndo(string name);
}
