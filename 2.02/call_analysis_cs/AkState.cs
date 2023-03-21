using System;
using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AkState : AkDragDropTriggerHandler
{
	public State data;

	private int valueIdInternal;

	private int groupIdInternal;

	private byte[] valueGuidInternal;

	private byte[] groupGuidInternal;

	protected override BaseType WwiseType
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 15)]
		get
		{
			return null;
		}
	}

	public int valueID
	{
		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
	}

	public int groupID
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BaseGroupType), Member = "get_GroupId")]
		get
		{
			return default(int);
		}
	}

	public byte[] valueGuid
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(WwiseObjectReference), Member = "get_Guid")]
		[Calls(Type = typeof(Guid), Member = "ToByteArray")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public byte[] groupGuid
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Guid), Member = "ToByteArray")]
		[Calls(Type = typeof(WwiseObjectReference), Member = "get_Guid")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(BaseGroupType), Member = "get_GroupWwiseObjectReference")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(BaseGroupType), Member = "get_GroupId")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetState")]
	public override void HandleEvent(GameObject in_gameObject)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkDragDropTriggerHandler), Member = ".ctor")]
	public AkState()
	{
	}
}
