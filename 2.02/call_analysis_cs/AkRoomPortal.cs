using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AkRoomPortal : AkTriggerHandler
{
	public const int MAX_ROOMS_PER_PORTAL = 2;

	private AkVector extent;

	private AkTransform portalTransform;

	private ulong backRoomID;

	public List<int> closePortalTriggerList;

	private ulong frontRoomID;

	public AkRoom[] rooms;

	public bool IsValid
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	public ulong GetID()
	{
		return default(ulong);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 76)]
	[Calls(Type = typeof(AkRoomPortal), Member = "ActivatePortal")]
	[Calls(Type = typeof(AkTriggerHandler), Member = "Awake")]
	[Calls(Type = typeof(AkTriggerHandler), Member = "RegisterTriggers")]
	[Calls(Type = typeof(AkRoom), Member = "GetID")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(AkRoom), Member = "GetID")]
	[Calls(Type = typeof(AkVector), Member = "set_Z")]
	[Calls(Type = typeof(AkVector), Member = "set_Y")]
	[Calls(Type = typeof(AkVector), Member = "set_X")]
	[CallsDeduplicatedMethods(Count = 29)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	protected override void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(AkTriggerHandler), Member = "Start")]
	[Calls(Type = typeof(AkRoomPortal), Member = "ActivatePortal")]
	[CallsUnknownMethods(Count = 5)]
	protected override void Start()
	{
	}

	[Calls(Type = typeof(AkRoomPortal), Member = "ActivatePortal")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public override void HandleEvent(GameObject in_gameObject)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkRoomPortal), Member = "ActivatePortal")]
	[DeduplicatedMethod]
	public void ClosePortal(GameObject in_gameObject)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(AkTriggerHandler), Member = "DoDestroy")]
	[Calls(Type = typeof(AkTriggerHandler), Member = "UnregisterTriggers")]
	[Calls(Type = typeof(AkRoomPortal), Member = "ActivatePortal")]
	[CallsUnknownMethods(Count = 12)]
	protected override void OnDestroy()
	{
	}

	[Calls(Type = typeof(AkRoomPortal), Member = "ActivatePortal")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void Open()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkRoomPortal), Member = "ActivatePortal")]
	public void Close()
	{
	}

	[CalledBy(Type = typeof(AkRoomPortal), Member = "HandleEvent")]
	[CalledBy(Type = typeof(AkRoomPortal), Member = "ClosePortal")]
	[CalledBy(Type = typeof(AkRoomPortal), Member = "Start")]
	[CalledBy(Type = typeof(AkRoomPortal), Member = "Open")]
	[CalledBy(Type = typeof(AkRoomPortal), Member = "Close")]
	[CalledBy(Type = typeof(AkRoomPortal), Member = "OnDestroy")]
	[CalledBy(Type = typeof(AkRoomPortal), Member = "Awake")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(AkTransform), Member = "getCPtr")]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(AkVector), Member = "getCPtr")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	[Calls(Type = typeof(string), Member = "Concat")]
	private void ActivatePortal(bool active)
	{
	}

	[CalledBy(Type = typeof(AkRoomPortal), Member = "UpdateOverlappingRooms")]
	[Calls(Type = typeof(AkRoomPortal), Member = "FillRoomList")]
	[Calls(Type = typeof(AkRoomPortal), Member = "FillRoomList")]
	[CallsUnknownMethods(Count = 20)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "get_forward")]
	public void FindOverlappingRooms(AkRoom.PriorityList[] roomList)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(AkRoom.PriorityList), Member = "BinarySearch")]
	[Calls(Type = typeof(AkRoom.PriorityList), Member = "Add")]
	[CalledBy(Type = typeof(AkRoomPortal), Member = "FindOverlappingRooms")]
	[CalledBy(Type = typeof(AkRoomPortal), Member = "FindOverlappingRooms")]
	[CallsUnknownMethods(Count = 16)]
	private void FillRoomList(Vector3 center, Vector3 halfExtents, AkRoom.PriorityList list)
	{
	}

	[Calls(Type = typeof(AkRoom), Member = "GetID")]
	[CallsUnknownMethods(Count = 12)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public void SetFrontRoom(AkRoom room)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(AkRoom), Member = "GetID")]
	[CallsUnknownMethods(Count = 12)]
	public void SetBackRoom(AkRoom room)
	{
	}

	[CallsUnknownMethods(Count = 49)]
	[Calls(Type = typeof(AkRoom), Member = "GetID")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(AkRoom), Member = "GetID")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(AkRoom.PriorityList), Member = "GetHighestPriorityRoom")]
	[Calls(Type = typeof(AkRoomPortal), Member = "FindOverlappingRooms")]
	[Calls(Type = typeof(AkRoom.PriorityList), Member = ".ctor")]
	[Calls(Type = typeof(AkRoom.PriorityList), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkRoom.PriorityList), Member = "BinarySearch")]
	public void UpdateOverlappingRooms()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkTriggerHandler), Member = ".ctor")]
	[CallsUnknownMethods(Count = 12)]
	public AkRoomPortal()
	{
	}
}
