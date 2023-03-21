using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MegaWireHanger : MonoBehaviour
{
	public MegaWire wire;

	public float alpha;

	public int strand;

	public float offset;

	public float weight;

	public bool align;

	public Vector3 rotate;

	private Quaternion locrot;

	private Matrix4x4 wtm;

	public Transform parent;

	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Matrix4x4), Member = "SetTRS")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(MegaWire), Member = "SetWeight")]
	[Calls(Type = typeof(Transform), Member = "get_localToWorldMatrix")]
	[Calls(Type = typeof(MegaWire), Member = "SetWeight")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "get_localToWorldMatrix")]
	private void LateUpdate()
	{
	}

	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public MegaWireHanger()
	{
	}
}
