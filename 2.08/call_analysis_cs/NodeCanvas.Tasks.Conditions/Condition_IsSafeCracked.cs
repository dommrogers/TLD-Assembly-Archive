using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Conditions;

public class Condition_IsSafeCracked : ConditionTask
{
	public BBParameter<string> safeId;

	protected override string info
	{
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsUnknownMethods(Count = 2)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[CallsUnknownMethods(Count = 2)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Condition_IsSafeCracked()
	{
	}
}
