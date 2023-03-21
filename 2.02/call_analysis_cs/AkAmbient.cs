using System;
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
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 21)]
	[Calls(Type = typeof(AkMultiPosEvent), Member = ".ctor")]
	[Calls(Type = typeof(AkAmbient), Member = "BuildMultiDirectionArray")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetMultiplePositions")]
	[Calls(Type = typeof(AkAmbient), Member = "BuildAkPositionArray")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(AmbientTracker), Member = "Start")]
	[CallsUnknownMethods(Count = 52)]
	public void OnEnable()
	{
	}

	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(AmbientTracker), Member = "Cleanup")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AkAmbient), Member = "BuildMultiDirectionArray")]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetMultiplePositions")]
	public void OnDisable()
	{
	}

	[CallsUnknownMethods(Count = 19)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(AK.Wwise.Event), Member = "Post")]
	[Calls(Type = typeof(AK.Wwise.Event), Member = "ExecuteAction")]
	[Calls(Type = typeof(AkEvent), Member = "HandleEvent")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public override void HandleEvent(GameObject in_gameObject)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	public void OnDrawGizmosSelected()
	{
	}

	[CalledBy(Type = typeof(AkAmbient), Member = "OnDisable")]
	[CalledBy(Type = typeof(AkAmbient), Member = "OnEnable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(AkPositionArray), Member = "Add")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AkPositionArray), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	public AkPositionArray BuildMultiDirectionArray(AkMultiPosEvent eventPosList)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(AkAmbient), Member = "OnEnable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(AkPositionArray), Member = "Add")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(AkPositionArray), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	private AkPositionArray BuildAkPositionArray()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 12)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkEvent), Member = ".ctor")]
	public AkAmbient()
	{
	}
}
