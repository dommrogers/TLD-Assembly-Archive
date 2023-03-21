using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_FoundAllHiddenCaches : ActionTask
{
	public Episode episode;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateCacheAchievementInProfile")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_FoundAllHiddenCaches()
	{
	}
}
