using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Gameplay.Condition;
using TLD.Gear;
using TLD.UI;
using TLD.UI.Generics;
using TLD.UI.Notifications;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Panel_FirstAid : Panel_AutoReferenced, INotificationHandler
{
	private class AfflictionsAtLocation
	{
		public bool[] m_AfflictionsArray;

		public AfflictionBodyArea m_Location;

		[CallerCount(Count = 0)]
		public AfflictionsAtLocation(AfflictionBodyArea location)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public void AddAffliction(AfflictionType afflictionType)
		{
		}
	}

	private PanelReference<Panel_Clothing> m_Clothing;

	private PanelReference<Panel_Crafting> m_CraftingPanel;

	private PanelReference<Panel_GenericProgressBar> m_GenericProgressBar;

	private PanelReference<Panel_Inventory> m_Inventory;

	private PanelReference<Panel_Log> m_Log;

	private PanelReference<Panel_Map> m_Map;

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

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	public override void Initialize()
	{
	}

	[Calls(Type = typeof(InputManager), Member = "GetAltFirePressed")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshAll")]
	[Calls(Type = typeof(Panel_HUD.ScentIndicator), Member = "Update")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshStatusLabels")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "CheckForAfflictionListChange")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetFirePressed")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "OnBack")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "ExitInterface")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "Enable")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 21)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Input), Member = "GetAxis")]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Input), Member = "GetAxis")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	[CallsUnknownMethods(Count = 1)]
	public void DoScrollUp()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
	[CallsUnknownMethods(Count = 1)]
	public void DoScrollDown()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void OnScrollbarChange()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	[Calls(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[CallsUnknownMethods(Count = 1)]
	public void UseItem(GearItem gi)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "SelectPrevFAKItem")]
	[Calls(Type = typeof(FirstAidKitButton), Member = "Refresh")]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(FirstAidKitButton), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "SelectNextFAKItem")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[CallsUnknownMethods(Count = 3)]
	public void SelectItem(FirstAidKitButton fakButton)
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	public void UseSelectedItem()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[Calls(Type = typeof(AfflictionButton), Member = "SetSelected")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public void SelectAffliction(AfflictionButton affButton)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "OnDrinkWaterComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnFirstAidComplete")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "OnBack")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "MaybeUseNextTreatmentItem")]
	[Calls(Type = typeof(FirstAidKitButton), Member = "Refresh")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshCheckmarks")]
	[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
	[Calls(Type = typeof(FirstAidKitButton), Member = "Refresh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "SelectNextFAKItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshAll")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "CheckIfSelectedAfflictionHealed")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void FirstAidItemCallback()
	{
	}

	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshAll")]
	[CallerCount(Count = 0)]
	public void ProgressBarCancel()
	{
	}

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnDrinkWaterComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnFirstAidComplete")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "UpdateDueToAfflictionHealed")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "ProgressBarCancel")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "CheckForAfflictionListChange")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "Update")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "FirstAidItemCallback")]
	[Calls(Type = typeof(FirstAidKitButton), Member = "Refresh")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshPaperDoll")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshTintedImages")]
	[Calls(Type = typeof(InterfaceManager), Member = "SetTimeWidgetActive")]
	public void RefreshAll()
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(InterfaceManager), Member = "InitializeAndActivateTimeWidget")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshAll")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "Update")]
	[Calls(Type = typeof(AfflictionButton), Member = "SetSelected")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshScrollList")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshAll")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "EnableNavigationTabs")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(InterfaceManager), Member = "SetTimeWidgetActive")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "EnableNavigationTabs")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictions")]
	public override void Enable(bool enable)
	{
	}

	[CalledBy(Type = typeof(InputManager), Member = "MaybeClosePanelDueToHotkey")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "FirstAidItemCallback")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "ExitInterface")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "Update")]
	[Calls(Type = typeof(GameAudioManager), Member = "MaybePlayOverrideCloseSound")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	public void OnBack()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(FirstAidKitButton), Member = "Refresh")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "SelectItem")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	public void SelectPrevFAKItem(bool playAudio = true)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "CheckIfSelectedItemUsedUp")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "FirstAidItemCallback")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "SelectItem")]
	[Calls(Type = typeof(FirstAidKitButton), Member = "Refresh")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	public void SelectNextFAKItem(bool playAudio = true)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "CheckIfSelectedAfflictionHealed")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "MaybeUseNextTreatmentItem")]
	[CallsUnknownMethods(Count = 1)]
	public AfflictionType GetSelectedAfflictionType()
	{
		return default(AfflictionType);
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public int GetSelectedAfflictionIndex()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshScrollList")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 4)]
	public bool SelectFirstAfflictionOfType(AfflictionType affType)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 1)]
	public void SelectMainTreatment()
	{
	}

	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void SelectAltTreatment()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_FirstAid), Member = "MaybeUseNextTreatmentItem")]
	[CallsUnknownMethods(Count = 6)]
	public void DoMainTreatment()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_FirstAid), Member = "MaybeUseNextTreatmentItem")]
	[CallsUnknownMethods(Count = 6)]
	public void DoAltTreatmeant()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Inventory), Member = "Enable")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	public void OnInventoryNav()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsUnknownMethods(Count = 1)]
	public void OnClothingNav()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	public void OnJournalNav()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Crafting), Member = "Enable")]
	[CallsUnknownMethods(Count = 1)]
	public void OnCraftingNav()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	public void OnMissionsNav()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsUnknownMethods(Count = 1)]
	public void OnMapNav()
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Panel_Actions), Member = "Update")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshStatusLabels")]
	[CallsUnknownMethods(Count = 1)]
	public Color GetColorForStatusLine()
	{
		return default(Color);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_FirstAid), Member = "CheckIfSelectedAfflictionHealed")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshAll")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void UpdateDueToAfflictionHealed()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 2)]
	public void ResetNotificationsData()
	{
	}

	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetTemperatureString")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetTemperatureString")]
	[Calls(Type = typeof(Freezing), Member = "CalculateBodyTemperature")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(Utils), Member = "GetTemperatureString")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(Condition), Member = "GetConditionValueForInterfaceDisplay")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "GetStringFromColor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "GetColorForStatusLine")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "Update")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[CallsUnknownMethods(Count = 23)]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void RefreshStatusLabels()
	{
	}

	[CallsUnknownMethods(Count = 33)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(AfflictionButton), Member = "GetColorBasedOnAffliction")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void UpdateBodyIconActiveAnimation(int affLocation, AfflictionType afflictionType)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateBodyIconColors")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateAllButSelectedBodyIconColors()
	{
	}

	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshAll")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Clothing), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictions")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	private void RefreshPaperDoll()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	private void HideRightPage()
	{
	}

	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictionLocation")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(BrokenRib), Member = "GetLocation")]
	[Calls(Type = typeof(BrokenRib), Member = "RequiresBandage")]
	[Calls(Type = typeof(BrokenRib), Member = "GetNumHoursRestForCure")]
	[Calls(Type = typeof(BrokenRib), Member = "GetRestAmountRemaining")]
	[Calls(Type = typeof(BrokenRib), Member = "GetRequiredPainKiller")]
	[Calls(Type = typeof(BrokenRib), Member = "GetRequiredBandages")]
	[Calls(Type = typeof(BrokenRib), Member = "RequiresPainKiller")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "SetItemsNeeded")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictionLocation")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictionLocation")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Headache), Member = "GetAfflictionByIndex")]
	[Calls(Type = typeof(EnergyBoost), Member = "GetEnergyBoostTimeRemainingHours")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictionLocation")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "SetItemsNeeded")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(BurnsElectric), Member = "RequiresBandage")]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(IntestinalParasites), Member = "GetNumDosesRequired")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(IntestinalParasites), Member = "GetNumDosesRemaining")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictionLocation")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "SetItemsNeeded")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictionLocation")]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(BurnsElectric), Member = "RequiresPainkillers")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(BurnsElectric), Member = "RequiresBandage")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(BurnsElectric), Member = "RequiresPainkillers")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictionLocation")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictionLocation")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(InsomniaManager), Member = "GetInsomniaByIndex")]
	[Calls(Type = typeof(InsomniaManager), Member = "GetActiveHoursRemaining")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateBodyIconActiveAnimation")]
	[CallsUnknownMethods(Count = 612)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshAll")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "SelectAffliction")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "Update")]
	[CalledBy(Type = typeof(AfflictionButton), Member = "OnClick")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "HideRightPage")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateAllButSelectedBodyIconColors")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateBodyIconColors")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(InsomniaManager), Member = "GetInsomniaByIndex")]
	[Calls(Type = typeof(DamageProtection), Member = "GetAfflictionDescription")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(SprainPain), Member = "GetRemainingHours")]
	[Calls(Type = typeof(SprainPain), Member = "GetLocation")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "SetItemsNeeded")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Headache), Member = "GetActiveHoursRemaining")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictionLocation")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictionLocation")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictionLocation")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictionLocation")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(BloodLoss), Member = "GetLocation")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "SetItemsNeeded")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "GetSelectedAfflictionIndex")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(InfectionRisk), Member = "GetCurrentRisk")]
	[Calls(Type = typeof(UILabel), Member = "get_text")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(UILabel), Member = "get_text")]
	[Calls(Type = typeof(Burns), Member = "RequiresBandage")]
	[Calls(Type = typeof(Burns), Member = "RequiresPainkillers")]
	[Calls(Type = typeof(Burns), Member = "RequiresBandage")]
	[Calls(Type = typeof(Burns), Member = "RequiresPainkillers")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "SetItemsNeeded")]
	[Calls(Type = typeof(Infection), Member = "GetRestAmountRemaining")]
	[Calls(Type = typeof(Infection), Member = "HasTakenAntibiotics")]
	[Calls(Type = typeof(Infection), Member = "HasTakenAntibiotics")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "SetItemsNeeded")]
	[Calls(Type = typeof(Hypothermia), Member = "GetHypothermiaRiskValue")]
	[Calls(Type = typeof(Dysentery), Member = "GetRestAmountRemaining")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "get_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictionLocation")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "SetItemsNeeded")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Infection), Member = "GetLocation")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(IntestinalParasites), Member = "GetCurrentRisk")]
	[Calls(Type = typeof(Affliction), Member = "LocalizedNameFromAfflictionType")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Affliction), Member = "HasAffliction")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "HideRightPage")]
	[Calls(Type = typeof(Condition), Member = "HasSpecificAffliction")]
	[Calls(Type = typeof(Affliction), Member = "AfflictionTypeIsBuff")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(FirstAidKitButton), Member = "SetNeeded")]
	[CallsDeduplicatedMethods(Count = 43)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Affliction), Member = "IsRisk")]
	[Calls(Type = typeof(Affliction), Member = "IsBeneficial")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UILabel), Member = "get_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(CabinFever), Member = "GetCurrentRisk")]
	[Calls(Type = typeof(UILabel), Member = "get_text")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(UILabel), Member = "get_text")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(Mathf), Member = "Clamp")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(UILabel), Member = "get_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(InsomniaManager), Member = "GetInsomniaByIndex")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(Frostbite), Member = "GetFrostbiteRiskValue")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(FoodPoisoning), Member = "GetRestAmountRemaining")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictionLocation")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictionLocation")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictionLocation")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictionLocation")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(CabinFever), Member = "GetTimeAmountRemaining")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictionLocation")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictionLocation")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetActiveHoursRemaining")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "SetItemsNeeded")]
	[Calls(Type = typeof(SprainedWrist), Member = "GetRestAmountRemaining")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(InfectionRisk), Member = "GetLocation")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(InfectionRisk), Member = "RequiresAntiseptic")]
	[Calls(Type = typeof(SprainedWrist), Member = "GetLocation")]
	[Calls(Type = typeof(InfectionRisk), Member = "RequiresAntiseptic")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(SprainedAnkle), Member = "GetLocation")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "SetItemsNeeded")]
	[Calls(Type = typeof(SprainedAnkle), Member = "GetRestAmountRemaining")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "SetItemsNeeded")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "SetItemsNeeded")]
	[Calls(Type = typeof(UILabel), Member = "get_text")]
	[Calls(Type = typeof(Frostbite), Member = "NumInstancesFrostbiteAtLocation")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(Hypothermia), Member = "GetNumHoursWarmForCure")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(Hypothermia), Member = "GetWarmTimeAmountRemaining")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(Frostbite), Member = "NumInstancesFrostbiteAtLocation")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	private void RefreshRightPage()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FirstAidKitButton), Member = "Refresh")]
	[CallsUnknownMethods(Count = 2)]
	private void RefreshKit()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "UpdateBodyIconColors")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "HasAfflictionOfCategory")]
	[Calls(Type = typeof(Affliction), Member = "IsBeneficial")]
	[Calls(Type = typeof(Affliction), Member = "IsBadAffliction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_FirstAid), Member = "HasAfflictionOfCategory")]
	private bool CanUpdateColor(AfflictionButton afflictionButton, AfflictionsAtLocation afflictionsAtLocation)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[CallsUnknownMethods(Count = 27)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshScrollList")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "UpdateAllButSelectedBodyIconColors")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "CanUpdateColor")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(AfflictionButton), Member = "GetColorBasedOnAffliction")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	private void UpdateBodyIconColors(AfflictionButton afflictionButton, bool isButtonSelected, int bodyIconIndex)
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshScrollList")]
	[CallsUnknownMethods(Count = 10)]
	private void AddAfflictionAtLocation(int bodyIconIndex, Affliction affliction)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "CheckForAfflictionListChange")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "CheckIfSelectedAfflictionHealed")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "SelectFirstAfflictionOfType")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "Enable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateBodyIconColors")]
	[Calls(Type = typeof(AfflictionButton), Member = "SetCauseAndEffect")]
	[Calls(Type = typeof(Affliction), Member = "LocalizedNameFromAfflictionType")]
	[Calls(Type = typeof(AfflictionButton), Member = "SetSelected")]
	[Calls(Type = typeof(Affliction), Member = "SpriteNameFromAfflictionType")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "AddAfflictionAtLocation")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictions")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void RefreshScrollList()
	{
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "UpdateDueToAfflictionHealed")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "FirstAidItemCallback")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(AfflictionButton), Member = "SetSelected")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_FirstAid), Member = "GetSelectedAfflictionType")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshScrollList")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 3)]
	private void CheckIfSelectedAfflictionHealed()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_FirstAid), Member = "SelectNextFAKItem")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private void CheckIfSelectedItemUsedUp()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "Update")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "OnBack")]
	[CallsUnknownMethods(Count = 1)]
	private void ExitInterface()
	{
	}

	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 32)]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(Color), Member = "get_green")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(Color), Member = "get_green")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
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
	[Calls(Type = typeof(Color), Member = "get_green")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Transform), Member = "set_localPosition_Injected")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 78)]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "NumGearInList")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Transform), Member = "set_localPosition_Injected")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "NumGearInList")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(FirstAidKitButton), Member = "SetNeeded")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTextureFromPrefabName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(int), Member = "ToString")]
	private void SetItemsNeeded(string[] remedySprites, bool[] remedyComplete, int[] remedyNumRequired, string[] altRemedySprites, bool[] altRemedyComplete, int[] altRemedyNumRequired, float waterNeeded, float restNeeded, float restRequired)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "FirstAidItemCallback")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTextureFromPrefabName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private void RefreshCheckmarks()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private bool HasAnyFirstAidItem()
	{
		return default(bool);
	}

	[Calls(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "FirstAidItemCallback")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "DoAltTreatmeant")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "DoMainTreatment")]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "GetSelectedAfflictionType")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	private void MaybeUseNextTreatmentItem()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private bool AfflictionTypeNeedsRestAfterItems(AfflictionType affType)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "Update")]
	[Calls(Type = typeof(GamepadButtonSprite), Member = "UpdateSpriteForActiveController")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	private void UpdateButtonLegend()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshTintedImages")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictions")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Affliction), Member = "IsBadAffliction")]
	private bool HasBadAffliction()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictions")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshTintedImages")]
	[CallsUnknownMethods(Count = 9)]
	private bool HasRiskAffliction()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "CanUpdateColor")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "CanUpdateColor")]
	[Calls(Type = typeof(Affliction), Member = "IsBeneficial")]
	[Calls(Type = typeof(Affliction), Member = "IsBadAffliction")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Affliction), Member = "IsRisk")]
	private bool HasAfflictionOfCategory(AfflictionsAtLocation afflictionsAtLocation, AfflictionCategory category)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void ClearAfflictionsAtLocationArray()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	private void UpdateScrollbar()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshAll")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "HasBadAffliction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_FirstAid), Member = "HasRiskAffliction")]
	private void RefreshTintedImages()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_HUD.ScentIndicator), Member = "Update")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateScentIndicator()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(AfflictionButton), Member = "SetSelected")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshAll")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "AfflictionListHasChanged")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshScrollList")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void CheckForAfflictionListChange()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "CheckForAfflictionListChange")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictions")]
	private bool AfflictionListHasChanged()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsUsingSurvivalTabs")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "Enable")]
	private void EnableNavigationTabs(bool enable)
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void CacheComponents()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 48)]
	public Panel_FirstAid()
	{
	}
}
