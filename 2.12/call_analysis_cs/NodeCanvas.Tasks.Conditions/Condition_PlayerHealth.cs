using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using ParadoxNotion;

namespace NodeCanvas.Tasks.Conditions;

public class Condition_PlayerHealth : ConditionTask
{
	public CompareMethod checkType;

	public BBParameter<float> compareValue;

	public float differenceThreshold;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
		[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
		[Calls(Type = typeof(OperationTools), Member = "GetCompareString")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 22)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsPanelEnabled")]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[CallsUnknownMethods(Count = 2)]
	protected override bool OnCheck()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Condition_PlayerHealth()
	{
	}
}
