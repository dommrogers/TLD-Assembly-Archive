using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SpinWithMouse : MonoBehaviour
{
	public Transform target;

	public float speed;

	private Transform mTrans;

	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Start()
	{
	}

	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CallerCount(Count = 0)]
	private void OnDrag(Vector2 delta)
	{
	}

	[CallerCount(Count = 0)]
	public SpinWithMouse()
	{
	}
}
