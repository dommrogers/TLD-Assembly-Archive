using Cpp2ILInjected.CallAnalysis;
using ParadoxNotion;
using UnityEngine;

namespace NodeCanvas.Framework;

public interface ITaskSystem
{
	Component agent
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		get;
	}

	IBlackboard blackboard
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		get;
	}

	float elapsedTime
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		get;
	}

	Object contextObject
	{
		[CallerCount(Count = 121780)]
		[DeduplicatedMethod]
		get;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	void SendTaskOwnerDefaults();

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	void SendEvent(EventData eventData, object sender);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	void RecordUndo(string name);
}
