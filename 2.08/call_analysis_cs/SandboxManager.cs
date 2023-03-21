using Cpp2ILInjected.CallAnalysis;

public class SandboxManager : MissionServicesManager
{
	[Calls(Type = typeof(MissionServicesManager), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public SandboxManager()
	{
	}
}
