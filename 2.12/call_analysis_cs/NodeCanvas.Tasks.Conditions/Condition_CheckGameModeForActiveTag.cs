using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using TLD.GameplayTags;

namespace NodeCanvas.Tasks.Conditions;

public class Condition_CheckGameModeForActiveTag : ConditionTask
{
	public GameplayTag m_GameplayTag;

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
	[Calls(Type = typeof(GameplayTag), Member = "MatchesAnyExact")]
	[CallsUnknownMethods(Count = 1)]
	protected override bool OnCheck()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Condition_CheckGameModeForActiveTag()
	{
	}
}
