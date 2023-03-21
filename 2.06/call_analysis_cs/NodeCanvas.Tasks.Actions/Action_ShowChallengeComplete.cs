using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_ShowChallengeComplete : ActionTask
{
	public bool succeededChallenge;

	public bool showToBeContinued;

	public BBParameter<bool> showFailTimeSurvived;

	public BBParameter<bool> showFailStatInfo;

	public BBParameter<string> failStatInfoLocId;

	public BBParameter<string> stat1Marker;

	public BBParameter<int> stat1Value;

	public BBParameter<string> stat2Marker;

	public BBParameter<int> stat2Value;

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Panel_ChallengeComplete), Member = "SetStatInfoText")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_ChallengeComplete), Member = "ShowPanel")]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_ShowChallengeComplete()
	{
	}
}
