using Cpp2ILInjected.CallAnalysis;

public class WwiseSwitchGroupReference : WwiseObjectReference
{
	private static readonly WwiseObjectType MyWwiseObjectType;

	public override WwiseObjectType WwiseObjectType
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return default(WwiseObjectType);
		}
	}

	[Calls(Type = typeof(WwiseObjectReference), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public WwiseSwitchGroupReference()
	{
	}
}
