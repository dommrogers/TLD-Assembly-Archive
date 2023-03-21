using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class FirstPersonItem : MonoBehaviour
{
	public string m_FirstPersonObjectName;

	public string m_WieldAudio;

	public string m_UnWieldAudio;

	public PlayerStateTransitions m_PlayerStateTransitions;

	private int m_FPSMeshID;

	private vp_FPSWeapon m_FPSWeapon;

	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponFromID")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponIDFromName")]
	[CallsUnknownMethods(Count = 4)]
	public void Awake()
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 4)]
	public bool IsActive()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public int GetMeshID()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Equip")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 6)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public void PlayWieldAudio()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "SwitchWeapon")]
	[CallsUnknownMethods(Count = 6)]
	public void PlayUnWieldAudio()
	{
	}

	[CalledBy(Type = typeof(TorchItem), Member = "ExtinguishAfterDelayStarted")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StowItem")]
	[CalledBy(Type = typeof(Panel_BedRollSelect), Member = "Enable")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "IgniteAfterDelay")]
	[CalledBy(Type = typeof(FlareItem), Member = "IgniteAfterDelay")]
	[CalledBy(Type = typeof(MatchesItem), Member = "IgniteAfterDelay")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(TorchItem), Member = "IgniteAfterDelay")]
	public void AnimateFPSMeshToExitPosition()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionEndInternal")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "get_DefaultRotation")]
	[CalledBy(Type = typeof(Panel_TorchLight), Member = "OnCancel")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "get_DefaultPosition")]
	public void AnimateFPSMeshToDefaultPosition()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[CalledBy(Type = typeof(PlayerSwing), Member = "SwingIsPlaying")]
	[CallsUnknownMethods(Count = 2)]
	public bool AnimIsPlaying(int id, int layer)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Equip")]
	[CalledBy(Type = typeof(IndoorSpaceTrigger), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(Weather), Member = "ForceIndoorEnvironment")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(IndoorSpaceTrigger), Member = "OnTriggerExit")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetIndoorEnvironmentSwitch")]
	[CalledBy(Type = typeof(Weather), Member = "ForceOutdoorEnvironment")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetOutdoorEnvironmentSwitch")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 5)]
	public void SetExteriorInteriorSwitch()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	public FirstPersonItem()
	{
	}
}
