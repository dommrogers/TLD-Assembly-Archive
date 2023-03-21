using Cpp2ILInjected.CallAnalysis;

public class WwiseStateReference : WwiseGroupValueObjectReference
{
	private static readonly WwiseObjectType MyWwiseObjectType;

	private static readonly WwiseObjectType MyGroupWwiseObjectType;

	private WwiseStateGroupReference WwiseStateGroupReference;

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

	public override WwiseObjectType GroupWwiseObjectType
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return default(WwiseObjectType);
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WwiseObjectReference), Member = ".ctor")]
	public WwiseStateReference()
	{
	}
}
