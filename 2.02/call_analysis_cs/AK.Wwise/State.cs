using System;
using Cpp2ILInjected.CallAnalysis;

namespace AK.Wwise;

[Serializable]
public class State : BaseGroupType
{
	public WwiseStateReference WwiseObjectReference;

	public override WwiseObjectReference ObjectReference
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 17)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public override WwiseObjectType WwiseObjectType
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(WwiseObjectType);
		}
	}

	public override WwiseObjectType WwiseObjectGroupType
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(WwiseObjectType);
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseGroupType), Member = "get_GroupId")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetState")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public void SetValue()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public State()
	{
	}
}
