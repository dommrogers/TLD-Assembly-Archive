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
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(Spline), Member = "GetOrientationOnSpline")]
	[Calls(Type = typeof(Spline), Member = "GetPositionOnSpline")]
	[Calls(Type = typeof(SplineUtils), Member = "WrapValue")]
	[Calls(Type = typeof(Spline), Member = "GetClosestPointParam")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public SplineAnimatorClosestPoint()
	{
	}
}
