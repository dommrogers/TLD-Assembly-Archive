using System.Collections.Generic;
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
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(string), Member = "Concat")]
		get
		{
			return null;
		}
	}

	[CalledBy(Type = typeof(Condition_ConditionBlock), Member = "OnCheck")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NCUtils), Member = "ParseConditional")]
	[Calls(Type = typeof(List<>), Member = "ToArray")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 10)]
	private object[] BuildVarCache(string[] conditions)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Split")]
	[Calls(Type = typeof(Condition_ConditionBlock), Member = "BuildVarCache")]
	[Calls(Type = typeof(NCUtils), Member = "TestConditional")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	protected override bool OnCheck()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Condition_ConditionBlock()
	{
	}
}
