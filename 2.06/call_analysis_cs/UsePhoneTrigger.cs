using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
using UnityEngine;

public class UsePhoneTrigger : MonoBehaviour
{
	private PanelReference<Panel_Loading> m_Loading;

	public string m_PhoneObjectId;

	[CalledBy(Type = typeof(UsePhoneTrigger), Member = "OnTriggerStay")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(GameObject), Member = "CompareTag")]
	[Calls(Type = typeof(Phone), Member = "GetPhone")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Phone), Member = "StopRinging")]
	[Calls(Type = typeof(Phone), Member = "OnPhonePickup")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
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
