using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Conditions;

public class Condition_CheckContainerPowder : ConditionTask
{
	public BBParameter<string> m_ContainerId;

	public GearPowderType m_Powder;

	public float m_RequiredAmount;

	protected override string info
	{
		[Calls(Type = typeof(string), Member = "Format")]
		[Calls(Type = typeof(string), Member = "Format")]
		[CallsUnknownMethods(Count = 3)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BBParameter), Member = "get_isNull")]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Container), Member = "GetPowderItemAmount")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(BBParameter), Member = "get_isNull")]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Condition_CheckContainerPowder()
	{
	}
}
