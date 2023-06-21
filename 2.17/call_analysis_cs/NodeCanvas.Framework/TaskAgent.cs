using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace NodeCanvas.Framework;

[Serializable]
public class TaskAgent : BBParameter<UnityEngine.Object>
{
	public new UnityEngine.Object value
	{
		[CalledBy(Type = typeof(TaskAgent), Member = "get_objectValue")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
		[Calls(Type = typeof(GameObject), Member = "get_transform")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 70)]
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
