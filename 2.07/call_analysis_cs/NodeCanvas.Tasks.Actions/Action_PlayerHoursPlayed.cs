using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_PlayerHoursPlayed : ActionTask<GraphOwner>
{
	public float timeThreshold;

	public string aboveThresholdEvent;

	public string belowThresholdEvent;

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(GraphOwner), Member = "SendEvent")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	public Action_PlayerHoursPlayed()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
