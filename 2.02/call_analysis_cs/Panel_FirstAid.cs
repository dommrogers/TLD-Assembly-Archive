using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Panel_FirstAid : Panel_Base
{
	private class AfflictionsAtLocation
	{
		public bool[] m_AfflictionsArray;

		public AfflictionBodyArea m_Location;

		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		public AfflictionsAtLocation(AfflictionBodyArea location)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		public void AddAffliction(AfflictionType afflictionType)
		{
		}
	}

	public GameObject m_TimeWidgetPos;

	public ButtonLegendContainer m_ButtonLegendContainer;

	public bool m_EnableDiaryOnExit;

	public GameObject m_ClickBlocker;

	public string m_OpenFirstAidAudio;

	public string m_CloseFirstAidAudio;

	public GameObject m_SurvivalTabs;

	public GameObject m_StoryTabs;

	public string[] m_ColdStatusLocIDs;

	public UILabel m_ColdStatusLabel;

	public UILabel m_ColdPercentLabel;

	public string[] m_FatigueStatusLocIDs;

	public UILabel m_FatigueStatusLabel;

	public UILabel m_FatiguePercentLabel;

	public string[] m_HungerStatusLocIDs;

	public UILabel m_HungerStatusLabel;

	public UILabel m_HungerPercentLabel;

	public string[] m_ThirstStatusLocIDs;

	public UILabel m_ThirstStatusLabel;

	public UILabel m_ThirstPercentLabel;

	public UILabel m_CalorieStoreLabel;

	public UILabel m_AirTempLabel;

	public UILabel m_WindchillLabel;

	public UILabel m_FeelsLikeLabel;

	public UILabel m_LabelConditionPercent;

	public GameObject m_PaperDollMale;

	public GameObject m_PaperDollFemale;

	public UISprite m_SpriteStatusLine;

	public Color m_GoodHealthStatusColor;

	public float m_GoodHealthThreshold;

	public Color m_FairHealthStatusColor;

	public float m_FairHealthThreshold;

	public Color m_PoorHealthStatusColor;

	public float m_PoorHealthThreshold;

	public GameObject m_RightPageHealthyObject;

	public GameObject m_RightPageObject;

	public UILabel m_LabelCause;

	public UILabel m_LabelAfflictionDescription;

	public UILabel m_LabelAfflictionDescriptionNoRest;

	public UITexture[] m_SpriteListItemsNeeded;

	public UISprite[] m_CheckmarksItemsNeeded;

	public UILabel[] m_NumLabelItemsNeeded;

	public UILabel m_LabelWaterAmount;

	public UILabel m_altLabelWaterAmount;

	public Vector2 m_WaterAmountPixelOffset;

	public GameObject m_ObjectRestRemaining;

	public UILabel m_LabelRestRemaining;

	public UILabel m_LabelRestRequired;

	public UILabel[] m_LabelOr;

	public UILabel[] m_LabelPlus;

	public GameObject m_ItemsNeededOnlyOneObj;

	public GameObject m_ItemsNeededMultipleObj;

	public GameObject m_FAKObject;

	public ScrollList m_ScrollListEffects;

	public GameObject m_ButtonScrollUp;

	public GameObject m_ButtonScrollDown;

	public GameObject m_ScrollbarObject;

	public GameObject m_SpecialTreatmentWindow;

	public UILabel m_LabelAfflictionName;

	public UILabel m_LabelSpecialTreatment;

	public UILabel m_LabelSpecialTreatmentDescription;

	public GameObject m_BuffWindow;

	public UILabel m_LabelBuffDescription;

	public UISprite[] m_BodyIconList;

	public GameObject m_BodyIconActiveAnimationObj;

	public string m_BodyIconSpriteNameAffliction;

	public string m_BodyIconSpriteNameBuff;

	public GameObject m_MultipleDosesObject;

	public UILabel m_LabelDosesRemaining;

	public UILabel m_LabelDosesRequired;

	public GameObject m_ButtonBack;

	public Vector3 m_SprainedWristMajorOffset;

	private GamepadButtonSprite[] m_GamepadButtonSprites;

	public Color m_ColorAffliction;

	public Color m_ColorRiskAffliction;

	public Color m_ColorNormal;

	public UISprite[] m_TintedSprites;

	public GameObject m_TreatmentButtonSingle;

	public GameObject m_TreatmentButtonMultiLeft;

	public GameObject m_TreatmentButtonMultiRight;

	public GameObject m_TreatmentSwapIndictorLeft;

	public GameObject m_TreatmentSwapIndictorRight;

	public UIWidget m_TreatmentWidgetSingle;

	public UIWidget m_TreatmentWidgetMultiLeft;

	public UIWidget m_TreatmentWidgetMultiRight;

	public UISprite m_TreatmentBorderSingle;

	public UISprite m_TreatmentBorderMultiLeft;

	public UISprite m_TreatmentBorderMultiRight;

	public UILabel m_TreatmentDontHaveItemsLabel;

	public UILabel m_UsedAntibioticsAlreadyLabel;

	public float m_HasTreatmentAlpha;

	public float m_MissingTreatmentAlpha;

	public Panel_HUD.ScentIndicator m_ScentIndicator;

	public UILabel m_ScentHeaderLabel;

	public GameObject m_DurationWidgetParentObj;

	public UILabel m_DurationWidgetHoursLabel;

	public UILabel m_DurationWidgetMinutesLabel;

	private FirstAidKitButton[] m_FakButtons;

	private FirstAidKitButton m_SelectedFAKButton;

	private AfflictionButton m_SelectedAffButton;

	private int m_BodyIconWidthOriginal;

	private int m_BodyIconHeightOriginal;

	private bool m_DoneFirstUpdate;

	private uint m_OpenCloseAudioID;

	private string m_ItemJustUsed;

	private List<string> m_TreatmentItemsToUse;

	private List<string> m_MainTreatmentItems;

	private List<string> m_AltTreatmentItems;

	private List<Affliction> m_AfflictionsLastFrame;

	private List<Affliction> m_AfflictionsThisFrame;

	private NotificationFlag m_NotificationFlag;

	private Transform[] m_NotificationFlagChildren;

	private AfflictionsAtLocation[] m_AfflictionsAtLocationArray;

	private List<Affliction> m_PaperDollAfflictions;

	private List<Affliction> m_ScrollListAfflictions;

	private List<Affliction> m_HasBadAfflictionList;

	private List<Affliction> m_HasRiskAfflictionList;

	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(Panel_FirstAid), Member = "CacheComponents")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	public override void Initialize()
	{
	}

	[Calls(Type = typeof(InputManager), Member = "GetFirePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetAltFirePressed")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "OnMapNav")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateScrollbar")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "CheckForAfflictionListChange")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshStatusLabels")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_HUD.ScentIndicator), Member = "Update")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshAll")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "OnBack")]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[CallsUnknownMethods(Count = 84)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "Enable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "ExitInterface")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[CallsDeduplicatedMethods(Count = 21)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Input), Member = "GetAxis")]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Input), Member = "GetAxis")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	public void DoScrollUp()
	{
	}

	[Calls(Type = typeof(ScrollList), Member = "Next")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void DoScrollDown()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	public void OnScrollbarChange()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public void UseItem(GearItem gi)
	{
	}

	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshKit")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "SelectPrevFAKItem")]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "SelectNextFAKItem")]
	[Calls(Type = typeof(FirstAidKitButton), Member = "Refresh")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 3)]
	public void SelectItem(FirstAidKitButton fakButton)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	[Calls(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 9)]
	public void UseSelectedItem()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(AfflictionButton), Member = "OnClick")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[Calls(Type = typeof(AfflictionButton), Member = "SetSelected")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void SelectAffliction(AfflictionButton affButton)
	{
	}

	[Calls(Type = typeof(Panel_FirstAid), Member = "OnBack")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Affliction), Member = "IsBeneficial")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnDrinkWaterComplete")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "MaybeUseNextTreatmentItem")]
	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnFirstAidComplete")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshKit")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "CheckIfSelectedAfflictionHealed")]
	[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
	[Calls(Type = typeof(FirstAidKitButton), Member = "Refresh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "SelectNextFAKItem")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshAll")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshCheckmarks")]
	public void FirstAidItemCallback()
	{
	}

	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshAll")]
	[CallerCount(Count = 0)]
	public void ProgressBarCancel()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "OnDrinkWaterComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnFirstAidComplete")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "CheckForAfflictionListChange")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "UpdateDueToAfflictionHealed")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "Enable")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "ProgressBarCancel")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "Update")]
	[Calls(Type = typeof(InterfaceManager), Member = "SetTimeWidgetActive")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshTintedImages")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshPaperDoll")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshKit")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "FirstAidItemCallback")]
	public void RefreshAll()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "CanPlaySpecialUIEntrySound")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(InterfaceManager), Member = "InitializeAndActivateTimeWidget")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "Update")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsUnknownMethods(Count = 30)]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshAll")]
	[Calls(Type = typeof(AfflictionButton), Member = "SetSelected")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshScrollList")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshAll")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "EnableNavigationTabs")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[Calls(Type = typeof(InterfaceManager), Member = "SetTimeWidgetActive")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "EnableNavigationTabs")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAllAfflictions")]
	public override void Enable(bool enable)
	{
	}

	[Calls(Type = typeof(Panel_FirstAid), Member = "ExitInterface")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(InputManager), Member = "MaybeClosePanelDueToHotkey")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "FirstAidItemCallback")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "Update")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "MaybePlayOverrideCloseSound")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	public void OnBack()
	{
	}

	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(FirstAidKitButton), Member = "Refresh")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_FirstAid), Member = "SelectItem")]
	public void SelectPrevFAKItem(bool playAudio = true)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "CheckIfSelectedItemUsedUp")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "FirstAidItemCallback")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_FirstAid), Member = "SelectItem")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(FirstAidKitButton), Member = "Refresh")]
	public void SelectNextFAKItem(bool playAudio = true)
	{
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "MaybeUseNextTreatmentItem")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "CheckIfSelectedAfflictionHealed")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public AfflictionType GetSelectedAfflictionType()
	{
		return default(AfflictionType);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallsUnknownMethods(Count = 1)]
	public int GetSelectedAfflictionIndex()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshScrollList")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 11)]
	public bool SelectFirstAfflictionOfType(AfflictionType affType)
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void SelectMainTreatment()
	{
	}

	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	public void SelectAltTreatment()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_FirstAid), Member = "MaybeUseNextTreatmentItem")]
	[CallsUnknownMethods(Count = 7)]
	public void DoMainTreatment()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_FirstAid), Member = "MaybeUseNextTreatmentItem")]
	[CallsUnknownMethods(Count = 7)]
	public void DoAltTreatmeant()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Inventory), Member = "Enable")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void OnInventoryNav()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsUnknownMethods(Count = 1)]
	public void OnClothingNav()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[CallsUnknownMethods(Count = 1)]
	public void OnJournalNav()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Crafting), Member = "Enable")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void OnCraftingNav()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[CallsUnknownMethods(Count = 1)]
	public void OnMissionsNav()
	{
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Map), Member = "ShowNoMapsUnlockedMessage")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "NoMapsUnlocked")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void OnMapNav()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Color), Member = "Lerp")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "Update")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshStatusLabels")]
	[CallsUnknownMethods(Count = 2)]
	public Color GetColorForStatusLine()
	{
		return default(Color);
	}

	[CalledBy(Type = typeof(Hypothermia), Member = "HypothermiaEnd")]
	[CalledBy(Type = typeof(Infection), Member = "InfectionEnd")]
	[CalledBy(Type = typeof(InfectionRisk), Member = "InfectionRiskEnd")]
	[CalledBy(Type = typeof(IntestinalParasites), Member = "IntestinalParasitesEnd")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SprainedAnkle), Member = "SprainedAnkleEnd")]
	[CalledBy(Type = typeof(SprainedWrist), Member = "SprainedWristEnd")]
	[CalledBy(Type = typeof(FoodPoisoning), Member = "FoodPoisoningEnd")]
	[CalledBy(Type = typeof(SprainPain), Member = "CureAffliction")]
	[CalledBy(Type = typeof(Dysentery), Member = "DysenteryEnd")]
	[CalledBy(Type = typeof(BurnsElectric), Member = "BurnsElectricEnd")]
	[CallerCount(Count = 15)]
	[CalledBy(Type = typeof(Burns), Member = "BurnsEnd")]
	[CalledBy(Type = typeof(WellFed), Member = "WellFedEnd")]
	[CalledBy(Type = typeof(BrokenRib), Member = "BrokenRibEnd")]
	[CalledBy(Type = typeof(BloodLoss), Member = "BloodLossEnd")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshAll")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "CheckIfSelectedAfflictionHealed")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(CabinFever), Member = "CabinFeverEnd")]
	public void UpdateDueToAfflictionHealed()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void ResetNotificationsData()
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetTemperatureString")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Utils), Member = "GetTemperatureString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Freezing), Member = "CalculateBodyTemperature")]
	[Calls(Type = typeof(Utils), Member = "GetTemperatureString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Condition), Member = "GetConditionValueForInterfaceDisplay")]
	[CallsUnknownMethods(Count = 70)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "GetColorForStatusLine")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "Update")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "GetStringFromColor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 14)]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	private void RefreshStatusLabels()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 30)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[Calls(Type = typeof(AfflictionButton), Member = "GetColorBasedOnAffliction")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 1)]
	private void UpdateBodyIconActiveAnimation(int affLocation, AfflictionType afflictionType)
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateBodyIconColors")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	private void UpdateAllButSelectedBodyIconColors()
	{
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshAll")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Clothing), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAllAfflictions")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Affliction), Member = "IsBeneficial")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	private void RefreshPaperDoll()
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	private void HideRightPage()
	{
	}

	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictionLocation")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(BurnsElectric), Member = "RequiresBandage")]
	[Calls(Type = typeof(BurnsElectric), Member = "RequiresPainkillers")]
	[Calls(Type = typeof(BurnsElectric), Member = "RequiresBandage")]
	[Calls(Type = typeof(BurnsElectric), Member = "RequiresPainkillers")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "SetItemsNeeded")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(BrokenRib), Member = "RequiresBandage")]
	[Calls(Type = typeof(BrokenRib), Member = "GetRequiredBandages")]
	[Calls(Type = typeof(BrokenRib), Member = "GetRequiredPainKiller")]
	[Calls(Type = typeof(BrokenRib), Member = "GetRestAmountRemaining")]
	[Calls(Type = typeof(BrokenRib), Member = "GetNumHoursRestForCure")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "SetItemsNeeded")]
	[Calls(Type = typeof(BrokenRib), Member = "GetLocation")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictionLocation")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(BrokenRib), Member = "RequiresPainKiller")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictionLocation")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictionLocation")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictionLocation")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "SetItemsNeeded")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(IntestinalParasites), Member = "GetNumDosesRequired")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(IntestinalParasites), Member = "GetNumDosesRemaining")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictionLocation")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictionLocation")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(DamageProtection), Member = "GetAfflictionDescription")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateBodyIconActiveAnimation")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateBodyIconColors")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateAllButSelectedBodyIconColors")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "HideRightPage")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "Update")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "SelectAffliction")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshAll")]
	[CallsUnknownMethods(Count = 668)]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictionLocation")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictionLocation")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictionLocation")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[Calls(Type = typeof(EnergyBoost), Member = "GetEnergyBoostTimeRemainingHours")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictionLocation")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "SetItemsNeeded")]
	[Calls(Type = typeof(SprainPain), Member = "GetLocation")]
	[Calls(Type = typeof(SprainPain), Member = "GetRemainingHours")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictionLocation")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Headache), Member = "GetActiveHoursRemaining")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictionLocation")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(BloodLoss), Member = "RequiresBandage")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "SetItemsNeeded")]
	[Calls(Type = typeof(BloodLoss), Member = "GetLocation")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Burns), Member = "RequiresBandage")]
	[Calls(Type = typeof(Burns), Member = "RequiresPainkillers")]
	[Calls(Type = typeof(Burns), Member = "RequiresBandage")]
	[Calls(Type = typeof(Burns), Member = "RequiresPainkillers")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "SetItemsNeeded")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictionLocation")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "get_text")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Dysentery), Member = "GetRestAmountRemaining")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "SetItemsNeeded")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Infection), Member = "HasTakenAntibiotics")]
	[Calls(Type = typeof(Infection), Member = "HasTakenAntibiotics")]
	[Calls(Type = typeof(Infection), Member = "GetRestAmountRemaining")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "SetItemsNeeded")]
	[Calls(Type = typeof(Infection), Member = "GetLocation")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "GetSelectedAfflictionIndex")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 38)]
	[Calls(Type = typeof(FirstAidKitButton), Member = "SetNeeded")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Condition), Member = "HasSpecificAffliction")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "HideRightPage")]
	[Calls(Type = typeof(Panel_Affliction), Member = "HasAffliction")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(Affliction), Member = "LocalizedNameFromAfflictionType")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Frostbite), Member = "GetFrostbiteRiskValue")]
	[Calls(Type = typeof(Mathf), Member = "Clamp")]
	[Calls(Type = typeof(UILabel), Member = "get_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Affliction), Member = "IsBeneficial")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UILabel), Member = "get_text")]
	[Calls(Type = typeof(CabinFever), Member = "GetCurrentRisk")]
	[Calls(Type = typeof(UILabel), Member = "get_text")]
	[Calls(Type = typeof(IntestinalParasites), Member = "GetCurrentRisk")]
	[Calls(Type = typeof(UILabel), Member = "get_text")]
	[Calls(Type = typeof(UILabel), Member = "get_text")]
	[Calls(Type = typeof(InfectionRisk), Member = "GetCurrentRisk")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Affliction), Member = "AfflictionTypeIsBuff")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "SetItemsNeeded")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictionLocation")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictionLocation")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetActiveHoursRemaining")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(CabinFever), Member = "GetTimeAmountRemaining")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictionLocation")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictionLocation")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictionLocation")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(FoodPoisoning), Member = "GetRestAmountRemaining")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(SprainedAnkle), Member = "GetRestAmountRemaining")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "SetItemsNeeded")]
	[Calls(Type = typeof(SprainedAnkle), Member = "GetLocation")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Hypothermia), Member = "GetNumHoursWarmForCure")]
	[Calls(Type = typeof(InfectionRisk), Member = "RequiresAntiseptic")]
	[Calls(Type = typeof(InfectionRisk), Member = "RequiresAntiseptic")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "SetItemsNeeded")]
	[Calls(Type = typeof(InfectionRisk), Member = "GetLocation")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(SprainedWrist), Member = "GetRestAmountRemaining")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "SetItemsNeeded")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Hypothermia), Member = "GetWarmTimeAmountRemaining")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Frostbite), Member = "NumInstancesFrostbiteAtLocation")]
	[Calls(Type = typeof(UILabel), Member = "get_text")]
	[Calls(Type = typeof(Frostbite), Member = "NumInstancesFrostbiteAtLocation")]
	[Calls(Type = typeof(SprainedWrist), Member = "GetLocation")]
	private void RefreshRightPage()
	{
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "FirstAidItemCallback")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshAll")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "SelectItem")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(FirstAidKitButton), Member = "Refresh")]
	private void RefreshKit()
	{
	}

	[Calls(Type = typeof(Panel_FirstAid), Member = "HasAfflictionOfCategory")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "HasAfflictionOfCategory")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "HasAfflictionOfCategory")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Affliction), Member = "IsBeneficial")]
	private bool CanUpdateColor(AfflictionButton afflictionButton, AfflictionsAtLocation afflictionsAtLocation)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 28)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshScrollList")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "UpdateAllButSelectedBodyIconColors")]
	[Calls(Type = typeof(AfflictionButton), Member = "GetColorBasedOnAffliction")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Affliction), Member = "IsBeneficial")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "HasAfflictionOfCategory")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "HasAfflictionOfCategory")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "HasAfflictionOfCategory")]
	private void UpdateBodyIconColors(AfflictionButton afflictionButton, bool isButtonSelected, int bodyIconIndex)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshScrollList")]
	[CallsUnknownMethods(Count = 20)]
	private void AddAfflictionAtLocation(int bodyIconIndex, Affliction affliction)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "CheckIfSelectedAfflictionHealed")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "SelectFirstAfflictionOfType")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "CheckForAfflictionListChange")]
	[CallsUnknownMethods(Count = 47)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateBodyIconColors")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(AfflictionButton), Member = "SetSelected")]
	[Calls(Type = typeof(AfflictionButton), Member = "SetCauseAndEffect")]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAllAfflictions")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "AddAfflictionAtLocation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Affliction), Member = "LocalizedNameFromAfflictionType")]
	[Calls(Type = typeof(Affliction), Member = "SpriteNameFromAfflictionType")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	private void RefreshScrollList()
	{
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "UpdateDueToAfflictionHealed")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshScrollList")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "GetSelectedAfflictionType")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(AfflictionButton), Member = "SetSelected")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "FirstAidItemCallback")]
	[CallsUnknownMethods(Count = 10)]
	private void CheckIfSelectedAfflictionHealed()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_FirstAid), Member = "SelectNextFAKItem")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private void CheckIfSelectedItemUsedUp()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "Update")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "OnBack")]
	[CallsUnknownMethods(Count = 2)]
	private void ExitInterface()
	{
	}

	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(Color), Member = "get_green")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(Color), Member = "get_green")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(Color), Member = "get_green")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[CallsUnknownMethods(Count = 106)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Inventory), Member = "NumGearInInventory")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Inventory), Member = "NumGearInInventory")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Transform), Member = "set_localPosition_Injected")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 80)]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(Transform), Member = "set_localPosition_Injected")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTextureFromPrefabName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(FirstAidKitButton), Member = "SetNeeded")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	private void SetItemsNeeded(string[] remedySprites, bool[] remedyComplete, int[] remedyNumRequired, string[] altRemedySprites, bool[] altRemedyComplete, int[] altRemedyNumRequired, float waterNeeded, float restNeeded, float restRequired)
	{
	}

	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsUnknownMethods(Count = 27)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "FirstAidItemCallback")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTextureFromPrefabName")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private void RefreshCheckmarks()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	private bool HasAnyFirstAidItem()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "DoAltTreatmeant")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "DoMainTreatment")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "FirstAidItemCallback")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "GetSelectedAfflictionType")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	private void MaybeUseNextTreatmentItem()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private bool AfflictionTypeNeedsRestAfterItems(AfflictionType affType)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "Update")]
	[Calls(Type = typeof(GamepadButtonSprite), Member = "UpdateSpriteForActiveController")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	private void UpdateButtonLegend()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Affliction), Member = "IsBadAffliction")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshTintedImages")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAllAfflictions")]
	private bool HasBadAffliction()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAllAfflictions")]
	[Calls(Type = typeof(Affliction), Member = "IsRisk")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshTintedImages")]
	[CallsUnknownMethods(Count = 8)]
	private bool HasRiskAffliction()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "UpdateBodyIconColors")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "UpdateBodyIconColors")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "UpdateBodyIconColors")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "CanUpdateColor")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "CanUpdateColor")]
	[Calls(Type = typeof(Affliction), Member = "IsBeneficial")]
	[Calls(Type = typeof(Affliction), Member = "IsRisk")]
	[Calls(Type = typeof(Affliction), Member = "IsBadAffliction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "CanUpdateColor")]
	private bool HasAfflictionOfCategory(AfflictionsAtLocation afflictionsAtLocation, AfflictionCategory category)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void ClearAfflictionsAtLocationArray()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	private void UpdateScrollbar()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_FirstAid), Member = "HasBadAffliction")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "HasRiskAffliction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshAll")]
	[CallsUnknownMethods(Count = 14)]
	private void RefreshTintedImages()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Panel_HUD.ScentIndicator), Member = "Update")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void UpdateScentIndicator()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_FirstAid), Member = "AfflictionListHasChanged")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshScrollList")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshAll")]
	[Calls(Type = typeof(AfflictionButton), Member = "SetSelected")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "Update")]
	[CallsUnknownMethods(Count = 9)]
	private void CheckForAfflictionListChange()
	{
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "CheckForAfflictionListChange")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAllAfflictions")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 1)]
	private bool AfflictionListHasChanged()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsUsingSurvivalTabs")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "Enable")]
	private void EnableNavigationTabs(bool enable)
	{
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "Initialize")]
	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	private void CacheComponents()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 79)]
	public Panel_FirstAid()
	{
	}
}
