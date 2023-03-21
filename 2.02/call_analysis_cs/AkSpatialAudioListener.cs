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
			[CallerCount(Count = 59)]
			get
			{
				return null;
			}
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Equality")]
		[Calls(Type = typeof(List<>), Member = "Contains")]
		[Calls(Type = typeof(List<>), Member = "Add")]
		[Calls(Type = typeof(SpatialAudioListenerList), Member = "Refresh")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public bool Add(AkSpatialAudioListener listener)
		{
			return false;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Equality")]
		[Calls(Type = typeof(List<>), Member = "Contains")]
		[Calls(Type = typeof(List<>), Member = "Remove")]
		[Calls(Type = typeof(SpatialAudioListenerList), Member = "Refresh")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public bool Remove(AkSpatialAudioListener listener)
		{
			return false;
		}

		[CalledBy(Type = typeof(AkSpatialAudioListener), Member = "OnEnable")]
		[CalledBy(Type = typeof(AkSpatialAudioListener), Member = "OnDisable")]
		[CalledBy(Type = typeof(SpatialAudioListenerList), Member = "Add")]
		[CalledBy(Type = typeof(SpatialAudioListenerList), Member = "Remove")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[Calls(Type = typeof(AkSoundEngine), Member = "UnregisterSpatialAudioListener")]
		[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
		[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
		[Calls(Type = typeof(AkSpatialAudioBase), Member = "SetGameObjectInRoom")]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 11)]
		private void Refresh()
		{
		}

		[CalledBy(Type = typeof(AkSpatialAudioListener), Member = ".cctor")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(List<>), Member = ".ctor")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		public SpatialAudioListenerList()
		{
		}
	}

	private static AkSpatialAudioListener s_SpatialAudioListener;

	private static readonly SpatialAudioListenerList spatialAudioListeners;

	private AkAudioListener AkAudioListener;

	public static AkAudioListener TheSpatialAudioListener
	{
		[CalledBy(Type = typeof(AkEmitterObstructionOcclusion), Member = "UpdateCurrentListenerList")]
		[CalledBy(Type = typeof(AkRoom), Member = "get_IsSpatialAudioEnabled")]
		[CalledBy(Type = typeof(AkRoomPortalObstruction), Member = "UpdateCurrentListenerList")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
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
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(SpatialAudioListenerList), Member = "Refresh")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(SpatialAudioListenerList), Member = "Refresh")]
	[CallsDeduplicatedMethods(Count = 2)]
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
