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

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 32)]
	[CalledBy(Type = typeof(InteractiveClothManager), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	public void Initialize()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Cloth), Member = "set_enabled")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(InteractiveClothManager), Member = "Initialize")]
	[Calls(Type = typeof(SceneManager), Member = "IsLoading")]
	[Calls(Type = typeof(Cloth), Member = "get_enabled")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Wind), Member = "SetWindAccelerationForAllInteractiveCloth")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public void SetAcceleration(Vector3 externalAcceleration, Vector3 randomAcceleration)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Cloth), Member = "set_enabled")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 4)]
	public void EnableAll(bool enable)
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 19)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public InteractiveClothManager()
	{
	}
}
