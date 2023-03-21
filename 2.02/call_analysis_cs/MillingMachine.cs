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
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsUnknownMethods(Count = 3)]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectDisplayText")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MillingMachine), Member = "CanBeUsed")]
	public string GetHoverText()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Milling), Member = "RefreshSelected")]
	[Calls(Type = typeof(Panel_Milling), Member = "RefreshList")]
	[Calls(Type = typeof(InputManager), Member = "ResetControllerState")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_Milling), Member = "DetermineRepairables")]
	[Calls(Type = typeof(MillingMachine), Member = "CanBeUsed")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	public bool ProcessInteraction()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(MillingMachine), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(MillingMachine), Member = "GetHoverText")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool CanBeUsed()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public MillingMachine()
	{
	}
}
