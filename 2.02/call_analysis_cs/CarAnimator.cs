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

	[Calls(Type = typeof(SplineUtils), Member = "WrapValue")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Spline), Member = "GetOrientationOnSpline")]
	[Calls(Type = typeof(Spline), Member = "GetPositionOnSpline")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Spline), Member = "GetCustomValueOnSpline")]
	[CallsUnknownMethods(Count = 12)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(SplineUtils), Member = "WrapValue")]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public CarAnimator()
	{
	}
}
