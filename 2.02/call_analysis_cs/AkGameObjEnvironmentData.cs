using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Audio.SimpleAudio;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AkGameObjEnvironmentData
{
	private readonly List<AkEnvironment> activeEnvironments;

	private readonly List<AkEnvironment> activeEnvironmentsFromPortals;

	private readonly List<AkEnvironmentPortal> activePortals;

	private readonly AkAuxSendArray auxSendValues;

	private Vector3 lastPosition;

	private bool hasEnvironmentListChanged;

	private bool hasActivePortalListChanged;

	private bool hasSentZero;

	[CalledBy(Type = typeof(AkGameObjEnvironmentData), Member = "UpdateAuxSend")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(List<>), Member = "BinarySearch")]
	[Calls(Type = typeof(AkEnvironmentPortal), Member = "GetAuxSendValueForPosition")]
	[Calls(Type = typeof(AkAuxSendArray), Member = "Add")]
	[Calls(Type = typeof(AkAuxSendArray), Member = "get_isFull")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	private void AddHighestPriorityEnvironmentsFromPortals(Vector3 position)
	{
	}

	[CalledBy(Type = typeof(AkGameObjEnvironmentData), Member = "UpdateAuxSend")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AkAuxSendArray), Member = "get_isFull")]
	[Calls(Type = typeof(AkAuxSendArray), Member = "Contains")]
	[Calls(Type = typeof(AkAuxSendArray), Member = "Add")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	private void AddHighestPriorityEnvironments(Vector3 position)
	{
	}

	[CalledBy(Type = typeof(AkGameObj), Member = "MaybeUpdateAuxValues")]
	[CalledBy(Type = typeof(AkGameObj), Member = "Awake")]
	[CalledBy(Type = typeof(AmbientMultiPositionEnvironmentTracker), Member = "Update")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AkGameObjEnvironmentData), Member = "AddHighestPriorityEnvironmentsFromPortals")]
	[Calls(Type = typeof(AkGameObjEnvironmentData), Member = "AddHighestPriorityEnvironments")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public void UpdateAuxSend(GameObject gameObject, Vector3 position)
	{
	}

	[CalledBy(Type = typeof(AkGameObjEnvironmentData), Member = "AddAkEnvironment")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(List<>), Member = "BinarySearch")]
	[Calls(Type = typeof(List<>), Member = "Insert")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void TryAddEnvironment(AkEnvironment env)
	{
	}

	[CalledBy(Type = typeof(AkGameObjEnvironmentData), Member = "RemoveAkEnvironment")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void RemoveEnvironment(AkEnvironment env)
	{
	}

	[CalledBy(Type = typeof(AkGameObj), Member = "Awake")]
	[CalledBy(Type = typeof(AkGameObj), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(AmbientMultiPositionEnvironmentTracker), Member = "OnTriggerEnter")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(AkGameObjEnvironmentData), Member = "TryAddEnvironment")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public void AddAkEnvironment(Collider environmentCollider, Collider gameObjectCollider)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private bool AkEnvironmentBelongsToActivePortals(AkEnvironment env)
	{
		return false;
	}

	[CalledBy(Type = typeof(AkGameObj), Member = "OnTriggerExit")]
	[CalledBy(Type = typeof(AmbientMultiPositionEnvironmentTracker), Member = "OnTriggerExit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(AkGameObjEnvironmentData), Member = "RemoveEnvironment")]
	[Calls(Type = typeof(Collider), Member = "get_bounds")]
	[Calls(Type = typeof(Bounds), Member = "Intersects")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 15)]
	public void RemoveAkEnvironment(Collider environmentCollider, Collider gameObjectCollider)
	{
	}

	[CalledBy(Type = typeof(AkGameObj), Member = "LevelLoadedCallback")]
	[CalledBy(Type = typeof(AmbientMultiPositionEnvironmentTracker), Member = "OnDestroy")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void Reset()
	{
	}

	[CalledBy(Type = typeof(AkGameObj), Member = "Awake")]
	[CalledBy(Type = typeof(AmbientMultiPositionEnvironmentTracker), Member = "Awake")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkAuxSendValue_GetSizeOf")]
	[Calls(Type = typeof(Marshal), Member = "AllocHGlobal")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 28)]
	public AkGameObjEnvironmentData()
	{
	}
}
