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

	[CalledBy(Type = typeof(PlayerSwing), Member = "SwingIsPlaying")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Equip")]
	[CalledBy(Type = typeof(FirstPersonItem), Member = "SetExteriorInteriorSwitch")]
	[CalledBy(Type = typeof(FirstPersonItem), Member = "AnimIsPlaying")]
	[CalledBy(Type = typeof(FirstPersonItem), Member = "AnimateFPSMeshToDefaultPosition")]
	[CalledBy(Type = typeof(FirstPersonItem), Member = "AnimateFPSMeshToExitPosition")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(FirstPersonItem), Member = "PlayUnWieldAudio")]
	[CalledBy(Type = typeof(FirstPersonItem), Member = "GetMeshID")]
	[CalledBy(Type = typeof(FirstPersonItem), Member = "IsActive")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "SwitchWeapon")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponFromItemData")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(FirstPersonItem), Member = "PlayWieldAudio")]
	private bool TryGetFPSWeapon(out vp_FPSWeapon weapon)
	{
		weapon = null;
		return default(bool);
	}

	[Calls(Type = typeof(FirstPersonItem), Member = "TryGetFPSWeapon")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public bool IsActive()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FirstPersonItem), Member = "TryGetFPSWeapon")]
	[CallsUnknownMethods(Count = 1)]
	public int GetMeshID()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(FirstPersonItem), Member = "TryGetFPSWeapon")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public void PlayWieldAudio()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(FirstPersonItem), Member = "TryGetFPSWeapon")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	public void PlayUnWieldAudio()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "StowItem")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_BedRollSelect), Member = "Enable")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[CalledBy(Type = typeof(TorchItem), Member = "ExtinguishAfterDelayStarted")]
	[CalledBy(Type = typeof(TorchItem), Member = "IgniteAfterDelay")]
	[CalledBy(Type = typeof(MatchesItem), Member = "IgniteAfterDelay")]
	[CalledBy(Type = typeof(FlareItem), Member = "IgniteAfterDelay")]
	[Calls(Type = typeof(FirstPersonItem), Member = "TryGetFPSWeapon")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "IgniteAfterDelay")]
	public void AnimateFPSMeshToExitPosition()
	{
	}

	[CalledBy(Type = typeof(Panel_TorchLight), Member = "OnCancel")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionEndInternal")]
	[CalledBy(Type = typeof(Panel_TorchLight), Member = "Update")]
	[Calls(Type = typeof(FirstPersonItem), Member = "TryGetFPSWeapon")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "GetFieldValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "GetFieldValue")]
	public void AnimateFPSMeshToDefaultPosition()
	{
	}

	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FirstPersonItem), Member = "TryGetFPSWeapon")]
	public bool AnimIsPlaying(int id, int layer)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Weather), Member = "ForceOutdoorEnvironment")]
	[CalledBy(Type = typeof(IndoorSpaceTrigger), Member = "OnTriggerExit")]
	[CalledBy(Type = typeof(IndoorSpaceTrigger), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Equip")]
	[CalledBy(Type = typeof(Weather), Member = "ForceIndoorEnvironment")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetOutdoorEnvironmentSwitch")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonItem), Member = "TryGetFPSWeapon")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetIndoorEnvironmentSwitch")]
	public void SetExteriorInteriorSwitch()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public FirstPersonItem()
	{
	}
}
