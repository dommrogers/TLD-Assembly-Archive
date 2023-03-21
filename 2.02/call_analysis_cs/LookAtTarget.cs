using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LookAtTarget : MonoBehaviour
{
	public int level;

	public Transform target;

	public float speed;

	private Transform mTrans;

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void Start()
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public LookAtTarget()
	{
	}
}
