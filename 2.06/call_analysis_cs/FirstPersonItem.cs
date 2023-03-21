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

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerSwing), Member = "SwingIsPlaying")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Equip")]
	[CalledBy(Type = typeof(FirstPersonItem), Member = "SetExteriorInteriorSwitch")]
	[CalledBy(Type = typeof(FirstPersonItem), Member = "AnimIsPlaying")]
	[CalledBy(Type = typeof(FirstPersonItem), Member = "AnimateFPSMeshToDefaultPosition")]
	[CalledBy(Type = typeof(FirstPersonItem), Member = "AnimateFPSMeshToExitPosition")]
	[CalledBy(Type = typeof(FirstPersonItem), Member = "PlayUnWieldAudio")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponFromItemData")]
	[CalledBy(Type = typeof(FirstPersonItem), Member = "GetMeshID")]
	[CalledBy(Type = typeof(FirstPersonItem), Member = "IsActive")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "SwitchWeapon")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(FirstPersonItem), Member = "PlayWieldAudio")]
	private bool TryGetFPSWeapon(out vp_FPSWeapon weapon)
	{
		weapon = null;
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(FirstPersonItem), Member = "TryGetFPSWeapon")]
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

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FirstPersonItem), Member = "TryGetFPSWeapon")]
	public void PlayWieldAudio()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(FirstPersonItem), Member = "TryGetFPSWeapon")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 3)]
	public void PlayUnWieldAudio()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StowItem")]
	[CalledBy(Type = typeof(Panel_BedRollSelect), Member = "Enable")]
	[CalledBy(Type = typeof(TorchItem), Member = "ExtinguishAfterDelayStarted")]
	[CalledBy(Type = typeof(TorchItem), Member = "IgniteAfterDelay")]
	[CalledBy(Type = typeof(FlareItem), Member = "IgniteAfterDelay")]
	[CalledBy(Type = typeof(MatchesItem), Member = "IgniteAfterDelay")]
	[Calls(Type = typeof(FirstPersonItem), Member = "TryGetFPSWeapon")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "IgniteAfterDelay")]
	public void AnimateFPSMeshToExitPosition()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionEndInternal")]
	[CalledBy(Type = typeof(Panel_TorchLight), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_TorchLight), Member = "Update")]
	[Calls(Type = typeof(FirstPersonItem), Member = "TryGetFPSWeapon")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "GetFieldValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "GetFieldValue")]
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
		return default(bool);
	}

	[CalledBy(Type = typeof(IndoorSpaceTrigger), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Equip")]
	[CalledBy(Type = typeof(Weather), Member = "ForceOutdoorEnvironment")]
	[CalledBy(Type = typeof(Weather), Member = "ForceIndoorEnvironment")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetIndoorEnvironmentSwitch")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonItem), Member = "TryGetFPSWeapon")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(IndoorSpaceTrigger), Member = "OnTriggerExit")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetOutdoorEnvironmentSwitch")]
	[CallsUnknownMethods(Count = 3)]
	public void SetExteriorInteriorSwitch()
	{
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public FirstPersonItem()
	{
	}
}
