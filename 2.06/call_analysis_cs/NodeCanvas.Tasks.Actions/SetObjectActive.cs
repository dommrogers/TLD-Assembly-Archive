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
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 5)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	public SetObjectActive()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
