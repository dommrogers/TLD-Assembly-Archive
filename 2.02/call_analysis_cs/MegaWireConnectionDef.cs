using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class MegaWireConnectionDef
{
	public Vector3 inOffset;

	public Vector3 outOffset;

	public float radius;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 1)]
	public MegaWireConnectionDef()
	{
	}

	[CalledBy(Type = typeof(MegaWire), Member = "Copy")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public MegaWireConnectionDef(MegaWireConnectionDef src)
	{
	}
}
