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
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(Quaternion), Member = "Inverse")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 23)]
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
