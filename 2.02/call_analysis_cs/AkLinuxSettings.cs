using Cpp2ILInjected.CallAnalysis;

public class AkLinuxSettings : AkWwiseInitializationSettings.CommonPlatformSettings
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkWwiseInitializationSettings.PlatformSettings), Member = ".ctor")]
	[DeduplicatedMethod]
	public AkLinuxSettings()
	{
	}
}
