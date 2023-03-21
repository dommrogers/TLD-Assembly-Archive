using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class MegaWireConnection
{
	public Vector3 inOffset;

	public Vector3 outOffset;

	public float radius;

	public Vector3 windFrc;

	public Transform start;

	public Transform end;

	public float WireLength;

	private Matrix4x4 wtm;

	public List<MegaWireMass> masses;

	public List<MegaWireSpring> springs;

	public List<MegaWirePointConstraint> constraints;

	public List<MegaWireLengthConstraint> lenconstraints;

	public Vector3[] masspos;

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public void SetEndConstraintActive(int index, bool active, float time)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Update(MegaWire wire, float timeStep)
	{
	}

	[Calls(Type = typeof(MegaWireSpring), Member = ".ctor")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(MegaWireSpan), Member = "Init")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(MegaWire), Member = "Init")]
	[Calls(Type = typeof(MegaWireLengthConstraint), Member = ".ctor")]
	[CallsUnknownMethods(Count = 129)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(MegaWireSpring), Member = ".ctor")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(MegaWireMass), Member = ".ctor")]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public void Init(MegaWire wire)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(MegaWireSpan), Member = "MoveMasses")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 24)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public void MoveMasses(MegaWire wire)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[CalledBy(Type = typeof(MegaWireAttach), Member = "LateUpdate")]
	[CalledBy(Type = typeof(MegaWireAttach), Member = "LateUpdate")]
	[CalledBy(Type = typeof(MegaWireConnection), Member = "GetDeformMat")]
	[CallsUnknownMethods(Count = 13)]
	public Vector3 Interp(float t)
	{
		return default(Vector3);
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(MegaWireConnection), Member = "GetDeformMat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	public Vector3 Velocity(float t)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[CalledBy(Type = typeof(MegaWireConnection), Member = "GetDeformMatLin")]
	[CalledBy(Type = typeof(MegaWireConnection), Member = "GetDeformMatLin")]
	[CalledBy(Type = typeof(MegaWireConnection), Member = "GetDeformMatLin")]
	[CallsUnknownMethods(Count = 7)]
	public Vector3 LinInterp(float t)
	{
		return default(Vector3);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(MegaWireConnection), Member = "Velocity")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MegaWireConnection), Member = "Interp")]
	public Matrix4x4 GetDeformMat(float alpha)
	{
		return default(Matrix4x4);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(MegaWireConnection), Member = "LinInterp")]
	[Calls(Type = typeof(MegaWireConnection), Member = "LinInterp")]
	[Calls(Type = typeof(MegaWireConnection), Member = "LinInterp")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[CallsUnknownMethods(Count = 1)]
	public Matrix4x4 GetDeformMatLin(float alpha)
	{
		return default(Matrix4x4);
	}

	[CallsUnknownMethods(Count = 28)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CalledBy(Type = typeof(MegaWire), Member = "Init")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	public MegaWireConnection()
	{
	}
}
