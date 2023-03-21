using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using NodeCanvas.Tasks.Conditions;
using TLD.Gameplay;
using TLD.GameplayTags;
using TLD.UI.Generics;
using UnityEngine;

public class PlayerStruggle : MonoBehaviour
{
	[Serializable]
	public class DamageEventTableOverride
	{
		public DamageEventTable_WildlifeType m_WildlifeType;

		public GameplayTag m_DamageEventTableTag;

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public DamageEventTableOverride()
		{
		}
	}

	[Serializable]
	public class SynchronizedAnimationInfo
	{
		public string m_AIStateName;

		[NonSerialized]
		public int m_AIStateHash;

		public string m_FPStateName;

		[NonSerialized]
		public int m_FPStateHash;

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		public void Initialize()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public SynchronizedAnimationInfo()
		{
		}
	}

	[Serializable]
	public class WeaponPicker
	{
		public float m_LaunchWeaponSelectionDelaySeconds;

		public float m_WeaponSelectionTimeScale;

		public float m_WeaponSelectionTimeSeconds;

		public float m_WeaponSelectionTimeScaleTransitionDuration;

		public string m_WeaponSelectionSlowdownAudio;

		public string m_ExitAudio;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public WeaponPicker()
		{
		}
	}

	public float m_NearClip;

	public float m_MaxBlurSize;

	public float m_TapIncrement;

	public float m_TapIncrementThatScalesWithFatigue;

	public float m_TapDecreasePerSecond;

	public float m_AccessibleStruggleTapsPerSecond;

	public float m_PlayerConditionLossPercentAfterBearAttack;

	public float m_PlayerConditionLossPercentAfterMooseAttack;

	public float m_WolfConditionLossPercentTap;

	public float m_FleeAtConditionThreshold;

	public float m_LayStunnedAfterBearAttackSeconds;

	public float m_LayStunnedAfterWolfAttackSeconds;

	public float m_ReturnCameraToStartTimeSeconds;

	public float m_BlendToAnimatedCameraTimeSeconds;

	public float m_StartDamageAfterSecondsWolf;

	public string m_StruggleWithWolfAudio;

	public string m_StruggleWithBearAudio;

	public string m_StruggleWithMooseAudio;

	public string m_BodyFallAudio;

	public string m_AtlasIconUnarmed;

	public float m_WolfDamagePerSecondToPlayer;

	public float m_WolfClothingDamagePerSecondMin;

	public float m_WolfClothingDamagePerSecondMax;

	public float m_BearClothingDamagePerSecondMin;

	public float m_BearClothingDamagePerSecondMax;

	public float m_FleeChanceOnHit;

	public float m_FleeChanceOnRevolverShot;

	public float m_GracePeriodAfterStruggleInSeconds;

	public float m_DegradeOnUseFrequencySeconds;

	public string m_PlayMauledMuffleAudioId;

	public string m_StopMauledMuffleAudioId;

	public bool m_ShowDebugText;

	public float m_SecondsSinceLastStruggle;

	public int m_AnimParameter_Dead;

	public int m_AnimParameter_KnockedOut;

	public int m_AnimParameter_GetUp;

	public int m_AnimParameter_SkipGetUp;

	public int m_AnimParameter_IsDragging;

	public int m_AnimParameter_StruggleHeight;

	private int m_AnimParameter_SpearExhaustedGetUp;

	public BaseAi m_PartnerBaseAi;

	private GameObject m_PartnerCameraBone;

	private GameObject m_PartnerEffectsBone;

	private GameObject m_OverrideOrigin;

	private Animator m_OverrideAnimator;

	private GameObject m_OverrideGameCamera;

	private GameObject m_OverrideEffectsBone;

	private bool m_KnockedOut;

	private bool m_Active;

	private bool m_SystemEnabled;

	private float m_AttachTimeSeconds;

	private float m_DetatchTimeSeconds;

	private float m_LayingStunnedSeconds;

	private float m_StartCameraFOV;

	private Vector3 m_StartCameraPos;

	private Quaternion m_StartCameraRotation;

	private Vector3 m_OriginalCameraPos;

	private Vector3 m_OriginalPlayerPos;

	private Quaternion m_OriginalPlayerRotation;

	private Quaternion m_OriginalCameraRotation;

	private float m_StruggleEndCameraFOV;

	private Vector3 m_StruggleEndCameraPos;

	private Quaternion m_StruggleEndCameraRotation;

	private StruggleCameraMode m_StruggleCameraMode;

	private uint m_StrugglePredatorAudioId;

	private float m_StruggleTimeSeconds;

	private float m_DegradeTimeSeconds;

	private bool m_PartnerWillFightUntilDead;

	private float m_SavedNearClip;

	private GearItem m_WeaponUsed;

	private float m_WolfClothingDamagePerSecond;

	private float m_BearClothingDamagePerSecond;

	private uint m_ClothesTearingAudioId;

	private float m_VoiceVolumeToRestore;

