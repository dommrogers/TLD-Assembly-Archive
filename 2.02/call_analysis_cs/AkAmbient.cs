using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AK.Wwise;
using Audio.SimpleAudio;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AkAmbient : AkEvent
{
	public static Dictionary<uint, AkMultiPosEvent> multiPosEventTree;

	public List<Vector3> multiPositionArray;

	public AkMultiPositionType MultiPositionType;

	public MultiPositionTypeLabel multiPositionTypeLabel;

	private AkAmbient _003CParentAkAmbience_003Ek__BackingField;

	public AkAmbient ParentAkAmbience
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(AmbientTracker), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(AkMultiPosEvent), Member = ".ctor")]
	[Calls(Type = typeof(AkAmbient), Member = "BuildMultiDirectionArray")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetMultiplePositions")]
	[Calls(Type = typeof(AkAmbient), Member = "BuildAkPositionArray")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 52)]
	public void OnEnable()
	{
	}

	[CalledBy(Type = typeof(AmbientTracker), Member = "Cleanup")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(AkAmbient), Member = "BuildMultiDirectionArray")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetMultiplePositions")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 14)]
	public void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(AK.Wwise.Event), Member = "Post")]
	[Calls(Type = typeof(AK.Wwise.Event), Member = "ExecuteAction")]
	[Calls(Type = typeof(AkEvent), Member = "HandleEvent")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 19)]
	public override void HandleEvent(GameObject in_gameObject)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	public void OnDrawGizmosSelected()
	{
	}

	[CalledBy(Type = typeof(AkAmbient), Member = "OnEnable")]
	[CalledBy(Type = typeof(AkAmbient), Member = "OnDisable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AkPositionArray), Member = ".ctor")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(AkPositionArray), Member = "Add")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 14)]
	public AkPositionArray BuildMultiDirectionArray(AkMultiPosEvent eventPosList)
	{
		return null;
	}

	[CalledBy(Type = typeof(AkAmbient), Member = "OnEnable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AkPositionArray), Member = ".ctor")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(AkPositionArray), Member = "Add")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 16)]
	private AkPositionArray BuildAkPositionArray()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkEvent), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	public AkAmbient()
	{
	}
}
