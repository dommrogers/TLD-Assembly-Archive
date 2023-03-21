using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ForceOrientation : MonoBehaviour
{
	public bool m_ResetLocalRotationOnDisable;

	public bool m_AlwaysOrientToPlayer;

	private Camera m_WeaponCamera;

	public Vector3 m_RotationOffset;

	[CallerCount(Count = 0)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public void OnDisable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void FixedUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CallsUnknownMethods(Count = 6)]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public ForceOrientation()
	{
	}
}
