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
		[CallerCount(Count = 15)]
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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetState")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(BaseGroupType), Member = "get_GroupId")]
	public void SetValue()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public State()
	{
	}
}
