using Cpp2ILInjected.CallAnalysis;

public class SandboxManager : MissionServicesManager
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionServicesManager), Member = ".ctor")]
	public SandboxManager()
	{
	}
}
