using Cpp2ILInjected.CallAnalysis;

public class AkMacSettings : AkWwiseInitializationSettings.CommonPlatformSettings
{
	[Calls(Type = typeof(AkWwiseInitializationSettings.PlatformSettings), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public AkMacSettings()
	{
	}
}
