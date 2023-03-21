using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using TLD.Gear;

namespace NodeCanvas.Tasks.Actions;

public class Action_UnlockBlueprint : ActionTask
{
	public string blueprintName;

	public bool showNotification;

	[Calls(Type = typeof(BlueprintManager), Member = "UnlockWithNotification")]
	[Calls(Type = typeof(BlueprintManager), Member = "UnlockSilent")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BlueprintManager), Member = "FindBlueprintsForGear")]
	[CallsUnknownMethods(Count = 7)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	public Action_UnlockBlueprint()
	{
	}
}
