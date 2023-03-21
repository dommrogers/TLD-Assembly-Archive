using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using NodeCanvas.Tasks.Conditions;
using TLD.Gameplay;
using TLD.GameplayTags;
using TLD.SaveState;
using TLD.UI.Generics;
using UnityEngine;

public class PlayerStruggle : MonoBehaviour
{
	[Serializable]
	public class DamageEventTableOverride
	{
		public DamageEventTable_WildlifeType m_WildlifeType;

		public GameplayTag m_DamageEventTableTag;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerStruggle), Member = "DamageEventsInitialize")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowStruggleRevolverWidget")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowStruggleWidget")]
	[Calls(Type = typeof(CameraEffects), Member = "BlurSetSize")]
	[Calls(Type = typeof(StruggleMeshTable), Member = "GetMesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 14)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearItem), Member = "DegradeOnUse")]
	[CallsUnknownMethods(Count = 1)]
	private void DegradeToolOnUse()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	public void OnMooseButtHeadAttackComplete()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerStruggle), Member = "UpdateKeyBindingLabels")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(PanelReference<>), Member = "GetPanel")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerStruggle), Member = "OnPlayerDeath")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerStruggle), Member = "BashCameraReturnToStart")]
	[Calls(Type = typeof(PlayerStruggle), Member = "BashGetupDelayCamera")]
	[Calls(Type = typeof(PlayerStruggle), Member = "BashCameraInterpolateToPartner")]
	[Calls(Type = typeof(PlayerStruggle), Member = "UpdateFadeAndBlur")]
	[Calls(Type = typeof(PlayerStruggle), Member = "UpdateVoiceVolume")]
	[Calls(Type = typeof(GearItem), Member = "DegradeOnUse")]
	[Calls(Type = typeof(PlayerStruggle), Member = "MaybeBreakStruggle")]
	[Calls(Type = typeof(PlayerStruggle), Member = "UpdateWolf")]
	[Calls(Type = typeof(PlayerStruggle), Member = "ApplyPlayerDamagePerSecond")]
	[Calls(Type = typeof(PlayerStruggle), Member = "MaybeReceiveAIAttack")]
	[Calls(Type = typeof(PlayerStruggle), Member = "ApplyClothingDamagePerSecond")]
	[Calls(Type = typeof(PlayerStruggle), Member = "UpdateTapBar")]
	[Calls(Type = typeof(PlayerStruggle), Member = "UpdateTapInput")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowStruggleWidget")]
	[Calls(Type = typeof(PlayerStruggle), Member = "HasFilledStruggleTapBar")]
	[Calls(Type = typeof(PlayerStruggle), Member = "SetStartCameraRotationToLookAtPartner")]
	[Calls(Type = typeof(PlayerStruggle), Member = "DoChangeWeapon")]
	[Calls(Type = typeof(PlayerStruggle), Member = "HandleTimeSlowdownFadeout")]
	[Calls(Type = typeof(PlayerStruggle), Member = "HandleShowPickerRequested")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 10)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[CallsUnknownMethods(Count = 1)]
	private void OnBearSpearDisengage()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerStruggle), Member = "UpdateTapBar")]
	[Calls(Type = typeof(PlayerStruggle), Member = "UpdateTapInput")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowStruggleWidget")]
	[Calls(Type = typeof(PlayerStruggle), Member = "HasFilledStruggleTapBar")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateSpear(Panel_HUD hud)
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "Update")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateSpear")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateWolf")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[Calls(Type = typeof(InputManager), Member = "GetStruggleTapPressed")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateTapInput(Action tapAction)
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(PlayerStruggle), Member = "GetDamageEventTable")]
	[Calls(Type = typeof(DamageEventTable), Member = "FadeOutEventUi")]
	[Calls(Type = typeof(RumbleEffectManager), Member = "StopEffect")]
	[Calls(Type = typeof(PlayerStruggle), Member = "StopAllAudio")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Restore")]
	[Calls(Type = typeof(CameraEffects), Member = "BlurSetSize")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowStruggleWidget")]
	[Calls(Type = typeof(PlayerStruggle), Member = "MaybeEnableStaminaRecharge")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void OnPlayerDeath(Panel_HUD hud)
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "Update")]
	[CalledBy(Type = typeof(Action_ScrapMetalStruggle), Member = "UpdateStruggle")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(InputManager), Member = "GetButtonNameForAction")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "GetButtonIcon")]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	public void UpdateKeyBindingLabels()
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerStruggle), Member = "UpdateTapBar")]
	[Calls(Type = typeof(PlayerStruggle), Member = "UpdateTapInput")]
	[Calls(Type = typeof(PlayerStruggle), Member = "ApplyPlayerDamagePerSecond")]
	[Calls(Type = typeof(PlayerStruggle), Member = "ApplyClothingDamagePerSecond")]
	[Calls(Type = typeof(PlayerStruggle), Member = "MaybeReceiveAIAttack")]
	[Calls(Type = typeof(PlayerStruggle), Member = "MaybeShootRevolver")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetFloat")]
	[Calls(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(PlayerStruggle), Member = "OnPlayerDazed")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateWolf(Panel_HUD hud)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerStruggle), Member = "ApplyPlayerDamagePerSecond")]
	[Calls(Type = typeof(PlayerStruggle), Member = "MaybeReceiveAIAttack")]
	[Calls(Type = typeof(PlayerStruggle), Member = "ApplyClothingDamagePerSecond")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateBear()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(PlayerStruggle), Member = "OnPlayerDazed")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[CallsUnknownMethods(Count = 1)]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsSystemEnabled()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsUnknownMethods(Count = 2)]
	public bool CanStruggle()
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PassTime), Member = "End")]
	[Calls(Type = typeof(PlayerStruggle), Member = "InitializeStruggle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "MaybeResetCurrentWeapon")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipImmediate")]
	[Calls(Type = typeof(PlayerAnimation), Member = "DropCurrentItemInHand")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(GearItem), Member = "StickToGroundAtPlayerFeet")]
	[Calls(Type = typeof(GearItem), Member = "IsLitLamp")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlashlight")]
	[Calls(Type = typeof(GearItem), Member = "Drop")]
	[Calls(Type = typeof(BodyCarry), Member = "Drop")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "InterruptAnyInProgressAnimations")]
	[Calls(Type = typeof(PlayerAnimation), Member = "HideHands")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHandsSkipAnimation")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Reset")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateHipAndShoulderOffsetLayerWeigth")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "ToggleZoom")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetTrigger")]
	[Calls(Type = typeof(PlayerStruggle), Member = "PrepareStruggle")]
	[Calls(Type = typeof(PlayerStruggle), Member = "WeaponPickerBegin")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetCameraLayer")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ShowHands")]
	[Calls(Type = typeof(PlayerAnimation), Member = "EnableWeapon")]
	[Calls(Type = typeof(AnimationUtils), Member = "HasParameter")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(RumbleEffectManager), Member = "PlayEffect")]
	[Calls(Type = typeof(CharcoalItem), Member = "CancelDetailSurvey")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(PlayerStruggle), Member = "MaybeDisableStaminaRecharge")]
	[Calls(Type = typeof(PlayerStruggle), Member = "RetrieveBearHuntReduxSettings")]
	[Calls(Type = typeof(PlayerStruggle), Member = "MaybeApplyStaminaCost")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Save")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "FullReset")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 31)]
	public void Begin(GameObject partner)
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BeginSpearStruggle")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "EnableCrouchImmediate")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "CancelReload")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(LeanToManager), Member = "ExitShelterDueToStruggle")]
	[Calls(Type = typeof(SnowShelterManager), Member = "ExitShelterDueToStruggle")]
	[Calls(Type = typeof(PlayerManager), Member = "CancelItemInHandsAction")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(PlayerStruggle), Member = "ResetDamageEvents")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_HUD), Member = "SetStruggleBarFillAmount")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowStruggleRevolverWidget")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 11)]
	private void InitializeStruggle(GameObject partner)
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "PrepareStruggle")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PanelReference<>), Member = "GetPanel")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowStruggleWidget")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	private void InitStruggleForPartner(GameObject partner)
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BeginSpearStruggle")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(PlayerStruggle), Member = "InitStruggleForPartner")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(vp_FPSController), Member = "Stop")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 11)]
	private void PrepareStruggle(GameObject partner)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "OnSpearHit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerStruggle), Member = "InitializeStruggle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerStruggle), Member = "RetrieveBearHuntReduxSettings")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateHipAndShoulderOffsetLayerWeigth")]
	[Calls(Type = typeof(PlayerStruggle), Member = "PrepareStruggle")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetCameraLayer")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ShowHands")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(RumbleEffectManager), Member = "PlayEffect")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowStruggleWidget")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(PlayerStruggle), Member = "MaybeDisableStaminaRecharge")]
	[Calls(Type = typeof(PlayerStruggle), Member = "MaybeApplyStaminaCost")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	public void BeginSpearStruggle(GameObject partner, bool isFatal)
	{
	}

	[CallerCount(Count = 0)]
	public bool IsControllingCamera()
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "WolfTap")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "SpearTap")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void DoTap()
	{
	}

	[CallerCount(Count = 0)]
	private bool WaitingToRecover()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerStruggle), Member = "DoTap")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "ApplyDamage")]
	[Calls(Type = typeof(PlayerStruggle), Member = "GetFleeChanceOnHitPercent")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(PlayerStruggle), Member = "MakePartnerFlee")]
	[CallsUnknownMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void OnTweenComplete()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "SetupDamageForAnim")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[CalledBy(Type = typeof(PackManager), Member = "CanAttack")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "Update")]
	[CalledBy(Type = typeof(GearItem), Member = "WearOut")]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "DidFallThroughIceFadeOut")]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "ExitStruggleIfActive")]
	[CalledBy(Type = typeof(Condition_IsPlayerInStrugglee), Member = "OnCheck")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool InStruggle()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool IsInBearSpearStruggle()
	{
		return false;
	}

	[CalledBy(Type = typeof(Condition), Member = "GetCauseOfDeathStringUntranslated")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_PlayerStunned_Begin")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public bool InStruggleWithMoose()
	{
		return false;
	}

	[CalledBy(Type = typeof(Condition), Member = "GetCauseOfDeathStringUntranslated")]
	[CalledBy(Type = typeof(RiskOfInfectionEvent), Member = "OnExecute")]
	[CalledBy(Type = typeof(SprainedAnkleEvent), Member = "OnExecute")]
	[CalledBy(Type = typeof(SprainedWristEvent), Member = "OnExecute")]
	[CalledBy(Type = typeof(BloodLossEvent), Member = "OnExecute")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShouldHideConditionRelatedLabels")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public bool InStruggleWIthBear()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsUnknownMethods(Count = 1)]
	public bool InFinalAmbushStruggleWIthBear()
	{
		return false;
	}

	[CalledBy(Type = typeof(Condition), Member = "GetCauseOfDeathStringUntranslated")]
	[CalledBy(Type = typeof(StatusBar), Member = "ShouldBeHidden")]
	[CalledBy(Type = typeof(RiskOfInfectionEvent), Member = "OnExecute")]
	[CalledBy(Type = typeof(SprainedAnkleEvent), Member = "OnExecute")]
	[CalledBy(Type = typeof(SprainedWristEvent), Member = "OnExecute")]
	[CalledBy(Type = typeof(BloodLossEvent), Member = "OnExecute")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "MaybeSelectGear")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "SelectGridItem")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public bool InStruggleWIthWolf()
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "WolfTap")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "MaybeBreakStruggle")]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "DidFallThroughIceFadeOut")]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "ExitStruggleIfActive")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(BaseAi), Member = "FleeFrom")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void MakePartnerFlee()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "OnBearBreakStruggle")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateWolf")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "WolfStruggleTimedOut")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Inventory), Member = "DropAndScatterItems")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public void OnPlayerDazed()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void LogEvent(string eventString)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsUnknownMethods(Count = 2)]
	public void PlayStruggleAudio(string audioEventName)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	public void PlayStruggleAudioOneShot(string audioEventName)
	{
	}

	[CalledBy(Type = typeof(Condition), Member = "AddHealth")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShouldHideConditionRelatedLabels")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsBlackedOutAfterStruggle()
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_Struggle_GetUp_Complete")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BeginReturnToStart")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashCameraReturnToStart")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "OnDestroy")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PlayerStruggle), Member = "GetDamageEventTable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DamageEventTable), Member = "FadeOutEventUi")]
	[Calls(Type = typeof(PlayerStruggle), Member = "StopAllAudio")]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateCameraRotation")]
	[Calls(Type = typeof(PlayerStruggle), Member = "ResetGameSettingsToNormal")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Restore")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateHipAndShoulderOffsetLayerWeigth")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetCameraLayer")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(PlayerManager), Member = "EquipItem")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 20)]
	public void GetUpAnimationComplete()
	{
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_PlayerStunned_Begin")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[CallsUnknownMethods(Count = 1)]
	public float GetStunnedDurationFromParter()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 1)]
	public void PlayMauledMuffle()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 1)]
	public void StopMauledMuffle()
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "OnPlayerDeath")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "GetUpAnimationComplete")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CallsUnknownMethods(Count = 7)]
	private void StopAllAudio()
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "Update")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashCamera")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateVoiceVolume()
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "Update")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashCameraReturnToStart")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashCamera")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(CameraFade), Member = "BashFadeAlpha")]
	[Calls(Type = typeof(CameraEffects), Member = "BlurSetSize")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private void UpdateFadeAndBlur(GameObject EffectsBone)
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "IsAttachedToPartner")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashCameraInterpolateToPartner")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "HandleShowPickerRequested")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private float GetAttachBlendTime()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerStruggle), Member = "GetAttachBlendTime")]
	public bool IsAttachedToPartner()
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "Update")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashCamera")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerStruggle), Member = "GetAttachBlendTime")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(PlayerStruggle), Member = "GetOverrideGameCameraPosition")]
	[Calls(Type = typeof(Utils), Member = "SetCameraFOVSafe")]
	[Calls(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 23)]
	private void BashCameraInterpolateToPartner()
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashCameraInterpolateToPartner")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashGetupDelayCamera")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashCameraReturnToStart")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	private Vector3 GetOverrideGameCameraPosition()
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "BeginReturnToStart")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashCameraReturnToStart")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private bool ShouldUseSpearExhaustedGetUp()
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashGetupDelayCamera")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerStruggle), Member = "IsHuntedBear2ChallengeEnd")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "set_eulerAngles")]
	[Calls(Type = typeof(PlayerStruggle), Member = "ApplyDamageAfterMooseAttack")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipImmediate")]
	[Calls(Type = typeof(PlayerStruggle), Member = "GetUpAnimationComplete")]
	[Calls(Type = typeof(PlayerStruggle), Member = "ShouldUseSpearExhaustedGetUp")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 10)]
	private void BeginReturnToStart(BaseAi bai)
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "LateUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(Utils), Member = "GetOrientationOnSlope")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 8)]
	private void UpdatePlayerTransformForHunted2Dragging()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(BaseAi), Member = "IsTimberwolf")]
	[CallsUnknownMethods(Count = 1)]
	private bool CanBeStunned()
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "Update")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashCamera")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(PlayerStruggle), Member = "BeginReturnToStart")]
	[Calls(Type = typeof(BaseAi), Member = "IsTimberwolf")]
	[Calls(Type = typeof(TimeOfDay), Member = "AccelerateTime")]
	[Calls(Type = typeof(Utils), Member = "SetCameraFOVSafe")]
	[Calls(Type = typeof(PlayerStruggle), Member = "GetOverrideGameCameraPosition")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(CameraFade), Member = "BashFadeAlpha")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 11)]
	private void BashGetupDelayCamera()
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "Update")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashCamera")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(PlayerStruggle), Member = "ShouldUseSpearExhaustedGetUp")]
	[Calls(Type = typeof(PlayerStruggle), Member = "GetOverrideGameCameraPosition")]
	[Calls(Type = typeof(Utils), Member = "SetCameraFOVSafe")]
	[Calls(Type = typeof(PlayerStruggle), Member = "GetUpAnimationComplete")]
	[Calls(Type = typeof(PlayerStruggle), Member = "UpdateFadeAndBlur")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallsUnknownMethods(Count = 21)]
	private void BashCameraReturnToStart()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerStruggle), Member = "BashCameraReturnToStart")]
	[Calls(Type = typeof(PlayerStruggle), Member = "UpdateVoiceVolume")]
	[Calls(Type = typeof(PlayerStruggle), Member = "BashGetupDelayCamera")]
	[Calls(Type = typeof(PlayerStruggle), Member = "BashCameraInterpolateToPartner")]
	[Calls(Type = typeof(PlayerStruggle), Member = "UpdateFadeAndBlur")]
	private void BashCamera()
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "Update")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateSpear")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateWolf")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_HUD), Member = "SetStruggleBarFillAmount")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateTapBar(Panel_HUD hud)
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "Update")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateSpear")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ShouldBreakStruggle")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "MaybeBreakStruggle")]
	[CallerCount(Count = 4)]
	private bool HasFilledStruggleTapBar()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInShelter")]
	[Calls(Type = typeof(PlayerStruggle), Member = "HasFilledStruggleTapBar")]
	[CallsUnknownMethods(Count = 5)]
	private bool ShouldBreakStruggle()
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInShelter")]
	[Calls(Type = typeof(PlayerStruggle), Member = "HasFilledStruggleTapBar")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(PlayerStruggle), Member = "MakePartnerFlee")]
	[CallsUnknownMethods(Count = 5)]
	private void MaybeBreakStruggle()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetAltFire")]
	[Calls(Type = typeof(InputManager), Member = "GetReloadPressed")]
	private bool GetCustomFireInput()
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateWolf")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GunItem), Member = "NumRoundsInClip")]
	[Calls(Type = typeof(PanelReference<>), Member = "GetPanel")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowStruggleRevolverWidget")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetAltFire")]
	[Calls(Type = typeof(InputManager), Member = "GetReloadPressed")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetStruggleRevolverFired")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowStruggleWidget")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void MaybeShootRevolver()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GunItem), Member = "StruggleRevolverFire")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillRevolver")]
	[Calls(Type = typeof(Skill_Revolver), Member = "GetStruggleBonus")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "ApplyDamage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void OnRevolverFired()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	private void OnRevolverFiredComplete()
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void SetStartCameraRotationToLookAtPartner()
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public float GetHeightOffset()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "OnSpearStruggleEnd")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnAnimationEvent_MooseButtHeadAttackComplete")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "OnMooseButtHeadAttackComplete")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateWolf")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "WolfStruggleTimedOut")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "MakePartnerFlee")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashCameraInterpolateToPartner")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "MaybeBreakStruggle")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "OnRevolverFiredComplete")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(PlayerAnimation), Member = "HideHands")]
	[Calls(Type = typeof(PlayerAnimation), Member = "DisableWeapon")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "Enable")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowStruggleWidget")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(PlayerStruggle), Member = "ApplyBearDamageAfterStruggleEnds")]
	[Calls(Type = typeof(PlayerStruggle), Member = "GetHeightOffset")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Inventory), Member = "DropAndScatterItems")]
	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnDamage")]
	[Calls(Type = typeof(CameraEffects), Member = "BlurSetSize")]
	[Calls(Type = typeof(PlayerStruggle), Member = "StopAllAudio")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(Utils), Member = "SendGameplayAnalyticsEvent")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Restore")]
	[Calls(Type = typeof(RumbleEffectManager), Member = "StopEffect")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(BloodTrail), Member = "LeaveStruggleBloodStain")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(BearHuntRedux), Member = "OnBearSpearOutcome")]
	[Calls(Type = typeof(PlayerStruggle), Member = "MaybeEnableStaminaRecharge")]
	[Calls(Type = typeof(GameManager), Member = "TriggerSurvivalSaveAndDisplayHUDMessage")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 11)]
	public void BreakStruggle()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[CallsUnknownMethods(Count = 1)]
	public void SpearDisengageReady()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(InterfaceManager), Member = "LoadPanel")]
	[Calls(Type = typeof(Panel_ChallengeComplete), Member = "ShowPanel")]
	[CallsUnknownMethods(Count = 1)]
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

	[CalledBy(Type = typeof(PlayerStruggle), Member = "WeaponPickerBegin")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "DoChangeWeapon")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	private void SetWeaponIcon(Panel_HUD hud)
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "Update")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateWolf")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateBear")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetStrugglePlayerDamageReceivedScale")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiDifficultySetting), Member = "GetStrugglePlayerDamageReceivedScale")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void ApplyPlayerDamagePerSecond(float damagePerSecond, DamageSource damageCause)
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "Update")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateWolf")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateBear")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetStrugglePlayerClothingDamageScale")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiDifficultySetting), Member = "GetStrugglePlayerClothingDamageScale")]
	[Calls(Type = typeof(PlayerManager), Member = "ApplyDamageToWornClothing")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void ApplyClothingDamagePerSecond(float damagePerSecond)
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "BeginReturnToStart")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ApplyMooseDamageAfterStruggleEnds")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetStugglePlayerPercentLossFromBearScale")]
	[Calls(Type = typeof(PlayerManager), Member = "GetDamageReductionFromExteriorClothing")]
	[Calls(Type = typeof(DamageProtection), Member = "GetTotalAnimalDamageModifier")]
	[Calls(Type = typeof(float), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(DamageProtection), Member = "GetTotalBrokenRibModifier")]
	[Calls(Type = typeof(BrokenRib), Member = "BrokenRibStart")]
	[CallsUnknownMethods(Count = 11)]
	private void ApplyDamageAfterMooseAttack(string causeLocId)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerStruggle), Member = "ApplyDamageAfterMooseAttack")]
	private void ApplyMooseDamageAfterStruggleEnds()
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "DisableCharacterController")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetStugglePlayerPercentLossFromBearScale")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(PlayerStruggle), Member = "RetrieveBearHuntReduxSettings")]
	[Calls(Type = typeof(PlayerManager), Member = "GetDamageReductionFromExteriorClothing")]
	[Calls(Type = typeof(DamageProtection), Member = "GetTotalAnimalDamageModifier")]
	[Calls(Type = typeof(float), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IsHuntedBear")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IncrementWaypoint")]
	[Calls(Type = typeof(BearHuntRedux), Member = "OnBearSpearOutcome")]
	[Calls(Type = typeof(BloodLoss), Member = "BloodLossStart")]
	[Calls(Type = typeof(BloodLoss), Member = "GetLocation")]
	[Calls(Type = typeof(InfectionRisk), Member = "InfectionRiskStart")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	private void ApplyBearDamageAfterStruggleEnds()
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "GetUpAnimationComplete")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CameraFade), Member = "BashFadeAlpha")]
	[Calls(Type = typeof(CameraEffects), Member = "BlurSetSize")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(Utils), Member = "SetCameraFOVSafe")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ShowHands")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void ResetGameSettingsToNormal()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateDebugText()
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "MaybeReceiveAIAttack")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private float GetNextAttackTime()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "Update")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateWolf")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateBear")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup")]
	[Calls(Type = typeof(PlayerStruggle), Member = "GetActiveDamageEventTable")]
	[Calls(Type = typeof(DamageEventTable), Member = "MaybeApplyAttack")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(PlayerStruggle), Member = "GetNextAttackTime")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[CallsUnknownMethods(Count = 4)]
	private void MaybeReceiveAIAttack()
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "OnPlayerDeath")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "GetUpAnimationComplete")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ResetDamageEvents")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "DamageEventsInitialize")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "GetActiveDamageEventTable")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(ExperienceMode), Member = "GetDamageEventTable")]
	[CallsUnknownMethods(Count = 3)]
	private DamageEventTable GetDamageEventTable(GameplayTag tag)
	{
		return null;
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "InitializeStruggle")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerStruggle), Member = "GetDamageEventTable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(DamageEventTable), Member = "Reset")]
	[CallsUnknownMethods(Count = 4)]
	private void ResetDamageEvents()
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerStruggle), Member = "GetDamageEventTable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DamageEventTable), Member = "Initialize")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 3)]
	private void DamageEventsInitialize()
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "MaybeReceiveAIAttack")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ReceiveAIAttack")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(PlayerStruggle), Member = "GetDamageEventTable")]
	[CallsUnknownMethods(Count = 3)]
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
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerStruggle), Member = "IsHuntedBear2ChallengeEnd")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "set_eulerAngles")]
	[CallsUnknownMethods(Count = 1)]
	private bool ShouldPlayDraggingAnimation(BaseAi bai, ref Quaternion overrideRotation)
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "BeginReturnToStart")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ShouldPlayDraggingAnimation")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IsHuntedBear")]
	[CallsUnknownMethods(Count = 1)]
	private bool IsHuntedBear2ChallengeEnd()
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "WolfTap")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillRevolver")]
	[Calls(Type = typeof(Skill_Revolver), Member = "GetStruggleBonus")]
	[CallsUnknownMethods(Count = 1)]
	private float GetFleeChanceOnHitPercent()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillRevolver")]
	[Calls(Type = typeof(Skill_Revolver), Member = "GetStruggleBonus")]
	[CallsUnknownMethods(Count = 1)]
	public float GetFleeChanceOnRevolverShotPercent()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	private bool IsBearSpearOutcomeSuccess()
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BeginSpearStruggle")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ApplyBearDamageAfterStruggleEnds")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[CallsUnknownMethods(Count = 1)]
	private BearHuntReduxSettings RetrieveBearHuntReduxSettings()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerStruggle), Member = "GetUpAnimationComplete")]
	private void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BeginSpearStruggle")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerMovement), Member = "AddSprintStamina")]
	private void MaybeApplyStaminaCost(float staminaCost)
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BeginSpearStruggle")]
	[CallerCount(Count = 2)]
	private void MaybeDisableStaminaRecharge()
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "OnPlayerDeath")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[CallerCount(Count = 2)]
	private void MaybeEnableStaminaRecharge()
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "LateUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Animator), Member = "PlayInFixedTime")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	private void SynchronizePartnerAnimation()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Animator), Member = "PlayInFixedTime")]
	[CallsUnknownMethods(Count = 2)]
	private void SynchronizeAnimationState(AnimatorStateInfo partnerAnimatorStateInfo, AnimatorStateInfo fpAnimatorStateInfo, int partnerHash, int fpHash)
	{
	}

	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "MaybeSelectGear")]
	[CallerCount(Count = 1)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerStruggle), Member = "DoChangeWeapon")]
	[Calls(Type = typeof(PlayerStruggle), Member = "HandleTimeSlowdownFadeout")]
	[Calls(Type = typeof(PlayerStruggle), Member = "HandleShowPickerRequested")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateWeaponSelection()
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "GetPrioritizedWeaponList")]
	[Calls(Type = typeof(PanelReference<>), Member = "GetPanel")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowStruggleWidget")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(Inventory), Member = "GetBestStuggleBonusItem")]
	[Calls(Type = typeof(PlayerStruggle), Member = "SetWeaponIcon")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	private void WeaponPickerBegin()
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "Update")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateWeaponSelection")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerStruggle), Member = "GetAttachBlendTime")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "Enable")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void HandleShowPickerRequested()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetWeaponTypeSwitch")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 1)]
	private void PlayPickerExitAudio()
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "HandleTimeSlowdownFadeout")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "Enable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetWeaponTypeSwitch")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallsUnknownMethods(Count = 1)]
	private void OnShowPickerEnded(bool isPickerEnabled)
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "Update")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateWeaponSelection")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PanelReference<>), Member = "IsEnabled")]
	[Calls(Type = typeof(PlayerStruggle), Member = "OnShowPickerEnded")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void HandleTimeSlowdownFadeout()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerStruggle), Member = "DoChangeWeapon")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void HandleChangeWeaponFadein()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "Enable")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeInterruptPicker()
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "Update")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateWeaponSelection")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "HandleChangeWeaponFadein")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PanelReference<>), Member = "GetPanel")]
	[Calls(Type = typeof(PlayerStruggle), Member = "SetWeaponIcon")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(PlayerAnimation), Member = "EnableWeapon")]
	[Calls(Type = typeof(AnimationUtils), Member = "HasParameter")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowStruggleWidget")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private void DoChangeWeapon()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "Enable")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallsUnknownMethods(Count = 1)]
	private void ShowPicker()
	{
	}

	[CallerCount(Count = 0)]
	private bool IsWeaponPickerSelectionPending()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public PlayerStruggle()
	{
	}
}
