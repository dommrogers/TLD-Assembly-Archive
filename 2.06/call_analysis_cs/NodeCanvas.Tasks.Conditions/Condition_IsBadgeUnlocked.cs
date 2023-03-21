using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using TLD.SaveState;

namespace NodeCanvas.Tasks.Conditions;

public class Condition_IsBadgeUnlocked : ConditionTask
{
	public BadgeInfoType m_Badge;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected override bool OnCheck()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Condition_IsBadgeUnlocked()
	{
	}
}
