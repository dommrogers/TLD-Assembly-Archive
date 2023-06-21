using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Conditions;

public class Condition_CheckExperienceMode : ConditionTask
{
	public ExperienceModeType xpMode;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enum), Member = "ToString")]
		[Calls(Type = typeof(string), Member = "Format")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	protected override bool OnCheck()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Condition_CheckExperienceMode()
	{
	}
}
