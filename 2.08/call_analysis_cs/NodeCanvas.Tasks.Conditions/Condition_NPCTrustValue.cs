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
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(OperationTools), Member = "GetCompareString")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsUnknownMethods(Count = 3)]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TrustManager), Member = "GetTrustValue")]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public Condition_NPCTrustValue()
	{
	}
}
