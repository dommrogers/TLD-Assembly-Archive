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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Vector2), Member = "Lerp")]
	private void Update()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public PanWithMouse()
	{
	}
}
