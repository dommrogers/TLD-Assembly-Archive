using Cpp2ILInjected.CallAnalysis;
using SplineUtilities;
using UnityEngine;

public class SplineAnimatorCustomValue : MonoBehaviour
{
	public Spline spline;

	public WrapMode wrapMode;

	public float speed;

	public float offSet;

	public float passedTime;

	[Calls(Type = typeof(Spline), Member = "GetCustomValueOnSpline")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[Calls(Type = typeof(Spline), Member = "GetOrientationOnSpline")]
	[Calls(Type = typeof(Spline), Member = "GetPositionOnSpline")]
	[Calls(Type = typeof(SplineUtils), Member = "WrapValue")]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public SplineAnimatorCustomValue()
	{
	}
}
