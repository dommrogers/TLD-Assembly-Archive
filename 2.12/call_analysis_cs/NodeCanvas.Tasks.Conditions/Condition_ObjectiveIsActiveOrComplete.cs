using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using TLD.Missions;

namespace NodeCanvas.Tasks.Conditions;

public class Condition_ObjectiveIsActiveOrComplete : ConditionTask
{
	public BBParameter<string> objectiveID;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
		[Calls(Type = typeof(string), Member = "Format")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(ActiveMissionManager), Member = "GetObjectiveIndex")]
	[CallsUnknownMethods(Count = 1)]
	protected override bool OnCheck()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Condition_ObjectiveIsActiveOrComplete()
	{
	}
}
