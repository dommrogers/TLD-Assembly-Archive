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

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	public void SetEndConstraintActive(int index, bool active, float time)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Update(MegaWire wire, float timeStep)
	{
	}

	[CalledBy(Type = typeof(MegaWire), Member = "Init")]
	[CalledBy(Type = typeof(MegaWireSpan), Member = "Init")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[Calls(Type = typeof(MegaWireMass), Member = ".ctor")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(MegaWireSpring), Member = ".ctor")]
	[Calls(Type = typeof(MegaWireLengthConstraint), Member = ".ctor")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 129)]
	public void Init(MegaWire wire)
	{
	}

	[CalledBy(Type = typeof(MegaWireSpan), Member = "MoveMasses")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 24)]
	public void MoveMasses(MegaWire wire)
	{
	}

	[CalledBy(Type = typeof(MegaWireAttach), Member = "LateUpdate")]
	[CalledBy(Type = typeof(MegaWireConnection), Member = "GetDeformMat")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	public Vector3 Interp(float t)
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(MegaWireConnection), Member = "GetDeformMat")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	public Vector3 Velocity(float t)
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(MegaWireConnection), Member = "GetDeformMatLin")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public Vector3 LinInterp(float t)
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(MegaWireStrandedMesher), Member = "BuildMesh")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MegaWireConnection), Member = "Interp")]
	[Calls(Type = typeof(MegaWireConnection), Member = "Velocity")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public Matrix4x4 GetDeformMat(float alpha)
	{
		return default(Matrix4x4);
	}

	[CalledBy(Type = typeof(MegaWireStrandedMesher), Member = "BuildMesh")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MegaWireConnection), Member = "LinInterp")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public Matrix4x4 GetDeformMatLin(float alpha)
	{
		return default(Matrix4x4);
	}

	[CalledBy(Type = typeof(MegaWire), Member = "Init")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 28)]
	public MegaWireConnection()
	{
	}
}
