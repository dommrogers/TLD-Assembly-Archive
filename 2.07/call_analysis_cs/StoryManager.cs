using Cpp2ILInjected.CallAnalysis;

public class StoryManager : MissionServicesManager
{
	[Calls(Type = typeof(MissionServicesManager), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public StoryManager()
	{
	}
}
