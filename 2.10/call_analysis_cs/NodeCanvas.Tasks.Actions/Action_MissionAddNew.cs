using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using TLD.Missions;

namespace NodeCanvas.Tasks.Actions;

public class Action_MissionAddNew : ActionTask
{
	public BBParameter<string> missionID;

	public BBParameter<bool> suppressUIPopup;

	public BBParameter<bool> suppressUIMission;

	public BBParameter<bool> suppressUIChapter;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task), Member = "get_name")]
		[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
		[Calls(Type = typeof(Utils), Member = "MissionIDExists")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(ActiveMissionManager), Member = "AddMission")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter<>), Member = "set_value")]
	[CallsUnknownMethods(Count = 4)]
	public Action_MissionAddNew()
	{
	}
}
