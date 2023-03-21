using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Conditions;

public class TLD_IsBearEncounterLast : ConditionTask
{
	public BBParameter<string> missionObjectIdentifier;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	protected override void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(BearHuntRedux), Member = "GetBearEncounterInfo")]
	[CallsUnknownMethods(Count = 1)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public TLD_IsBearEncounterLast()
	{
	}
}
