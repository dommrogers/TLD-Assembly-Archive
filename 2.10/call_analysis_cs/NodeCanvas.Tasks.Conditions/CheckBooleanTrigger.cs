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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[CallsUnknownMethods(Count = 2)]
	protected override bool OnCheck()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public CheckBooleanTrigger()
	{
	}
}