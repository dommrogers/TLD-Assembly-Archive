using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using NodeCanvas.Tasks.Conditions;
using UnityEngine;

public class PlayerStruggle : MonoBehaviour
{
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
		[CallerCount(Count = 2)]
		public WeaponPicker()
		{
		}
	}

	[Serializable]
	public class DamageEventTableOverride
	{
		public DamageEventTable_WildlifeType m_WildlifeType;

		public DamageEventTable m_DamageEventTable;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
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

		[CallsUnknownMethods(Count = 2)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		public void Initialize()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public SynchronizedAnimationInfo()
		{
		}
	}

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

	public DamageEventTable m_DamageEvents;

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

	[CallerCount(Count = 17)]
	[DeduplicatedMethod]
	public void OnWeaponPicked(GearItem gearItem)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void InitWeaponPicker()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void ResetWeaponPicker()
	{
	}

	[Calls(Type = typeof(PlayerStruggle), Member = "HandleTimeSlowdownFadeout")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerStruggle), Member = "HandleChangeWeaponFadein")]
	[Calls(Type = typeof(PlayerStruggle), Member = "HandleShowPickerRequested")]
	private void UpdateWeaponSelection()
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[Calls(Type = typeof(Utils), Member = "GetBestStruggleBonusItem")]
	[CallsUnknownMethods(Count = 24)]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(PlayerStruggle), Member = "SetWeaponIcon")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "GetPrioritizedWeaponList")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowStruggleWidget")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 1)]
	private void WeaponPickerBegin()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Update")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateWeaponSelection")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(PlayerStruggle), Member = "GetAttachBlendTime")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "Enable")]
	private void HandleShowPickerRequested()
	{
	}

	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "OnShowPickerEnded")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetWeaponTypeSwitch")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	private void PlayPickerExitAudio()
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "HandleTimeSlowdownFadeout")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "Enable")]
	[Calls(Type = typeof(PlayerStruggle), Member = "PlayPickerExitAudio")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsUnknownMethods(Count = 4)]
	private void OnShowPickerEnded(bool isPickerEnabled)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateWeaponSelection")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(PlayerStruggle), Member = "OnShowPickerEnded")]
	[CallerCount(Count = 2)]
	private void HandleTimeSlowdownFadeout()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PlayerStruggle), Member = "DoChangeWeapon")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateWeaponSelection")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	private void HandleChangeWeaponFadein()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	private void MaybeInterruptPicker()
	{
	}

	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "HandleChangeWeaponFadein")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowStruggleWidget")]
	[Calls(Type = typeof(AnimationUtils), Member = "HasParameter")]
	[Calls(Type = typeof(PlayerAnimation), Member = "EnableWeapon")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerStruggle), Member = "SetWeaponIcon")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	private void DoChangeWeapon()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "Enable")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
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

	[CallsUnknownMethods(Count = 25)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowStruggleRevolverWidget")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowStruggleWidget")]
	[Calls(Type = typeof(PlayerStruggle), Member = "DamageEventsInitialize")]
	[Calls(Type = typeof(CameraEffects), Member = "BlurSetSize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetRevolverMuzzleFlashGO")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	public void Start()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GearItem), Member = "DegradeOnUse")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void DegradeToolOnUse()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	public void OnMooseButtHeadAttackComplete()
	{
	}

	[Calls(Type = typeof(PlayerStruggle), Member = "MaybeReceiveAIAttack")]
	[Calls(Type = typeof(PlayerStruggle), Member = "UpdateWolf")]
	[Calls(Type = typeof(PlayerStruggle), Member = "UpdateSpear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerStruggle), Member = "ApplyPlayerDamagePerSecond")]
	[Calls(Type = typeof(PlayerStruggle), Member = "ApplyClothingDamagePerSecond")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerStruggle), Member = "SetStartCameraRotationToLookAtPartner")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(PlayerStruggle), Member = "HandleChangeWeaponFadein")]
	[Calls(Type = typeof(PlayerStruggle), Member = "HandleTimeSlowdownFadeout")]
	[Calls(Type = typeof(PlayerStruggle), Member = "HandleShowPickerRequested")]
	[Calls(Type = typeof(PlayerStruggle), Member = "UpdateSpear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerStruggle), Member = "UpdateDebugText")]
	[Calls(Type = typeof(GearItem), Member = "DegradeOnUse")]
	[Calls(Type = typeof(PlayerStruggle), Member = "MaybeBreakStruggle")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerStruggle), Member = "OnPlayerDeath")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerStruggle), Member = "UpdateKeyBindingLabels")]
	[Calls(Type = typeof(PlayerStruggle), Member = "BashGetupDelayCamera")]
	[Calls(Type = typeof(PlayerStruggle), Member = "BashCameraInterpolateToPartner")]
	[Calls(Type = typeof(PlayerStruggle), Member = "UpdateFadeAndBlur")]
	[Calls(Type = typeof(PlayerStruggle), Member = "UpdateVoiceVolume")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(PlayerStruggle), Member = "BashCameraReturnToStart")]
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
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	private void OnBearSpearDisengage()
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "Update")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Update")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowStruggleWidget")]
	[Calls(Type = typeof(PlayerStruggle), Member = "HasFilledStruggleTapBar")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowStruggleWidget")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(PlayerStruggle), Member = "UpdateTapInput")]
	[Calls(Type = typeof(PlayerStruggle), Member = "UpdateTapBar")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void UpdateSpear()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateWolf")]
	[Calls(Type = typeof(InputManager), Member = "GetStruggleTapPressed")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateSpear")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "GetStruggleTapHeldDown")]
	private void UpdateTapInput(Action tapAction)
	{
	}

	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Restore")]
	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Update")]
	[Calls(Type = typeof(PlayerStruggle), Member = "MaybeEnableStaminaRecharge")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowStruggleWidget")]
	[Calls(Type = typeof(CameraEffects), Member = "BlurSetSize")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Restore")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(PlayerStruggle), Member = "StopAllAudio")]
	[Calls(Type = typeof(RumbleEffectManager), Member = "StopEffect")]
	[Calls(Type = typeof(DamageEventTable), Member = "FadeOutEventUi")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	private void OnPlayerDeath()
	{
	}

	[CallsUnknownMethods(Count = 39)]
	[CalledBy(Type = typeof(Action_ScrapMetalStruggle), Member = "UpdateStruggle")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Update")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "GetButtonIcon")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(InputManager), Member = "GetButtonNameForAction")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "GetButtonIcon")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "GetButtonNameForAction")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	public void UpdateKeyBindingLabels()
	{
	}

	[Calls(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Update")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[Calls(Type = typeof(PlayerStruggle), Member = "OnPlayerDazed")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetFloat")]
	[Calls(Type = typeof(PlayerStruggle), Member = "UpdateTapInput")]
	[Calls(Type = typeof(PlayerStruggle), Member = "MaybeReceiveAIAttack")]
	[Calls(Type = typeof(PlayerStruggle), Member = "ApplyClothingDamagePerSecond")]
	[Calls(Type = typeof(PlayerStruggle), Member = "ApplyPlayerDamagePerSecond")]
	[Calls(Type = typeof(PlayerStruggle), Member = "UpdateTapBar")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerStruggle), Member = "MaybeShootRevolver")]
	private void UpdateWolf()
	{
	}

	[Calls(Type = typeof(PlayerStruggle), Member = "MaybeReceiveAIAttack")]
	[Calls(Type = typeof(PlayerStruggle), Member = "ApplyClothingDamagePerSecond")]
	[Calls(Type = typeof(PlayerStruggle), Member = "ApplyPlayerDamagePerSecond")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void UpdateBear()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(PlayerStruggle), Member = "OnPlayerDazed")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[CallsUnknownMethods(Count = 4)]
	private void WolfStruggleTimedOut()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowStruggleWidget")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void BearSpearStruggleTimedOut()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowStruggleWidget")]
	[CallsUnknownMethods(Count = 2)]
	private void BearSpearStruggleSuccess()
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
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool CanStruggle()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GearItem), Member = "StickToGroundAtPlayerFeet")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetCameraLayer")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ShowHands")]
	[Calls(Type = typeof(PlayerAnimation), Member = "EnableWeapon")]
	[Calls(Type = typeof(AnimationUtils), Member = "HasParameter")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(CharcoalItem), Member = "CancelDetailSurvey")]
	[CallsUnknownMethods(Count = 77)]
	[Calls(Type = typeof(PlayerStruggle), Member = "MaybeDisableStaminaRecharge")]
	[Calls(Type = typeof(PlayerStruggle), Member = "RetrieveBearHuntReduxSettings")]
	[Calls(Type = typeof(PlayerStruggle), Member = "MaybeApplyStaminaCost")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "ResetForStruggle")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "ResetForStruggle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[Calls(Type = typeof(PlayerAnimation), Member = "DropCurrentItemInHand")]
	[Calls(Type = typeof(RumbleEffectManager), Member = "PlayEffect")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(PlayerStruggle), Member = "WeaponPickerBegin")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(PassTime), Member = "End")]
	[Calls(Type = typeof(PlayerStruggle), Member = "InitializeStruggle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "MaybeResetCurrentWeapon")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "IsLitLamp")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlashlight")]
	[Calls(Type = typeof(GearItem), Member = "Drop")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipImmediate")]
	[Calls(Type = typeof(BodyCarry), Member = "Drop")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetTrigger")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "CancelZoom")]
	[Calls(Type = typeof(PlayerStruggle), Member = "PrepareStruggle")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Reset")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHandsSkipAnimation")]
	[Calls(Type = typeof(PlayerAnimation), Member = "HideHands")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "InterruptAnyInProgressAnimations")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateHipAndShoulderOffsetLayerWeigth")]
	public void Begin(GameObject partner)
	{
	}

	[Calls(Type = typeof(SnowShelterManager), Member = "ExitShelterDueToStruggle")]
	[CallsUnknownMethods(Count = 48)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BeginSpearStruggle")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowStruggleRevolverWidget")]
	[Calls(Type = typeof(PlayerStruggle), Member = "ResetDamageEvents")]
	[Calls(Type = typeof(Panel_HUD), Member = "SetStruggleBarFillAmount")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "CancelItemInHandsAction")]
	[Calls(Type = typeof(LeanToManager), Member = "ExitShelterDueToStruggle")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "EnableCrouchImmediate")]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInShelter")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "CancelReload")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LeanToManager), Member = "PlayerInLeanTo")]
	private void InitializeStruggle(GameObject partner)
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowStruggleWidget")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "PrepareStruggle")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallsUnknownMethods(Count = 33)]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowStruggleWidget")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowStruggleWidget")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	private void InitStruggleForPartner(GameObject partner)
	{
	}

	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsUnknownMethods(Count = 39)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BeginSpearStruggle")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[Calls(Type = typeof(vp_FPSController), Member = "Stop")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(PlayerStruggle), Member = "InitStruggleForPartner")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	private void PrepareStruggle(GameObject partner)
	{
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "ShowHands")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnSpearHit")]
	[Calls(Type = typeof(PlayerStruggle), Member = "MaybeApplyStaminaCost")]
	[Calls(Type = typeof(PlayerStruggle), Member = "MaybeDisableStaminaRecharge")]
	[CallsUnknownMethods(Count = 26)]
	[Calls(Type = typeof(RumbleEffectManager), Member = "PlayEffect")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetCameraLayer")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowStruggleWidget")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateHipAndShoulderOffsetLayerWeigth")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerStruggle), Member = "RetrieveBearHuntReduxSettings")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerStruggle), Member = "InitializeStruggle")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerStruggle), Member = "PrepareStruggle")]
	public void BeginSpearStruggle(GameObject partner, bool isFatal)
	{
	}

	[CallerCount(Count = 0)]
	public bool IsControllingCamera()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "SpearTap")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "WolfTap")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 4)]
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
	[Calls(Type = typeof(PlayerStruggle), Member = "MakePartnerFlee")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(PlayerStruggle), Member = "GetFleeChanceOnHitPercent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerStruggle), Member = "DoTap")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void WolfTap()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerStruggle), Member = "DoTap")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private void SpearTap()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	public void OnTweenComplete()
	{
	}

	[CalledBy(Type = typeof(Condition_IsPlayerInStrugglee), Member = "OnCheck")]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "ExitStruggleIfActive")]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "DidFallThroughIceFadeOut")]
	[CalledBy(Type = typeof(GearItem), Member = "WearOut")]
	[CalledBy(Type = typeof(PackManager), Member = "CanAttack")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "Update")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetupDamageForAnim")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
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
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Condition), Member = "GetCauseOfDeathStringUntranslated")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool InStruggleWithMoose()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BloodLossEvent), Member = "OnExecute")]
	[CalledBy(Type = typeof(SprainedWristEvent), Member = "OnExecute")]
	[CalledBy(Type = typeof(SprainedAnkleEvent), Member = "OnExecute")]
	[CalledBy(Type = typeof(RiskOfInfectionEvent), Member = "OnExecute")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShouldHideConditionRelatedLabels")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Condition), Member = "GetCauseOfDeathStringUntranslated")]
	public bool InStruggleWIthBear()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool InFinalAmbushStruggleWIthBear()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(SprainedAnkleEvent), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "SelectGridItem")]
	[CalledBy(Type = typeof(BloodLossEvent), Member = "OnExecute")]
	[CalledBy(Type = typeof(SprainedWristEvent), Member = "OnExecute")]
	[CalledBy(Type = typeof(RiskOfInfectionEvent), Member = "OnExecute")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "MaybeSelectGear")]
	[CalledBy(Type = typeof(Condition), Member = "GetCauseOfDeathStringUntranslated")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(StatusBar), Member = "ShouldBeHidden")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 8)]
	public bool InStruggleWIthWolf()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "ExitStruggleIfActive")]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "DidFallThroughIceFadeOut")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "MaybeBreakStruggle")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "WolfTap")]
	[Calls(Type = typeof(BaseAi), Member = "FleeFrom")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	public void MakePartnerFlee()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateWolf")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnBearBreakStruggle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "WolfStruggleTimedOut")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Inventory), Member = "DropAndScatterItems")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	public void OnPlayerDazed()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void LogEvent(string eventString)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CalledBy(Type = typeof(AudioCallback), Member = "OnAudioStruggleEvent")]
	[CallsUnknownMethods(Count = 7)]
	public void PlayStruggleAudio(string audioEventName)
	{
	}

	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void PlayStruggleAudioOneShot(string audioEventName)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CalledBy(Type = typeof(Condition), Member = "AddHealth")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShouldHideConditionRelatedLabels")]
	[CallsUnknownMethods(Count = 2)]
	public bool IsBlackedOutAfterStruggle()
	{
		return default(bool);
	}

	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Restore")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetHipAndShoulderOffsetLayer")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetCameraLayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "EquipItem")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "OnDestroy")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BeginReturnToStart")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashCameraReturnToStart")]
	[CallsUnknownMethods(Count = 39)]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Restore")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_Struggle_GetUp_Complete")]
	[Calls(Type = typeof(PlayerStruggle), Member = "ResetGameSettingsToNormal")]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(DamageEventTable), Member = "FadeOutEventUi")]
	[Calls(Type = typeof(PlayerStruggle), Member = "StopAllAudio")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateCameraRotation")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	public void GetUpAnimationComplete()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_PlayerStunned_Begin")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_PlayerStunned_Begin")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public float GetStunnedDurationFromParter()
	{
		return default(float);
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void PlayMauledMuffle()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 1)]
	public void StopMauledMuffle()
	{
	}

	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "GetUpAnimationComplete")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "OnPlayerDeath")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	private void StopAllAudio()
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashCamera")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashCamera")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Update")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashCamera")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	private void UpdateVoiceVolume()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashCamera")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashCameraReturnToStart")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Update")]
	[Calls(Type = typeof(CameraEffects), Member = "BlurSetSize")]
	[Calls(Type = typeof(CameraFade), Member = "BashFadeAlpha")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	private void UpdateFadeAndBlur(GameObject EffectsBone)
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashCameraInterpolateToPartner")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "HandleShowPickerRequested")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "IsAttachedToPartner")]
	[CallsUnknownMethods(Count = 1)]
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

	[Calls(Type = typeof(Utils), Member = "SetCameraFOVSafe")]
	[CallsUnknownMethods(Count = 31)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashCamera")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Update")]
	[Calls(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[Calls(Type = typeof(Quaternion), Member = "Lerp")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(PlayerStruggle), Member = "GetOverrideGameCameraPosition")]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 14)]
	[Calls(Type = typeof(PlayerStruggle), Member = "GetAttachBlendTime")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Quaternion), Member = "Lerp")]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	private void BashCameraInterpolateToPartner()
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashCameraReturnToStart")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashCameraInterpolateToPartner")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashGetupDelayCamera")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashCameraReturnToStart")]
	[CallsUnknownMethods(Count = 17)]
	private Vector3 GetOverrideGameCameraPosition()
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "BeginReturnToStart")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashCameraReturnToStart")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	private bool ShouldUseSpearExhaustedGetUp()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 21)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashGetupDelayCamera")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashGetupDelayCamera")]
	[Calls(Type = typeof(PlayerStruggle), Member = "ShouldUseSpearExhaustedGetUp")]
	[Calls(Type = typeof(PlayerStruggle), Member = "GetUpAnimationComplete")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipImmediate")]
	[Calls(Type = typeof(PlayerStruggle), Member = "IsHuntedBear2ChallengeEnd")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerStruggle), Member = "ShouldPlayDraggingAnimation")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerStruggle), Member = "ApplyDamageAfterMooseAttack")]
	private void BeginReturnToStart(BaseAi bai)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(Utils), Member = "GetOrientationOnSlope")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "LateUpdate")]
	[CallsUnknownMethods(Count = 10)]
	private void UpdatePlayerTransformForHunted2Dragging()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(BaseAi), Member = "IsTimberwolf")]
	[Calls(Type = typeof(BaseAi), Member = "IsTimberwolf")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	private bool CanBeStunned()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Utils), Member = "SetCameraFOVSafe")]
	[CallsUnknownMethods(Count = 27)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashCamera")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Update")]
	[Calls(Type = typeof(CameraFade), Member = "BashFadeAlpha")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(PlayerStruggle), Member = "GetOverrideGameCameraPosition")]
	[Calls(Type = typeof(PlayerStruggle), Member = "BeginReturnToStart")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(TimeOfDay), Member = "AccelerateCo")]
	[Calls(Type = typeof(BaseAi), Member = "IsTimberwolf")]
	[Calls(Type = typeof(BaseAi), Member = "IsTimberwolf")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(PlayerStruggle), Member = "BeginReturnToStart")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 2)]
	private void BashGetupDelayCamera()
	{
	}

	[Calls(Type = typeof(PlayerStruggle), Member = "GetUpAnimationComplete")]
	[Calls(Type = typeof(PlayerStruggle), Member = "UpdateFadeAndBlur")]
	[Calls(Type = typeof(PlayerStruggle), Member = "GetOverrideGameCameraPosition")]
	[Calls(Type = typeof(Utils), Member = "SetCameraFOVSafe")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashCamera")]
	[CallsUnknownMethods(Count = 40)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Update")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[Calls(Type = typeof(PlayerStruggle), Member = "GetOverrideGameCameraPosition")]
	[Calls(Type = typeof(Mathf), Member = "SmoothStep")]
	[Calls(Type = typeof(PlayerStruggle), Member = "ShouldUseSpearExhaustedGetUp")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallerCount(Count = 2)]
	private void BashCameraReturnToStart()
	{
	}

	[Calls(Type = typeof(PlayerStruggle), Member = "UpdateVoiceVolume")]
	[Calls(Type = typeof(PlayerStruggle), Member = "UpdateFadeAndBlur")]
	[Calls(Type = typeof(PlayerStruggle), Member = "BashCameraInterpolateToPartner")]
	[Calls(Type = typeof(PlayerStruggle), Member = "UpdateVoiceVolume")]
	[Calls(Type = typeof(PlayerStruggle), Member = "UpdateVoiceVolume")]
	[Calls(Type = typeof(PlayerStruggle), Member = "BashCameraReturnToStart")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerStruggle), Member = "BashGetupDelayCamera")]
	private void BashCamera()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Panel_HUD), Member = "SetStruggleBarFillAmount")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateSpear")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateWolf")]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateTapBar()
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateSpear")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ShouldBreakStruggle")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool HasFilledStruggleTapBar()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInShelter")]
	[Calls(Type = typeof(PlayerStruggle), Member = "HasFilledStruggleTapBar")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "MaybeBreakStruggle")]
	[CallsUnknownMethods(Count = 9)]
	private bool ShouldBreakStruggle()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Update")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(PlayerStruggle), Member = "ShouldBreakStruggle")]
	[Calls(Type = typeof(PlayerStruggle), Member = "MakePartnerFlee")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	private void MaybeBreakStruggle()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetAltFire")]
	[Calls(Type = typeof(InputManager), Member = "GetReloadPressed")]
	private bool GetCustomFireInput()
	{
		return default(bool);
	}

	[Calls(Type = typeof(InputManager), Member = "GetAltFire")]
	[CallsUnknownMethods(Count = 27)]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowStruggleWidget")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetStruggleRevolverFired")]
	[Calls(Type = typeof(InputManager), Member = "GetReloadPressed")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowStruggleRevolverWidget")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateWolf")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowStruggleRevolverWidget")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GunItem), Member = "NumRoundsInClip")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void MaybeShootRevolver()
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(BaseAi), Member = "ApplyDamage")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(Skill_Revolver), Member = "GetStruggleBonus")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillRevolver")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(GunItem), Member = "StruggleRevolverFire")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void OnRevolverFired()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	private void OnRevolverFiredComplete()
	{
	}

	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Update")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	private void SetStartCameraRotationToLookAtPartner()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	public float GetHeightOffset()
	{
		return default(float);
	}

	[Calls(Type = typeof(PlayerStruggle), Member = "StopAllAudio")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "SendGameplayAnalyticsEvent")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Restore")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Restore")]
	[Calls(Type = typeof(RumbleEffectManager), Member = "StopEffect")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(BloodTrail), Member = "LeaveStruggleBloodStain")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(BearHuntRedux), Member = "OnBearSpearOutcome")]
	[Calls(Type = typeof(PlayerStruggle), Member = "MaybeEnableStaminaRecharge")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnSpearStruggleEnd")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnAnimationEvent_MooseButtHeadAttackComplete")]
	[Calls(Type = typeof(CameraEffects), Member = "BlurSetSize")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateWolf")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "WolfStruggleTimedOut")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "MakePartnerFlee")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashCameraInterpolateToPartner")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "MaybeBreakStruggle")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "OnRevolverFiredComplete")]
	[CallsUnknownMethods(Count = 64)]
	[Calls(Type = typeof(GameManager), Member = "TriggerSurvivalSaveAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "OnMooseButtHeadAttackComplete")]
	[Calls(Type = typeof(Inventory), Member = "DropAndScatterItems")]
	[Calls(Type = typeof(PlayerStruggle), Member = "GetHeightOffset")]
	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnDamage")]
	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 20)]
	[Calls(Type = typeof(PlayerAnimation), Member = "HideHands")]
	[Calls(Type = typeof(PlayerAnimation), Member = "DisableWeapon")]
	[Calls(Type = typeof(PlayerStruggle), Member = "MaybeInterruptPicker")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowStruggleWidget")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerStruggle), Member = "ApplyBearDamageAfterStruggleEnds")]
	[Calls(Type = typeof(PlayerStruggle), Member = "GetHeightOffset")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(PlayerStruggle), Member = "GetHeightOffset")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void BreakStruggle()
	{
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnAnimationEvent_SpearDisengageReady")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	public void SpearDisengageReady()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_ChallengeComplete), Member = "ShowPanel")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "DraggingAnimationEnd")]
	[CallsUnknownMethods(Count = 3)]
	public void WinHunted2Challenge()
	{
	}

	[Calls(Type = typeof(InfectionRisk), Member = "InfectionRiskStart")]
	[Calls(Type = typeof(BloodLoss), Member = "GetLocationOfLastAdded")]
	[CallsUnknownMethods(Count = 8)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BloodLoss), Member = "BloodLossStart")]
	private void BearFadeFinish()
	{
	}

	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "DoChangeWeapon")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "WeaponPickerBegin")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	private void SetWeaponIcon()
	{
	}

	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateBear")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateWolf")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Update")]
	[Calls(Type = typeof(AiDifficultySetting), Member = "GetStrugglePlayerDamageReceivedScale")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetStrugglePlayerDamageReceivedScale")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	private void ApplyPlayerDamagePerSecond(float damagePerSecond, DamageSource damageCause)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateBear")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateWolf")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Update")]
	[Calls(Type = typeof(PlayerManager), Member = "ApplyDamageToWornClothing")]
	[Calls(Type = typeof(AiDifficultySetting), Member = "GetStrugglePlayerClothingDamageScale")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetStrugglePlayerClothingDamageScale")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void ApplyClothingDamagePerSecond(float damagePerSecond)
	{
	}

	[Calls(Type = typeof(DamageProtection), Member = "GetTotalBrokenRibModifier")]
	[CallsUnknownMethods(Count = 22)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ApplyMooseDamageAfterStruggleEnds")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BeginReturnToStart")]
	[Calls(Type = typeof(BrokenRib), Member = "BrokenRibStart")]
	[Calls(Type = typeof(DamageProtection), Member = "HasDamageProtection")]
	[Calls(Type = typeof(DamageProtection), Member = "GetTotalAnimalDamageModifier")]
	[Calls(Type = typeof(DamageProtection), Member = "HasDamageProtection")]
	[Calls(Type = typeof(PlayerManager), Member = "GetDamageReductionFromExteriorClothing")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetStugglePlayerPercentLossFromBearScale")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private void ApplyDamageAfterMooseAttack(string causeLocId)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerStruggle), Member = "ApplyDamageAfterMooseAttack")]
	private void ApplyMooseDamageAfterStruggleEnds()
	{
	}

	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IsHuntedBear")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IncrementWaypoint")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[Calls(Type = typeof(BearHuntRedux), Member = "OnBearSpearOutcome")]
	[Calls(Type = typeof(BloodLoss), Member = "BloodLossStart")]
	[Calls(Type = typeof(BloodLoss), Member = "GetLocationOfLastAdded")]
	[CallsUnknownMethods(Count = 48)]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(InfectionRisk), Member = "InfectionRiskStart")]
	[Calls(Type = typeof(DamageProtection), Member = "GetTotalAnimalDamageModifier")]
	[Calls(Type = typeof(DamageProtection), Member = "HasDamageProtection")]
	[Calls(Type = typeof(PlayerManager), Member = "GetDamageReductionFromExteriorClothing")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetStugglePlayerPercentLossFromBearScale")]
	[Calls(Type = typeof(PlayerStruggle), Member = "RetrieveBearHuntReduxSettings")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetStugglePlayerPercentLossFromBearScale")]
	[Calls(Type = typeof(PlayerManager), Member = "DisableCharacterController")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	private void ApplyBearDamageAfterStruggleEnds()
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "GetUpAnimationComplete")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ShowHands")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(Utils), Member = "SetCameraFOVSafe")]
	[Calls(Type = typeof(CameraFade), Member = "BashFadeAlpha")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CameraEffects), Member = "BlurSetSize")]
	private void ResetGameSettingsToNormal()
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Update")]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateDebugText()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "MaybeReceiveAIAttack")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	private float GetNextAttackTime()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateBear")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateWolf")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Update")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup")]
	[Calls(Type = typeof(PlayerStruggle), Member = "GetNextAttackTime")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(DamageEventTable), Member = "MaybeApplyAttack")]
	[Calls(Type = typeof(PlayerStruggle), Member = "GetActiveDamageEventTable")]
	[Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void MaybeReceiveAIAttack()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "InitializeStruggle")]
	[CallsUnknownMethods(Count = 13)]
	private void ResetDamageEvents()
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "Start")]
	[Calls(Type = typeof(DamageEventTable), Member = "Initialize")]
	[CallsUnknownMethods(Count = 5)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(DamageEventTable), Member = "Initialize")]
	[CallerCount(Count = 1)]
	private void DamageEventsInitialize()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "MaybeReceiveAIAttack")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ReceiveAIAttack")]
	[CallsUnknownMethods(Count = 7)]
	private DamageEventTable GetActiveDamageEventTable()
	{
		return null;
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(DamageEventTable), Member = "MaybeApplyAttack")]
	[Calls(Type = typeof(PlayerStruggle), Member = "GetActiveDamageEventTable")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private bool ReceiveAIAttack()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerStruggle), Member = "IsHuntedBear2ChallengeEnd")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "set_eulerAngles")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BeginReturnToStart")]
	[CallsUnknownMethods(Count = 1)]
	private bool ShouldPlayDraggingAnimation(BaseAi bai, ref Quaternion overrideRotation)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BeginReturnToStart")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ShouldPlayDraggingAnimation")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IsHuntedBear")]
	private bool IsHuntedBear2ChallengeEnd()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillRevolver")]
	[Calls(Type = typeof(Skill_Revolver), Member = "GetStruggleBonus")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "WolfTap")]
	[CallsUnknownMethods(Count = 7)]
	private float GetFleeChanceOnHitPercent()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Skill_Revolver), Member = "GetStruggleBonus")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillRevolver")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public float GetFleeChanceOnRevolverShotPercent()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	private bool IsBearSpearOutcomeSuccess()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BeginSpearStruggle")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ApplyBearDamageAfterStruggleEnds")]
	private BearHuntReduxSettings RetrieveBearHuntReduxSettings()
	{
		return null;
	}

	[Calls(Type = typeof(PlayerStruggle), Member = "GetUpAnimationComplete")]
	[CallerCount(Count = 0)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(PlayerMovement), Member = "AddSprintStamina")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BeginSpearStruggle")]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeApplyStaminaCost(float staminaCost)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BeginSpearStruggle")]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeDisableStaminaRecharge()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "OnPlayerDeath")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private void MaybeEnableStaminaRecharge()
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[Calls(Type = typeof(Animator), Member = "PlayInFixedTime")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "LateUpdate")]
	private void SynchronizePartnerAnimation()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Animator), Member = "PlayInFixedTime")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void SynchronizeAnimationState(AnimatorStateInfo partnerAnimatorStateInfo, AnimatorStateInfo fpAnimatorStateInfo, int partnerHash, int fpHash)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 19)]
	public PlayerStruggle()
	{
	}
}
