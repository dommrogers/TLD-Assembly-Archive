using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class MegaWireSpring
{
	public int p1;

	public int p2;

	public float restlen;

	public float initlen;

	public float ks;

	public float kd;

	public float len;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public MegaWireSpring(int _p1, int _p2, float _ks, float _kd, MegaWireConnection con)
	{
	}

	[CalledBy(Type = typeof(MegaWireConnection), Member = "Init")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public MegaWireSpring(int _p1, int _p2, float _ks, float _kd, MegaWireConnection con, float stretch)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	public void doCalculateSpringForce(MegaWireConnection hose)
	{
	}

	[CalledBy(Type = typeof(MegaWireSolverVertlet), Member = "doCalculateForces")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 22)]
	public void doCalculateSpringForce1(MegaWireConnection mod)
	{
	}
}
