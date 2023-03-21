using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public abstract class AkSpatialAudioBase : MonoBehaviour
{
	private readonly AkRoom.PriorityList roomPriorityList;

	[CalledBy(Type = typeof(AkRoom), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(AkSpatialAudioBase), Member = "EnteredRoom")]
	[CalledBy(Type = typeof(AkSpatialAudioBase), Member = "ExitedRoom")]
	[CalledBy(Type = typeof(AkSpatialAudioBase), Member = "SetGameObjectInRoom")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AkRoom.PriorityList), Member = "GetHighestPriorityRoom")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(AkRoom), Member = "GetID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	protected void SetGameObjectInHighestPriorityRoom()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkRoom.PriorityList), Member = "Add")]
	[Calls(Type = typeof(AkSpatialAudioBase), Member = "SetGameObjectInHighestPriorityRoom")]
	[CallsUnknownMethods(Count = 1)]
	public void EnteredRoom(AkRoom room)
	{
	}

	[CalledBy(Type = typeof(AkRoom), Member = "OnTriggerExit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(AkSpatialAudioBase), Member = "SetGameObjectInHighestPriorityRoom")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void ExitedRoom(AkRoom room)
	{
	}

	[CalledBy(Type = typeof(AkSpatialAudioEmitter), Member = "OnEnable")]
	[CalledBy(Type = typeof(AkSpatialAudioListener.SpatialAudioListenerList), Member = "Refresh")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Physics), Member = "OverlapSphere")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(AkRoom.PriorityList), Member = "Add")]
	[Calls(Type = typeof(AkSpatialAudioBase), Member = "SetGameObjectInHighestPriorityRoom")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 10)]
	public void SetGameObjectInRoom()
	{
	}

	[CalledBy(Type = typeof(AkSpatialAudioEmitter), Member = ".ctor")]
	[CalledBy(Type = typeof(AkSpatialAudioListener), Member = ".ctor")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AkRoom.PriorityList), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	protected AkSpatialAudioBase()
	{
	}
}
