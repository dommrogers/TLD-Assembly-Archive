using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UsePhoneTrigger : MonoBehaviour
{
	public string m_PhoneObjectId;

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(UsePhoneTrigger), Member = "OnTriggerStay")]
	[Calls(Type = typeof(Phone), Member = "ProcessInteraction")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Phone), Member = "GetPhone")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "CompareTag")]
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
