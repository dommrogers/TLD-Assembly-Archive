using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public abstract class AkSpatialAudioBase : MonoBehaviour
{
	private readonly AkRoom.PriorityList roomPriorityList;

	[CalledBy(Type = typeof(AkRoom), Member = "OnTriggerEnter")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(AkSpatialAudioBase), Member = "SetGameObjectInRoom")]
	[CalledBy(Type = typeof(AkSpatialAudioBase), Member = "ExitedRoom")]
	[CalledBy(Type = typeof(AkSpatialAudioBase), Member = "EnteredRoom")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(AkRoom), Member = "GetID")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(AkRoom.PriorityList), Member = "GetHighestPriorityRoom")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	protected void SetGameObjectInHighestPriorityRoom()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AkSpatialAudioBase), Member = "SetGameObjectInHighestPriorityRoom")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkRoom.PriorityList), Member = "Add")]
	public void EnteredRoom(AkRoom room)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AkSpatialAudioBase), Member = "SetGameObjectInHighestPriorityRoom")]
	[CalledBy(Type = typeof(AkRoom), Member = "OnTriggerExit")]
	[CallsUnknownMethods(Count = 2)]
	public void ExitedRoom(AkRoom room)
	{
	}

	[Calls(Type = typeof(AkRoom.PriorityList), Member = "Add")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(AkSpatialAudioListener.SpatialAudioListenerList), Member = "Refresh")]
	[CalledBy(Type = typeof(AkSpatialAudioEmitter), Member = "OnEnable")]
	[Calls(Type = typeof(AkSpatialAudioBase), Member = "SetGameObjectInHighestPriorityRoom")]
	[Calls(Type = typeof(Physics), Member = "OverlapSphere")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	public void SetGameObjectInRoom()
	{
	}

	[CalledBy(Type = typeof(AkSpatialAudioEmitter), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CalledBy(Type = typeof(AkSpatialAudioListener), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AkRoom.PriorityList), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	protected AkSpatialAudioBase()
	{
	}
}
