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

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(InteractiveClothManager), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	public void Initialize()
	{
	}

	[Calls(Type = typeof(Cloth), Member = "get_enabled")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Cloth), Member = "set_enabled")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(InteractiveClothManager), Member = "Initialize")]
	[Calls(Type = typeof(SceneManager), Member = "IsLoading")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Wind), Member = "SetWindAccelerationForAllInteractiveCloth")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public void SetAcceleration(Vector3 externalAcceleration, Vector3 randomAcceleration)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Cloth), Member = "set_enabled")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public void EnableAll(bool enable)
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public InteractiveClothManager()
	{
	}
}
