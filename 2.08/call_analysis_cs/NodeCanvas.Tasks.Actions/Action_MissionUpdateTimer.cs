using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_MissionUpdateTimer : ActionTask
{
	public BBParameter<string> missionID;

	public BBParameter<string> timerID;

	public BBParameter<bool> suppressUIPopup;

	protected override string info
	{
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(Task), Member = "get_name")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Utils), Member = "MissionIDExists")]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "UpdateMissionTimer")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	protected override void OnExecute()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	public Action_MissionUpdateTimer()
	{
	}
}
