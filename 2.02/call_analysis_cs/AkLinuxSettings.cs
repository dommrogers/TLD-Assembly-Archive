using Cpp2ILInjected.CallAnalysis;

public class AkLinuxSettings : AkWwiseInitializationSettings.CommonPlatformSettings
{
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkWwiseInitializationSettings.PlatformSettings), Member = ".ctor")]
	public AkLinuxSettings()
	{
	}
}
