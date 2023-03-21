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
		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(OperationTools), Member = "GetCompareString")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TrustManager), Member = "GetTrustValue")]
	[CallsUnknownMethods(Count = 3)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public Condition_NPCTrustValue()
	{
	}
}
