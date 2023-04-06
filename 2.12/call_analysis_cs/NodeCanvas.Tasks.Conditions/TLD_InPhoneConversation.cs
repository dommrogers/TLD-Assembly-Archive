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
	[CallsUnknownMethods(Count = 1)]
	protected override bool OnCheck()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TLD_InPhoneConversation), Member = "GetPhone")]
	private void RetrievePhone()
	{
	}

	[CalledBy(Type = typeof(TLD_InPhoneConversation), Member = "OnCheck")]
	[CalledBy(Type = typeof(TLD_InPhoneConversation), Member = "RetrievePhone")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetMissionServicesManager")]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
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
