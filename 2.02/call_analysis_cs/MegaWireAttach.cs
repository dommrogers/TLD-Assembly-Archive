using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MegaWireAttach : MonoBehaviour
{
	public MegaWire wire;

	public int span;

	public int connection;

	public float alpha;

	public Vector3 offset;

	public bool align;

	public Vector3 rotate;

	private Quaternion locrot;

	private Matrix4x4 wtm;

	public Transform parent;

	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Matrix4x4), Member = "SetTRS")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(MegaWireConnection), Member = "Interp")]
	[Calls(Type = typeof(MegaWireConnection), Member = "Interp")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	private void LateUpdate()
	{
	}

	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public MegaWireAttach()
	{
	}
}
