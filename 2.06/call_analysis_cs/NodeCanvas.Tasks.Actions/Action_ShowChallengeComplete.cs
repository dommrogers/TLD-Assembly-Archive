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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(InterfaceManager), Member = "LoadPanel")]
	[Calls(Type = typeof(Panel_ChallengeComplete), Member = "ShowPanel")]
	[Calls(Type = typeof(Panel_ChallengeComplete), Member = "SetStatInfoText")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_ShowChallengeComplete()
	{
	}
}
