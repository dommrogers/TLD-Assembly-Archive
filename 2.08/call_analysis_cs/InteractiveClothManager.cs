using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class InteractiveClothManager : MonoBehaviour
{
	public List<Cloth> m_Items;

	public List<float> m_SimulationDistance;

	private Transform m_PlayerCameraTransform;

	private bool m_Initialized;

	private Vector3 m_lastExternalAcceleration;

	private Vector3 m_lastRandomAcceleration;

	[CalledBy(Type = typeof(InteractiveClothManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(Resources), Member = "FindObjectsOfTypeAll")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 10)]
	public void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SceneManager), Member = "IsLoading")]
	[Calls(Type = typeof(InteractiveClothManager), Member = "Initialize")]
	[Calls(Type = typeof(Cloth), Member = "get_enabled")]
	[Calls(Type = typeof(Cloth), Member = "set_enabled")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(Wind), Member = "SetWindAccelerationForAllInteractiveCloth")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public void SetAcceleration(Vector3 externalAcceleration, Vector3 randomAcceleration)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Cloth), Member = "set_enabled")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	public void EnableAll(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public InteractiveClothManager()
	{
	}
}
