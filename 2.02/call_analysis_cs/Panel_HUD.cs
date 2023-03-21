using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using SpecialEvents;
using TMPro;
using UnityEngine;

public class Panel_HUD : Panel_Base
{
	public class BuffNotification
	{
		public string m_BuffNameLocID;

		public string m_BuffHeaderLocId;

		public string m_BuffSpriteName;

		public bool m_BuffWasGained;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public BuffNotification()
		{
		}
	}

	public class CreditsQueueInfo
	{
		public bool m_IsCenter;

		public string m_MessageCenter;

		public string m_MessageTop;

		public string m_MessageBottom;

		public float m_TweenDuration;

		public float m_WaitDuration;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public CreditsQueueInfo()
		{
		}
	}

	[Serializable]
	public class ScentIndicator
	{
		public UIWidget m_ScentIndicatorRoot;

		public UISprite m_Sprite_ScentIndicator1;

		public UISprite m_Sprite_ScentIndicator2;

		public UISprite m_Sprite_ScentIndicator3;

		public GameObject m_ScentIndicatorEmptySlot1;

		public GameObject m_ScentIndicatorEmptySlot2;

		public GameObject m_ScentIndicatorEmptySlot3;

		public float m_SecondsToShowOnStateChange;

		public float m_SecondsToFadeOut;

		public bool m_AlwaysShowWhenAboveZero;

		private int m_IndicatorValue;

		private float m_TimerSeconds;

		private bool m_DoFadeOut;

