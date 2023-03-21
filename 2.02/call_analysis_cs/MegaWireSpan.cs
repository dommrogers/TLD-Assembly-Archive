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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void OnBecameVisible()
	{
	}

	[CallerCount(Count = 0)]
	private void OnBecameInvisible()
	{
	}

	[CalledBy(Type = typeof(MegaWire), Member = "Create")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(MegaWireConnection), Member = "Init")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	public void Init(MegaWire wire)
	{
	}

	[CalledBy(Type = typeof(MegaWire), Member = "WireUpdate")]
	[CalledBy(Type = typeof(MegaWire), Member = "RunPhysics")]
	[CallerCount(Count = 2)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public void UpdateSpan(MegaWire wire, float ts)
	{
	}

	[CalledBy(Type = typeof(MegaWire), Member = "RunPhysics")]
	[CalledBy(Type = typeof(MegaWire), Member = "RebuildWire")]
	[CalledBy(Type = typeof(MegaWire), Member = "LateUpdate")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MegaWireConnection), Member = "MoveMasses")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
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
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public MegaWireSpan()
	{
	}
}
