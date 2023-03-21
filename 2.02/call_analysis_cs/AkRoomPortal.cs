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
			return false;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	public ulong GetID()
	{
		return 0uL;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(AkVector), Member = "set_X")]
	[Calls(Type = typeof(AkVector), Member = "set_Y")]
	[Calls(Type = typeof(AkVector), Member = "set_Z")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(AkRoom), Member = "GetID")]
	[Calls(Type = typeof(AkTriggerHandler), Member = "RegisterTriggers")]
	[Calls(Type = typeof(AkTriggerHandler), Member = "Awake")]
	[Calls(Type = typeof(AkRoomPortal), Member = "ActivatePortal")]
	[CallsDeduplicatedMethods(Count = 28)]
	[CallsUnknownMethods(Count = 76)]
	protected override void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkTriggerHandler), Member = "Start")]
	[Calls(Type = typeof(AkRoomPortal), Member = "ActivatePortal")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	protected override void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkRoomPortal), Member = "ActivatePortal")]
	public override void HandleEvent(GameObject in_gameObject)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkRoomPortal), Member = "ActivatePortal")]
	public void ClosePortal(GameObject in_gameObject)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkTriggerHandler), Member = "DoDestroy")]
	[Calls(Type = typeof(AkTriggerHandler), Member = "UnregisterTriggers")]
	[Calls(Type = typeof(AkRoomPortal), Member = "ActivatePortal")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 12)]
	protected override void OnDestroy()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkRoomPortal), Member = "ActivatePortal")]
	public void Open()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkRoomPortal), Member = "ActivatePortal")]
	public void Close()
	{
	}

	[CalledBy(Type = typeof(AkRoomPortal), Member = "Awake")]
	[CalledBy(Type = typeof(AkRoomPortal), Member = "Start")]
	[CalledBy(Type = typeof(AkRoomPortal), Member = "HandleEvent")]
	[CalledBy(Type = typeof(AkRoomPortal), Member = "ClosePortal")]
	[CalledBy(Type = typeof(AkRoomPortal), Member = "OnDestroy")]
	[CalledBy(Type = typeof(AkRoomPortal), Member = "Open")]
	[CalledBy(Type = typeof(AkRoomPortal), Member = "Close")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	[Calls(Type = typeof(AkTransform), Member = "getCPtr")]
	[Calls(Type = typeof(AkVector), Member = "getCPtr")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private void ActivatePortal(bool active)
	{
	}

	[CalledBy(Type = typeof(AkRoomPortal), Member = "UpdateOverlappingRooms")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Vector3), Member = "get_forward")]
	[Calls(Type = typeof(AkRoomPortal), Member = "FillRoomList")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 20)]
	public void FindOverlappingRooms(AkRoom.PriorityList[] roomList)
	{
	}

	[CalledBy(Type = typeof(AkRoomPortal), Member = "FindOverlappingRooms")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(AkRoom.PriorityList), Member = "BinarySearch")]
	[Calls(Type = typeof(AkRoom.PriorityList), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 16)]
	private void FillRoomList(Vector3 center, Vector3 halfExtents, AkRoom.PriorityList list)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(AkRoom), Member = "GetID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	public void SetFrontRoom(AkRoom room)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(AkRoom), Member = "GetID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	public void SetBackRoom(AkRoom room)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkRoom.PriorityList), Member = ".ctor")]
	[Calls(Type = typeof(AkRoomPortal), Member = "FindOverlappingRooms")]
	[Calls(Type = typeof(AkRoom.PriorityList), Member = "BinarySearch")]
	[Calls(Type = typeof(AkRoom.PriorityList), Member = "GetHighestPriorityRoom")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(AkRoom), Member = "GetID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 49)]
	public void UpdateOverlappingRooms()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkTriggerHandler), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	public AkRoomPortal()
	{
	}
}
