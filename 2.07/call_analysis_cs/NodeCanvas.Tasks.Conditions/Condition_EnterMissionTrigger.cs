using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using ParadoxNotion;

namespace NodeCanvas.Tasks.Conditions;

public class Condition_EnterMissionTrigger : ConditionTask
{
	public bool checkForPlayer;

	public BBParameter<string> checkForMissionObjectId;

	public BBParameter<string> checkForTriggerId;

	public MissionTriggerType triggerType;

	public string storeAssociatedDataVar;

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[Calls(Type = typeof(ConditionTask), Member = "YieldReturn")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(MissionTrigger), Member = "ParseAssociatedData")]
	[CallsUnknownMethods(Count = 7)]
	public void OnCustomEvent(EventData receivedEvent)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public Condition_EnterMissionTrigger()
	{
	}
}
