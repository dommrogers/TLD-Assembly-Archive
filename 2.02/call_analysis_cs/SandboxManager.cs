using Cpp2ILInjected.CallAnalysis;

public class SandboxManager : MissionServicesManager
{
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionServicesManager), Member = "Awake")]
	private new void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionServicesManager), Member = "Update")]
	private new void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionServicesManager), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public SandboxManager()
	{
	}
}
