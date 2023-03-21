using Cpp2ILInjected.CallAnalysis;

public class WwiseSwitchReference : WwiseGroupValueObjectReference
{
	private static readonly WwiseObjectType MyWwiseObjectType;

	private static readonly WwiseObjectType MyGroupWwiseObjectType;

	private WwiseSwitchGroupReference WwiseSwitchGroupReference;

	public override WwiseObjectType WwiseObjectType
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return default(WwiseObjectType);
		}
	}

	public override WwiseObjectReference GroupObjectReference
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

	public override WwiseObjectType GroupWwiseObjectType
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return default(WwiseObjectType);
		}
	}

	[Calls(Type = typeof(WwiseObjectReference), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public WwiseSwitchReference()
	{
	}
}
