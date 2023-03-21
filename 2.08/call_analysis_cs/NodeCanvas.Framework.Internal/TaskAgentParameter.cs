using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace NodeCanvas.Framework.Internal;

[Serializable]
public class TaskAgentParameter : BBParameter<UnityEngine.Object>
{
	public new UnityEngine.Object value
	{
		[CallerCount(Count = 3)]
		[CalledBy(Type = typeof(Task), Member = "get_agent")]
		[CalledBy(Type = typeof(Task), Member = "Set")]
		[CalledBy(Type = typeof(TaskAgentParameter), Member = "get_objectValue")]
		[CallsUnknownMethods(Count = 3)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 60)]
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
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
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
