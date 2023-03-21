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
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(TLD_InPhoneConversation), Member = "GetPhone")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TLD_InPhoneConversation), Member = "GetPhone")]
	private void RetrievePhone()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(TLD_InPhoneConversation), Member = "RetrievePhone")]
	[CalledBy(Type = typeof(TLD_InPhoneConversation), Member = "OnCheck")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
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
