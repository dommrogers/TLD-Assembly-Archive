using Cpp2ILInjected.CallAnalysis;

public class AkMacSettings : AkWwiseInitializationSettings.CommonPlatformSettings
{
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkWwiseInitializationSettings.PlatformSettings), Member = ".ctor")]
	public AkMacSettings()
	{
	}
}
