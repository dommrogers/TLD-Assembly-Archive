using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class MegaWireStrandedMesher : MegaWireMesher
{
	private Matrix4x4 wtm;

	public int sides;

	public int segments;

	public float uvtwist;

	public float uvtilex;

	public float uvtiley;

	public int strands;

	public float offset;

	public float Twist;

	public bool cap;

	public float strandRadius;

	public float SegsPerUnit;

	public float TwistPerUnit;

	public bool calcBounds;

	public bool calcTangents;

	public bool genuv;

	public bool linInterp;

	public float rotation;

	private Vector3 ropeup;

	private Vector3[] cross;

	private Vector3[] cnorms;

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void Copy(MegaWireStrandedMesher src)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MegaWireStrandedMesher), Member = "BuildCrossSection")]
	[Calls(Type = typeof(List<>), Member = "get_Item")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(MegaWireConnection), Member = "GetDeformMat")]
	[Calls(Type = typeof(Vector3), Member = "op_Multiply")]
	[Calls(Type = typeof(Vector3), Member = "op_Addition")]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint3x4")]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyVector")]
	[Calls(Type = typeof(MegaWireConnection), Member = "GetDeformMatLin")]
	[Calls(Type = typeof(Mesh), Member = "SetArrayForChannel")]
	[Calls(Type = typeof(Mesh), Member = "set_triangles")]
	[Calls(Type = typeof(Mesh), Member = "RecalculateBounds")]
	[Calls(Type = typeof(Mesh), Member = "get_normals")]
	[Calls(Type = typeof(MegaWireMesher), Member = "BuildTangents")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 59)]
	public override void BuildMesh(MegaWire rope, MegaWireSpan span)
	{
	}

	[CalledBy(Type = typeof(MegaWireStrandedMesher), Member = "BuildMesh")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private void BuildCrossSection(float rad)
	{
	}

	[CallerCount(Count = 0)]
	public MegaWireStrandedMesher()
	{
	}
}
