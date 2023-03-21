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
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
		[CallsUnknownMethods(Count = 3)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(OperationTools), Member = "GetCompareString")]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(PhoneManager), Member = "GetPhoneSaveInfo")]
	[CallerCount(Count = 0)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public TLD_CheckPhoneRingCycle()
	{
	}
}
