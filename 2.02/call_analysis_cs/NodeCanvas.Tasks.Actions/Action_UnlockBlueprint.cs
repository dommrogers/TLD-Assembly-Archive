using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_UnlockBlueprint : ActionTask
{
	public string blueprintName;

	public bool showNotification;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "FindBlueprintsForGear")]
	[Calls(Type = typeof(BlueprintItem), Member = "UnlockSilent")]
	[Calls(Type = typeof(BlueprintItem), Member = "UnlockWithNotification")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 4)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	public Action_UnlockBlueprint()
	{
	}
}
