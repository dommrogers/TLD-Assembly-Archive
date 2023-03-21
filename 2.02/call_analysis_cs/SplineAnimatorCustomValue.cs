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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SplineUtils), Member = "WrapValue")]
	[Calls(Type = typeof(Spline), Member = "GetCustomValueOnSpline")]
	[Calls(Type = typeof(Spline), Member = "GetPositionOnSpline")]
	[Calls(Type = typeof(Spline), Member = "GetOrientationOnSpline")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 13)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public SplineAnimatorCustomValue()
	{
	}
}