	private float m_HPBeforeStruggle;

	private float m_TapBarNormalized;

	private UILabel m_DebugTextLabel;

	public float m_SecondsPerAttackMin;

	public float m_SecondsPerAttackMax;

	private float m_NextAttackTime;

	public int m_DazedDropItemsMin;

	public int m_DazedDropItemsMax;

	public float m_DazedDropItemsRadiusMin;

	public float m_DazedDropItemsRadiusMax;

	public int m_NormalizedPlayerConditionForDeathOnFirstAttack;

	public List<SynchronizedAnimationInfo> m_WolfStruggleSynchronizedAnimationInfoList;

	private float m_HPNormalizedBeforeStruggle;

	private int m_Struggle_Button_Key_Sprite_OriginalWidth;

	private int m_Struggle_Button_Key_Feedback_OriginalWidth;

	public float m_WolfStruggleLengthMax;

	public float m_WolfBleedoutMinutes;

	private int m_TapCount;

	private GearItem m_ItemInHandsAtStruggleStart;

	private PanelReference<Panel_HUD> m_HUD;

	private PanelReference<Panel_WeaponPicker> m_WeaponPickerPanel;

	public List<DamageEventTableOverride> m_DamageEventOverrides;

	private List<uint> m_StruggleAudioIds;

	private bool m_CrouchDisabled;

	private PlayerAnimation.CameraLayer m_CameraLayerBeforeStruggle;

	private BearSpearItem m_BearSpearItem;

	private bool m_IsInSpearStruggle;

	private bool m_HasStartedAcceleratingTimeWhileStunned;

	private BearSpearStruggleOutcome m_BearSpearStruggleOutcome;

	private bool m_HasDisengagedSpearStruggle;

	private BearHuntReduxSettings m_BearHuntReduxSettings;

	private bool m_CanDropItems;

	private float m_PressHoldStoredTimeSeconds;

	public float m_RevolverEquippedFirePercent;

	public float m_RevolverWeaponSwitchFirePercent;

	private float m_AllowedToFirePercent;

	private bool m_AllowedToFire;

	public GameObject m_RevolverMuzzleFlash;

	private bool m_IsHunted2Dragging;

	private bool m_SynchronizeAnimationRequested;

	public WeaponPicker m_WeaponPicker;

	private float m_ShowPickerTimer;

	private float m_PreviousTimeScaleFactor;

	private float m_TimeScalingFadingTimer;

	private float m_TimeScaledDownTimer;

	private float m_StruggleTimeScaleFactor;

	private uint m_WeaponSelectionSlowdownAudioId;

	private bool m_ShowPickerRequested;

	private bool m_ChangeWeaponRequested;

	private bool m_TimeScalingFadeOutRequested;

	private List<GearItem> m_ListItems;

