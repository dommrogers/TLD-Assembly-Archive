using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SpinWithMouse : MonoBehaviour
{
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
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 9)]
	private void OnDrag(Vector2 delta)
	{
	}

	[CallerCount(Count = 0)]
	public SpinWithMouse()
	{
	}
}
