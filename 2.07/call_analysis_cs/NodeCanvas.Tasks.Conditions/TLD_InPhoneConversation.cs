using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

public class TLD_InPhoneConversation : ConditionTask
{
	public BBParameter<string> phoneMissionId;

	private Phone m_Phone;

	private bool m_HasRetrievedPhone;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TLD_InPhoneConversation), Member = "GetPhone")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TLD_InPhoneConversation), Member = "GetPhone")]
	private void RetrievePhone()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[CalledBy(Type = typeof(TLD_InPhoneConversation), Member = "OnCheck")]
	[CalledBy(Type = typeof(TLD_InPhoneConversation), Member = "RetrievePhone")]
	[CallsUnknownMethods(Count = 3)]
	private Phone GetPhone()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public TLD_InPhoneConversation()
	{
	}
}
