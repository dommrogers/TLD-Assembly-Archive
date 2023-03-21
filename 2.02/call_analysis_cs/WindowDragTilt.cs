using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class WindowDragTilt : MonoBehaviour
{
	public int updateOrder;

	public float degrees;

	private Vector3 mLastPos;

	private Transform mTrans;

	private float mAngle;

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[Calls(Type = typeof(NGUIMath), Member = "SpringLerp")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[CallsUnknownMethods(Count = 7)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public WindowDragTilt()
	{
	}
}
