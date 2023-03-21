using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using ParadoxNotion;

namespace NodeCanvas.Tasks.Conditions;

public class Condition_ExitMissionTrigger : ConditionTask
{
	public bool checkForPlayer;

	public BBParameter<string> checkForMissionObjectId;

	public BBParameter<string> checkForTriggerId;

	public MissionTriggerType triggerType;

	public string clearAssociatedDataVar;

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[Calls(Type = typeof(ConditionTask), Member = "YieldReturn")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public void OnCustomEvent(EventData receivedEvent)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public Condition_ExitMissionTrigger()
	{
	}
}
