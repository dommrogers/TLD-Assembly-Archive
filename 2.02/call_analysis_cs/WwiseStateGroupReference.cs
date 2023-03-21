using Cpp2ILInjected.CallAnalysis;

public class WwiseStateGroupReference : WwiseObjectReference
{
	private static readonly WwiseObjectType MyWwiseObjectType;

	public override WwiseObjectType WwiseObjectType
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
	public WwiseStateGroupReference()
	{
	}
}
