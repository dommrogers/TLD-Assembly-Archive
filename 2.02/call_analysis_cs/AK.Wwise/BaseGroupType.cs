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
		[CalledBy(Type = typeof(BaseGroupType), Member = "get_GroupId")]
		[CalledBy(Type = typeof(BaseGroupType), Member = "IsValid")]
		[CalledBy(Type = typeof(BaseGroupType), Member = "get_GroupId")]
		[CalledBy(Type = typeof(AkSwitch), Member = "get_groupGuid")]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallerCount(Count = 5)]
		[CalledBy(Type = typeof(AkState), Member = "get_groupGuid")]
		get
		{
			return null;
		}
	}

	public abstract WwiseObjectType WwiseObjectGroupType
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		get;
	}

	public uint GroupId
	{
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(Switch), Member = "SetValue")]
		[CalledBy(Type = typeof(BaseGroupType), Member = "get_groupID")]
		[CalledBy(Type = typeof(AkSwitch), Member = "get_groupID")]
		[CalledBy(Type = typeof(AkSwitch), Member = "HandleEvent")]
		[CalledBy(Type = typeof(AkState), Member = "get_groupID")]
		[CalledBy(Type = typeof(State), Member = "SetValue")]
		[Calls(Type = typeof(BaseGroupType), Member = "get_GroupWwiseObjectReference")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(BaseGroupType), Member = "get_GroupWwiseObjectReference")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 7)]
		[CalledBy(Type = typeof(AkState), Member = "HandleEvent")]
		get
		{
			return default(uint);
		}
	}

	public int groupID
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BaseGroupType), Member = "get_GroupId")]
		get
		{
			return default(int);
		}
	}

	public byte[] groupGuid
	{
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(WwiseObjectReference), Member = "get_Guid")]
		[Calls(Type = typeof(Guid), Member = "ToByteArray")]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(BaseGroupType), Member = "get_GroupWwiseObjectReference")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public override bool IsValid()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	protected BaseGroupType()
	{
	}
}
