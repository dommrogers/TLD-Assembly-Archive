using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_MissionAddNew : ActionTask
{
	public BBParameter<string> missionID;

	public BBParameter<bool> suppressUIPopup;

	public BBParameter<bool> suppressUIMission;

	public BBParameter<bool> suppressUIChapter;

	protected override string info
	{
		[CallsUnknownMethods(Count = 2)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task), Member = "get_name")]
		[Calls(Type = typeof(Utils), Member = "MissionIDExists")]
		[Calls(Type = typeof(string), Member = "Concat")]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "AddMission")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	public Action_MissionAddNew()
	{
	}
}
