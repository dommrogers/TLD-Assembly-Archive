using System;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Conditions;

public class Probability : ConditionTask
{
	public BBParameter<float> probability;

	public BBParameter<float> maxValue;

	protected override string info
	{
		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public Probability()
	{
	}
}
