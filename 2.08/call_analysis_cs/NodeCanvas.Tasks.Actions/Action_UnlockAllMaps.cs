using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_UnlockAllMaps : ActionTask
{
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Panel_Map), Member = "RevealFogForScene")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Map), Member = "UnlockRegionMap")]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_UnlockAllMaps()
	{
	}
}
