using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using UnityEngine;

public class vp_FPSPlayer : MonoBehaviour
{
	public enum UnCrouchOptions
	{
		None,
		CheckHeadroom
	}

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

	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "ControlsLocked")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "MaybeCancelZoomInternal")]
	[Calls(Type = typeof(InputManager), Member = "GetPlayerMovement")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "InputZoom")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "InputWalk")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Vector2), Member = "get_magnitude")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "ShouldTurnOffZoom")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "UpdateSprintState")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 9)]
	[CallsDeduplicatedMethods(Count = 5)]
	private void Update()
	{
	}

	[Calls(Type = typeof(vp_FPSPlayer), Member = "GetMovementInput")]
	[Calls(Type = typeof(InputManager), Member = "GetPlayerMovement")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetAutoWalkingEnabled")]
	[Calls(Type = typeof(InputManager), Member = "GetPlayerMovement")]
	[Calls(Type = typeof(Vector2), Member = "get_magnitude")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "Update")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetAutoWalkingEnabled")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	protected void InputWalk()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetPlayerMovement")]
	[Calls(Type = typeof(Vector2), Member = "get_magnitude")]
	[CallsUnknownMethods(Count = 1)]
	protected void InputStrafing()
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	protected void InputJump()
	{
	}

	[CalledBy(Type = typeof(BodyCarry), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "CanPlayDarkWalkerDeathAnimation")]
	[CalledBy(Type = typeof(BaseAi), Member = "CanPlayerBeReached")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "EnableCrouchImmediate")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "EnableCrouch")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(PhysicsScene), Member = "SphereCast")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 5)]
	public bool HasHeadRoom()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnTakeDamage")]
	[CalledBy(Type = typeof(SprainPain), Member = "ApplyAffliction")]
	[CalledBy(Type = typeof(Condition), Member = "AddHealth")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "InputWalk")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "InputWalk")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	public void SetAutoWalkingEnabled(bool enabled)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(GameManager), Member = "Update")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerCanSprint")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "InputWalk")]
	[Calls(Type = typeof(InputManager), Member = "GetPlayerMovement")]
	public Vector2 GetMovementInput()
	{
		return default(Vector2);
	}

	[CalledBy(Type = typeof(Panel_Debug), Member = "Enable")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "StartAnimatedInteraction")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateTransitionIn")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "InputCrouch")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteCrouchAction")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_force_crouch")]
	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(Action_ForceUncrouchEnable), Member = "OnExecute")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "SetForceCrouch")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "Update")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "Update")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "BeginClimbing")]
	[Calls(Type = typeof(BowItem), Member = "ForceReady")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_AnimatedInteraction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_StateManager), Member = "IsEnabled")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "HasHeadRoom")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(GameManager), Member = "GetSkillArchery")]
	public bool EnableCrouch(bool enabled)
	{
		return default(bool);
	}

	[Calls(Type = typeof(vp_FPSController), Member = "SetCompactImmmediate")]
	[Calls(Type = typeof(vp_FPSController), Member = "SetCompactImmmediate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "SnapToCrouch")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(BowItem), Member = "ForceReady")]
	[Calls(Type = typeof(vp_StateManager), Member = "IsEnabled")]
	[CalledBy(Type = typeof(BodyCarry), Member = "SetupCarryState")]
	[CalledBy(Type = typeof(PlayerInVehicle), Member = "EnterVehicleCommon")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillArchery")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerMovement), Member = "Deserialize")]
	[CalledBy(Type = typeof(Action_PlayTimeline), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "HasHeadRoom")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "InitializeStruggle")]
	public bool EnableCrouchImmediate(bool enabled, UnCrouchOptions options)
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "EnableCrouchImmediate")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SnapSprings")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SnapZoom")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "PlayTimeline")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	public bool SnapToCrouch(bool enabled, UnCrouchOptions options)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetCrouchPressed")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "EnableCrouch")]
	protected void InputCrouch()
	{
	}

	[Calls(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[CallsUnknownMethods(Count = 27)]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessFireAction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(vp_StateManager), Member = "SetState")]
	[Calls(Type = typeof(vp_StateManager), Member = "IsEnabled")]
	[Calls(Type = typeof(vp_StateManager), Member = "SetState")]
	[Calls(Type = typeof(vp_StateManager), Member = "IsEnabled")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(vp_StateManager), Member = "IsEnabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_StateManager), Member = "IsEnabled")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public void PullTrigger()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "GetAmmoCount")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "ReenableWeaponStatesIn")]
	[Calls(Type = typeof(InputManager), Member = "GetFireReleased")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	protected void CheckForFireRelease()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(vp_FPSShooter), Member = "PreventFiring")]
	[Calls(Type = typeof(InputManager), Member = "GetAltFire")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "ShouldStopAiming")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InputManager), Member = "GetAltFire")]
	[Calls(Type = typeof(InputManager), Member = "GetAltFire")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "ToggleZoom")]
	[Calls(Type = typeof(StoneItem), Member = "ZoomStart")]
	[CallsUnknownMethods(Count = 40)]
	[Calls(Type = typeof(GunItem), Member = "ZoomStart")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "Update")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "HandleBearSpearInput")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "MaybeCancelZoomInternal")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "ToggleZoom")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "MaybeCancelZoomInternal")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "CanStartAiming")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "CanTransitionToState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InputManager), Member = "GetAltFire")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	protected void InputZoom()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "ReenableWeaponStatesIn")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SwitchWeapon")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "IsWeaponAvailable")]
	public bool SetWeapon(int weaponID, GearItem gi)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 26)]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "MaybeCancelZoomInternal")]
	[Calls(Type = typeof(vp_Timer), Member = "Cancel")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "UnJam")]
	[Calls(Type = typeof(vp_FPSShooter), Member = "Reload")]
	[Calls(Type = typeof(HUDManager), Member = "DisplayAmmoOnHUDForTime")]
	[Calls(Type = typeof(Inventory), Member = "GetAmmoAvailableForWeapon")]
	[Calls(Type = typeof(GunItem), Member = "NumRoundsInClip")]
	[Calls(Type = typeof(GunItem), Member = "NumRoundsInClip")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteReloadAction")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	public void Reload()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "MaybeCancelZoomInternal")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "ToggleZoom")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	public void CancelZoom()
	{
	}

	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "InputZoom")]
	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "HandleBearSpearInput")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "Reload")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "InputZoom")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "Update")]
	[Calls(Type = typeof(StoneItem), Member = "ZoomEnd")]
	[Calls(Type = typeof(BearSpearItem), Member = "OnEnter_Recovering")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GunItem), Member = "NumRoundsInClip")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "ReenableWeaponStatesIn")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "CancelZoom")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(GunItem), Member = "ZoomEnd")]
	private void MaybeCancelZoomInternal()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "CancelReload")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "InitializeStruggle")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public void CancelReload()
	{
	}

	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "EnableCrouch")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "EnableCrouchImmediate")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "CancelReload")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "InputZoom")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "InputZoom")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "Reload")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "CancelZoom")]
	[Calls(Type = typeof(vp_StateManager), Member = "SetState")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "HandleBearSpearInput")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "Update")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ExitDialogueMode")]
	[CallsUnknownMethods(Count = 24)]
	[Calls(Type = typeof(vp_StateManager), Member = "IsEnabled")]
	[CalledBy(Type = typeof(BowItem), Member = "ZoomStart")]
	[CalledBy(Type = typeof(BowItem), Member = "ZoomEnd")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "OnPlayInteractAnimation")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "DoOnInteractionComplete")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "Start")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "Start")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateTransitionIn")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(BowItem), Member = "PressFire")]
	[Calls(Type = typeof(vp_StateManager), Member = "IsEnabled")]
	[Calls(Type = typeof(vp_StateManager), Member = "SetState")]
	[CallerCount(Count = 18)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(vp_StateManager), Member = "IsEnabled")]
	[Calls(Type = typeof(vp_StateManager), Member = "IsEnabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(vp_StateManager), Member = "IsEnabled")]
	[Calls(Type = typeof(vp_StateManager), Member = "SetState")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(vp_StateManager), Member = "SetState")]
	public void SetState(string state, bool isEnabled)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerMovement), Member = "Start")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerIsSwingingFirstPersonItem")]
	[Calls(Type = typeof(vp_StateManager), Member = "IsEnabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 2)]
	public bool IsStateEnabled(string state)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_StateManager), Member = "IsEnabled")]
	[Calls(Type = typeof(vp_StateManager), Member = "SetState")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "Update")]
	[CallsUnknownMethods(Count = 9)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	public void UpdateSprintState()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(vp_Component), Member = "AllowStateRecursively")]
	public void AllowState(string state, bool isAllowed)
	{
	}

	[Calls(Type = typeof(vp_Timer), Member = "Cancel")]
	[Calls(Type = typeof(vp_Timer), Member = "In")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "CheckForFireRelease")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "SetWeapon")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "MaybeCancelZoomInternal")]
	[CallsUnknownMethods(Count = 8)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EquipItem")]
	[CallerCount(Count = 4)]
	public void ReenableWeaponStatesIn(float seconds)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(vp_StateManager), Member = "Reset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(vp_StateManager), Member = "Reset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(vp_StateManager), Member = "Reset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(vp_StateManager), Member = "Reset")]
	public void ResetState()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SwitchWeapon")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EquipItem")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponFromID")]
	public void SetWeaponAvailable(int weaponID, bool isAvailable)
	{
	}

	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "SetWeapon")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponFromID")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PlayerManager), Member = "EquipItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EquipItem")]
	public bool IsWeaponAvailable(int weaponID)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public void SetStrafingParameters(Vector3 strafingRightDirection, Vector3 strafingCenter, float strafingDistanceLimit)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Vector3 GetStrafingRightDirection()
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Vector3 GetStrafingCenter()
	{
		return default(Vector3);
	}

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public float GetStrafingDistanceLimit()
	{
		return default(float);
	}

	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "MaybeCancelZoomInternal")]
	[Calls(Type = typeof(BearSpearItem), Member = "OnEnter_Setting")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(BearSpearItem), Member = "DistanceToNearestSpearable")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "ToggleZoom")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	[Calls(Type = typeof(InputManager), Member = "GetFireReleased")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(InputManager), Member = "GetFirePressed")]
	[CallsUnknownMethods(Count = 23)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "InputZoom")]
	[CallsDeduplicatedMethods(Count = 3)]
	private void HandleBearSpearInput(PlayerManager pm)
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	private bool ShouldTurnOffZoom()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public vp_FPSPlayer()
	{
	}
}
