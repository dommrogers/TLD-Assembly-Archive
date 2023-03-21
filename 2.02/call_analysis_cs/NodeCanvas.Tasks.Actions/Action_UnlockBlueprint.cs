using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_UnlockBlueprint : ActionTask
{
	public string blueprintName;

	public bool showNotification;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "FindBlueprintsForGear")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(BlueprintItem), Member = "UnlockSilent")]
	[Calls(Type = typeof(BlueprintItem), Member = "UnlockWithNotification")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	public Action_UnlockBlueprint()
	{
	}
}
