using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_PlayerHoursPlayed : ActionTask<GraphOwner>
{
	public float timeThreshold;

	public string aboveThresholdEvent;

	public string belowThresholdEvent;

	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GraphOwner), Member = "SendEvent")]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public Action_PlayerHoursPlayed()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
