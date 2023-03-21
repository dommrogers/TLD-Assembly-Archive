using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_FaceTarget : ActionTask
{
	public BBParameter<GameObject> target;

	public BBParameter<float> rotationDegreesPerSecond;

	public BBParameter<string> turnAngleParameterName;

	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Utils), Member = "GetAngleDegrees")]
	[Calls(Type = typeof(ActionTask), Member = "get_deltaTime")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(BaseAi), Member = "SetTurnAngleParameters")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(ActionTask), Member = "get_deltaTime")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(Animator), Member = "StringToHash")]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "MoveTowardsAngle")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(ActionTask), Member = "get_deltaTime")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	protected override void OnUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Utils), Member = "GetAngleDegrees")]
	[Calls(Type = typeof(ActionTask), Member = "get_deltaTime")]
	private float GetTurnSpeed(Vector3 previousHeading, Vector3 currentHeading)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public Action_FaceTarget()
	{
	}
}
