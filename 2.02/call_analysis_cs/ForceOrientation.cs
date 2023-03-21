using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ForceOrientation : MonoBehaviour
{
	public bool m_ResetLocalRotationOnDisable;

	public bool m_AlwaysOrientToPlayer;

	private Camera m_WeaponCamera;

	public Vector3 m_RotationOffset;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsUnknownMethods(Count = 6)]
	public void OnDisable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void FixedUpdate()
	{
	}

	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public ForceOrientation()
	{
	}
}
