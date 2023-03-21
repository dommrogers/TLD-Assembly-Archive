using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class MegaWireSolverVertlet : MegaWireSolver
{
	[CalledBy(Type = typeof(MegaWireSolverVertlet), Member = "doIntegration1")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MegaWireSpring), Member = "doCalculateSpringForce1")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private void doCalculateForces(MegaWireConnection rope, MegaWire wire)
	{
	}

	[CalledBy(Type = typeof(MegaWireSolverVertlet), Member = "doIntegration1")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MegaWirePointConstraint), Member = "ReActivate")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 12)]
	private void DoConstraints(MegaWireConnection rope, MegaWire wire)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MegaWireSolverVertlet), Member = "doCalculateForces")]
	[Calls(Type = typeof(MegaWireSolverVertlet), Member = "DoConstraints")]
	[Calls(Type = typeof(MegaWireSolverVertlet), Member = "DoCollisions")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 23)]
	public override void doIntegration1(MegaWireConnection rope, MegaWire wire, float dt)
	{
	}

	[CalledBy(Type = typeof(MegaWireSolverVertlet), Member = "doIntegration1")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 31)]
	private void DoCollisions(MegaWireConnection rope, MegaWire wire)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public MegaWireSolverVertlet()
	{
	}
}
