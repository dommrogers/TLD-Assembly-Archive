using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace NodeCanvas.Framework;

[Serializable]
public class TaskAgent : BBParameter<UnityEngine.Object>
{
	public new UnityEngine.Object value
	{
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(GameObject), Member = "get_transform")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 41)]
		set
		{
		}
	}

	protected override object objectValue
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(GameObject), Member = "get_transform")]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public TaskAgent()
	{
		((BBParameter<>)(object)this)._002Ector();
	}
}
