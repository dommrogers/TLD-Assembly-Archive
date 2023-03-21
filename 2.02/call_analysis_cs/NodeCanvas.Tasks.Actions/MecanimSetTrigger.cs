using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class MecanimSetTrigger : ActionTask<Animator>
{
	public BBParameter<string> parameter;

	public BBParameter<int> parameterHashID;

	protected override string info
	{
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 4)]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 8)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public MecanimSetTrigger()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
