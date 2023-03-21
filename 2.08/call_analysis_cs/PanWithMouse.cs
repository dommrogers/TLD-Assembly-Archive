using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PanWithMouse : MonoBehaviour
{
	public Vector2 degrees;

	public float range;

	private Transform mTrans;

	private Quaternion mStart;

	private Vector2 mRot;

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	public PanWithMouse()
	{
	}
}
