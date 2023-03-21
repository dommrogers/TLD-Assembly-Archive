using Cpp2ILInjected.CallAnalysis;
using SplineUtilities;
using UnityEngine;

public class SplineAnimator : MonoBehaviour
{
	public Spline spline;

	public WrapMode wrapMode;

	public float speed;

	public float offSet;

	public float passedTime;

	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(SplineUtils), Member = "WrapValue")]
	[Calls(Type = typeof(Spline), Member = "GetPositionOnSpline")]
	[Calls(Type = typeof(Spline), Member = "GetOrientationOnSpline")]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public SplineAnimator()
	{
	}
}
