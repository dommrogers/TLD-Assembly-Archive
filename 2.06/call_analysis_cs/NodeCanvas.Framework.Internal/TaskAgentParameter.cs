using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace NodeCanvas.Framework.Internal;

[Serializable]
public class TaskAgentParameter : BBParameter<UnityEngine.Object>
{
	public new UnityEngine.Object value
	{
		[CalledBy(Type = typeof(Task), Member = "get_agent")]
		[CalledBy(Type = typeof(Task), Member = "Set")]
		[CalledBy(Type = typeof(TaskAgentParameter), Member = "get_objectValue")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 65)]
		set
		{
		}
	}

	protected override object objectValue
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TaskAgentParameter), Member = "get_value")]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	public TaskAgentParameter()
	{
		((BBParameter<>)(object)this)._002Ector();
	}
}
