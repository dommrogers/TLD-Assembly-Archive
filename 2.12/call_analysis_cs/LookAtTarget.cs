using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LookAtTarget : MonoBehaviour
{
	public int level;

	public Transform target;

	public float speed;

	private Transform mTrans;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	public LookAtTarget()
	{
	}
}
