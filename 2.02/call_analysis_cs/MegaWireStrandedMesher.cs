using System;
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

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Copy(MegaWireStrandedMesher src)
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public override void BuildMesh(MegaWire rope, MegaWireSpan span)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsUnknownMethods(Count = 5)]
	private void BuildCrossSection(float rad)
	{
	}

	[CallerCount(Count = 0)]
	public MegaWireStrandedMesher()
	{
	}
}
