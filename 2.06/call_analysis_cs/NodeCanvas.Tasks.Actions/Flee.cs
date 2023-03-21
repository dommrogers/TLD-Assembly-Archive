using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;
using UnityEngine.AI;

namespace NodeCanvas.Tasks.Actions;

public class Flee : ActionTask<NavMeshAgent>
{
	public BBParameter<GameObject> target;

	public BBParameter<float> speed;

	public BBParameter<float> fledDistance;

	public BBParameter<float> lookAhead;

	protected override string info
	{
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
	[CallsUnknownMethods(Count = 10)]
	protected override void OnExecute()
	{
	}

	[CallsUnknownMethods(Count = 15)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	protected override void OnUpdate()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	protected override void OnPause()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	protected override void OnStop()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public Flee()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
