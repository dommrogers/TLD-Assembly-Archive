using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MegaWireSpan : MonoBehaviour
{
	public bool visible;

	public bool on;

	public Transform start;

	public Transform end;

	public List<MegaWireConnection> connections;

	public Mesh mesh;

	public float WireLength;

	public bool AllowUpdates;

	public bool buildmesh;

	public float time;

	public Matrix4x4 startTm;

	public Matrix4x4 endTm;

	public int vcount;

	public Vector3[] verts;

	public Vector2[] uvs;

	public int[] tris;

	public Vector3[] norms;

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void OnBecameVisible()
	{
	}

	[CallerCount(Count = 0)]
	private void OnBecameInvisible()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(MegaWireConnection), Member = "Init")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(MegaWire), Member = "Create")]
	public void Init(MegaWire wire)
	{
	}

	[CalledBy(Type = typeof(MegaWire), Member = "RunPhysics")]
	[CalledBy(Type = typeof(MegaWire), Member = "WireUpdate")]
	[CallsUnknownMethods(Count = 5)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public void UpdateSpan(MegaWire wire, float ts)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(MegaWire), Member = "LateUpdate")]
	[CalledBy(Type = typeof(MegaWire), Member = "RebuildWire")]
	[CalledBy(Type = typeof(MegaWire), Member = "RunPhysics")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MegaWireConnection), Member = "MoveMasses")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public void MoveMasses(MegaWire wire)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void BuildMesh(MegaWire wire)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	public MegaWireSpan()
	{
	}
}
