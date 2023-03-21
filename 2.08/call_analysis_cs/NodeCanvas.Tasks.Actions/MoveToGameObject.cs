using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;
using UnityEngine.AI;

namespace NodeCanvas.Tasks.Actions;

public class MoveToGameObject : ActionTask<NavMeshAgent>
{
	public BBParameter<GameObject> target;

	public BBParameter<float> speed;

	public BBParameter<float> keepDistance;

	private Vector3? lastRequest;

	protected override string info
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 11)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 9)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 9)]
	protected override void OnUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	protected override void OnStop()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void OnPause()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public override void OnDrawGizmos()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public MoveToGameObject()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
