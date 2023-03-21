using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_MissionUpdateName : ActionTask
{
	public BBParameter<string> missionID;

	public BBParameter<string> nameLocID;

	public BBParameter<bool> suppressUIPopup;

	protected override string info
	{
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(Utils), Member = "MissionIDExists")]
		[CallsUnknownMethods(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task), Member = "get_name")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "UpdateMissionName")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 5)]
	protected override void OnExecute()
	{
	}

	[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(BBParameter), Member = "get_isNone")]
	[Calls(Type = typeof(BBParameter), Member = "PromoteToVariable")]
	[CallsUnknownMethods(Count = 24)]
	public Action_MissionUpdateName()
	{
	}
}
