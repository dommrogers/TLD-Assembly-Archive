using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PanWithMouse : MonoBehaviour
{
	public Vector2 degrees;

	public float range;

	private Transform mTrans;

	private Quaternion mStart;

	private Vector2 mRot;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	public PanWithMouse()
	{
	}
}
