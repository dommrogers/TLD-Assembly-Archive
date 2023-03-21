using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UsePhoneTrigger : MonoBehaviour
{
	public string m_PhoneObjectId;

	[CalledBy(Type = typeof(UsePhoneTrigger), Member = "OnTriggerStay")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(GameObject), Member = "CompareTag")]
	[Calls(Type = typeof(Phone), Member = "GetPhone")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Phone), Member = "ProcessInteraction")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private void MaybeUsePhone(Collider c)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UsePhoneTrigger), Member = "MaybeUsePhone")]
	private void OnTriggerStay(Collider c)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public UsePhoneTrigger()
	{
	}
}
