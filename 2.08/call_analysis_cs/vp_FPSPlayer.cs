using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using TLD.Gameplay;
using TLD.UI.Generics;
using UnityEngine;

public class vp_FPSPlayer : MonoBehaviour
{
	public enum UnCrouchOptions
	{
		None,
		CheckHeadroom
	}

	private PanelReference<Panel_Loading> m_Loading;

	public vp_FPSCamera FPSCamera;

	public vp_FPSController Controller;

	public BloodTrail m_BloodTrail;

	protected vp_Timer m_ReenableWeaponStatesTimer;

	protected List<GameObject> m_AvailableWeapons;

	public bool m_CrouchToggleOn;

	public bool m_MovementInputLastFrame;

	public bool m_AltFireReleaseRequiredBeforeZoom;

	public bool m_InteractReleaseRequiredBeforeSpearZoom;

	private bool m_CancelSpearZoomRequested;

	private bool m_InZoom;

	private Vector3 m_StrafingRightDirection;

	private Vector3 m_StrafingCenter;

	private float m_StrafingDistanceLimit;

	private bool m_SpearZoomRequested;

	private bool m_AutoWalking;

	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	private void Start()
	{
	}

	[Calls(Type = typeof(vp_StateManager), Member = "IsEnabled")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "InputZoom")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "InputWalk")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(GameManager), Member = "ControlsLocked")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "MaybeCancelZoomInternal")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "ShouldTurnOffZoom")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(vp_StateManager), Member = "SetState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[Calls(Type = typeof(InputManager), Member = "GetPlayerMovement")]
	private void Update()
	{
	}

	[Calls(Type = typeof(vp_FPSPlayer), Member = "GetMovementInput")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputManager), Member = "GetPlayerMovement")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetAutoWalkingEnabled")]
	[Calls(Type = typeof(InputManager), Member = "GetPlayerMovement")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetAutoWalkingEnabled")]
	protected void InputWalk()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "GetPlayerMovement")]
	[CallsUnknownMethods(Count = 2)]
	protected void InputStrafing()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected void InputJump()
	{
	}

	[CalledBy(Type = typeof(BodyCarry), Member = "ProcessInteraction")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "CanPlayDarkWalkerDeathAnimation")]
	[CalledBy(Type = typeof(BaseAi), Member = "CanPlayerBeReached")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "EnableCrouchImmediate")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "EnableCrouch")]
	[Calls(Type = typeof(Physics), Member = "SphereCast")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[CallerCount(Count = 5)]
	public bool HasHeadRoom()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "InputWalk")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "InputWalk")]
	[CallsUnknownMethods(Count = 1)]
	public void SetAutoWalkingEnabled(bool enabled)
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "Update")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerCanSprint")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "InputWalk")]
	[Calls(Type = typeof(InputManager), Member = "GetPlayerMovement")]
	public Vector2 GetMovementInput()
	{
		return default(Vector2);
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_force_crouch")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "Enable")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "TryPerformInteraction")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "StartAnimatedInteraction")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateTransitionIn")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteCrouchAction")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Action_ForceUncrouchEnable), Member = "OnExecute")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "SetForceCrouch")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "Update")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "BeginClimbing")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_AnimatedInteraction")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "InputCrouch")]
	[Calls(Type = typeof(BowItem), Member = "ForceReady")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "Update")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillArchery")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_StateManager), Member = "IsEnabled")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "HasHeadRoom")]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(Skill_Archery), Member = "CanFireBowWhileCrouched")]
	public bool EnableCrouch(bool enabled)
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameManager), Member = "GetSkillArchery")]
	[Calls(Type = typeof(Skill_Archery), Member = "CanFireBowWhileCrouched")]
	[Calls(Type = typeof(BowItem), Member = "ForceReady")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "InitializeStruggle")]
	[CalledBy(Type = typeof(BodyCarry), Member = "SetupCarryState")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "SnapToCrouch")]
	[CalledBy(Type = typeof(PlayerInVehicle), Member = "EnterVehicleCommon")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "PlayTimeline")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "PlayTimelineOnPlayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	[Calls(Type = typeof(vp_FPSController), Member = "SetCompactImmmediate")]
	[Calls(Type = typeof(vp_StateManager), Member = "IsEnabled")]
	[Calls(Type = typeof(vp_FPSController), Member = "SetCompactImmmediate")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "HasHeadRoom")]
	[CallerCount(Count = 7)]
	public bool EnableCrouchImmediate(bool enabled, UnCrouchOptions options)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SnapZoom")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SnapSprings")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "EnableCrouchImmediate")]
	[CallerCount(Count = 1)]
	public bool SnapToCrouch(bool enabled, UnCrouchOptions options)
	{
		return default(bool);
	}

	[Calls(Type = typeof(vp_FPSPlayer), Member = "EnableCrouch")]
	[Calls(Type = typeof(InputManager), Member = "GetCrouchPressed")]
	[CallerCount(Count = 0)]
	protected void InputCrouch()
	{
	}

	[Calls(Type = typeof(vp_StateManager), Member = "IsEnabled")]
	[Calls(Type = typeof(vp_StateManager), Member = "IsEnabled")]
	[Calls(Type = typeof(vp_StateManager), Member = "IsEnabled")]
	[Calls(Type = typeof(vp_StateManager), Member = "SetState")]
	[Calls(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessFireAction")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(vp_StateManager), Member = "IsEnabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_StateManager), Member = "SetState")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void PullTrigger()
	{
	}

	[Calls(Type = typeof(vp_FPSWeapon), Member = "GetAmmoCount")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "ReenableWeaponStatesIn")]
	[Calls(Type = typeof(InputManager), Member = "GetFireReleased")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected void CheckForFireRelease()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Aim")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSShooter), Member = "PreventFiring")]
	[Calls(Type = typeof(InputManager), Member = "GetAltFire")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "MaybeCancelZoomInternal")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InputManager), Member = "GetAltFire")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "HandleBearSpearInput")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "ToggleZoom")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Aim")]
	[Calls(Type = typeof(PlayerVoice), Member = "CompleteActiveRequest")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopAllSoundsFromGameObject")]
	[Calls(Type = typeof(InputManager), Member = "GetAltFire")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "MaybeCancelZoomInternal")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "ToggleZoom")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "CanTransitionToState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InputManager), Member = "GetAltFire")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	protected void InputZoom()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "EquipItem")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SwitchWeapon")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponFromItemData")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "IsWeaponAvailable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "ReenableWeaponStatesIn")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	public bool SetWeapon(GearItem gi)
	{
		return default(bool);
	}

	[Calls(Type = typeof(vp_FPSShooter), Member = "Reload")]
	[Calls(Type = typeof(Inventory), Member = "GetAmmoAvailableForWeapon")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "UnJam")]
	[Calls(Type = typeof(vp_Timer), Member = "Cancel")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "MaybeCancelZoomInternal")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteReloadAction")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(HUDManager), Member = "DisplayAmmoOnHUDForTime")]
	[Calls(Type = typeof(GunItem), Member = "NumRoundsInClip")]
	[Calls(Type = typeof(GunItem), Member = "NumRoundsInClip")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[CallerCount(Count = 1)]
	public void Reload()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "ToggleZoom")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	[CallerCount(Count = 0)]
	public void CancelZoom()
	{
	}

	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "InputZoom")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "Update")]
	[Calls(Type = typeof(Freezing), Member = "MaybeCancelPlayerFreezingTeethChatter")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Aim_Cancel")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "Reload")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "HandleBearSpearInput")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(BearSpearItem), Member = "SetCurrentState")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "InputZoom")]
	[Calls(Type = typeof(GunItem), Member = "ZoomEnd")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "ReenableWeaponStatesIn")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "ToggleZoom")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void MaybeCancelZoomInternal()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "InitializeStruggle")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "CancelReload")]
	[CallerCount(Count = 1)]
	public void CancelReload()
	{
	}

	[Calls(Type = typeof(vp_StateManager), Member = "IsEnabled")]
	[Calls(Type = typeof(vp_StateManager), Member = "SetState")]
	[Calls(Type = typeof(vp_StateManager), Member = "SetState")]
	[Calls(Type = typeof(vp_StateManager), Member = "SetState")]
	[Calls(Type = typeof(vp_StateManager), Member = "IsEnabled")]
	[Calls(Type = typeof(vp_StateManager), Member = "IsEnabled")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(vp_StateManager), Member = "SetState")]
	[Calls(Type = typeof(vp_StateManager), Member = "IsEnabled")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(vp_StateManager), Member = "IsEnabled")]
	[CallerCount(Count = 20)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public void SetState(string state, bool isEnabled)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerMovement), Member = "Start")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(vp_StateManager), Member = "IsEnabled")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerIsSwingingFirstPersonItem")]
	public bool IsStateEnabled(string state)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(vp_StateManager), Member = "SetState")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_StateManager), Member = "IsEnabled")]
	public void UpdateSprintState()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public void AllowState(string state, bool isAllowed)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "MaybeCancelZoomInternal")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "SetWeapon")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "CheckForFireRelease")]
	[Calls(Type = typeof(vp_Timer), Member = "Cancel")]
	[Calls(Type = typeof(vp_Timer), Member = "In")]
	public void ReenableWeaponStatesIn(float seconds)
	{
	}

	[Calls(Type = typeof(vp_StateManager), Member = "Reset")]
	[Calls(Type = typeof(vp_StateManager), Member = "Reset")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_StateManager), Member = "Reset")]
	[Calls(Type = typeof(vp_StateManager), Member = "Reset")]
	[CallsUnknownMethods(Count = 1)]
	public void ResetState()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponFromItemData")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PlayerManager), Member = "EquipItem")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SwitchWeapon")]
	public void SetWeaponAvailable(FPSItem itemData, bool isAvailable)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "EquipItem")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "SetWeapon")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponFromItemData")]
	[CallerCount(Count = 2)]
	public bool IsWeaponAvailable(FPSItem itemData)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public void SetStrafingParameters(Vector3 strafingRightDirection, Vector3 strafingCenter, float strafingDistanceLimit)
	{
	}

	[CallerCount(Count = 0)]
	public Vector3 GetStrafingRightDirection()
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	public Vector3 GetStrafingCenter()
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float GetStrafingDistanceLimit()
	{
		return default(float);
	}

	[Calls(Type = typeof(BearSpearItem), Member = "DistanceToNearestSpearable")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(BearSpearItem), Member = "OnEnter_Setting")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "MaybeCancelZoomInternal")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "InputZoom")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "ToggleZoom")]
	[Calls(Type = typeof(InputManager), Member = "GetFirePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetFireReleased")]
	[CallerCount(Count = 1)]
	private void HandleBearSpearInput(PlayerManager pm)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool ShouldTurnOffZoom()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public vp_FPSPlayer()
	{
	}
}
