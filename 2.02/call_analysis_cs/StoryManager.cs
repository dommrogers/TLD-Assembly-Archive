using Cpp2ILInjected.CallAnalysis;

public class StoryManager : MissionServicesManager
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
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MissionServicesManager), Member = ".ctor")]
	public StoryManager()
	{
	}
}
