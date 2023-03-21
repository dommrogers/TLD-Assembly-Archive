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
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(OperationTools), Member = "GetCompareString")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public CheckInt()
	{
	}
}
