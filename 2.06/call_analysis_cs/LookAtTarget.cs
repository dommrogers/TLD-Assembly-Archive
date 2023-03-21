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

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	public LookAtTarget()
	{
	}
}
