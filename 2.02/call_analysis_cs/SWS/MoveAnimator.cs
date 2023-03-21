using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.AI;

namespace SWS;

public class MoveAnimator : MonoBehaviour
{
	public enum MovementType
	{
		splineMove,
		bezierMove,
		navMove
	}

	public MovementType mType;

	private splineMove hMove;

	private bezierMove bMove;

	private NavMeshAgent nAgent;

	private Animator animator;

	private float lastRotY;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	private void Start()
	{
	}

	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CallsUnknownMethods(Count = 23)]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "Inverse")]
	private void OnAnimatorMove()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public MoveAnimator()
	{
	}
}
