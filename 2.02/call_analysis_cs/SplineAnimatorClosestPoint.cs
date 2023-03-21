using Cpp2ILInjected.CallAnalysis;
using SplineUtilities;
using UnityEngine;

public class SplineAnimatorClosestPoint : MonoBehaviour
{
	public Spline spline;

	public WrapMode wMode;

	public Transform target;

	public int iterations;

	public float diff;

	public float offset;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Spline), Member = "GetClosestPointParam")]
	[Calls(Type = typeof(SplineUtils), Member = "WrapValue")]
	[Calls(Type = typeof(Spline), Member = "GetPositionOnSpline")]
	[Calls(Type = typeof(Spline), Member = "GetOrientationOnSpline")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 11)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public SplineAnimatorClosestPoint()
	{
	}
}
