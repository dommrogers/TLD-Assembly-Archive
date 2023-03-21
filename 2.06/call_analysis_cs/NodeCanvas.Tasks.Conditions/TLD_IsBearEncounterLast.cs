using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Conditions;

public class TLD_IsBearEncounterLast : ConditionTask
{
	public BBParameter<string> missionObjectIdentifier;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected override void OnEnable()
	{
	}

	[Calls(Type = typeof(BearHuntRedux), Member = "GetBearEncounterInfo")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
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
