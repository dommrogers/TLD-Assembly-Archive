using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_FoundAllHiddenCaches : ActionTask
{
	public Episode episode;

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateCacheAchievementInProfile")]
	[CallerCount(Count = 0)]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_FoundAllHiddenCaches()
	{
	}
}