	private GearItem m_WeaponPicked;

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(StruggleMeshTable), Member = "GetMesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowStruggleWidget")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowStruggleRevolverWidget")]
	[Calls(Type = typeof(PlayerStruggle), Member = "DamageEventsInitialize")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraEffects), Member = "BlurSetSize")]
	public void Start()
	{
	}

	[Calls(Type = typeof(GearItem), Member = "DegradeOnUse")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void DegradeToolOnUse()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	public void OnMooseButtHeadAttackComplete()
	{
	}

	[Calls(Type = typeof(PlayerStruggle), Member = "UpdateTapBar")]
	[Calls(Type = typeof(PlayerStruggle), Member = "UpdateWolf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerStruggle), Member = "ApplyPlayerDamagePerSecond")]
	[Calls(Type = typeof(PlayerStruggle), Member = "MaybeReceiveAIAttack")]
	[Calls(Type = typeof(PlayerStruggle), Member = "ApplyClothingDamagePerSecond")]
	[Calls(Type = typeof(PlayerStruggle), Member = "UpdateTapInput")]
	[Calls(Type = typeof(PlayerStruggle), Member = "HandleTimeSlowdownFadeout")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowStruggleWidget")]
	[Calls(Type = typeof(PlayerStruggle), Member = "HasFilledStruggleTapBar")]
	[Calls(Type = typeof(PlayerStruggle), Member = "SetStartCameraRotationToLookAtPartner")]
	[Calls(Type = typeof(PlayerStruggle), Member = "DoChangeWeapon")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerStruggle), Member = "HandleShowPickerRequested")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowStruggleWidget")]
	[Calls(Type = typeof(GearItem), Member = "DegradeOnUse")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(PlayerStruggle), Member = "UpdateKeyBindingLabels")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(PlayerStruggle), Member = "MaybeBreakStruggle")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerStruggle), Member = "BashCameraReturnToStart")]
	[Calls(Type = typeof(PlayerStruggle), Member = "BashGetupDelayCamera")]
	[Calls(Type = typeof(PlayerStruggle), Member = "BashCameraInterpolateToPartner")]
	[Calls(Type = typeof(PlayerStruggle), Member = "UpdateFadeAndBlur")]
	[Calls(Type = typeof(PlayerStruggle), Member = "UpdateVoiceVolume")]
	[Calls(Type = typeof(PlayerStruggle), Member = "OnPlayerDeath")]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerStruggle), Member = "UpdatePlayerTransformForHunted2Dragging")]
	[Calls(Type = typeof(PlayerStruggle), Member = "SynchronizePartnerAnimation")]
	public void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	public void SetCanDropItems(bool canDropItems)
	{
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	private void OnBearSpearDisengage()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowStruggleWidget")]
	[Calls(Type = typeof(PlayerStruggle), Member = "HasFilledStruggleTapBar")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowStruggleWidget")]
	[Calls(Type = typeof(PlayerStruggle), Member = "UpdateTapBar")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerStruggle), Member = "UpdateTapInput")]
	private void UpdateSpear(Panel_HUD hud)
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "Update")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateWolf")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateSpear")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetStruggleTapPressed")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	private void UpdateTapInput(Action tapAction)
	{
	}

	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Update")]
	[Calls(Type = typeof(PlayerStruggle), Member = "MaybeEnableStaminaRecharge")]
	[Calls(Type = typeof(CameraEffects), Member = "BlurSetSize")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Restore")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Restore")]
	[Calls(Type = typeof(PlayerStruggle), Member = "StopAllAudio")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowStruggleWidget")]
	[Calls(Type = typeof(DamageEventTable), Member = "FadeOutEventUi")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerStruggle), Member = "GetDamageEventTable")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RumbleEffectManager), Member = "StopEffect")]
	private void OnPlayerDeath(Panel_HUD hud)
	{
	}

	[Calls(Type = typeof(InputManager), Member = "GetButtonNameForAction")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[CalledBy(Type = typeof(Action_ScrapMetalStruggle), Member = "UpdateStruggle")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Update")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "GetButtonIcon")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "GetButtonIcon")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(InputManager), Member = "GetButtonNameForAction")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	public void UpdateKeyBindingLabels()
	{
	}

	[Calls(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Update")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[Calls(Type = typeof(PlayerStruggle), Member = "OnPlayerDazed")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetFloat")]
	[Calls(Type = typeof(PlayerStruggle), Member = "UpdateTapInput")]
	[Calls(Type = typeof(PlayerStruggle), Member = "MaybeReceiveAIAttack")]
	[Calls(Type = typeof(PlayerStruggle), Member = "ApplyClothingDamagePerSecond")]
	[Calls(Type = typeof(PlayerStruggle), Member = "ApplyPlayerDamagePerSecond")]
	[Calls(Type = typeof(PlayerStruggle), Member = "UpdateTapBar")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerStruggle), Member = "MaybeShootRevolver")]
	private void UpdateWolf(Panel_HUD hud)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PlayerStruggle), Member = "MaybeReceiveAIAttack")]
	[Calls(Type = typeof(PlayerStruggle), Member = "ApplyClothingDamagePerSecond")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerStruggle), Member = "ApplyPlayerDamagePerSecond")]
	private void UpdateBear()
	{
	}

	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[Calls(Type = typeof(PlayerStruggle), Member = "OnPlayerDazed")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	private void WolfStruggleTimedOut()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowStruggleWidget")]
	[CallsUnknownMethods(Count = 1)]
	private void BearSpearStruggleTimedOut(Panel_HUD hud)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowStruggleWidget")]
	[CallsUnknownMethods(Count = 1)]
	private void BearSpearStruggleSuccess(Panel_HUD hud)
	{
	}

	[CallerCount(Count = 0)]
	public BearSpearStruggleOutcome GetBearSpearStruggleOutcome()
	{
		return default(BearSpearStruggleOutcome);
	}

	[CallerCount(Count = 0)]
	public void EnableSystem(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool IsSystemEnabled()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsUnknownMethods(Count = 2)]
	public bool CanStruggle()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerStruggle), Member = "WeaponPickerBegin")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetCameraLayer")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ShowHands")]
	[Calls(Type = typeof(PlayerAnimation), Member = "EnableWeapon")]
	[Calls(Type = typeof(AnimationUtils), Member = "HasParameter")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(RumbleEffectManager), Member = "PlayEffect")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(PlayerStruggle), Member = "MaybeDisableStaminaRecharge")]
	[Calls(Type = typeof(PlayerStruggle), Member = "RetrieveBearHuntReduxSettings")]
	[Calls(Type = typeof(PlayerStruggle), Member = "MaybeApplyStaminaCost")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Save")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "FullReset")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Save")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "FullReset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 31)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CharcoalItem), Member = "CancelDetailSurvey")]
	[Calls(Type = typeof(PlayerStruggle), Member = "PrepareStruggle")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "InterruptAnyInProgressAnimations")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetTrigger")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(PassTime), Member = "End")]
	[Calls(Type = typeof(PlayerStruggle), Member = "InitializeStruggle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "MaybeResetCurrentWeapon")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipImmediate")]
	[Calls(Type = typeof(PlayerAnimation), Member = "DropCurrentItemInHand")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(GearItem), Member = "StickToGroundAtPlayerFeet")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetTrigger")]
	[Calls(Type = typeof(GearItem), Member = "IsLitLamp")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "ToggleZoom")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateHipAndShoulderOffsetLayerWeigth")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Reset")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHandsSkipAnimation")]
	[Calls(Type = typeof(PlayerAnimation), Member = "HideHands")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	[Calls(Type = typeof(BodyCarry), Member = "Drop")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "Drop")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlashlight")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void Begin(GameObject partner)
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BeginSpearStruggle")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowStruggleRevolverWidget")]
	[Calls(Type = typeof(Panel_HUD), Member = "SetStruggleBarFillAmount")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(PlayerStruggle), Member = "ResetDamageEvents")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(PlayerManager), Member = "CancelItemInHandsAction")]
	[Calls(Type = typeof(SnowShelterManager), Member = "ExitShelterDueToStruggle")]
	[Calls(Type = typeof(LeanToManager), Member = "ExitShelterDueToStruggle")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "CancelReload")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "EnableCrouchImmediate")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 2)]
	private void InitializeStruggle(GameObject partner)
	{
	}

	[Calls(Type = typeof(Panel_HUD), Member = "ShowStruggleWidget")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowStruggleWidget")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "PrepareStruggle")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowStruggleWidget")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallerCount(Count = 1)]
	private void InitStruggleForPartner(GameObject partner)
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BeginSpearStruggle")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[Calls(Type = typeof(vp_FPSController), Member = "Stop")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(PlayerStruggle), Member = "InitStruggleForPartner")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	private void PrepareStruggle(GameObject partner)
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(BaseAi), Member = "OnSpearHit")]
	[Calls(Type = typeof(PlayerStruggle), Member = "MaybeApplyStaminaCost")]
	[Calls(Type = typeof(PlayerStruggle), Member = "MaybeDisableStaminaRecharge")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowStruggleWidget")]
	[Calls(Type = typeof(RumbleEffectManager), Member = "PlayEffect")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ShowHands")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(PlayerStruggle), Member = "PrepareStruggle")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateHipAndShoulderOffsetLayerWeigth")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetCameraLayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerStruggle), Member = "RetrieveBearHuntReduxSettings")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerStruggle), Member = "InitializeStruggle")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	public void BeginSpearStruggle(GameObject partner, bool isFatal)
	{
	}

	[CallerCount(Count = 0)]
	public bool IsControllingCamera()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "SpearTap")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "WolfTap")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	private void DoTap()
	{
	}

	[CallerCount(Count = 0)]
	private bool WaitingToRecover()
	{
		return default(bool);
	}

	[Calls(Type = typeof(BaseAi), Member = "ApplyDamage")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(PlayerStruggle), Member = "GetFleeChanceOnHitPercent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerStruggle), Member = "MakePartnerFlee")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerStruggle), Member = "DoTap")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void WolfTap()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerStruggle), Member = "DoTap")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private void SpearTap()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	public void OnTweenComplete()
	{
	}

	[CallerCount(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetupDamageForAnim")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[CalledBy(Type = typeof(PackManager), Member = "CanAttack")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "Update")]
	[CalledBy(Type = typeof(GearItem), Member = "WearOut")]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "DidFallThroughIceFadeOut")]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "ExitStruggleIfActive")]
	[CalledBy(Type = typeof(Condition_IsPlayerInStrugglee), Member = "OnCheck")]
	public bool InStruggle()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool IsInBearSpearStruggle()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_PlayerStunned_Begin")]
	[CalledBy(Type = typeof(Condition), Member = "GetCauseOfDeathStringUntranslated")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool InStruggleWithMoose()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_HUD), Member = "ShouldHideConditionRelatedLabels")]
	[CalledBy(Type = typeof(BloodLossEvent), Member = "OnExecute")]
	[CalledBy(Type = typeof(SprainedWristEvent), Member = "OnExecute")]
	[CalledBy(Type = typeof(SprainedAnkleEvent), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Condition), Member = "GetCauseOfDeathStringUntranslated")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(RiskOfInfectionEvent), Member = "OnExecute")]
	public bool InStruggleWIthBear()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool InFinalAmbushStruggleWIthBear()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(SprainedWristEvent), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "SelectGridItem")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "MaybeSelectGear")]
	[CalledBy(Type = typeof(BloodLossEvent), Member = "OnExecute")]
	[CalledBy(Type = typeof(SprainedAnkleEvent), Member = "OnExecute")]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(StatusBar), Member = "ShouldBeHidden")]
	[CalledBy(Type = typeof(Condition), Member = "GetCauseOfDeathStringUntranslated")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(RiskOfInfectionEvent), Member = "OnExecute")]
	public bool InStruggleWIthWolf()
	{
		return default(bool);
	}

	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "ExitStruggleIfActive")]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "DidFallThroughIceFadeOut")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "MaybeBreakStruggle")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "MaybeBreakStruggle")]
	[Calls(Type = typeof(BaseAi), Member = "FleeFrom")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "WolfTap")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void MakePartnerFlee()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "WolfStruggleTimedOut")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateWolf")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnBearBreakStruggle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Inventory), Member = "DropAndScatterItems")]
	public void OnPlayerDazed()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void LogEvent(string eventString)
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	public void PlayStruggleAudio(string audioEventName)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	public void PlayStruggleAudioOneShot(string audioEventName)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CalledBy(Type = typeof(Condition), Member = "AddHealth")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShouldHideConditionRelatedLabels")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsBlackedOutAfterStruggle()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 20)]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Restore")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Restore")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateHipAndShoulderOffsetLayerWeigth")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetCameraLayer")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashCameraReturnToStart")]
	[Calls(Type = typeof(PlayerManager), Member = "EquipItem")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_Struggle_GetUp_Complete")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BeginReturnToStart")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "OnDestroy")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateCameraRotation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[Calls(Type = typeof(PlayerStruggle), Member = "ResetGameSettingsToNormal")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(PlayerStruggle), Member = "GetDamageEventTable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DamageEventTable), Member = "FadeOutEventUi")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerStruggle), Member = "StopAllAudio")]
	public void GetUpAnimationComplete()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_PlayerStunned_Begin")]
	[CallsUnknownMethods(Count = 1)]
	public float GetStunnedDurationFromParter()
	{
		return default(float);
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void PlayMauledMuffle()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 1)]
	public void StopMauledMuffle()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "GetUpAnimationComplete")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "OnPlayerDeath")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	private void StopAllAudio()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashCamera")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashCamera")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashCamera")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 2)]
	private void UpdateVoiceVolume()
	{
	}

	[Calls(Type = typeof(CameraEffects), Member = "BlurSetSize")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashCamera")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashCameraReturnToStart")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Update")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(CameraFade), Member = "BashFadeAlpha")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	private void UpdateFadeAndBlur(GameObject EffectsBone)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "IsAttachedToPartner")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashCameraInterpolateToPartner")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "HandleShowPickerRequested")]
	private float GetAttachBlendTime()
	{
		return default(float);
	}

	[Calls(Type = typeof(PlayerStruggle), Member = "GetAttachBlendTime")]
	[CallerCount(Count = 0)]
	public bool IsAttachedToPartner()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashCamera")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Update")]
	[Calls(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[Calls(Type = typeof(Utils), Member = "SetCameraFOVSafe")]
	[CallsUnknownMethods(Count = 23)]
	[Calls(Type = typeof(PlayerStruggle), Member = "GetOverrideGameCameraPosition")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(PlayerStruggle), Member = "GetAttachBlendTime")]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	private void BashCameraInterpolateToPartner()
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashCameraInterpolateToPartner")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashGetupDelayCamera")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashCameraReturnToStart")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashCameraReturnToStart")]
	[CallsUnknownMethods(Count = 9)]
	private Vector3 GetOverrideGameCameraPosition()
	{
		return default(Vector3);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashCameraReturnToStart")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BeginReturnToStart")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool ShouldUseSpearExhaustedGetUp()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashGetupDelayCamera")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashGetupDelayCamera")]
	[Calls(Type = typeof(PlayerStruggle), Member = "IsHuntedBear2ChallengeEnd")]
	[Calls(Type = typeof(PlayerStruggle), Member = "ShouldUseSpearExhaustedGetUp")]
	[Calls(Type = typeof(PlayerStruggle), Member = "GetUpAnimationComplete")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipImmediate")]
	[Calls(Type = typeof(PlayerStruggle), Member = "ApplyDamageAfterMooseAttack")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Quaternion), Member = "set_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerStruggle), Member = "IsHuntedBear2ChallengeEnd")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void BeginReturnToStart(BaseAi bai)
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "LateUpdate")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Utils), Member = "GetOrientationOnSlope")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	private void UpdatePlayerTransformForHunted2Dragging()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(BaseAi), Member = "IsTimberwolf")]
	[Calls(Type = typeof(BaseAi), Member = "IsTimberwolf")]
	[CallsUnknownMethods(Count = 1)]
	private bool CanBeStunned()
	{
		return default(bool);
	}

	[Calls(Type = typeof(PlayerStruggle), Member = "BeginReturnToStart")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Update")]
	[Calls(Type = typeof(CameraFade), Member = "BashFadeAlpha")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(PlayerStruggle), Member = "GetOverrideGameCameraPosition")]
	[Calls(Type = typeof(Utils), Member = "SetCameraFOVSafe")]
	[Calls(Type = typeof(TimeOfDay), Member = "AccelerateTime")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashCamera")]
	[Calls(Type = typeof(BaseAi), Member = "IsTimberwolf")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "IsTimberwolf")]
	[Calls(Type = typeof(PlayerStruggle), Member = "BeginReturnToStart")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	private void BashGetupDelayCamera()
	{
	}

	[CallsUnknownMethods(Count = 21)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashCamera")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Update")]
	[Calls(Type = typeof(PlayerStruggle), Member = "GetOverrideGameCameraPosition")]
	[Calls(Type = typeof(PlayerStruggle), Member = "UpdateFadeAndBlur")]
	[Calls(Type = typeof(PlayerStruggle), Member = "GetUpAnimationComplete")]
	[Calls(Type = typeof(Utils), Member = "SetCameraFOVSafe")]
	[Calls(Type = typeof(PlayerStruggle), Member = "ShouldUseSpearExhaustedGetUp")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerStruggle), Member = "GetOverrideGameCameraPosition")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	private void BashCameraReturnToStart()
	{
	}

	[Calls(Type = typeof(PlayerStruggle), Member = "BashCameraInterpolateToPartner")]
	[Calls(Type = typeof(PlayerStruggle), Member = "UpdateVoiceVolume")]
	[Calls(Type = typeof(PlayerStruggle), Member = "UpdateFadeAndBlur")]
	[Calls(Type = typeof(PlayerStruggle), Member = "UpdateVoiceVolume")]
	[Calls(Type = typeof(PlayerStruggle), Member = "UpdateVoiceVolume")]
	[Calls(Type = typeof(PlayerStruggle), Member = "BashCameraReturnToStart")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerStruggle), Member = "BashGetupDelayCamera")]
	private void BashCamera()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_HUD), Member = "SetStruggleBarFillAmount")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Update")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateSpear")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateWolf")]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateTapBar(Panel_HUD hud)
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "MaybeBreakStruggle")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ShouldBreakStruggle")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Update")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateSpear")]
	private bool HasFilledStruggleTapBar()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInShelter")]
	[Calls(Type = typeof(PlayerStruggle), Member = "HasFilledStruggleTapBar")]
	[CallsUnknownMethods(Count = 5)]
	private bool ShouldBreakStruggle()
	{
		return default(bool);
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Update")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(PlayerStruggle), Member = "MakePartnerFlee")]
	[Calls(Type = typeof(PlayerStruggle), Member = "MakePartnerFlee")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerStruggle), Member = "HasFilledStruggleTapBar")]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInShelter")]
	[Calls(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	private void MaybeBreakStruggle()
	{
	}

	[Calls(Type = typeof(InputManager), Member = "GetAltFire")]
	[Calls(Type = typeof(InputManager), Member = "GetReloadPressed")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	private bool GetCustomFireInput()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateWolf")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowStruggleWidget")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetStruggleRevolverFired")]
	[Calls(Type = typeof(InputManager), Member = "GetReloadPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetAltFire")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowStruggleRevolverWidget")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GunItem), Member = "NumRoundsInClip")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowStruggleRevolverWidget")]
	private void MaybeShootRevolver()
	{
	}

	[Calls(Type = typeof(Skill_Revolver), Member = "GetStruggleBonus")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillRevolver")]
	[Calls(Type = typeof(BaseAi), Member = "ApplyDamage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(GunItem), Member = "StruggleRevolverFire")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void OnRevolverFired()
	{
	}

	[Calls(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[CallerCount(Count = 0)]
	private void OnRevolverFiredComplete()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	private void SetStartCameraRotationToLookAtPartner()
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	public float GetHeightOffset()
	{
		return default(float);
	}

	[Calls(Type = typeof(BloodTrail), Member = "LeaveStruggleBloodStain")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(Utils), Member = "SendGameplayAnalyticsEvent")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Restore")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Restore")]
	[Calls(Type = typeof(RumbleEffectManager), Member = "StopEffect")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "MaybeBreakStruggle")]
	[Calls(Type = typeof(PlayerStruggle), Member = "MaybeEnableStaminaRecharge")]
	[Calls(Type = typeof(GameManager), Member = "TriggerSurvivalSaveAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnSpearStruggleEnd")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnAnimationEvent_MooseButtHeadAttackComplete")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "OnMooseButtHeadAttackComplete")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateWolf")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "WolfStruggleTimedOut")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "MakePartnerFlee")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashCameraInterpolateToPartner")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "OnRevolverFiredComplete")]
	[Calls(Type = typeof(PlayerStruggle), Member = "StopAllAudio")]
	[Calls(Type = typeof(BearHuntRedux), Member = "OnBearSpearOutcome")]
	[Calls(Type = typeof(CameraEffects), Member = "BlurSetSize")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(Inventory), Member = "DropAndScatterItems")]
	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 20)]
	[Calls(Type = typeof(PlayerAnimation), Member = "HideHands")]
	[Calls(Type = typeof(PlayerAnimation), Member = "DisableWeapon")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "Enable")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowStruggleWidget")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(PlayerStruggle), Member = "ApplyBearDamageAfterStruggleEnds")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnDamage")]
	[Calls(Type = typeof(PlayerStruggle), Member = "GetHeightOffset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerStruggle), Member = "GetHeightOffset")]
	[Calls(Type = typeof(PlayerStruggle), Member = "GetHeightOffset")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void BreakStruggle()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[CallsUnknownMethods(Count = 1)]
	public void SpearDisengageReady()
	{
	}

	[Calls(Type = typeof(Panel_ChallengeComplete), Member = "ShowPanel")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void WinHunted2Challenge()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BloodLoss), Member = "BloodLossStart")]
	[Calls(Type = typeof(BloodLoss), Member = "GetLocation")]
	[Calls(Type = typeof(InfectionRisk), Member = "InfectionRiskStart")]
	[CallsUnknownMethods(Count = 4)]
	private void BearFadeFinish()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "DoChangeWeapon")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "WeaponPickerBegin")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	private void SetWeaponIcon(Panel_HUD hud)
	{
	}

	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateBear")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateWolf")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Update")]
	[Calls(Type = typeof(AiDifficultySetting), Member = "GetStrugglePlayerDamageReceivedScale")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetStrugglePlayerDamageReceivedScale")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void ApplyPlayerDamagePerSecond(float damagePerSecond, DamageSource damageCause)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateBear")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateWolf")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Update")]
	[Calls(Type = typeof(PlayerManager), Member = "ApplyDamageToWornClothing")]
	[Calls(Type = typeof(AiDifficultySetting), Member = "GetStrugglePlayerClothingDamageScale")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetStrugglePlayerClothingDamageScale")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void ApplyClothingDamagePerSecond(float damagePerSecond)
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ApplyMooseDamageAfterStruggleEnds")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BeginReturnToStart")]
	[Calls(Type = typeof(BrokenRib), Member = "BrokenRibStart")]
	[Calls(Type = typeof(DamageProtection), Member = "GetTotalBrokenRibModifier")]
	[Calls(Type = typeof(DamageProtection), Member = "GetTotalAnimalDamageModifier")]
	[Calls(Type = typeof(PlayerManager), Member = "GetDamageReductionFromExteriorClothing")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetStugglePlayerPercentLossFromBearScale")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private void ApplyDamageAfterMooseAttack(string causeLocId)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerStruggle), Member = "ApplyDamageAfterMooseAttack")]
	private void ApplyMooseDamageAfterStruggleEnds()
	{
	}

	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IsHuntedBear")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IncrementWaypoint")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(BearHuntRedux), Member = "OnBearSpearOutcome")]
	[Calls(Type = typeof(InfectionRisk), Member = "InfectionRiskStart")]
	[Calls(Type = typeof(BloodLoss), Member = "GetLocation")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[Calls(Type = typeof(BloodLoss), Member = "BloodLossStart")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetStugglePlayerPercentLossFromBearScale")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(DamageProtection), Member = "GetTotalAnimalDamageModifier")]
	[Calls(Type = typeof(PlayerManager), Member = "GetDamageReductionFromExteriorClothing")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetStugglePlayerPercentLossFromBearScale")]
	[Calls(Type = typeof(PlayerStruggle), Member = "RetrieveBearHuntReduxSettings")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "DisableCharacterController")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	private void ApplyBearDamageAfterStruggleEnds()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "GetUpAnimationComplete")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ShowHands")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(Utils), Member = "SetCameraFOVSafe")]
	[Calls(Type = typeof(CameraFade), Member = "BashFadeAlpha")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CameraEffects), Member = "BlurSetSize")]
	private void ResetGameSettingsToNormal()
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateDebugText()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "MaybeReceiveAIAttack")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	private float GetNextAttackTime()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateBear")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Update")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup")]
	[Calls(Type = typeof(PlayerStruggle), Member = "GetNextAttackTime")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateWolf")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(DamageEventTable), Member = "MaybeApplyAttack")]
	[Calls(Type = typeof(PlayerStruggle), Member = "GetActiveDamageEventTable")]
	[Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private void MaybeReceiveAIAttack()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "GetActiveDamageEventTable")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "GetActiveDamageEventTable")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "DamageEventsInitialize")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "DamageEventsInitialize")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ResetDamageEvents")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ResetDamageEvents")]
	[Calls(Type = typeof(ExperienceMode), Member = "GetDamageEventTable")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "OnPlayerDeath")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "GetUpAnimationComplete")]
	private DamageEventTable GetDamageEventTable(GameplayTag tag)
	{
		return null;
	}

	[Calls(Type = typeof(DamageEventTable), Member = "Reset")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "InitializeStruggle")]
	[Calls(Type = typeof(PlayerStruggle), Member = "GetDamageEventTable")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(PlayerStruggle), Member = "GetDamageEventTable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void ResetDamageEvents()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(DamageEventTable), Member = "Initialize")]
	[Calls(Type = typeof(PlayerStruggle), Member = "GetDamageEventTable")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Start")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerStruggle), Member = "GetDamageEventTable")]
	[Calls(Type = typeof(DamageEventTable), Member = "Initialize")]
	[CallerCount(Count = 1)]
	private void DamageEventsInitialize()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "MaybeReceiveAIAttack")]
	[Calls(Type = typeof(PlayerStruggle), Member = "GetDamageEventTable")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ReceiveAIAttack")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerStruggle), Member = "GetDamageEventTable")]
	private DamageEventTable GetActiveDamageEventTable()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerStruggle), Member = "GetActiveDamageEventTable")]
	[Calls(Type = typeof(DamageEventTable), Member = "MaybeApplyAttack")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 1)]
	private bool ReceiveAIAttack()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Quaternion), Member = "set_eulerAngles")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerStruggle), Member = "IsHuntedBear2ChallengeEnd")]
	[CallerCount(Count = 0)]
	private bool ShouldPlayDraggingAnimation(BaseAi bai, ref Quaternion overrideRotation)
	{
		return default(bool);
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IsHuntedBear")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BeginReturnToStart")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BeginReturnToStart")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ShouldPlayDraggingAnimation")]
	[CallsUnknownMethods(Count = 1)]
	private bool IsHuntedBear2ChallengeEnd()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "WolfTap")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Skill_Revolver), Member = "GetStruggleBonus")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetSkillRevolver")]
	private float GetFleeChanceOnHitPercent()
	{
		return default(float);
	}

	[Calls(Type = typeof(Skill_Revolver), Member = "GetStruggleBonus")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetSkillRevolver")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	public float GetFleeChanceOnRevolverShotPercent()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	private bool IsBearSpearOutcomeSuccess()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ApplyBearDamageAfterStruggleEnds")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BeginSpearStruggle")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private BearHuntReduxSettings RetrieveBearHuntReduxSettings()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerStruggle), Member = "GetUpAnimationComplete")]
	private void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "BeginSpearStruggle")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerMovement), Member = "AddSprintStamina")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	private void MaybeApplyStaminaCost(float staminaCost)
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "BeginSpearStruggle")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CallerCount(Count = 2)]
	private void MaybeDisableStaminaRecharge()
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "OnPlayerDeath")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	private void MaybeEnableStaminaRecharge()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Animator), Member = "PlayInFixedTime")]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "LateUpdate")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	private void SynchronizePartnerAnimation()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Animator), Member = "PlayInFixedTime")]
	[CallsUnknownMethods(Count = 2)]
	private void SynchronizeAnimationState(AnimatorStateInfo partnerAnimatorStateInfo, AnimatorStateInfo fpAnimatorStateInfo, int partnerHash, int fpHash)
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "MaybeSelectGear")]
	public void OnWeaponPicked(GearItem gearItem)
	{
	}

	[CallerCount(Count = 0)]
	private void InitWeaponPicker()
	{
	}

	[CallerCount(Count = 0)]
	private void ResetWeaponPicker()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayerStruggle), Member = "HandleTimeSlowdownFadeout")]
	[Calls(Type = typeof(PlayerStruggle), Member = "HandleShowPickerRequested")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerStruggle), Member = "DoChangeWeapon")]
	[CallerCount(Count = 0)]
	private void UpdateWeaponSelection()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[Calls(Type = typeof(PlayerStruggle), Member = "SetWeaponIcon")]
	[Calls(Type = typeof(Inventory), Member = "GetBestStuggleBonusItem")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "GetPrioritizedWeaponList")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowStruggleWidget")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	private void WeaponPickerBegin()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PlayerStruggle), Member = "GetAttachBlendTime")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "Enable")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Update")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateWeaponSelection")]
	[CallsUnknownMethods(Count = 3)]
	private void HandleShowPickerRequested()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetWeaponTypeSwitch")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	private void PlayPickerExitAudio()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "Enable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetWeaponTypeSwitch")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "HandleTimeSlowdownFadeout")]
	[CallsUnknownMethods(Count = 1)]
	private void OnShowPickerEnded(bool isPickerEnabled)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Update")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateWeaponSelection")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(PlayerStruggle), Member = "OnShowPickerEnded")]
	[CallerCount(Count = 2)]
	private void HandleTimeSlowdownFadeout()
	{
	}

	[Calls(Type = typeof(PlayerStruggle), Member = "DoChangeWeapon")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void HandleChangeWeaponFadein()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "Enable")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeInterruptPicker()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "HandleChangeWeaponFadein")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateWeaponSelection")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Update")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowStruggleWidget")]
	[Calls(Type = typeof(AnimationUtils), Member = "HasParameter")]
	[Calls(Type = typeof(PlayerAnimation), Member = "EnableWeapon")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(PlayerStruggle), Member = "SetWeaponIcon")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	private void DoChangeWeapon()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "Enable")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void ShowPicker()
	{
	}

	[CallerCount(Count = 0)]
	private bool IsWeaponPickerSelectionPending()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public PlayerStruggle()
	{
	}
}
