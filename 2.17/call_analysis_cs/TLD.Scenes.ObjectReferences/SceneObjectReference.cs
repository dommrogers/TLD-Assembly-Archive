using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using InteractiveObjects;
using TLD.Gameplay;
using TLD.Logging;
using UnityEngine;

namespace TLD.Scenes.ObjectReferences;

public class SceneObjectReference : ScriptableObject
{
	public delegate void SceneObjectReferenceNotificationDelegate(SceneObjectReference sender, GameObject owner);

	public static readonly LogFilter LogFilter;

	private string m_SceneName;

	private string m_ObjectPath;

	private GameObject m_ownerObject;

	private readonly List<SceneObjectReferenceNotificationDelegate> m_notifyOnAvailable;

	public string SceneName
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 32)]
		get
		{
			return null;
		}
	}

	public string ObjectPath
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 25)]
		get
		{
			return null;
		}
	}

	public GameObject Owner
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 29)]
		get
		{
			return null;
		}
	}

	public event SceneObjectReferenceNotificationDelegate OnAvailable
	{
		[CalledBy(Type = typeof(TrackableItemsManager), Member = "Awake")]
		[CalledBy(TypeFullName = "TLD.Gameplay.BunkerDistributor.BunkerLocationInteriorPair", Member = ".ctor")]
		[CalledBy(TypeFullName = "TLD.Gameplay.BunkerDistributor.BunkerLocationInteriorPair", Member = "Attach")]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		add
		{
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(List<>), Member = "Remove")]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	[CalledBy(Type = typeof(TrackableItem), Member = "Awake")]
	[CalledBy(Type = typeof(TrackableItem), Member = "OnDestroy")]
	[CalledBy(Type = typeof(FakeTrackableItem), Member = "Awake")]
	[CalledBy(Type = typeof(FakeTrackableItem), Member = "OnDestroy")]
	[CalledBy(Type = typeof(Transmitter), Member = "Awake")]
	[CalledBy(Type = typeof(Transmitter), Member = "OnDestroy")]
	[CalledBy(Type = typeof(BunkerLocation), Member = "Awake")]
	[CalledBy(Type = typeof(BunkerLocation), Member = "OnDestroy")]
	[CallerCount(Count = 8)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void SetOwner(GameObject gameObject)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void NotifyAvailable()
	{
	}

	[CalledBy(Type = typeof(TrackableItemData), Member = ".ctor")]
	[CalledBy(Type = typeof(TransmitterData), Member = ".ctor")]
	[CalledBy(Type = typeof(BunkerLocationReference), Member = ".ctor")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public SceneObjectReference()
	{
	}
}
