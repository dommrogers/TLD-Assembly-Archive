using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using ParadoxNotion;

namespace NodeCanvas.Tasks.Conditions;

public class CheckInt : ConditionTask
{
	public BBParameter<int> valueA;

	public CompareMethod checkType;

	public BBParameter<int> valueB;

	protected override string info
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(OperationTools), Member = "GetCompareString")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[CallsUnknownMethods(Count = 1)]
	protected override bool OnCheck()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public CheckInt()
	{
	}
}
