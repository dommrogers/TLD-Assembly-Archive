using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Conditions;

public class TLD_IsBearEncounterActivated : ConditionTask
{
	public BBParameter<string> missionObjectIdentifier;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	protected override void OnEnable()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(BearHuntRedux), Member = "GetBearEncounterInfo")]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public TLD_IsBearEncounterActivated()
	{
	}
}
