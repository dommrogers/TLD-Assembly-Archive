using System;
using System.Collections.Generic;
using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AkRoom : AkTriggerHandler
{
	public class PriorityList
	{
		private class CompareByPriority : IComparer<AkRoom>
		{
			[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 2)]
			public virtual int Compare(AkRoom a, AkRoom b)
			{
				return default(int);
			}

			[CallerCount(Count = 2)]
			[DeduplicatedMethod]
			public CompareByPriority()
			{
			}
		}

		private static readonly CompareByPriority s_compareByPriority;

		public List<AkRoom> rooms;

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(PriorityList), Member = "GetHighestPriorityRoom")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(AkRoom), Member = "GetID")]
		[CallsUnknownMethods(Count = 1)]
		public ulong GetHighestPriorityRoomID()
		{
			return default(ulong);
		}

		[CalledBy(Type = typeof(AkRoomPortal), Member = "UpdateOverlappingRooms")]
		[CalledBy(Type = typeof(AkSpatialAudioBase), Member = "SetGameObjectInHighestPriorityRoom")]
		[CalledBy(Type = typeof(PriorityList), Member = "GetHighestPriorityRoomID")]
		[CallsUnknownMethods(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		public AkRoom GetHighestPriorityRoom()
		{
			return null;
		}

		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(AkSpatialAudioBase), Member = "SetGameObjectInRoom")]
		[CalledBy(Type = typeof(AkSpatialAudioBase), Member = "EnteredRoom")]
		[CalledBy(Type = typeof(AkRoomPortal), Member = "FillRoomList")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(PriorityList), Member = "BinarySearch")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(AkRoom), Member = "OnTriggerEnter")]
		public void Add(AkRoom room)
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		public void Remove(AkRoom room)
		{
		}

		[Calls(Type = typeof(PriorityList), Member = "BinarySearch")]
		[CallerCount(Count = 0)]
		public bool Contains(AkRoom room)
		{
			return default(bool);
		}

		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CalledBy(Type = typeof(PriorityList), Member = "Contains")]
		[CalledBy(Type = typeof(AkRoomPortal), Member = "FillRoomList")]
		[CalledBy(Type = typeof(AkRoomPortal), Member = "UpdateOverlappingRooms")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(PriorityList), Member = "Add")]
		public int BinarySearch(AkRoom room)
		{
			return default(int);
		}

		[CallsUnknownMethods(Count = 7)]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(AkRoomPortal), Member = "UpdateOverlappingRooms")]
		[CalledBy(Type = typeof(AkRoomPortal), Member = "UpdateOverlappingRooms")]
		[CalledBy(Type = typeof(AkSpatialAudioBase), Member = ".ctor")]
		public PriorityList()
		{
		}
	}

	public static ulong INVALID_ROOM_ID;

	private static int RoomCount;

	public int priority;

	public AuxBus reverbAuxBus;

	public float reverbLevel;

	public float wallOcclusion;

	public AK.Wwise.Event roomToneEvent;

	public float roomToneAuxSend;

	public static bool IsSpatialAudioEnabled
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(AkSpatialAudioListener), Member = "get_TheSpatialAudioListener")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CalledBy(Type = typeof(AkEmitterObstructionOcclusion), Member = "UpdateCurrentListenerList")]
		[CalledBy(Type = typeof(AkEmitterObstructionOcclusion), Member = "SetObstructionOcclusion")]
		get
		{
			return default(bool);
		}
	}

	[CalledBy(Type = typeof(AkRoomPortal), Member = "SetFrontRoom")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(AkSpatialAudioBase), Member = "SetGameObjectInHighestPriorityRoom")]
	[CalledBy(Type = typeof(AkRoomPortal), Member = "UpdateOverlappingRooms")]
	[CalledBy(Type = typeof(AkRoomPortal), Member = "UpdateOverlappingRooms")]
	[CalledBy(Type = typeof(AkRoomPortal), Member = "SetBackRoom")]
	[CalledBy(Type = typeof(AkRoomPortal), Member = "Awake")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[CalledBy(Type = typeof(PriorityList), Member = "GetHighestPriorityRoomID")]
	[CalledBy(Type = typeof(AkRoom), Member = "OnDisable")]
	[CalledBy(Type = typeof(AkRoom), Member = "OnEnable")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(AkRoomPortal), Member = "Awake")]
	public ulong GetID()
	{
		return default(ulong);
	}

	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(AkVector), Member = "set_Y")]
	[Calls(Type = typeof(AkRoomParams), Member = "get_Front")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(AkRoom), Member = "GetID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetRoom")]
	[CallsUnknownMethods(Count = 34)]
	[Calls(Type = typeof(AkRoomParams), Member = "get_Front")]
	[Calls(Type = typeof(AkVector), Member = "set_Z")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(AkVector), Member = "set_X")]
	[Calls(Type = typeof(AkVector), Member = "set_Z")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 22)]
	[Calls(Type = typeof(AkRoomParams), Member = "get_Up")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(AkVector), Member = "set_X")]
	[Calls(Type = typeof(AkRoomParams), Member = "get_Front")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(AkVector), Member = "set_Y")]
	[Calls(Type = typeof(AkRoomParams), Member = "get_Up")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(AkRoomParams), Member = "get_Up")]
	private void OnEnable()
	{
	}

	[Calls(Type = typeof(AkTriggerHandler), Member = "Start")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected override void Start()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AK.Wwise.Event), Member = "Post")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public override void HandleEvent(GameObject in_gameObject)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AkRoom), Member = "GetID")]
	[CallsUnknownMethods(Count = 1)]
	private void OnDisable()
	{
	}

	[Calls(Type = typeof(AkSpatialAudioBase), Member = "SetGameObjectInHighestPriorityRoom")]
	[CallsUnknownMethods(Count = 10)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PriorityList), Member = "Add")]
	private void OnTriggerEnter(Collider in_other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(AkSpatialAudioBase), Member = "ExitedRoom")]
	[CallsUnknownMethods(Count = 9)]
	private void OnTriggerExit(Collider in_other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkTriggerHandler), Member = ".ctor")]
	[CallsUnknownMethods(Count = 14)]
	public AkRoom()
	{
	}
}
