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

	[CallsUnknownMethods(Count = 13)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(AkEnvironmentPortal), Member = "GetAuxSendValueForPosition")]
	[Calls(Type = typeof(AkAuxSendArray), Member = "Add")]
	[Calls(Type = typeof(AkAuxSendArray), Member = "get_isFull")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(AkGameObjEnvironmentData), Member = "UpdateAuxSend")]
	private void AddHighestPriorityEnvironmentsFromPortals(Vector3 position)
	{
	}

	[CalledBy(Type = typeof(AkGameObjEnvironmentData), Member = "UpdateAuxSend")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(AkAuxSendArray), Member = "get_isFull")]
	[Calls(Type = typeof(AkAuxSendArray), Member = "Add")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AkAuxSendArray), Member = "get_isFull")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(AkAuxSendArray), Member = "Contains")]
	private void AddHighestPriorityEnvironments(Vector3 position)
	{
	}

	[CalledBy(Type = typeof(AkGameObj), Member = "Awake")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(AmbientMultiPositionEnvironmentTracker), Member = "Update")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CalledBy(Type = typeof(AkGameObj), Member = "MaybeUpdateAuxValues")]
	[Calls(Type = typeof(AkGameObjEnvironmentData), Member = "AddHighestPriorityEnvironments")]
	[Calls(Type = typeof(AkGameObjEnvironmentData), Member = "AddHighestPriorityEnvironmentsFromPortals")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	public void UpdateAuxSend(GameObject gameObject, Vector3 position)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(AkGameObjEnvironmentData), Member = "AddAkEnvironment")]
	[CalledBy(Type = typeof(AkGameObjEnvironmentData), Member = "AddAkEnvironment")]
	[CallsUnknownMethods(Count = 4)]
	private void TryAddEnvironment(AkEnvironment env)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(AkGameObjEnvironmentData), Member = "RemoveAkEnvironment")]
	[CalledBy(Type = typeof(AkGameObjEnvironmentData), Member = "RemoveAkEnvironment")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void RemoveEnvironment(AkEnvironment env)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(AkGameObjEnvironmentData), Member = "TryAddEnvironment")]
	[Calls(Type = typeof(AkGameObjEnvironmentData), Member = "TryAddEnvironment")]
	[CalledBy(Type = typeof(AkGameObj), Member = "Awake")]
	[CalledBy(Type = typeof(AkGameObj), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(AmbientMultiPositionEnvironmentTracker), Member = "OnTriggerEnter")]
	[CallsUnknownMethods(Count = 6)]
	public void AddAkEnvironment(Collider environmentCollider, Collider gameObjectCollider)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool AkEnvironmentBelongsToActivePortals(AkEnvironment env)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(AmbientMultiPositionEnvironmentTracker), Member = "OnTriggerExit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(AkGameObjEnvironmentData), Member = "RemoveEnvironment")]
	[Calls(Type = typeof(Bounds), Member = "Intersects")]
	[Calls(Type = typeof(Collider), Member = "get_bounds")]
	[Calls(Type = typeof(Collider), Member = "get_bounds")]
	[CalledBy(Type = typeof(AkGameObj), Member = "OnTriggerExit")]
	[Calls(Type = typeof(AkGameObjEnvironmentData), Member = "RemoveEnvironment")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public void RemoveAkEnvironment(Collider environmentCollider, Collider gameObjectCollider)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(AmbientMultiPositionEnvironmentTracker), Member = "OnDestroy")]
	[CalledBy(Type = typeof(AkGameObj), Member = "LevelLoadedCallback")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public void Reset()
	{
	}

	[CallsUnknownMethods(Count = 28)]
	[CalledBy(Type = typeof(AmbientMultiPositionEnvironmentTracker), Member = "Awake")]
	[CalledBy(Type = typeof(AkGameObj), Member = "Awake")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Marshal), Member = "AllocHGlobal")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkAuxSendValue_GetSizeOf")]
	public AkGameObjEnvironmentData()
	{
	}
}
