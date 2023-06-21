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
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Format")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 7)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 11)]
	protected override void OnUpdate()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void OnPause()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	protected override void OnStop()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public Flee()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
