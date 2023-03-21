using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PanWithMouse : MonoBehaviour
{
	public Vector2 degrees;

	public float range;

	private Transform mTrans;

	private Quaternion mStart;

	private Vector2 mRot;

	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	public PanWithMouse()
	{
	}
}
