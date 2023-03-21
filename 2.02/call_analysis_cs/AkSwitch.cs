using System;
using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AkSwitch : AkDragDropTriggerHandler
{
	public Switch data;

	private int valueIdInternal;

	private int groupIdInternal;

	private byte[] valueGuidInternal;

	private byte[] groupGuidInternal;

	protected override BaseType WwiseType
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
	}

	public int valueID
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(int);
		}
	}

	public int groupID
	{
		[Calls(Type = typeof(BaseGroupType), Member = "get_GroupId")]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
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
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Guid), Member = "ToByteArray")]
		[Calls(Type = typeof(WwiseObjectReference), Member = "get_Guid")]
		[Calls(Type = typeof(BaseGroupType), Member = "get_GroupWwiseObjectReference")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(BaseGroupType), Member = "get_GroupId")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
	[CallsUnknownMethods(Count = 3)]
	public override void HandleEvent(GameObject in_gameObject)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkDragDropTriggerHandler), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	public AkSwitch()
	{
	}
}
