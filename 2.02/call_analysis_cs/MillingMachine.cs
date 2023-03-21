using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MillingMachine : MonoBehaviour
{
	public LocalizedString m_HoverText;

	public bool m_RequiresAurora;

	public string m_IdleAudioPlay;

	public string m_IdleAudioStop;

	public string m_RepairAudioLoop;

	private uint m_IdleAudioPlayingId;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectDisplayText")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MillingMachine), Member = "CanBeUsed")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public string GetHoverText()
	{
		return null;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MillingMachine), Member = "CanBeUsed")]
	[Calls(Type = typeof(Panel_Milling), Member = "DetermineRepairables")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InputManager), Member = "ResetControllerState")]
	[Calls(Type = typeof(Panel_Milling), Member = "RefreshList")]
	[Calls(Type = typeof(Panel_Milling), Member = "RefreshSelected")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public bool ProcessInteraction()
	{
		return false;
	}

	[CalledBy(Type = typeof(MillingMachine), Member = "GetHoverText")]
	[CalledBy(Type = typeof(MillingMachine), Member = "ProcessInteraction")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool CanBeUsed()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public MillingMachine()
	{
	}
}
