using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_ToggleRestAbility : ActionTask
{
	public bool shouldLock;

	public string locIDToShow;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public Action_ToggleRestAbility()
	{
	}
}
