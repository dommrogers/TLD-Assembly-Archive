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
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Object), Member = "op_Inequality")]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 2)]
			public virtual int Compare(AkRoom a, AkRoom b)
			{
				return 0;
			}

			[DeduplicatedMethod]
			[CallerCount(Count = 7)]
			public CompareByPriority()
			{
			}
		}

		private static readonly CompareByPriority s_compareByPriority;

		public List<AkRoom> rooms;

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(PriorityList), Member = "GetHighestPriorityRoom")]
		[Calls(Type = typeof(Object), Member = "op_Equality")]
		[Calls(Type = typeof(AkRoom), Member = "GetID")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public ulong GetHighestPriorityRoomID()
		{
			return 0uL;
		}

		[CalledBy(Type = typeof(PriorityList), Member = "GetHighestPriorityRoomID")]
		[CalledBy(Type = typeof(AkRoomPortal), Member = "UpdateOverlappingRooms")]
		[CalledBy(Type = typeof(AkSpatialAudioBase), Member = "SetGameObjectInHighestPriorityRoom")]
		[CallerCount(Count = 3)]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public AkRoom GetHighestPriorityRoom()
		{
			return null;
		}

		[CalledBy(Type = typeof(AkRoom), Member = "OnTriggerEnter")]
		[CalledBy(Type = typeof(AkRoomPortal), Member = "FillRoomList")]
		[CalledBy(Type = typeof(AkSpatialAudioBase), Member = "EnteredRoom")]
		[CalledBy(Type = typeof(AkSpatialAudioBase), Member = "SetGameObjectInRoom")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(PriorityList), Member = "BinarySearch")]
		[Calls(Type = typeof(List<>), Member = "Insert")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public void Add(AkRoom room)
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(List<>), Member = "Remove")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public void Remove(AkRoom room)
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(PriorityList), Member = "BinarySearch")]
		public bool Contains(AkRoom room)
		{
			return false;
		}

		[CalledBy(Type = typeof(PriorityList), Member = "Add")]
		[CalledBy(Type = typeof(PriorityList), Member = "Contains")]
		[CalledBy(Type = typeof(AkRoomPortal), Member = "FillRoomList")]
		[CalledBy(Type = typeof(AkRoomPortal), Member = "UpdateOverlappingRooms")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Object), Member = "op_Implicit")]
		[Calls(Type = typeof(List<>), Member = "BinarySearch")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public int BinarySearch(AkRoom room)
		{
			return 0;
		}

		[CalledBy(Type = typeof(AkRoomPortal), Member = "UpdateOverlappingRooms")]
		[CalledBy(Type = typeof(AkSpatialAudioBase), Member = ".ctor")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(List<>), Member = ".ctor")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
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
		[CalledBy(Type = typeof(AkEmitterObstructionOcclusion), Member = "UpdateCurrentListenerList")]
		[CalledBy(Type = typeof(AkEmitterObstructionOcclusion), Member = "SetObstructionOcclusion")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(AkSpatialAudioListener), Member = "get_TheSpatialAudioListener")]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	[CalledBy(Type = typeof(AkRoom), Member = "OnEnable")]
	[CalledBy(Type = typeof(AkRoom), Member = "OnDisable")]
	[CalledBy(Type = typeof(PriorityList), Member = "GetHighestPriorityRoomID")]
	[CalledBy(Type = typeof(AkRoomPortal), Member = "Awake")]
	[CalledBy(Type = typeof(AkRoomPortal), Member = "SetFrontRoom")]
	[CalledBy(Type = typeof(AkRoomPortal), Member = "SetBackRoom")]
	[CalledBy(Type = typeof(AkRoomPortal), Member = "UpdateOverlappingRooms")]
	[CalledBy(Type = typeof(AkSpatialAudioBase), Member = "SetGameObjectInHighestPriorityRoom")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public ulong GetID()
	{
		return 0uL;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkRoomParams), Member = "get_Up")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(AkVector), Member = "set_X")]
	[Calls(Type = typeof(AkVector), Member = "set_Y")]
	[Calls(Type = typeof(AkVector), Member = "set_Z")]
	[Calls(Type = typeof(AkRoomParams), Member = "get_Front")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(AkRoom), Member = "GetID")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetRoom")]
	[CallsDeduplicatedMethods(Count = 22)]
	[CallsUnknownMethods(Count = 34)]
	private void OnEnable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkTriggerHandler), Member = "Start")]
	protected override void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AK.Wwise.Event), Member = "Post")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override void HandleEvent(GameObject in_gameObject)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkRoom), Member = "GetID")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PriorityList), Member = "Add")]
	[Calls(Type = typeof(AkSpatialAudioBase), Member = "SetGameObjectInHighestPriorityRoom")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	private void OnTriggerEnter(Collider in_other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSpatialAudioBase), Member = "ExitedRoom")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	private void OnTriggerExit(Collider in_other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkTriggerHandler), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	public AkRoom()
	{
	}
}
