using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;
using UnityEngine.AI;

namespace NodeCanvas.Tasks.Actions;

public class MoveToPosition : ActionTask<NavMeshAgent>
{
	public BBParameter<Vector3> targetPosition;

	public BBParameter<float> speed;

	public BBParameter<float> keepDistance;

	private Vector3? lastRequest;

	protected override string info
	{
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 14)]
	protected override void OnExecute()
	{
	}

	[CallsUnknownMethods(Count = 16)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(Vector3), Member = "op_Inequality")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	protected override void OnUpdate()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	protected override void OnStop()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void OnPause()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public MoveToPosition()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
