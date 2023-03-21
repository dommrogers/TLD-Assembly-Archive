using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Conditions;

public class TLD_IsBearEncounterActivated : ConditionTask
{
	public BBParameter<string> missionObjectIdentifier;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected override void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BearHuntRedux), Member = "GetBearEncounterInfo")]
	[CallsUnknownMethods(Count = 2)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public TLD_IsBearEncounterActivated()
	{
	}
}
