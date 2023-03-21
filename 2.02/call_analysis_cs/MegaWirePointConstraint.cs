using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class MegaWirePointConstraint : MegaWireConstraint
{
	public int p1;

	public Vector3 offset;

	public Transform obj;

	public Vector3 ps;

	public Vector3 tp;

	[CallerCount(Count = 0)]
	public MegaWirePointConstraint(int _p1, Transform trans, Vector3 off)
	{
	}

	[CalledBy(Type = typeof(MegaWirePointConstraint), Member = "ReActivate")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private Vector3 easeInOutSine(Vector3 start, Vector3 end, float value)
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(MegaWireSolverVertlet), Member = "DoConstraints")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MegaWirePointConstraint), Member = "easeInOutSine")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public void ReActivate(MegaWireConnection soft, float t)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public override void Apply(MegaWireConnection soft)
	{
	}
}
