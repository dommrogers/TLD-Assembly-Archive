using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using ParadoxNotion;

namespace NodeCanvas.Tasks.Conditions;

public class TLD_CheckPhoneRingCycle : ConditionTask
{
	public BBParameter<string> phoneMissionId;

	public CompareMethod checkType;

	public BBParameter<int> compareValue;

	private Phone m_Phone;

	private bool m_HasRetrievedPhone;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(OperationTools), Member = "GetCompareString")]
		[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsUnknownMethods(Count = 3)]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PhoneManager), Member = "GetPhoneSaveInfo")]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public TLD_CheckPhoneRingCycle()
	{
	}
}
