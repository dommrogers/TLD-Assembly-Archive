using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class MecanimSetFloat : ActionTask<Animator>
{
	public BBParameter<string> parameter;

	public BBParameter<int> parameterHashID;

	public BBParameter<float> setTo;

	public float transitTime;

	private float currentValue;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		[CallsUnknownMethods(Count = 4)]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(MecanimSetFloat), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MecanimSetFloat), Member = "Get")]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ActionTask), Member = "get_elapsedTime")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(MecanimSetFloat), Member = "Set")]
	[Calls(Type = typeof(ActionTask), Member = "get_elapsedTime")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 2)]
	protected override void OnUpdate()
	{
	}

	[CalledBy(Type = typeof(MecanimSetFloat), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	private float Get()
	{
		return default(float);
	}

	[CallsDeduplicatedMethods(Count = 7)]
	[CalledBy(Type = typeof(MecanimSetFloat), Member = "OnExecute")]
	[CalledBy(Type = typeof(MecanimSetFloat), Member = "OnUpdate")]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 2)]
	private void Set(float newValue)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public MecanimSetFloat()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