		private readonly int[] m_RangeScents;

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ScentIndicator), Member = "SetVisibleSprites")]
		private void UpdateSprites(int indicatorValue)
		{
		}

		[CalledBy(Type = typeof(Panel_FirstAid), Member = "Update")]
		[CalledBy(Type = typeof(Panel_FirstAid), Member = "UpdateScentIndicator")]
		[Calls(Type = typeof(ScentIndicator), Member = "SetActive")]
		[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
		[CallsUnknownMethods(Count = 8)]
		[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateScentIndicator")]
		[Calls(Type = typeof(ScentIndicator), Member = "SetActive")]
		[Calls(Type = typeof(Time), Member = "get_deltaTime")]
		[Calls(Type = typeof(ScentIndicator), Member = "SetVisibleSprites")]
		[Calls(Type = typeof(ScentIndicator), Member = "SetActive")]
		[Calls(Type = typeof(ScentIndicator), Member = "SetActive")]
		[Calls(Type = typeof(ScentIndicator), Member = "GetIndicatorValue")]
		[Calls(Type = typeof(Inventory), Member = "GetExtraScentIntensity")]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallerCount(Count = 4)]
		public void Update()
		{
		}

		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(ScentIndicator), Member = "Update")]
		[CalledBy(Type = typeof(ScentIndicator), Member = "Update")]
		[CalledBy(Type = typeof(ScentIndicator), Member = "Update")]
		[CalledBy(Type = typeof(ScentIndicator), Member = "Update")]
		[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateScentIndicator")]
		[Calls(Type = typeof(Utils), Member = "SetActive")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 6)]
		[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
		public void SetActive(bool enabled)
		{
		}

		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 5)]
		[CalledBy(Type = typeof(ScentIndicator), Member = "UpdateSprites")]
		[CalledBy(Type = typeof(ScentIndicator), Member = "Update")]
		[CallsUnknownMethods(Count = 7)]
		private void SetVisibleSprites(int indicatorValue)
		{
		}

		[CallsUnknownMethods(Count = 21)]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
		[CalledBy(Type = typeof(ScentIndicator), Member = "Update")]
		private int GetIndicatorValue(float scent)
		{
			return default(int);
		}

		[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		public ScentIndicator()
		{
		}
	}

	public enum MoraleMeterState
	{
		Inactive,
		Hidden,
		Visible
	}

	public GameObject m_BuffNotificationParent;

	public GameObject m_BuffNotificationAimingParent;

	public GameObject m_BuffNotificationPanel;

	public UILabel m_BuffHeaderLabel;

	public UILabel m_BuffNameLabel;

	public UISprite m_BuffSprite;

	public float m_BuffNotificationDurationSeconds;

	public string m_BuffSpriteWellFed;

	public string m_BuffSpriteFatigueBuff;

	public string m_BuffSpriteFreezingBuff;

	public string m_BuffSpriteRestBuff;

	public string m_BuffSpriteConditionOverTimeBuff;

	public string m_BuffSpriteSprainProtection;

	public UIWidget[] m_BuffWidgetsToChangeColor;

	public Color m_BuffGainColor;

	public Color m_BuffLossColor;

	private bool m_IsShowingBuffNotification;

	private List<BuffNotification> m_BuffNotificationQueue;

	private float m_BuffNotificationElapsedSeconds;

	public TweenAlpha m_CairnNotificationTween;

	public UILabel m_CairnNameLabel;

	public UILabel m_CairnQuoteLabel;

	public UILabel m_CairnBackerLabel;

	public UILabel m_CairnThanksLabel;

	private bool m_IsShowingCairnNotification;

	public GameObject m_CollectibleNoteObject;

	public UILabel m_CollectibleNoteObjectText;

	public UILabel m_CollectibleNoteObjectTitle;

	public GameObject m_CollectibleNoteScrollObject;

	public UIScrollView m_CollectibleNoteScrollView;

	private float m_ScrollPanelHeight;

	private Color m_SliderDefaultColor;

	private float m_TitleY;

	private float m_TitleYOffset;

	public GameObject m_CreditsParentObject;

	public TweenAlpha m_CenterLabelTween;

	public TweenAlpha m_SideLabelTopTween;

	public TweenAlpha m_SideLabelCenterTween;

	public TweenAlpha m_SideLabelBottomTween;

	public float m_MinTimeBetweenCredits;

	private List<CreditsQueueInfo> m_CreditsQueue;

	private float m_CreditsQueueTimer;

	private float m_CreditsWaitTimer;

	public ScentIndicator m_ScentIndicator;

	public float m_TextFadeOutTimeSeconds;

	public float m_ConditionTweenNormalizedThreshold;

	public UIWidget m_Widget_Affliction;

	public UISprite m_Sprite_HasAffliction;

	public UISprite m_Sprite_HasAfflictionRisk;

	public UISprite m_Sprite_Crouching;

	public UITexture m_Texture_InspectItem;

	public UILabel m_Label_Calories;

	public UILabel m_Label_Condition;

	public UILabel m_Label_DebugLines;

	public UILabel m_Label_DebugPlayerInfo;

	public UILabel m_Label_DebugString;

	public UILabel m_Label_DebugStruggleEvents;

	public UILabel m_Label_DebugHeavyBreathing;

	public UILabel m_Label_FPS;

	public UILabel m_Label_SurvivalTime;

	public UILabel m_Label_Message;

	public UILabel m_Label_MessageBottom;

	public UILabel m_Label_ItemProgressBar;

	public UILabel m_Label_WarningMessage;

	public Animator m_ThinIceAnimator;

	public UIWidget m_ThinIceWidget;

	public UILabel m_Label_DebugCompass;

	public UILabel m_Label_DebugMissionText;

	public GameObject m_ClickHoldCancelButton;

	public ButtonPrompt m_ExitDialogueButtonPrompt;

	public UISprite m_ProgressBar_Item;

	public UISlider m_Slider_TOD;

	public UILabel m_SliderLabel_TOD;

	public UISprite m_Sprite_Crosshair;

	public UISprite m_Sprite_CrosshairClickHold;

	public UISlider m_Slider_StruggleWolfHealth;

	public UILabel m_Label_WolfHealth;

	public UISprite m_Sprite_UnarmedIcon;

	public UITexture m_Texture_StruggleWeapon;

	public UILabel m_Label_StruggleWeaponBonus;

	public UILabel m_Label_StruggleLMB;

	public UILabel m_Label_StruggleRMB;

	public UILabel m_Label_StruggleCaption;

	public GameObject m_StruggleWidget;

	public GameObject m_StruggleRevolverWidget;

	public TweenAlpha[] m_Struggle_TweenAlpha;

	public GameObject m_Struggle_Button_Mouse;

	public GameObject m_Struggle_Button_Key;

	public UISprite m_Struggle_Button_Key_Sprite;

	public UISprite m_Struggle_Button_Key_Feedback;

	public UILabel m_Struggle_Button_Key_Label;

	public GameObject m_Struggle_Button_Gamepad;

	public GameObject m_Struggle_Revolver_Shoot_Button_Mouse;

	public GameObject m_Struggle_Revolver_Shoot_Button_Key;

	public GameObject m_Struggle_Revolver_Shoot_Button_Gamepad;

	public UILabel m_Label_Struggle_Revolver_Shoot_Caption;

	public UISprite m_Sprite_SystemFadeOverlay;

	public UISprite m_Sprite_CinematicFadeOverlay;

	public GameObject m_NonEssentialHud;

	public GameObject m_EssentialHud;

	public AccelTimePopup m_AccelTimePopup;

	public GameObject m_FreeTrialMode;

	public UILabel m_FreeTrialModeTimeLabel;

	public UILabel m_ExperimentalBuildLabel;

	public EquipItemPopup m_EquipItemPopup;

	public TwoButtonsChoiceUI m_TwoButtonsChoiceUI;

	public GenericInteractionCancelUI m_InteractionCancelUI;

	public Animator m_SprainWarningAnimator;

	public UIWidget m_SprainWarningWidget;

	public Transform m_SmallSizeGroup;

	public Transform m_RegularSizeGroup;

	public Transform m_LargeSizeGroup;

	public GameObject m_BearSpearTarget;

	public GameObject m_BearSpearVisorDebug;

	public GameObject m_BearSpearTopRightCorner;

	public UIWidget m_SprintBar;

	public UISprite m_Sprite_SprintBarX;

	public UISprite m_Sprite_SprintBar;

	public UISprite m_Sprite_SprintBarGlow;

	public UISprite m_Sprite_SprintBarBackground;

	public UISprite m_Sprite_SprintReductionBar;

	public Color m_SprintBarNoSprintColor;

	public Color m_SprintBarGlowNoSprintColor;

	public Color m_SprintBarBackgroundNoSprintColor;

	private Color m_SprintIconOriginalColor;

	private Color m_SprintBarOrigionalColor;

	private Color m_SprintBarGlowOrigionalColor;

	private Color m_SprintBarBackgroundOrigionalColor;

	public float m_SprintBar_SecondsBeforeFadeOut;

	public float m_SprintBar_SecondsToFadeOut;

	public UIWidget m_AimingStaminaBar;

	public UIWidget m_AimingLimitedMobility;

	public UISprite m_Sprite_AimingStaminaBar;

	public UISprite m_Sprite_AimingStaminaBarGlow;

	public UISprite m_Sprite_AimingStaminaBarCenter;

	public UISprite m_Sprite_AimingStaminaBarBackground;

	public UISprite m_Sprite_AimingStaminaBarReductionBar;

	public float m_AimingStaminaBar_SecondsBeforeFadeOut;

	public float m_AimingStaminaBar_SecondsToFadeOut;

	public GameObject m_Button_InspectModePutBack_Mac;

	public GameObject m_Button_InspectModePutBack_PC;

	public UISprite m_Sprite_GamepadTake;

	public UISprite m_Sprite_GamepadPutback;

	public UISprite m_Sprite_GamepadEquip;

	public UISprite m_Sprite_GamepadStruggleTap;

	public UIGrid m_PlayerDamageEventsGrid;

	public GameObject m_PlayerDamageEventPrefab;

	public UISprite m_StruggleBar;

	public float m_StruggleBarFillOffset;

	public UISprite m_Sprite_GamepadRevolverShoot;

	public UISprite m_Sprite_Encumbered;

	public UISprite m_Sprite_CapacityBuff;

	public UISprite m_Sprite_Sheltered;

	public UISprite m_Sprite_Cold;

	public UISprite m_Sprite_Thirsty;

	public UISprite m_Sprite_Tired;

	public UISprite m_Sprite_Hungry;

	public UISprite m_Sprite_SprintCenter;

	public UISprite m_Sprite_ClimbCenter;

	public UISprite m_Sprite_SpearCenter;

	public UISprite m_Sprite_CarryRestrictions;

	public UIWidget m_Widget_GearMessage;

	public UISprite m_Sprite_GearMessageIcon;

	public UITexture m_Texture_GearMessageIcon;

	public UILabel m_Label_GearMessageHeader;

	public UILabel m_Label_GearMessageText;

	public UILabel m_Label_GearMessageQuickKeyText;

	public Transform m_GearMessageNormalLocation;

	public Transform m_GearMessageOffsetLocation;

	public UIWidget m_VistaNotification;

	public UILabel m_VistaNotificationTitle;

	public UILabel m_VistaNotificationDescription;

	public UITexture m_VistaNotificationPostcardTexture;

	public List<Texture> m_VistaPostcardTextures;

	public float m_VistaNotificationDurationSeconds;

	public TextMeshPro m_TMP_Location;

	public TextMeshPro m_TMP_Region;

	public LocationRevealText m_TMP_Location_FadeComponent;

	public Vector3 m_TMPLocationPosAlone;

	public Vector3 m_TMPLocationPosUnderRegion;

	public TweenAlpha m_NewLocationDiscovered;

	public float m_StatusIconsHorizontalOffset;

	public float m_StatusIconVerticalOffset;

	public float m_StatusIconsPadding;

	public Color m_StatusIconRedColor;

	public ButtonLegendContainer m_FlyModeButtonLegendContainer;

	public ButtonLegendContainer m_TimePopupButtonLegendContainer;

	public ButtonLegendContainer m_GenericButtonLegendContainer;

	public float m_DamageEventDisplaySeconds;

	public float m_DamageEventFadeOutSeconds;

	public UISprite m_FireGamepadButtonSprite;

	public UISprite m_AltFireGamepadButtonSprite;

	public UISprite m_InspectMode_InventoryStatusSprite;

	public UIWidget m_SkillIncreaseWidget;

	public UISprite m_SkillIncreaseIcon;

	public UIWidget m_SkillLevelUpWidget;

	public UISprite m_SkillLevelUpBackgroundIcon;

	public UILabel m_SkillLevelUpLabel;

	public UILabel m_SkillLevelUpHeader;

	public UILabel m_SkillLevelUpFooter;

	public UIWidget m_FeatUnlockedWidget;

	public UITexture m_FeatUnlockedBadgeIcon;

	public UILabel m_FeatUnlockedFooter;

	public GameObject m_HoverTextObject;

	public UILabel m_Label_ObjectName;

	public UILabel m_Label_SubText;

	public UILabel m_Label_FireTime;

	public UILabel m_Label_FireTemp;

	public UISprite m_HoverTextBG;

	public UISprite m_HoverTextLinebreak;

	public int m_HoverTextLinebreakOffset;

	public UISprite[] m_HoverTextIcons;

	public UISprite[] m_HoverTextIconsRow2;

	public UISprite[] m_HoverTextIconsRow3;

	public int m_HoverTextBGPadding;

	public int m_HoverTextBGPaddingBonusWithIcons;

	public int m_HoverTextBGSizePerIcon;

	public int m_HoverTextBGHeightWithSub;

	public int m_HoverTextBGHeightWithFire;

	public UIGrid m_HoverTextGrid;

	public GameObject m_HoverTextGridRow1;

	public GameObject m_HoverTextGridRow2;

	public GameObject m_HoverTextGridRow3;

	public Color m_HoverTextNormalColor;

	public Color m_HoverTextTheftColor;

	public Color m_HoverTextUnlockedColor;

	public Color m_HoverTextLockedColor;

	public GameObject m_InspectMode_StandardElementsParent;

	public GameObject m_InspectMode_InspectPrompts;

	public Transform m_InspectMode_StatDetails;

	public float m_StatDetailsOffsetFromDesc;

	public float m_StatDetailsOffsetFromContains;

	public UISprite m_Sprite_Condition;

	public UISprite m_Sprite_ConditionBarBG;

	public UISprite m_Sprite_ConditionBarFG;

	public UISprite m_Sprite_ContainsFG;

	public UISprite m_Sprite_ContainsBG;

	public UISprite m_Sprite_Weight;

	public UISprite m_InspectMode_FoodHot;

	public UISprite m_InspectMode_FoodCold;

	public UILabel m_InspectMode_Conditon;

	public UILabel m_InspectMode_Contains;

	public UILabel m_InspectMode_Description;

	public UILabel m_InspectMode_Equip;

	public UILabel m_InspectMode_PutBack;

	public UILabel m_InspectMode_Take;

	public UILabel m_InspectMode_Title;

	public UILabel m_InspectMode_Weight;

	public UILabel m_InspectMode_InventoryStatus;

	public UILabel m_InspectMode_ResearchBenefit;

	public string m_UnitsSprite_Calories;

	public string m_UnitsSprite_WaterPotable;

	public string m_UnitsSprite_WaterNonPotable;

	public string m_UnitsSprite_Time;

	public UISprite[] m_InspectModeItemTypeIcons;

	public float m_InspectFadeAlphaPerSecond;

	public float m_InspectStartFadeSecondsFast;

	public UIWidget[] m_InspectElementsToFadeFast;

	public float m_InspectStartFadeSecondsMediumFast;

	public UIWidget[] m_InspectElementsToFadeMediumFast;

	public float m_InspectStartFadeSecondsMedium;

	public UIWidget[] m_InspectElementsToFadeMedium;

	public float m_InspectStartFadeSecondsSlow;

	public UIWidget[] m_InspectElementsToFadeSlow;

	public float m_InspectStartFadeSecondsSlowest;

	public UIWidget[] m_InspectElementsToFadeSlowest;

	public GameObject m_BearHuntWidget;

	public UISprite m_BearHuntProgressBar;

	public TextMeshPro m_FullScreenMessageTMP;

	public MissionInfoHUD m_MissionInfoHUD;

	public HUDChapter m_ChapterPanel;

	public HUDMission m_MissionPanel;

	public HUDObjectives m_ObjectivesPanel;

	public HUDTutorial m_TutorialPanel;

	public List<GenericStatusBarSpawner> m_NPCStatusBarSpawners;

	public List<GameObject> m_NpcStatusHudObjects;

	public List<UILabel> m_NpcNames;

	public float m_MaxDistanceToShowNpcCondition;

	[NonSerialized]
	public UILabel m_InspectMode_ToolTip;

	[NonSerialized]
	public bool m_EnableDiscoveryText;

	public float m_MaxMoraleMeterPackSize;

	public Animator m_MoraleMeterAnimator;

	public UIWidget m_MoraleMeterWidget;

	public UITexture m_MoraleMeter;

	public UITexture m_MoraleMeterBackground;

	public UILabel m_MoralePackNumber;

	private float m_FillBarPercentPerMember;

	public UIWidget m_SuffocatingMeterWidget;

	public UISprite m_SuffocatingMeterForeground;

	public UILabel m_SuffocatingRemainingTime;

	public LocalizedString m_SuffocationTimeRemaining;

	public GenericInteractionPrompt m_GenericInteractionPrompt;

	public GameObject m_GenericCancelPrompt;

	public ButtonPrompt m_GenericCancelButtonPrompt;

	public GameObject m_TitleCards;

	public HUDNowhereToHide m_NowhereToHide;

	private MoraleMeterState m_MoraleMeterState;

	private static readonly int s_AnimState_PackMoraleIn;

	private static readonly int s_AnimState_PackMoraleOut;

	private static readonly int s_AnimState_PackMoraleIdle;

	public static bool m_DebugHeavyBreathing;

	public static bool m_HideTestBuildWatermark;

	public bool m_ForceTimeOfDayDisplay;

	[NonSerialized]
	public bool m_ForceHideNotifications;

	private bool m_ForceDisableTimeOfDayDisplay;

	private bool m_DisplayVistaNotification;

	private string m_DisplayVistaPostcardName;

	private float m_VistaNotificationElapsedDisplayTimeSeconds;

	private bool m_DisplaySurvivalTimeAfterRest;

	private float m_SurvivalTimeLabelDisplayTimeSeconds;

	private float m_SurvivalTimeLabelElapsedDisplayTimeSeconds;

	private float m_SurvivalTimeLabelAlpha;

	private float m_ItemProgressBarTimer;

	private float m_ItemProgressBarDuration;

	private Action m_ItemProgressBarCallback;

	private GearItem m_ItemProgressBarRelatedItem;

	private bool m_ItemProgressBarCancelled;

	private bool m_ItemProgressBarActive;

	private float m_RegisterClickAsHoldDelay;

	private float m_ItemProgressBarMinDuration;

	private HudDisplayMode m_HudDisplayMode;

	private bool m_SetDisplayModeOnce;

	private float m_TimeToHideSubtitles;

	private float m_AspectRatioBonusSize;

	private int m_HoverTextSizeOrig;

	private bool m_WasFadedDueToSleep;

	private int m_PanelDepthOrig;

	private bool m_FadeOutDamageEvents;

	private float m_DamageEventsTimeSinceFadoutStarted;

	private float m_DamageEventsFadeOutTimerStartsInSeconds;

	private float m_DamageEventsFadeoutTime;

	private int m_HoverTextBGHeightOrig;

	private List<Transform> m_StatusIconTransforms;

	private bool m_CinematicBlackout;

	private bool m_HideHudElements;

	private bool m_HideReticle;

	private TweenScale m_TweenScaleAffliction;

	private string m_CurrentObjectiveLocID;

	private string m_DisplayedMissionID;

	private float m_DisplayedMissionNextUpdate;

	private static readonly float DISPLAYED_MISSION_UPDATE_DELAY;

	private float m_SprintFadeTimeTracker;

	private float m_AimStaminaFadeTimeTracker;

	private Queue<LocationRevealQueueInfo> m_LocationRevealQueue;

	private static readonly int NUM_CACHED_OBJECTIVES;

	private List<string> m_LastObjectiveIDs;

	private List<StoryMissionObjective> m_TempObjectives;

	private Animator m_StruggleWidgetAnimator;

	private int m_AnimParameter_EnableRevolverPointBlank;

	private uint m_TimerwolfCombatMusicPlayingID;

	private NPCStatusBar[] m_SatusBars;

	public static bool s_DebugStoryHUD;

	public TimedActionPopup m_TimedActionPopup;

	private GameObject m_PreviousItemUnderCrosshairs;

	private HoverTextState m_PreviousTextState;

	private string m_PreviousHoverText;

	private bool m_WasSuffocating;

	[CalledBy(Type = typeof(FreezingBuff), Member = "Apply")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(WellFed), Member = "WellFedStart")]
	[CalledBy(Type = typeof(SprainProtection), Member = "Update")]
	[CalledBy(Type = typeof(DamageProtection), Member = "ApplyProtectionBuff")]
	[CalledBy(Type = typeof(FatigueBuff), Member = "Apply")]
	[CalledBy(Type = typeof(ConditionOverTimeBuff), Member = "Apply")]
	[CalledBy(Type = typeof(EmergencyStim), Member = "ApplyEmergencyStim")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(ConditionRestBuff), Member = "Apply")]
	public void ShowBuffNotification(string buffNameLocID, string buffHeaderLocId, string buffSpriteName)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateConditonBuffDuration")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateBuffDurations")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateBuffDurations")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateBuffDurations")]
	[CalledBy(Type = typeof(DamageProtection), Member = "RemoveProtectionBuff")]
	[CalledBy(Type = typeof(SprainProtection), Member = "Update")]
	[CalledBy(Type = typeof(EmergencyStim), Member = "ApplyEmergencyStimExitEffects")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(WellFed), Member = "WellFedEnd")]
	public void ShowBuffLossNotification(string buffNameLocID, string buffHeaderLocId, string buffSpriteName)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void HideBuffNotification()
	{
	}

	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShouldHideNotification")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Panel_HUD), Member = "DoShowBuffNotification")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShouldHideNotification")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	private void UpdateBuffNotification()
	{
	}

	[CalledBy(Type = typeof(Panel_HUD), Member = "DoShowBuffNotification")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[CallsUnknownMethods(Count = 10)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	private void StartBuffNotificationTweeens(GameObject parent)
	{
	}

	[CallsUnknownMethods(Count = 30)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateBuffNotification")]
	[Calls(Type = typeof(Panel_HUD), Member = "StartBuffNotificationTweeens")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void DoShowBuffNotification(BuffNotification buffNotification)
	{
	}

	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[CalledBy(Type = typeof(Cairn), Member = "ProcessInteraction")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	public void ShowCairnNotification(Cairn cairn)
	{
	}

	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void HideCairnNotification()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_HUD), Member = "ShouldHideNotification")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateCairnNotification()
	{
	}

	[CalledBy(Type = typeof(Panel_HUD), Member = "Initialize")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(Panel_HUD), Member = "HideCollectibleNote")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public void SetupCollectibleNote()
	{
	}

	[CallsUnknownMethods(Count = 52)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIScrollView), Member = "Scroll")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_HUD), Member = "UpdateCollectibleNote")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "ProcessAndRequest")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 24)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	public void ShowCollectibleNote(GearItem gearItem)
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "OnCollectibleNoteReadingClickBack")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnCollectibleNoteReadingClickBack()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Panel_HUD), Member = "RefreshHudDisplayMode")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "SetupCollectibleNote")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnCollectibleNoteReadingClickBack")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitInspectGearMode")]
	[CallsUnknownMethods(Count = 24)]
	public void HideCollectibleNote(GearItem gearItem)
	{
	}

	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShowCollectibleNote")]
	[Calls(Type = typeof(UIScrollView), Member = "Scroll")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVerticalRightStick")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallsUnknownMethods(Count = 9)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	public void UpdateCollectibleNote()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(InterfaceManager), Member = "ShouldEnableMousePointer")]
	[CallerCount(Count = 1)]
	public bool IsShowingCollectibleNote()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 7)]
	public void ShowReadNoteButtonLegend()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowQueuedCredits")]
	[CalledBy(Type = typeof(Action_ShowCenterCredit), Member = "OnExecute")]
	public void ShowCreditsCenter(string msg, float tweenDuration, float waitDuration)
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Action_ShowSideCredits), Member = "OnExecute")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowQueuedCredits")]
	public void ShowCreditsSide(string msgTop, string msgCenter, string msgBottom, float waitDuration)
	{
	}

	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateCredits")]
	[CallAnalysisFailed]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShowCreditsCenter")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShowCreditsSide")]
	private void ShowQueuedCredits(CreditsQueueInfo creditsInfo)
	{
	}

	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	private void ShowQueuedCreditsCenter(string msg)
	{
	}

	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	private void ShowQueuedCreditsSide(string msgTop, string msgCenter, string msgBottom)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void HideCredits()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowQueuedCredits")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShouldHideNotification")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShouldHideNotification")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private void UpdateCredits()
	{
	}

	[Calls(Type = typeof(ScentIndicator), Member = "SetActive")]
	[Calls(Type = typeof(ScentIndicator), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_HUD), Member = "ShouldHideConditionRelatedLabels")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_HUD), Member = "IsNonRadialOverlayActive")]
	private void UpdateScentIndicator()
	{
	}

	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(Animator), Member = "StringToHash")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsUnknownMethods(Count = 87)]
	[Calls(Type = typeof(HUDNowhereToHide), Member = "Reset")]
	[Calls(Type = typeof(HUDObjectives), Member = "Disable")]
	[Calls(Type = typeof(Panel_HUD), Member = "SetupCollectibleNote")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "get_fontSize")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(Panel_HUD), Member = "SetHoverText")]
	[CallsDeduplicatedMethods(Count = 39)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameManager), Member = "IsTrialMode")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	public override void Initialize()
	{
	}

	[Calls(Type = typeof(ButtonLegend), Member = "ConfigureButtonIconSpriteName")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShouldHideNotification")]
	[Calls(Type = typeof(Panel_HUD), Member = "UpdateCollectibleNote")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(ButtonLegend), Member = "ConfigureButtonIconSpriteName")]
	[Calls(Type = typeof(Panel_HUD), Member = "UpdateAimingStaminaBar")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_HUD), Member = "MaybeFadeOutIndividualDamageEvents")]
	[Calls(Type = typeof(Panel_HUD), Member = "FadeOutAllEvents")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Panel_HUD), Member = "UpdateStaminaBar")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameManager), Member = "TrialModeTimeRemaining")]
	[Calls(Type = typeof(InputManager), Member = "IsSteamControllerActive")]
	[Calls(Type = typeof(CameraFade), Member = "GetTargetAlpha")]
	[Calls(Type = typeof(Panel_HUD), Member = "UpdateCredits")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShouldHideConditionRelatedLabels")]
	[Calls(Type = typeof(GameManager), Member = "IsTrialMode")]
	[CallsUnknownMethods(Count = 100)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Enable")]
	[Calls(Type = typeof(PlayerSkills), Member = "ShowSkillIncreaseMessages")]
	[Calls(Type = typeof(Panel_HUD), Member = "UpdateSuffocatingMeter")]
	[Calls(Type = typeof(Panel_HUD), Member = "UpdateNowhereToHideEvent")]
	[Calls(Type = typeof(Panel_HUD), Member = "UpdatePackMorale")]
	[Calls(Type = typeof(Panel_HUD), Member = "UpdateCurrentNPCCondition")]
	[Calls(Type = typeof(Panel_HUD), Member = "UpdateCurrentMissionDisplay")]
	[Calls(Type = typeof(Panel_HUD), Member = "UpdatePopupPanels")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShouldHideNotification")]
	[Calls(Type = typeof(ScentIndicator), Member = "SetActive")]
	[Calls(Type = typeof(ScentIndicator), Member = "Update")]
	[Calls(Type = typeof(Panel_HUD), Member = "IsNonRadialOverlayActive")]
	[Calls(Type = typeof(UIPanel), Member = "set_depth")]
	[Calls(Type = typeof(GameManager), Member = "IsTrialMode")]
	[Calls(Type = typeof(Panel_HUD), Member = "UpdateBuffNotification")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_HUD), Member = "ExitDialogueUpdate")]
	[Calls(Type = typeof(Panel_HUD), Member = "ItemProgressBarCheck")]
	[Calls(Type = typeof(Panel_HUD), Member = "UpdateSurvivalTimeLabel")]
	[Calls(Type = typeof(Panel_HUD), Member = "UpdateVistaNotification")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowLocationReveal")]
	[Calls(Type = typeof(Panel_HUD), Member = "CanShowLocationReveal")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(Panel_HUD), Member = "MaybeHideHudElementsThatOverlapPauseMenuIcon")]
	[Calls(Type = typeof(UIRect), Member = "get_root")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(UIRect), Member = "get_root")]
	[CallsDeduplicatedMethods(Count = 34)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_HUD), Member = "UpdateDebugCompass")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(PlayerManager), Member = "CancelItemInHandsAction")]
	[Calls(Type = typeof(UILabel), Member = "set_fontSize")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShouldShowAfflictionSprite")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsCrouched")]
	[Calls(Type = typeof(Panel_HUD), Member = "UpdateBuffCapacityIcon")]
	[Calls(Type = typeof(Panel_HUD), Member = "IsNonRadialOverlayActive")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShouldHideConditionRelatedLabels")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShouldHideCaloriesLabel")]
	[Calls(Type = typeof(Panel_HUD), Member = "UpdateEnvironmentStateIconVisibility")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShouldHideConditionRelatedLabels")]
	[Calls(Type = typeof(Panel_HUD), Member = "IsNonRadialOverlayActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(PlayerMovement), Member = "StaminaUsedForClimbing")]
	[Calls(Type = typeof(PlayerManager), Member = "IsCancelableActionInProgress")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShouldShowAfflictionRiskSprite")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShouldShowAlternateColor")]
	[Calls(Type = typeof(Panel_HUD), Member = "ToggleConditionTween")]
	private void Update()
	{
	}

	[Calls(Type = typeof(Panel_HUD), Member = "UpdateStatusIcons")]
	[CallerCount(Count = 0)]
	public void LateUpdate()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public bool IsShowingGenericInteractionPrompt()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool IsOverlayActive()
	{
		return default(bool);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Enable")]
	public void EnableTimeOfDayScaleDisplay(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	public void ForceDisableTimeOfDayScaleDisplay(bool disable)
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public void EnableForcedTimeOfDayScaleDisplay(bool enable)
	{
	}

	[CalledBy(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_timeofday_display")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsTimeLapseActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	public void SetConditionLabelDepth()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(HUDNowhereToHide), Member = "Reset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_HUD), Member = "RefreshHudDisplayMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(Panel_HUD), Member = "Update")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_HUD), Member = "EnableTimeOfDayScaleDisplay")]
	public override void Enable(bool enable)
	{
	}

	[CalledBy(Type = typeof(Action_ScrapMetalStruggle), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Action_ScrapMetalStruggle), Member = "UpdateStruggle")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateTapBar")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "InitializeStruggle")]
	public void SetStruggleBarFillAmount(float value)
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(Action_ScrapMetalStruggle), Member = "EnterOutro")]
	[CalledBy(Type = typeof(Action_ScrapMetalStruggle), Member = "EnterStruggle")]
	[CalledBy(Type = typeof(Action_ScrapMetalStruggle), Member = "OnPrepareStruggleComplete")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "MaybeShootRevolver")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BeginSpearStruggle")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "InitStruggleForPartner")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "InitStruggleForPartner")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "InitStruggleForPartner")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "OnPlayerDeath")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BearSpearStruggleTimedOut")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateSpear")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateSpear")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Start")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "DoChangeWeapon")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "WeaponPickerBegin")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 17)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BearSpearStruggleSuccess")]
	public void ShowStruggleWidget(bool enable)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "MaybeShootRevolver")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "InitializeStruggle")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "MaybeShootRevolver")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Start")]
	public void ShowStruggleRevolverWidget(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 1)]
	public void ShowSurvivalTimeAfterRest(string text, float numSeconds)
	{
	}

	[Calls(Type = typeof(LocationRevealText), Member = "StartFade")]
	[Calls(Type = typeof(LocationRevealText), Member = "StartFade")]
	[Calls(Type = typeof(LocationRevealText), Member = "StartFade")]
	[CalledBy(Type = typeof(DisplayLocationLabel), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(DisplayLocationLabel), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateLocationLabel")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShowRegionReveal")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_show_location_reveal")]
	[CalledBy(Type = typeof(HUDManager), Member = "MaybeShowLocationReveal")]
	[CallsUnknownMethods(Count = 26)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[Calls(Type = typeof(LocationRevealText), Member = "SetFontAndHide")]
	[Calls(Type = typeof(TextMeshPro), Member = "get_transform")]
	[Calls(Type = typeof(TextMeshPro), Member = "get_transform")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowNewLocationDiscovered")]
	[Calls(Type = typeof(Panel_Map), Member = "UnlockRegionMap")]
	[Calls(Type = typeof(Panel_Map), Member = "SceneCanBeMapped")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(Panel_HUD), Member = "CanShowLocationReveal")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(LocationRevealText), Member = "SetFontAndHide")]
	public void ShowLocationReveal(string text, string subText = "", bool showNewLocation = false)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(VistaLocation), Member = "MaybeHideNotification")]
	[CalledBy(Type = typeof(VistaLocation), Member = "OnTriggerEnter")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Replace")]
	public void ShowVistaNotification(bool enabled, string gearItemName)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowLocationReveal")]
	public void ShowRegionReveal(string text, string subText, bool showNewLocation = false)
	{
	}

	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShowLocationReveal")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EventDelegate), Member = "Set")]
	private void ShowNewLocationDiscovered()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenAlpha), Member = "set_value")]
	[CallsUnknownMethods(Count = 1)]
	private void HideNewLocationDiscovered()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateCredits")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateCredits")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "MaybeHideNewLocationDiscovered")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateBuffNotification")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateBuffNotification")]
	[CalledBy(Type = typeof(LocationRevealText), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateCairnNotification")]
	public bool ShouldHideNotification()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateEnvironmentStateIconVisibility")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShouldShowAfflictionRiskSprite")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShouldShowAfflictionSprite")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateNowhereToHideEvent")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdatePackMorale")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateCurrentNPCCondition")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateScentIndicator")]
	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "ShouldShow")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateBuffCapacityIcon")]
	public bool IsNonRadialOverlayActive()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Panel_HUD), Member = "ShouldHideNotification")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void MaybeHideNewLocationDiscovered()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(LocationRevealText), Member = "Hide")]
	[Calls(Type = typeof(LocationRevealText), Member = "Hide")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[CalledBy(Type = typeof(GameManager), Member = "Start")]
	[CallsUnknownMethods(Count = 9)]
	public void HideLocationLabel()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public UILabel GetUILabel(string label)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	public void OnSliderTODChange()
	{
	}

	[CalledBy(Type = typeof(RadioTower), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(OpenClose), Member = "StartInteract")]
	[CalledBy(Type = typeof(VehicleDoor), Member = "StartInteract")]
	[CalledBy(Type = typeof(Harvestable), Member = "DoHarvest")]
	[CalledBy(Type = typeof(LoadingZone), Member = "StartInteract")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(LoadScene), Member = "StartInteractInternal")]
	[CalledBy(Type = typeof(Container), Member = "BeginContainerInteraction")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "IgniteDelayed")]
	[CalledBy(Type = typeof(TorchItem), Member = "IgniteDelayed")]
	[CalledBy(Type = typeof(MatchesItem), Member = "IgniteDelayed")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "Toggle")]
	[CalledBy(Type = typeof(FlareItem), Member = "IgniteDelayed")]
	[CalledBy(Type = typeof(Lock), Member = "StartInteractInternal")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallerCount(Count = 14)]
	[CalledBy(Type = typeof(TorchItem), Member = "ExtinguishDelayed")]
	public void StartItemProgressBar(float duration, string progressLabel, GearItem relatedItem, Action callbackDelegate = null)
	{
	}

	[CallerCount(Count = 20)]
	public void CancelItemProgressBar()
	{
	}

	[CallerCount(Count = 0)]
	public bool IsItemProgressBarActive()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "CancelItemInHandsAction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CancelItemInHandsAction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CancelItemInHandsAction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CancelItemInHandsAction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessFireAction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(PlayerManager), Member = "CancelItemInHandsAction")]
	public bool IsProgressBarRelatedItem(GearItem item)
	{
		return default(bool);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void SetHudDisplayMode(HudDisplayMode hudDisplayMode)
	{
	}

	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "HideCollectibleNote")]
	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "Enable")]
	[CalledBy(Type = typeof(HUDManager), Member = "Update")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "SetHudModeForCinematic")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Enable")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(GameManager), Member = "IsMainMenuActive")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	public void RefreshHudDisplayMode()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void DisplayWarningMessage(string msg)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "Enable")]
	[CalledBy(Type = typeof(WetZoneTrigger), Member = "Update")]
	[CalledBy(Type = typeof(WetZoneTrigger), Member = "OnTriggerExit")]
	[CallsUnknownMethods(Count = 5)]
	public void ClearWarningMessage()
	{
	}

	[CallerCount(Count = 0)]
	public void FadeOutDamageEvents(float delayTime, float fadeOutTime)
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "DeserializeTimers")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "RemoveMissionTimer")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "StartMissionTimer")]
	[CallerCount(Count = 3)]
	public void ShowMissionTimer(bool visible)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 4)]
	public void RefreshMissionTimer(string text)
	{
	}

	[CalledBy(Type = typeof(Action_HideObjective), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_Objective), Member = "DoWork")]
	[CalledBy(Type = typeof(Action_4DONObjective), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 20)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ShowPanel")]
	public void ShowMissionMessage(bool visible)
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmDisplay")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmLanguage")]
	[CallsUnknownMethods(Count = 8)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_HUD), Member = "RefreshMissionMessage")]
	public void RefreshObjectiveLabel()
	{
	}

	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 30)]
	[CalledBy(Type = typeof(Action_Objective), Member = "DoWork")]
	[CalledBy(Type = typeof(Action_4DONObjective), Member = "OnExecute")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "RefreshObjectiveLabel")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Panel_Actions), Member = "ConfigureForMissionStart")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	public void RefreshMissionMessage(string locID, Color col, bool allowSkipFirstTime)
	{
	}

	[CallsUnknownMethods(Count = 30)]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_Actions), Member = "ConfigureForMissionStart")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	public void RefreshMissionMessageNoLoc(string mesasge, Color col, bool allowSkipFirstTime)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Action_Message), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_Message), Member = "OnStop")]
	[CallsUnknownMethods(Count = 3)]
	public void ShowDebugMissionText(bool visible)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	public void RefreshDebugMissionText(string str, Color col)
	{
	}

	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UIRect), Member = "UpdateAnchors")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ItemProgressBarCheck")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateHUDText")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateHUDText")]
	[CallsUnknownMethods(Count = 145)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(HoverIconsToShow), Member = "GetSpriteNameForHoverIcon")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 47)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	public void SetHoverText(string hoverText, GameObject itemUnderCrosshairs, HoverTextState textState)
	{
	}

	[CallerCount(Count = 0)]
	public bool GetCinematicBlackout()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_cinematic_fade_blackout")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "MaybeUpdateCinematicFade")]
	[CallsUnknownMethods(Count = 2)]
	public void SetCinematicBlackout(bool enabled)
	{
	}

	[CallerCount(Count = 0)]
	public void HideHudElements(bool hide)
	{
	}

	[CallerCount(Count = 0)]
	public bool GetHideHudElements()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public void HideReticle(bool hide)
	{
	}

	[CallerCount(Count = 0)]
	public bool ShouldHideReticle()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "OnDestroy")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "FadeOutAllEvents")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "HideNotifications")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UIGrid), Member = "GetChild")]
	[CallerCount(Count = 4)]
	public void CleanupDamageEventTable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void SetExperimentalBuildLabel()
	{
	}

	[Calls(Type = typeof(Panel_Rest), Member = "IsPassingTimeOnly")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Panel_Rest), Member = "OnCancel")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "ProgressBarEnded")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(InputManager), Member = "MaybeCancelClickHold")]
	[CallerCount(Count = 0)]
	public void DoClickHoldCancel()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ExitDialogueUpdate")]
	[CallsUnknownMethods(Count = 3)]
	public void DoExitDialogue()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public string GetStoryHUDDebugText()
	{
		return null;
	}

	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(InterfaceManager), Member = "ClearUISaveData")]
	[Calls(Type = typeof(Panel_HUD), Member = "CleanupDamageEventTable")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	public void HideNotifications()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_HUD), Member = "CanShowLocationReveal")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowLocationReveal")]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateLocationLabel()
	{
	}

	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateVistaNotification")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	private Texture GetVistaPostcardTexture()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(HUDManager), Member = "DoNotRenderHUD")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Panel_HUD), Member = "GetVistaPostcardTexture")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[CallsUnknownMethods(Count = 10)]
	private void UpdateVistaNotification()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateLocationLabel")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShowLocationReveal")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Loading), Member = "IsShowingQuote")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	private bool CanShowLocationReveal()
	{
		return default(bool);
	}

	[Calls(Type = typeof(HUDManager), Member = "DoNotRenderHUD")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "GetExpandedDurationString")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private void UpdateSurvivalTimeLabel()
	{
	}

	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "CanUserCancelAction")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(Panel_HUD), Member = "SetHoverText")]
	[CallsUnknownMethods(Count = 44)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_Rest), Member = "IsPassingTimeOnly")]
	[Calls(Type = typeof(InputManager), Member = "MaybeCancelClickHold")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(PlayerManager), Member = "IsCancelableActionInProgress")]
	[Calls(Type = typeof(PlayerManager), Member = "IsClickHoldActive")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "MaybeCancelClickHold")]
	private void ItemProgressBarCheck()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	private bool IsDialogueExitButtonAvailable()
	{
		return default(bool);
	}

	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_HUD), Member = "DoExitDialogue")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[Calls(Type = typeof(InputManager), Member = "GetRadialButton")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	private void ExitDialogueUpdate()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[CallsUnknownMethods(Count = 9)]
	private void MaybeHideHudElementsThatOverlapPauseMenuIcon()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetCompassBearingAndDistance")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	private void UpdateDebugCompass()
	{
	}

	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateBuffCapacityIcon")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateEnvironmentStateIconVisibility")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShouldShowAfflictionRiskSprite")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShouldShowAfflictionSprite")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateNowhereToHideEvent")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdatePackMorale")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateCurrentNPCCondition")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateScentIndicator")]
	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "ShouldShow")]
	[Calls(Type = typeof(Panel_Loading), Member = "IsShowingQuote")]
	[Calls(Type = typeof(PlayerStruggle), Member = "IsBlackedOutAfterStruggle")]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggleWIthBear")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	public bool ShouldHideConditionRelatedLabels()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[CallsUnknownMethods(Count = 5)]
	private bool ShouldHideCaloriesLabel()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateStaminaBar")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerCantSprintBecauseOfInjury")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BodyCarry), Member = "HasBody")]
	private bool ShouldShowAlternateColor()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(PlayerManager), Member = "IsCancelableActionInProgress")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShouldShowAlternateColor")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(BodyCarry), Member = "HasBody")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[CallsUnknownMethods(Count = 43)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsInElevator")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 16)]
	[Calls(Type = typeof(PlayerMovement), Member = "StaminaUsedForClimbing")]
	[Calls(Type = typeof(PlayerMovement), Member = "GetSprintStaminaRemainingAsPercentage")]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[Calls(Type = typeof(PlayerManager), Member = "GetNormalizedSprintReduction")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsCrouched")]
	[Calls(Type = typeof(PlayerMovement), Member = "GetModifiedMaxSprintStamina")]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "IsStaminaAiming")]
	[Calls(Type = typeof(InputManager), Member = "GetSprintDown")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsClimbing")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSwingingFirstPersonItem")]
	private void UpdateStaminaBar()
	{
	}

	[CallsUnknownMethods(Count = 43)]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(PlayerManager), Member = "IsCancelableActionInProgress")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[Calls(Type = typeof(PlayerManager), Member = "IsStaminaAiming")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 21)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetStaminaAimDropThresholdPercent")]
	private void UpdateAimingStaminaBar()
	{
	}

	[CallsUnknownMethods(Count = 60)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "LateUpdate")]
	[CallsDeduplicatedMethods(Count = 35)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	private void UpdateStatusIcons()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void CreateFlyModeIcons()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void UpdateFlyModeIcons()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(UILabel), Member = "set_fontSize")]
	[CallsUnknownMethods(Count = 1)]
	private void MaintainOriginalObjectSize()
	{
	}

	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateDamageEventFade")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Panel_HUD), Member = "CleanupDamageEventTable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SetAlpha")]
	[Calls(Type = typeof(UIGrid), Member = "GetChild")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 2)]
	private void FadeOutAllEvents()
	{
	}

	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateDamageEventFade")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UIGrid), Member = "GetChild")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SetAlpha")]
	private void MaybeFadeOutIndividualDamageEvents()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_HUD), Member = "FadeOutAllEvents")]
	[Calls(Type = typeof(Panel_HUD), Member = "MaybeFadeOutIndividualDamageEvents")]
	private void UpdateDamageEventFade()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_HUD), Member = "CleanupDamageEventTable")]
	private void OnDestroy()
	{
	}

	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ToggleConditionTween")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	private void SetUpConditionTween()
	{
	}

	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_HUD), Member = "SetUpConditionTween")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	private void ToggleConditionTween(bool toggle)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(Panel_HUD), Member = "ShouldHideConditionRelatedLabels")]
	[Calls(Type = typeof(Panel_HUD), Member = "IsNonRadialOverlayActive")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[CallsUnknownMethods(Count = 15)]
	private void UpdateBuffCapacityIcon(bool isEncumbered)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HUDObjectives), Member = "Disable")]
	private void SetupPopupPanels()
	{
	}

	[Calls(Type = typeof(HUDObjectives), Member = "RestoreDisplay")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[Calls(Type = typeof(HUDObjectives), Member = "HideDisplay")]
	[Calls(Type = typeof(HUDMission), Member = "HideDisplay")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsUnknownMethods(Count = 42)]
	[Calls(Type = typeof(HUDObjectives), Member = "ManualUpdate")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Animator), Member = "PlayInFixedTime")]
	[Calls(Type = typeof(HUDTutorial), Member = "Dequeue")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(HUDManager), Member = "DoNotRenderHUD")]
	[Calls(Type = typeof(HUDTutorial), Member = "Disable")]
	[Calls(Type = typeof(HUDObjectives), Member = "Disable")]
	[Calls(Type = typeof(HUDMission), Member = "Disable")]
	[Calls(Type = typeof(HUDChapter), Member = "Disable")]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
	[CallsDeduplicatedMethods(Count = 21)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	private void UpdatePopupPanels()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_HUD), Member = "SetCurrentMissionDisplay")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowCurrentMissionDisplay")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateCurrentMissionDisplay")]
	private void MaybeHideCurrentMissionDisplay()
	{
	}

	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateCurrentMissionDisplay")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "MaybeHideCurrentMissionDisplay")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	private void SetCurrentMissionDisplay(string missionName, string objectives)
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(MissionsProgressBar), Member = "Enable")]
	[Calls(Type = typeof(MissionsProgressBar), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "MaybeHideCurrentMissionDisplay")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateCurrentMissionDisplay")]
	private void ShowCurrentMissionDisplay(bool show)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(MissionsProgressBar), Member = "Refresh")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 26)]
	[Calls(Type = typeof(MissionsProgressBar), Member = "Refresh")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowCurrentMissionDisplay")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Panel_HUD), Member = "SetCurrentMissionDisplay")]
	[Calls(Type = typeof(Panel_HUD), Member = "MaybeHideCurrentMissionDisplay")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetAllActiveObjectivesForMission")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "op_Inequality")]
	private void UpdateCurrentMissionDisplay()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 22)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Panel_HUD), Member = "ShouldHideConditionRelatedLabels")]
	[Calls(Type = typeof(Panel_HUD), Member = "IsNonRadialOverlayActive")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(NPC), Member = "FindNearest")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private void UpdateCurrentNPCCondition()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdatePackMorale")]
	[CallsUnknownMethods(Count = 9)]
	private bool IsPackMoraleMeterIdle()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdatePackMorale")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdatePackMorale")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Animator), Member = "Play")]
	private void SetMoraleMeterState(MoraleMeterState state)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool IsMoraleMeterOptionEnabled()
	{
		return default(bool);
	}

	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[Calls(Type = typeof(Panel_HUD), Member = "SetMoraleMeterState")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Transform), Member = "get_localScale")]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[Calls(Type = typeof(Transform), Member = "get_localScale")]
	[Calls(Type = typeof(Panel_HUD), Member = "SetMoraleMeterState")]
	[Calls(Type = typeof(PackManager), Member = "GetHighestPackMorale")]
	[Calls(Type = typeof(Panel_HUD), Member = "IsNonRadialOverlayActive")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShouldHideConditionRelatedLabels")]
	[Calls(Type = typeof(Panel_HUD), Member = "IsPackMoraleMeterIdle")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 1)]
	private void UpdatePackMorale()
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[Calls(Type = typeof(Panel_HUD), Member = "IsNonRadialOverlayActive")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(HUDNowhereToHide), Member = "MaybeSetRootActive")]
	[Calls(Type = typeof(NowhereToHide), Member = "IsCurrentExperienceMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_HUD), Member = "ShouldHideConditionRelatedLabels")]
	private void UpdateNowhereToHideEvent()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	private void UpdateSuffocatingMeter()
	{
	}

	[CalledBy(Type = typeof(BaseAiManager), Member = "ResetAudioLoops")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PackManager), Member = "Start")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	public void QuietlyResetTimberWolfCombatMusic()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "SetLanguage")]
	[CallsUnknownMethods(Count = 1)]
	public void ForceCurrentMissionDisplayUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public string GetDisplayedMissionId()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[Calls(Type = typeof(Panel_HUD), Member = "IsNonRadialOverlayActive")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShouldHideConditionRelatedLabels")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Condition), Member = "HasNonRiskAffliction")]
	private bool ShouldShowAfflictionSprite()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Condition), Member = "HasNonRiskAffliction")]
	[Calls(Type = typeof(Condition), Member = "HasRiskAffliction")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShouldHideConditionRelatedLabels")]
	[Calls(Type = typeof(Panel_HUD), Member = "IsNonRadialOverlayActive")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[CallsUnknownMethods(Count = 9)]
	private bool ShouldShowAfflictionRiskSprite()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void OnControllerScheme(bool isController)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Panel_HUD), Member = "ShouldHideConditionRelatedLabels")]
	[Calls(Type = typeof(Panel_HUD), Member = "IsNonRadialOverlayActive")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[CallsUnknownMethods(Count = 8)]
	private void UpdateEnvironmentStateIconVisibility()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public override bool IsOverlayPanel()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void ResetHoverTextPreviousValues()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 70)]
	public Panel_HUD()
	{
	}
}
