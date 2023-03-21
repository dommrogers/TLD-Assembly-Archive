using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Conditions;

public class Condition_IsTODInRange : ConditionTask
{
	public BBParameter<int> hourValMin;

	public BBParameter<int> hourValMax;

	protected override string info
	{
		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(string), Member = "Format")]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 8)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Condition_IsTODInRange()
	{
	}
}
