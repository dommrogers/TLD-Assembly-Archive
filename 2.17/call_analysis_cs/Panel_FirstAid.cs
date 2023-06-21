using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Gameplay.Condition;
using TLD.Gear;
using TLD.SaveState;
using TLD.UI;
using TLD.UI.Generics;
using TLD.UI.Notifications;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Panel_FirstAid : Panel_AutoReferenced, INotificationHandler, IMiniTopNav
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

	public MiniTopNav m_MiniTopNav;

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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "CacheComponents")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public override void Initialize()
	{
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "Enable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(PanelReference<>), Member = "IsEnabled")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
	[Calls(Type = typeof(Input), Member = "GetAxis")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "CheckForAfflictionListChange")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshAll")]
	[Calls(Type = typeof(Panel_HUD.ScentIndicator), Member = "Update")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshStatusLabels")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateScrollbar")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "OnBack")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "ExitInterface")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 21)]
	[CallsUnknownMethods(Count = 22)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
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

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "SelectPrevFAKItem")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "SelectNextFAKItem")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FirstAidKitButton), Member = "Refresh")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public void SelectItem(FirstAidKitButton fakButton)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	[Calls(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 1)]
	public void UseSelectedItem()
	{
	}

	[CalledBy(Type = typeof(AfflictionButton), Member = "OnClick")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(AfflictionButton), Member = "SetSelected")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallsUnknownMethods(Count = 1)]
	public void SelectAffliction(AfflictionButton affButton)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "OnFirstAidComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnDrinkWaterComplete")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_FirstAid), Member = "CheckIfSelectedAfflictionHealed")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshAll")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "SelectNextFAKItem")]
	[Calls(Type = typeof(FirstAidKitButton), Member = "Refresh")]
	[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshCheckmarks")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "MaybeUseNextTreatmentItem")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "OnBack")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void FirstAidItemCallback()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshAll")]
	public void ProgressBarCancel()
	{
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "Update")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "FirstAidItemCallback")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "ProgressBarCancel")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "UpdateDueToAfflictionHealed")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "CheckForAfflictionListChange")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnFirstAidComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnDrinkWaterComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TreatAfflictionWithFirstAid")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[Calls(Type = typeof(FirstAidKitButton), Member = "Refresh")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshPaperDoll")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshTintedImages")]
	[Calls(Type = typeof(InterfaceManager), Member = "SetTimeWidgetActive")]
	[CallsUnknownMethods(Count = 2)]
	public void RefreshAll()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(MiniTopNav), Member = "Hide")]
	[Calls(Type = typeof(InterfaceManager), Member = "SetTimeWidgetActive")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(PanelReference<>), Member = "TrySetEnabled")]
	[Calls(Type = typeof(MiniTopNav), Member = "Show")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshAll")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshScrollList")]
	[Calls(Type = typeof(AfflictionButton), Member = "SetSelected")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictions")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(InterfaceManager), Member = "InitializeAndActivateTimeWidget")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "Update")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 11)]
	public override void Enable(bool enable)
	{
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "Update")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "FirstAidItemCallback")]
	[CalledBy(Type = typeof(InputManager), Member = "MaybeClosePanelDueToHotkey")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "MaybePlayOverrideCloseSound")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "ExitInterface")]
	public void OnBack()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "SelectItem")]
	[Calls(Type = typeof(FirstAidKitButton), Member = "Refresh")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public void SelectPrevFAKItem(bool playAudio = true)
	{
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "FirstAidItemCallback")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "CheckIfSelectedItemUsedUp")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "SelectItem")]
	[Calls(Type = typeof(FirstAidKitButton), Member = "Refresh")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public void SelectNextFAKItem(bool playAudio = true)
	{
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "CheckIfSelectedAfflictionHealed")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "MaybeUseNextTreatmentItem")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public AfflictionType GetSelectedAfflictionType()
	{
		return default(AfflictionType);
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public int GetSelectedAfflictionIndex()
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshScrollList")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public bool SelectFirstAfflictionOfType(AfflictionType affType)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SelectMainTreatment()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SelectAltTreatment()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "MaybeUseNextTreatmentItem")]
	[CallsUnknownMethods(Count = 1)]
	public void DoMainTreatment()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "MaybeUseNextTreatmentItem")]
	[CallsUnknownMethods(Count = 1)]
	public void DoAltTreatmeant()
	{
	}

	[CalledBy(Type = typeof(Panel_Actions), Member = "Update")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshStatusLabels")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public Color GetColorForStatusLine()
	{
		return default(Color);
	}

	[CallerCount(Count = 23)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "CheckIfSelectedAfflictionHealed")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshAll")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateDueToAfflictionHealed()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void ResetNotificationsData()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool CanShowMiniTopNav()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public bool OnMiniTopNavButtonClick(Panel_Base owner)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(Utils), Member = "GetTemperatureString")]
	[Calls(Type = typeof(Freezing), Member = "CalculateBodyTemperature")]
	[Calls(Type = typeof(Condition), Member = "GetConditionValueForInterfaceDisplay")]
	[Calls(Type = typeof(Utils), Member = "GetStringFromColor")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "GetColorForStatusLine")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 23)]
	private void RefreshStatusLabels()
	{
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AfflictionButton), Member = "GetColorBasedOnAffliction")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 22)]
	private void UpdateBodyIconActiveAnimation(int affLocation, AfflictionType afflictionType)
	{
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateBodyIconColors")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateAllButSelectedBodyIconColors()
	{
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictions")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Clothing), Member = "UpdateButtonLegend")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void RefreshPaperDoll()
	{
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void HideRightPage()
	{
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "Update")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "SelectAffliction")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshAll")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(FirstAidKitButton), Member = "SetNeeded")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Affliction), Member = "AfflictionTypeIsBuff")]
	[Calls(Type = typeof(Condition), Member = "HasSpecificAffliction")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "HideRightPage")]
	[Calls(Type = typeof(Panel_Affliction), Member = "HasAffliction")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(Affliction), Member = "LocalizedNameFromAfflictionType")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Affliction), Member = "IsRisk")]
	[Calls(Type = typeof(Affliction), Member = "IsBeneficial")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(InsomniaManager), Member = "GetInsomniaByIndex")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "get_text")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Frostbite), Member = "GetFrostbiteRiskValue")]
	[Calls(Type = typeof(Mathf), Member = "Clamp")]
	[Calls(Type = typeof(CabinFever), Member = "GetCurrentRisk")]
	[Calls(Type = typeof(IntestinalParasites), Member = "GetCurrentRisk")]
	[Calls(Type = typeof(Hypothermia), Member = "GetHypothermiaRiskValue")]
	[Calls(Type = typeof(InfectionRisk), Member = "GetCurrentRisk")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "GetSelectedAfflictionIndex")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "SetItemsNeeded")]
	[Calls(Type = typeof(BloodLoss), Member = "GetLocation")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(Burns), Member = "RequiresBandage")]
	[Calls(Type = typeof(Burns), Member = "RequiresPainkillers")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictionLocation")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Dysentery), Member = "GetRestAmountRemaining")]
	[Calls(Type = typeof(Infection), Member = "HasTakenAntibiotics")]
	[Calls(Type = typeof(Infection), Member = "GetRestAmountRemaining")]
	[Calls(Type = typeof(Infection), Member = "GetLocation")]
	[Calls(Type = typeof(FoodPoisoning), Member = "GetRestAmountRemaining")]
	[Calls(Type = typeof(SprainedAnkle), Member = "GetRestAmountRemaining")]
	[Calls(Type = typeof(SprainedAnkle), Member = "GetLocation")]
	[Calls(Type = typeof(InfectionRisk), Member = "RequiresAntiseptic")]
	[Calls(Type = typeof(InfectionRisk), Member = "GetLocation")]
	[Calls(Type = typeof(SprainedWrist), Member = "GetRestAmountRemaining")]
	[Calls(Type = typeof(SprainedWrist), Member = "GetLocation")]
	[Calls(Type = typeof(Frostbite), Member = "NumInstancesFrostbiteAtLocation")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Hypothermia), Member = "GetWarmTimeAmountRemaining")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Hypothermia), Member = "GetNumHoursWarmForCure")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetActiveHoursRemaining")]
	[Calls(Type = typeof(CabinFever), Member = "GetTimeAmountRemaining")]
	[Calls(Type = typeof(float), Member = "ToString")]
	[Calls(Type = typeof(IntestinalParasites), Member = "GetNumDosesRemaining")]
	[Calls(Type = typeof(IntestinalParasites), Member = "GetNumDosesRequired")]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[Calls(Type = typeof(BurnsElectric), Member = "RequiresBandage")]
	[Calls(Type = typeof(BurnsElectric), Member = "RequiresPainkillers")]
	[Calls(Type = typeof(BrokenRib), Member = "RequiresBandage")]
	[Calls(Type = typeof(BrokenRib), Member = "RequiresPainKiller")]
	[Calls(Type = typeof(BrokenRib), Member = "GetRequiredBandages")]
	[Calls(Type = typeof(BrokenRib), Member = "GetRequiredPainKiller")]
	[Calls(Type = typeof(BrokenRib), Member = "GetRestAmountRemaining")]
	[Calls(Type = typeof(BrokenRib), Member = "GetNumHoursRestForCure")]
	[Calls(Type = typeof(BrokenRib), Member = "GetLocation")]
	[Calls(Type = typeof(EnergyBoost), Member = "GetEnergyBoostTimeRemainingHours")]
	[Calls(Type = typeof(Headache), Member = "GetAfflictionByIndex")]
	[Calls(Type = typeof(Headache), Member = "GetActiveHoursRemaining")]
	[Calls(Type = typeof(HeadacheParams), Member = "NeedsTreatment")]
	[Calls(Type = typeof(SprainPain), Member = "GetLocation")]
	[Calls(Type = typeof(SprainPain), Member = "GetRemainingHours")]
	[Calls(Type = typeof(DamageProtection), Member = "GetAfflictionDescription")]
	[Calls(Type = typeof(InsomniaManager), Member = "GetActiveHoursRemaining")]
	[Calls(Type = typeof(PlayerManager), Member = "GetIngestedCarryCapacityBuffDuration")]
	[Calls(Type = typeof(PlayerManager), Member = "GetIngestedCarryCapacityDebuffDuration")]
	[Calls(Type = typeof(FoodMaxStatBuffManager), Member = "GetBuffTimeLeftHours")]
	[Calls(Type = typeof(FoodMaxStatBuffManager), Member = "GetDebuffTimeLeftHours")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateBodyIconActiveAnimation")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateBodyIconColors")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateAllButSelectedBodyIconColors")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 42)]
	[CallsUnknownMethods(Count = 658)]
	private void RefreshRightPage()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FirstAidKitButton), Member = "Refresh")]
	[CallsUnknownMethods(Count = 2)]
	private void RefreshKit()
	{
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "UpdateBodyIconColors")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Affliction), Member = "IsBadAffliction")]
	[Calls(Type = typeof(Affliction), Member = "IsRisk")]
	[CallsUnknownMethods(Count = 2)]
	private bool CanUpdateColor(AfflictionButton afflictionButton, AfflictionsAtLocation afflictionsAtLocation)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "UpdateAllButSelectedBodyIconColors")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshScrollList")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_FirstAid), Member = "CanUpdateColor")]
	[Calls(Type = typeof(AfflictionButton), Member = "GetColorBasedOnAffliction")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 16)]
	private void UpdateBodyIconColors(AfflictionButton afflictionButton, bool isButtonSelected, int bodyIconIndex)
	{
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshScrollList")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private void AddAfflictionAtLocation(int bodyIconIndex, Affliction affliction)
	{
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "SelectFirstAfflictionOfType")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "CheckIfSelectedAfflictionHealed")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "CheckForAfflictionListChange")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictions")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "AddAfflictionAtLocation")]
	[Calls(Type = typeof(Affliction), Member = "LocalizedNameFromAfflictionType")]
	[Calls(Type = typeof(Affliction), Member = "SpriteNameFromAfflictionType")]
	[Calls(Type = typeof(AfflictionButton), Member = "SetCauseAndEffect")]
	[Calls(Type = typeof(AfflictionButton), Member = "SetSelected")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateBodyIconColors")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	private void RefreshScrollList()
	{
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "FirstAidItemCallback")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "UpdateDueToAfflictionHealed")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshScrollList")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "GetSelectedAfflictionType")]
	[Calls(Type = typeof(AfflictionButton), Member = "SetSelected")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void CheckIfSelectedAfflictionHealed()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_FirstAid), Member = "SelectNextFAKItem")]
	[CallsUnknownMethods(Count = 1)]
	private void CheckIfSelectedItemUsedUp()
	{
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "Update")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "OnBack")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void ExitInterface()
	{
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTextureFromPrefabName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(FirstAidKitButton), Member = "SetNeeded")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "NumGearInList")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 70)]
	[CallsUnknownMethods(Count = 68)]
	private void SetItemsNeeded(string[] remedySprites, bool[] remedyComplete, int[] remedyNumRequired, string[] altRemedySprites, bool[] altRemedyComplete, int[] altRemedyNumRequired, float waterNeeded, float restNeeded, float restRequired)
	{
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "FirstAidItemCallback")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTextureFromPrefabName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 3)]
	private void RefreshCheckmarks()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private bool HasAnyFirstAidItem()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "FirstAidItemCallback")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "DoMainTreatment")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "DoAltTreatmeant")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_FirstAid), Member = "GetSelectedAfflictionType")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 9)]
	private void MaybeUseNextTreatmentItem()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private bool AfflictionTypeNeedsRestAfterItems(AfflictionType affType)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PanelReference<>), Member = "IsEnabled")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(GamepadButtonSprite), Member = "UpdateSpriteForActiveController")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateButtonLegend()
	{
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshTintedImages")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictions")]
	[Calls(Type = typeof(Affliction), Member = "IsBadAffliction")]
	[CallsUnknownMethods(Count = 3)]
	private bool HasBadAffliction()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshTintedImages")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictions")]
	[CallsUnknownMethods(Count = 3)]
	private bool HasRiskAffliction()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Affliction), Member = "IsBadAffliction")]
	[Calls(Type = typeof(Affliction), Member = "IsBeneficial")]
	[Calls(Type = typeof(Affliction), Member = "IsRisk")]
	[CallsUnknownMethods(Count = 2)]
	private bool HasAfflictionOfCategory(AfflictionsAtLocation afflictionsAtLocation, AfflictionCategory category)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void ClearAfflictionsAtLocationArray()
	{
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateScrollbar()
	{
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_FirstAid), Member = "HasBadAffliction")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "HasRiskAffliction")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[CallsUnknownMethods(Count = 2)]
	private void RefreshTintedImages()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_HUD.ScentIndicator), Member = "Update")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateScentIndicator()
	{
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_FirstAid), Member = "AfflictionListHasChanged")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshScrollList")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshAll")]
	[Calls(Type = typeof(AfflictionButton), Member = "SetSelected")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void CheckForAfflictionListChange()
	{
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "CheckForAfflictionListChange")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictions")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private bool AfflictionListHasChanged()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MiniTopNav), Member = "Hide")]
	[Calls(Type = typeof(MiniTopNav), Member = "Show")]
	[CallsUnknownMethods(Count = 1)]
	private void EnableNavigationTabs(bool enable)
	{
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "Initialize")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void CacheComponents()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 7)]
	public Panel_FirstAid()
	{
	}
}
