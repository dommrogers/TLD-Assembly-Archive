using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Conditions;

public class Condition_ObjectiveIsActiveOrComplete : ConditionTask
{
	public BBParameter<string> objectiveID;

	protected override string info
	{
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		[CallsUnknownMethods(Count = 2)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetObjectiveIndex")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Condition_ObjectiveIsActiveOrComplete()
	{
	}
}
