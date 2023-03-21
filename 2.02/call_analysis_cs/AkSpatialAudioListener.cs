using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AkSpatialAudioListener : AkSpatialAudioBase
{
	public class SpatialAudioListenerList
	{
		private readonly List<AkSpatialAudioListener> listenerList;

		public List<AkSpatialAudioListener> ListenerList
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 52)]
			get
			{
				return null;
			}
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(SpatialAudioListenerList), Member = "Refresh")]
		[CallsUnknownMethods(Count = 2)]
		public bool Add(AkSpatialAudioListener listener)
		{
			return default(bool);
		}

		[CallsDeduplicatedMethods(Count = 3)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(SpatialAudioListenerList), Member = "Refresh")]
		[CallsUnknownMethods(Count = 2)]
		public bool Remove(AkSpatialAudioListener listener)
		{
			return default(bool);
		}

		[CalledBy(Type = typeof(AkSpatialAudioListener), Member = "OnEnable")]
		[CalledBy(Type = typeof(AkSpatialAudioListener), Member = "OnDisable")]
		[CallsUnknownMethods(Count = 11)]
		[CalledBy(Type = typeof(SpatialAudioListenerList), Member = "Remove")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[CalledBy(Type = typeof(SpatialAudioListenerList), Member = "Add")]
		[Calls(Type = typeof(AkSpatialAudioBase), Member = "SetGameObjectInRoom")]
		[CallsDeduplicatedMethods(Count = 6)]
		[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
		[Calls(Type = typeof(AkSoundEngine), Member = "UnregisterSpatialAudioListener")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(AkSoundEngine), Member = "UnregisterSpatialAudioListener")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
		private void Refresh()
		{
		}

		[CallsUnknownMethods(Count = 7)]
		[CalledBy(Type = typeof(AkSpatialAudioListener), Member = ".cctor")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		public SpatialAudioListenerList()
		{
		}
	}

	private static AkSpatialAudioListener s_SpatialAudioListener;

	private static readonly SpatialAudioListenerList spatialAudioListeners;

	private AkAudioListener AkAudioListener;

	public static AkAudioListener TheSpatialAudioListener
	{
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(AkRoomPortalObstruction), Member = "UpdateCurrentListenerList")]
		[CalledBy(Type = typeof(AkRoom), Member = "get_IsSpatialAudioEnabled")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallerCount(Count = 3)]
		[CalledBy(Type = typeof(AkEmitterObstructionOcclusion), Member = "UpdateCurrentListenerList")]
		get
		{
			return null;
		}
	}

	public static SpatialAudioListenerList SpatialAudioListeners
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(SpatialAudioListenerList), Member = "Refresh")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(SpatialAudioListenerList), Member = "Refresh")]
	[CallsUnknownMethods(Count = 3)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSpatialAudioBase), Member = ".ctor")]
	public AkSpatialAudioListener()
	{
	}
}
