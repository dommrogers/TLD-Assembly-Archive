using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using TLD.Gameplay;
using UnityEngine;

public class FirstPersonItem : MonoBehaviour
{
	public FPSItem m_ItemData;

	public AK.Wwise.Event m_WieldAudioEvent;

	public AK.Wwise.Event m_UnwieldAudioEvent;

	public PlayerStateTransitions m_PlayerStateTransitions;

	private string m_FirstPersonObjectName;

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "SwitchWeapon")]
	[CalledBy(Type = typeof(FirstPersonItem), Member = "IsActive")]
	[CalledBy(Type = typeof(FirstPersonItem), Member = "GetMeshID")]
	[CalledBy(Type = typeof(FirstPersonItem), Member = "PlayWieldAudio")]
	[CalledBy(Type = typeof(FirstPersonItem), Member = "PlayUnWieldAudio")]
	[CalledBy(Type = typeof(FirstPersonItem), Member = "AnimateFPSMeshToExitPosition")]
	[CalledBy(Type = typeof(FirstPersonItem), Member = "AnimateFPSMeshToDefaultPosition")]
	[CalledBy(Type = typeof(FirstPersonItem), Member = "AnimIsPlaying")]
	[CalledBy(Type = typeof(FirstPersonItem), Member = "SetExteriorInteriorSwitch")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Equip")]
	[CalledBy(Type = typeof(PlayerSwing), Member = "SwingIsPlaying")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponFromItemData")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	private bool TryGetFPSWeapon(out vp_FPSWeapon weapon)
	{
		weapon = null;
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FirstPersonItem), Member = "TryGetFPSWeapon")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public bool IsActive()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FirstPersonItem), Member = "TryGetFPSWeapon")]
	[CallsUnknownMethods(Count = 1)]
	public int GetMeshID()
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FirstPersonItem), Member = "TryGetFPSWeapon")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void PlayWieldAudio()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FirstPersonItem), Member = "TryGetFPSWeapon")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void PlayUnWieldAudio()
	{
	}

	[CalledBy(Type = typeof(FlareItem), Member = "IgniteAfterDelay")]
	[CalledBy(Type = typeof(MatchesItem), Member = "IgniteAfterDelay")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "IgniteAfterDelay")]
	[CalledBy(Type = typeof(TorchItem), Member = "IgniteAfterDelay")]
	[CalledBy(Type = typeof(TorchItem), Member = "ExtinguishAfterDelayStarted")]
	[CalledBy(Type = typeof(Panel_BedRollSelect), Member = "Enable")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StowItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(FirstPersonItem), Member = "TryGetFPSWeapon")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void AnimateFPSMeshToExitPosition()
	{
	}

	[CalledBy(Type = typeof(Panel_TorchLight), Member = "Update")]
	[CalledBy(Type = typeof(Panel_TorchLight), Member = "OnCancel")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionEndInternal")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(FirstPersonItem), Member = "TryGetFPSWeapon")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "GetFieldValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void AnimateFPSMeshToDefaultPosition()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FirstPersonItem), Member = "TryGetFPSWeapon")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[CallsUnknownMethods(Count = 1)]
	public bool AnimIsPlaying(int id, int layer)
	{
		return false;
	}

	[CalledBy(Type = typeof(Weather), Member = "ForceIndoorEnvironment")]
	[CalledBy(Type = typeof(Weather), Member = "ForceOutdoorEnvironment")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Equip")]
	[CalledBy(Type = typeof(IndoorSpaceTrigger), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(IndoorSpaceTrigger), Member = "OnTriggerExit")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(FirstPersonItem), Member = "TryGetFPSWeapon")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetOutdoorEnvironmentSwitch")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetIndoorEnvironmentSwitch")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void SetExteriorInteriorSwitch()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public FirstPersonItem()
	{
	}
}
