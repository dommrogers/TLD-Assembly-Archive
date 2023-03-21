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

	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	public void OnDisable()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public void FixedUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 7)]
	public void Update()
	{
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public ForceOrientation()
	{
	}
}
