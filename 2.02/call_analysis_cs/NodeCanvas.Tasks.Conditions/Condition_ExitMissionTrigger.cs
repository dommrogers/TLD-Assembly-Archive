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
	[CallerCount(Count = 0)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(Task), Member = "StartCoroutine")]
	[Calls(Type = typeof(ConditionTask), Member = "Flip")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	public void OnCustomEvent(EventData receivedEvent)
	{
	}

	[CallsUnknownMethods(Count = 16)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	public Condition_ExitMissionTrigger()
	{
	}
}
