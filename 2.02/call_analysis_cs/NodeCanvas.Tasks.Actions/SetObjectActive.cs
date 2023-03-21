using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class SetObjectActive : ActionTask<Transform>
{
	public enum SetActiveMode
	{
		Deactivate,
		Activate,
		Toggle
	}

	public SetActiveMode setTo;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Task), Member = "get_agentInfo")]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public SetObjectActive()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
