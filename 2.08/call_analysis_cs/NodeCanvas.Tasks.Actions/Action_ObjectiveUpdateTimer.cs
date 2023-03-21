using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_ObjectiveUpdateTimer : ActionTask
{
	public BBParameter<string> objectiveID;

	public BBParameter<string> timerID;

	public BBParameter<bool> suppressUIPopup;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task), Member = "get_name")]
		[Calls(Type = typeof(Utils), Member = "ObjectiveIDExists")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "UpdateObjectiveTimer")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public Action_ObjectiveUpdateTimer()
	{
	}
}
