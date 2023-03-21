using Cpp2ILInjected.CallAnalysis;

public static class GameModeFilterExtensions
{
	[CalledBy(Type = typeof(Lock), Member = "Awake")]
	[CalledBy(Type = typeof(Container), Member = "PopulateWithScriptedGear")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	public static bool PassesGameModeFilter(this GameModeFilter mode)
	{
		return false;
	}
}
