using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_FilterObjectsByTag : ActionTask
{
	public string tags;

	public bool scopeToState;

	protected override string info
	{
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(MissionServicesManager), Member = "AddMissionObjectFilterTags")]
	[CallerCount(Count = 0)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionServicesManager), Member = "RemoveMissionObjectFilterTags")]
	[CallsUnknownMethods(Count = 2)]
	protected override void OnStop()
	{
	}

	[CallerCount(Count = 0)]
	public Action_FilterObjectsByTag()
	{
	}
}
