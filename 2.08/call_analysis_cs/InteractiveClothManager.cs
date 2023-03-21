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

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(InteractiveClothManager), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	public void Initialize()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Cloth), Member = "set_enabled")]
	[Calls(Type = typeof(Cloth), Member = "get_enabled")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(SceneManager), Member = "IsLoading")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InteractiveClothManager), Member = "Initialize")]
	private void Update()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Wind), Member = "SetWindAccelerationForAllInteractiveCloth")]
	[CallsUnknownMethods(Count = 4)]
	public void SetAcceleration(Vector3 externalAcceleration, Vector3 randomAcceleration)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Cloth), Member = "set_enabled")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public void EnableAll(bool enable)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public InteractiveClothManager()
	{
	}
}
