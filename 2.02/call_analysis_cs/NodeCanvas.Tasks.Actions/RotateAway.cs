using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class RotateAway : ActionTask<Transform>
{
	public BBParameter<GameObject> target;

	public BBParameter<float> speed;

	public BBParameter<float> angleDifference;

	public BBParameter<Vector3> upVector;

	public bool waitActionFinish;

	[CallsUnknownMethods(Count = 27)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsDeduplicatedMethods(Count = 20)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "Angle")]
	protected override void OnUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[CallsUnknownMethods(Count = 3)]
	public RotateAway()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
