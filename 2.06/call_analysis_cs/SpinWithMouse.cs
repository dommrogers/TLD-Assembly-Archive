using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SpinWithMouse : MonoBehaviour
{
	public Transform target;

	public float speed;

	private Transform mTrans;

	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 9)]
	[CallerCount(Count = 0)]
	private void OnDrag(Vector2 delta)
	{
	}

	[CallerCount(Count = 0)]
	public SpinWithMouse()
	{
	}
}
