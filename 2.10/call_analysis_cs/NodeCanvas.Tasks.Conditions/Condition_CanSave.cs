using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Conditions;

public class Condition_CanSave : ConditionTask
{
	public SaveState state;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task), Member = "get_name")]
		[Calls(Type = typeof(Enum), Member = "ToString")]
		[Calls(Type = typeof(string), Member = "Concat")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "AllowedToSave")]
	protected override bool OnCheck()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public Condition_CanSave()
	{
	}
}
