using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using TLD.Gear;

namespace NodeCanvas.Tasks.Actions;

public class Action_OverrideStartGear : ActionTask
{
	public bool DestroyCurrentGear;

	public StartGear Gear;

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Inventory), Member = "DestroyAllGear")]
	[Calls(Type = typeof(StartGear), Member = "AddAllToInventory")]
	[CallerCount(Count = 0)]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_OverrideStartGear()
	{
	}
}
