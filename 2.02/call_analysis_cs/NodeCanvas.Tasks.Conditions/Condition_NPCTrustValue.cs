using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using ParadoxNotion;

namespace NodeCanvas.Tasks.Conditions;

public class Condition_NPCTrustValue : ConditionTask
{
	public BBParameter<string> npcTrustID;

	public CompareMethod checkType;

	public BBParameter<int> compareValue;

	protected override string info
	{
		[CallsUnknownMethods(Count = 20)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(OperationTools), Member = "GetCompareString")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(TrustManager), Member = "GetTrustValue")]
	[CallsUnknownMethods(Count = 5)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
	[Calls(Type = typeof(BBParameter), Member = "PromoteToVariable")]
	[Calls(Type = typeof(BBParameter), Member = "get_isNone")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	public Condition_NPCTrustValue()
	{
	}
}
