using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Conditions;

public class CheckBooleanTrigger : ConditionTask
{
	public BBParameter<bool> trigger;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Format")]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public CheckBooleanTrigger()
	{
	}
}
