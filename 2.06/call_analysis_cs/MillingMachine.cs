using Cpp2ILInjected.CallAnalysis;
using TLD.Interactions;
using TLD.UI.Generics;
using UnityEngine;

public class MillingMachine : MonoBehaviour
{
	public string m_IdleAudioPlay;

	public string m_IdleAudioStop;

	public string m_RepairAudioLoop;

	private PanelReference<Panel_Milling> m_MillingPanel;

	private uint m_IdleAudioPlayingId;

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void InitializeInteraction(BaseInteraction baseInteraction)
	{
	}

	[Calls(Type = typeof(InputManager), Member = "ResetControllerState")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Milling), Member = "RefreshList")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Milling), Member = "RefreshSelected")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_Milling), Member = "DetermineRepairables")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	public void PerformInteraction()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public MillingMachine()
	{
	}
}
