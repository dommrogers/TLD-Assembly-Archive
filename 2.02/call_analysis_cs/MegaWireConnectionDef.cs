using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class MegaWireConnectionDef
{
	public Vector3 inOffset;

	public Vector3 outOffset;

	public float radius;

	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public MegaWireConnectionDef()
	{
	}

	[CalledBy(Type = typeof(MegaWire), Member = "Copy")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CalledBy(Type = typeof(MegaWire), Member = "Copy")]
	[CallsUnknownMethods(Count = 1)]
	public MegaWireConnectionDef(MegaWireConnectionDef src)
	{
	}
}
