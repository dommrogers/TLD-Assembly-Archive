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
		[Calls(Type = typeof(string), Member = "Format")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Condition_IsBadgeUnlocked()
	{
	}
}
