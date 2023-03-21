using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace NodeCanvas.Framework;

[Serializable]
public class TaskAgent : BBParameter<UnityEngine.Object>
{
	public new UnityEngine.Object value
	{
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(GameObject), Member = "get_transform")]
		[CalledBy(Type = typeof(TaskAgent), Member = "get_objectValue")]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return null;
		}
		[CallerCount(Count = 60)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	protected override object objectValue
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TaskAgent), Member = "get_value")]
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
	public TaskAgent()
	{
		((BBParameter<>)(object)this)._002Ector();
	}
}
