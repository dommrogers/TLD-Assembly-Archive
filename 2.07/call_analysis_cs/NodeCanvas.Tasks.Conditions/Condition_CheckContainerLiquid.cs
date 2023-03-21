using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Conditions;

public class Condition_CheckContainerLiquid : ConditionTask
{
	public BBParameter<string> m_ContainerId;

	public GearLiquidTypeEnum m_Liquid;

	public float m_RequiredAmount;

	protected override string info
	{
		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(string), Member = "Format")]
		[Calls(Type = typeof(BBParameter), Member = "get_isNull")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Format")]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(Container), Member = "GetLiquidItemAmount")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(BBParameter), Member = "get_isNull")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[CallsUnknownMethods(Count = 2)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Condition_CheckContainerLiquid()
	{
	}
}
