using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class MegaWireLengthConstraint : MegaWireConstraint
{
	public int p1;

	public int p2;

	public float length;

	private Vector3 moveVector;

	[CalledBy(Type = typeof(MegaWireConnection), Member = "Init")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 1)]
	public MegaWireLengthConstraint(int _p1, int _p2, float _len)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 21)]
	public override void Apply(MegaWireConnection soft)
	{
	}
}
