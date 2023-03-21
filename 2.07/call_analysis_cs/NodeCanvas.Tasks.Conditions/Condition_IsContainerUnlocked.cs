using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Conditions;

public class Condition_IsContainerUnlocked : ConditionTask
{
	public BBParameter<string> containerId;

	protected override string info
	{
		[CallsUnknownMethods(Count = 2)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Concat")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[Calls(Type = typeof(Container), Member = "IsLocked")]
	[CallsUnknownMethods(Count = 2)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Condition_IsContainerUnlocked()
	{
	}
}
