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
		[DeduplicatedMethod]
		[CallerCount(Count = 60)]
		set
		{
		}
	}

	protected override object objectValue
	{
		[Calls(Type = typeof(TaskAgent), Member = "get_value")]
		[CallerCount(Count = 0)]
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
