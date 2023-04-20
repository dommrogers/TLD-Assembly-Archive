using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using TLD.Missions;

namespace NodeCanvas.Tasks.Actions;

public class Action_MissionMarkComplete : ActionTask
{
	public BBParameter<string> missionID;

	public BBParameter<bool> completedSuccessfully;

	public BBParameter<bool> suppressUIPopup;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(Utils), Member = "MissionIDExists")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(ActiveMissionManager), Member = "MarkMissionComplete")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter<>), Member = "set_value")]
	[CallsUnknownMethods(Count = 3)]
	public Action_MissionMarkComplete()
	{
	}
}
