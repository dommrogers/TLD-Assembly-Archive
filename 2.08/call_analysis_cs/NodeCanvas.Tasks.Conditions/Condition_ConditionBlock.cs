using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Conditions;

public class Condition_ConditionBlock : ConditionTask
{
	public string andConditions;

	public string orConditions;

	private object[] cachedAndConditions;

	private object[] cachedOrConditions;

	protected override string info
	{
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Concat")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(NCUtils), Member = "ParseConditional")]
	[CalledBy(Type = typeof(Condition_ConditionBlock), Member = "OnCheck")]
	[CalledBy(Type = typeof(Condition_ConditionBlock), Member = "OnCheck")]
	[CallsUnknownMethods(Count = 5)]
	private object[] BuildVarCache(string[] conditions)
	{
		return null;
	}

	[Calls(Type = typeof(NCUtils), Member = "TestConditional")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(NCUtils), Member = "TestConditional")]
	[Calls(Type = typeof(Condition_ConditionBlock), Member = "BuildVarCache")]
	[Calls(Type = typeof(string), Member = "Split")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Condition_ConditionBlock), Member = "BuildVarCache")]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Condition_ConditionBlock()
	{
	}
}
