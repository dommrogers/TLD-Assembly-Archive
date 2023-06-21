using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_AchievementComplete : ActionTask
{
	public AchievementManager.ChallengeAchievement achievement;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 2)]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_AchievementComplete()
	{
	}
}
