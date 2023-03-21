using Cpp2ILInjected.CallAnalysis;

public class WwiseRtpcReference : WwiseObjectReference
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WwiseObjectReference), Member = ".ctor")]
	public WwiseRtpcReference()
	{
	}
}
