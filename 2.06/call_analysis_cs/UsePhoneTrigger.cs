using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
using UnityEngine;

public class UsePhoneTrigger : MonoBehaviour
{
	private PanelReference<Panel_Loading> m_Loading;

	public string m_PhoneObjectId;

	[CalledBy(Type = typeof(UsePhoneTrigger), Member = "OnTriggerStay")]
	[Calls(Type = typeof(Phone), Member = "StopRinging")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Phone), Member = "OnPhonePickup")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Phone), Member = "GetPhone")]
	[Calls(Type = typeof(GameObject), Member = "CompareTag")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void MaybeUsePhone(Collider c)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UsePhoneTrigger), Member = "MaybeUsePhone")]
	private void OnTriggerStay(Collider c)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public UsePhoneTrigger()
	{
	}
}
