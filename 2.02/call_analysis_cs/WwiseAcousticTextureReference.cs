using Cpp2ILInjected.CallAnalysis;

public class WwiseAcousticTextureReference : WwiseObjectReference
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

	[Calls(Type = typeof(WwiseObjectReference), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public WwiseAcousticTextureReference()
	{
	}
}
