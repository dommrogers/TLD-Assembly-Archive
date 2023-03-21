using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_MissionUpdateDesc : ActionTask
{
	public BBParameter<string> missionID;

	public BBParameter<string> descID;

	public BBParameter<bool> suppressUIPopup;

	protected override string info
	{
		[Calls(Type = typeof(Utils), Member = "MissionIDExists")]
		[Calls(Type = typeof(Task), Member = "get_name")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "UpdateMissionDesc")]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(BBParameter), Member = "get_isNone")]
	[Calls(Type = typeof(BBParameter), Member = "PromoteToVariable")]
	[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
	[CallsUnknownMethods(Count = 24)]
	public Action_MissionUpdateDesc()
	{
	}
}
