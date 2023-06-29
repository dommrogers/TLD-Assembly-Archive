using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_PlayerHPThreshold : ActionTask<GraphOwner>
{
	public float hpThreshold;

	public string aboveThresholdEvent;

	public string belowThresholdEvent;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GraphOwner), Member = "SendEvent")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	public Action_PlayerHPThreshold()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
