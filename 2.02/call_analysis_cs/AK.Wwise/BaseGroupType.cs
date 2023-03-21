using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace AK.Wwise;

[Serializable]
public abstract class BaseGroupType : BaseType
{
	private int groupIdInternal;

	private byte[] groupGuidInternal;

	public WwiseObjectReference GroupWwiseObjectReference
	{
		[CalledBy(Type = typeof(AkState), Member = "get_groupGuid")]
		[CalledBy(Type = typeof(AkSwitch), Member = "get_groupGuid")]
		[CalledBy(Type = typeof(BaseGroupType), Member = "get_GroupId")]
		[CalledBy(Type = typeof(BaseGroupType), Member = "IsValid")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public abstract WwiseObjectType WwiseObjectGroupType { get; }

	public uint GroupId
	{
		[CalledBy(Type = typeof(AkState), Member = "HandleEvent")]
		[CalledBy(Type = typeof(AkState), Member = "get_groupID")]
		[CalledBy(Type = typeof(AkSwitch), Member = "HandleEvent")]
		[CalledBy(Type = typeof(AkSwitch), Member = "get_groupID")]
		[CalledBy(Type = typeof(BaseGroupType), Member = "get_groupID")]
		[CalledBy(Type = typeof(State), Member = "SetValue")]
		[CalledBy(Type = typeof(Switch), Member = "SetValue")]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(BaseGroupType), Member = "get_GroupWwiseObjectReference")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0u;
		}
	}

	public int groupID
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BaseGroupType), Member = "get_GroupId")]
		get
		{
			return 0;
		}
	}

	public byte[] groupGuid
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(WwiseObjectReference), Member = "get_Guid")]
		[Calls(Type = typeof(Guid), Member = "ToByteArray")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(BaseGroupType), Member = "get_GroupWwiseObjectReference")]
	[CallsDeduplicatedMethods(Count = 3)]
	public override bool IsValid()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	protected BaseGroupType()
	{
	}
}
