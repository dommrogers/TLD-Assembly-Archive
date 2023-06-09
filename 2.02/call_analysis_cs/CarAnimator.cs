using Cpp2ILInjected.CallAnalysis;
using SplineUtilities;
using UnityEngine;

public class CarAnimator : MonoBehaviour
{
	public Spline spline;

	public WrapMode wrapMode;

	public float speed;

	public float passedTime;

	public float rotationOffset;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SplineUtils), Member = "WrapValue")]
	[Calls(Type = typeof(Spline), Member = "GetOrientationOnSpline")]
	[Calls(Type = typeof(Spline), Member = "GetPositionOnSpline")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Spline), Member = "GetCustomValueOnSpline")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 12)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public CarAnimator()
	{
	}
}
