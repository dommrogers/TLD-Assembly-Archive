using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_UnlockAllMaps : ActionTask
{
	[Calls(Type = typeof(Panel_Map), Member = "RevealFogForScene")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Panel_Map), Member = "UnlockRegionMap")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_UnlockAllMaps()
	{
	}
}
