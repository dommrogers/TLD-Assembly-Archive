using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Conditions;

public class TLD_IsLatestBearEncounterWon : ConditionTask
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

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public TLD_IsLatestBearEncounterWon()
	{
	}
}
