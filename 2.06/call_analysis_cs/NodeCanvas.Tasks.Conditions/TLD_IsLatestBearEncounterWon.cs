using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Conditions;

public class TLD_IsLatestBearEncounterWon : ConditionTask
{
	public BBParameter<string> missionObjectIdentifier;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
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

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public TLD_IsLatestBearEncounterWon()
	{
	}
}
