using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using ParadoxNotion;

namespace NodeCanvas.Tasks.Conditions;

public class CheckFloat : ConditionTask
{
	public BBParameter<float> valueA;

	public CompareMethod checkType;

	public BBParameter<float> valueB;

	public float differenceThreshold;

	protected override string info
	{
		[Calls(Type = typeof(OperationTools), Member = "GetCompareString")]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(string), Member = "Concat")]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public CheckFloat()
	{
	}
}
