using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class WindowDragTilt : MonoBehaviour
{
	public int updateOrder;

	public float degrees;

	private Vector3 mLastPos;

	private Transform mTrans;

	private float mAngle;

	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(NGUIMath), Member = "SpringLerp")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	public WindowDragTilt()
	{
	}
}
