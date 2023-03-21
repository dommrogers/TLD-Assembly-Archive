using System;
using Cpp2ILInjected.CallAnalysis;

namespace AK.Wwise;

[Serializable]
public class AuxBus : BaseType
{
	public WwiseAuxBusReference WwiseObjectReference;

	public override WwiseObjectReference ObjectReference
	{
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public AuxBus()
	{
	}
}
