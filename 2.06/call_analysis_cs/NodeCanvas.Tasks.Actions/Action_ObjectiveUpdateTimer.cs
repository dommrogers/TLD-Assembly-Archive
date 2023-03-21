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
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "UpdateObjectiveTimer")]
	protected override void OnExecute()
	{
	}

	[CallsUnknownMethods(Count = 18)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BBParameter), Member = "get_isNone")]
	[Calls(Type = typeof(BBParameter), Member = "PromoteToVariable")]
	[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
	public Action_ObjectiveUpdateTimer()
	{
	}
}
