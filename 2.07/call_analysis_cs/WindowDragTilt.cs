using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class WindowDragTilt : MonoBehaviour
{
	public int updateOrder;

	public float degrees;

	private Vector3 mLastPos;

	private Transform mTrans;

	private float mAngle;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUIMath), Member = "SpringLerp")]
	[CallsUnknownMethods(Count = 6)]
	[CallsDeduplicatedMethods(Count = 5)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	public WindowDragTilt()
	{
	}
}
