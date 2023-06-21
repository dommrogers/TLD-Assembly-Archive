using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using TLD.Gear;

namespace NodeCanvas.Tasks.Actions;

public class Action_UnlockBlueprint : ActionTask
{
	public string blueprintName;

	public bool showNotification;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BlueprintManager), Member = "FindBlueprintsForGear")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(BlueprintManager), Member = "UnlockSilent")]
	[Calls(Type = typeof(BlueprintManager), Member = "UnlockWithNotification")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 6)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	public Action_UnlockBlueprint()
	{
	}
}
