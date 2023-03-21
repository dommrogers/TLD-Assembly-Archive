using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class FindChildByName : ActionTask<Transform>
{
	public BBParameter<string> childName;

	public BBParameter<Transform> saveAs;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(string), Member = "Format")]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	public FindChildByName()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
