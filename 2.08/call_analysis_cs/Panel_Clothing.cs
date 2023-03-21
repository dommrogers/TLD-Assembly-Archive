using System;
using System.Collections.Generic;
using System.Text;
using Cpp2ILInjected.CallAnalysis;
using TLD.UI;
using TLD.UI.Generics;
using TLD.UI.Notifications;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Panel_Clothing : Panel_AutoReferenced, INotificationHandler
{
	[Serializable]
	public class HeadItemLayerAdjustment
	{
		public GearItem m_Item;

		public List<GearItem> m_AdjustedBy;

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public HeadItemLayerAdjustment()
		{
		}
	}

	public GameObject m_SurvivalTabs;

	public GameObject m_StoryTabs;

	public GameObject m_ItemDescriptionPageDummy;

	public GameObject m_ItemDescriptionPagePrefab;

	public UILabel m_FeelsLikeLabel;

	public UILabel m_AirTempLabel;

	public UILabel m_WindchillLabel;

	private PanelReference<Panel_Crafting> m_CraftingPanel;

	private PanelReference<Panel_FirstAid> m_FirstAid;

	private PanelReference<Panel_Inventory> m_Inventory;

	private PanelReference<Panel_Inventory_Examine> m_InventoryExamine;

	private PanelReference<Panel_Log> m_Log;

	private PanelReference<Panel_Map> m_Map;

	public string m_OpenClothingAudio;

	public string m_CloseClothingAudio;

	public ButtonLegendContainer m_ButtonLegendContainer;

	public ScrollList m_ScrollList;

	public GameObject m_ButtonLeft;

	public GameObject m_ButtonLeftGamepad;

	public GameObject m_ButtonRight;

	public GameObject m_ButtonRightGamepad;

	public GameObject m_NonPaperDollObject;

	public GameObject m_PaperDollMale;

	public GameObject m_PaperDollFemale;

	public GameObject m_CoverflowSection;

	public GameObject m_NoItemsOfTypeSection;

	public GameObject m_EmptySlotSection;

	public UILabel m_UseClothingItemLabel;

	public GenericClothingSlotSpawner[] m_BodyLayers;

	public GenericClothingSlotSpawner[] m_LegLayers;

	public GenericClothingSlotSpawner[] m_HandLayers;

	public GenericClothingSlotSpawner[] m_FeetLayers;

	public UITexture[] m_PaperDollHandsTextures;

	public UITexture[] m_PaperDollFeetTextures;

	public UILabel m_TotalWarmthLabel;

	public UILabel m_TotalWindproofLabel;

	public UILabel m_TotalToughnessLabel;

	public UILabel m_TotalMobilityLabel;

	public UISlider m_TotalMobilitySlider;

	public UILabel m_NumItemsLabel;

	public UISprite m_FullHypothermiaSprite;

	public UISprite m_HypothermiaRiskSprite;

	public UISprite m_HypothermiaRiskFillSprite;

	public GameObject m_ClothingStatLegend;

	public ClothingRegion[] m_DefaultSelectRegionOrder;

	public ClothingLayer[] m_DefaultSelectLayerOrder;

	public int m_HandsNormalLayer;

	public int m_HandsRaisedLayer;

	public List<string> m_HandItemsToRaiseLayer;

	public int m_FeetNormalLayer;

	public int m_FeetRaisedLayer;

	public List<string> m_FeetItemsToRaiseLayer;

	public List<string> m_ToquesThatCannotLayerTogether;

	public List<string> m_HeadItemsThatAltersToqueLayer;

	public List<HeadItemLayerAdjustment> m_ItemLayerAdjustments;

	public string m_EmptySlotTextureName;

	private List<ClothingSlot> m_ClothingSlots;

	private List<GearItemCoverflow> m_CoverflowItems;

	private List<GearItem> m_ClothingItemsForSelectedSlot;

	private ClothingRegion m_SelectedRegion;

	private ClothingLayer m_SelectedLayer;

	private ItemDescriptionPage m_ItemDescriptionPage;

	private StringBuilder m_StringBuilder;

	private bool m_ShowPaperDollOnly;

	private int m_SlotNavCameFromColumn;

	private uint m_OpenCloseAudioID;

	private bool m_IsDirty;

	private GamepadButtonSprite[] m_GamepadButtonSprites;

	private NotificationFlag m_NotificationFlag;

	private Transform[] m_NotificationFlagChildren;

	private bool m_MovementPressedOnEnable;

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Clothing), Member = "CacheComponents")]
	[Calls(Type = typeof(Panel_Clothing), Member = "InstantiateItemDescriptionPage")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	public override void Initialize()
	{
	}

	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	[Calls(Type = typeof(Panel_Clothing), Member = "GetCurrentlySelectedGearItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "Enable")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_Clothing), Member = "GetCurrentlySelectedGearItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "CanDrop")]
	[Calls(Type = typeof(GearItem), Member = "Drop")]
	[Calls(Type = typeof(Panel_Clothing), Member = "RefreshVisuals")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_Clothing), Member = "RefreshVisuals")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryAddToSatchelPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Clothing), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOff")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Panel_Clothing), Member = "SetupScrollList")]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
	[Calls(Type = typeof(Panel_Clothing), Member = "OnUseClothingItem")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_Clothing), Member = "OnCancel")]
	[Calls(Type = typeof(Utils), Member = "GetMovementPressed")]
	[Calls(Type = typeof(Panel_Clothing), Member = "MoveCursorUntilFindMatch")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(Panel_Clothing), Member = "MoveCursorUntilFindMatch")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryDropPressed")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryAddToSatchelPressed")]
	[Calls(Type = typeof(Panel_Inventory), Member = "Enable")]
	[Calls(Type = typeof(InputManager), Member = "GetAltFirePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterRightPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterLeftPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryExaminePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetFirePressed")]
	private void Update()
	{
	}

	[Calls(Type = typeof(Panel_Clothing), Member = "RefreshVisuals")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GameManager), Member = "MaybeForceGC")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(Panel_Clothing), Member = "SetupScrollList")]
	[Calls(Type = typeof(ClothingSlot), Member = "SetSelected")]
	[Calls(Type = typeof(Utils), Member = "GetMovementPressed")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Clothing), Member = "EnableNavigationTabs")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(ClothingSlot), Member = "ActivateMouseHoverHighlight")]
	[Calls(Type = typeof(Panel_Clothing), Member = "EnableNavigationTabs")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Clothing), Member = "SetDefaultSelection")]
	public override void Enable(bool enable)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "MoveCursorUntilFindMatch")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Enable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(ClothingSlot), Member = "SetSelected")]
	[Calls(Type = typeof(Panel_Clothing), Member = "SelectDefaultSlot")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ClothingSlot), Member = "SetSelected")]
	private void SetDefaultSelection()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Clothing), Member = "UpdateButtonLegend")]
	public void ShowPaperDollOnly()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CalledBy(Type = typeof(InputManager), Member = "MaybeClosePanelDueToHotkey")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Update")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "MaybePlayOverrideCloseSound")]
	public void OnCancel()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetMovementPressed")]
	private void MaybeFlagMovmentPressedOnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetMovementPressed")]
	private bool ShouldIgnoreNavigationInput()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Panel_Clothing), Member = "MoveCursorUntilFindMatch")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(Panel_Clothing), Member = "MoveCursorUntilFindMatch")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(Utils), Member = "GetMovementPressed")]
	[CallerCount(Count = 0)]
	private void Navigate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Inventory), Member = "Enable")]
	[CallsUnknownMethods(Count = 1)]
	public void OnInventoryNav()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public void OnFirstAidNav()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[CallsUnknownMethods(Count = 1)]
	public void OnJournalNav()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void OnMissionsNav()
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
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void OnMapNav()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Clothing), Member = "GetCurrentlySelectedGearItem")]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[Calls(Type = typeof(Panel_Clothing), Member = "UnequipItemInSelectedSlot")]
	[Calls(Type = typeof(PlayerManager), Member = "PutOnClothingItem")]
	[Calls(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Panel_Clothing), Member = "UnequipItemInSelectedSlot")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "DoDoubleClickAction")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Update")]
	[CallsUnknownMethods(Count = 4)]
	public void OnUseClothingItem()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_Clothing), Member = "RefreshVisuals")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Clothing), Member = "SetupScrollList")]
	[Calls(Type = typeof(GearItem), Member = "Drop")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "CanDrop")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Clothing), Member = "GetCurrentlySelectedGearItem")]
	[CallerCount(Count = 0)]
	public void OnDropItem()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "Enable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Clothing), Member = "GetCurrentlySelectedGearItem")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void OnActionsButton()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
	[CallsUnknownMethods(Count = 3)]
	public void NextTool()
	{
	}

	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void PrevTool()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallerCount(Count = 0)]
	public void SelectItemByIndex(int index)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "MoveCursorUntilFindMatch")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "MoveCursorUntilFindMatch")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "DoClickAction")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_Clothing), Member = "RefreshVisuals")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GearItem), Member = "PlayPickUpClip")]
	[Calls(Type = typeof(ClothingSlot), Member = "SetSelected")]
	[Calls(Type = typeof(ClothingSlot), Member = "SetSelected")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Clothing), Member = "SetupScrollList")]
	public bool SelectClothingSlot(int col, int row, bool skipAudio = false)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Panel_Clothing), Member = "RefreshVisuals")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(ClothingSlot), Member = "SetSelected")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[Calls(Type = typeof(Panel_Clothing), Member = "SetupScrollList")]
	public void SelectItemIfEquipped(GearItem gearItem)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Clothing), Member = "MoveCursorUntilFindMatch")]
	public void MoveCursorUp()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Clothing), Member = "MoveCursorUntilFindMatch")]
	public void MoveCursorDown()
	{
	}

	[Calls(Type = typeof(Panel_Clothing), Member = "MoveCursorUntilFindMatch")]
	[CallerCount(Count = 0)]
	public void MoveCursorLeft()
	{
	}

	[Calls(Type = typeof(Panel_Clothing), Member = "MoveCursorUntilFindMatch")]
	[CallerCount(Count = 0)]
	public void MoveCursorRight()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "OnUseClothingItem")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "OnUseClothingItem")]
	[CallsUnknownMethods(Count = 3)]
	public void UnequipItemInSelectedSlot()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Clothing), Member = "RefreshVisuals")]
	[CallerCount(Count = 0)]
	public void MaybeRefreshVisuals()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 2)]
	public void ResetNotificationsData()
	{
	}

	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GearItemCoverflow), Member = "SetGearItem")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GearItemCoverflow), Member = "SetEmptySlot")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "OnDropItem")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "SelectClothingSlot")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "SelectItemIfEquipped")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetWornCarryingCapacityBuffClothing")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetClimbingBuffClothing")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InProgressCraftItem), Member = "IsProgressComplete")]
	[Calls(Type = typeof(PlayerManager), Member = "GetClothingInSlot")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void SetupScrollList()
	{
	}

	[Calls(Type = typeof(Panel_Clothing), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(Panel_Clothing), Member = "ActivateTopLayerOnly")]
	[Calls(Type = typeof(Panel_Clothing), Member = "ActivateTopLayerOnly")]
	[Calls(Type = typeof(Panel_Clothing), Member = "ActivateTopLayerOnly")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTopLayerGear")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTopLayerGear")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "OnDropItem")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "SelectClothingSlot")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "SelectItemIfEquipped")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "MaybeRefreshVisuals")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "CheckForHide")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Panel_Clothing), Member = "UpdateGlobalStatBars")]
	[Calls(Type = typeof(Panel_Clothing), Member = "UpdateTemperatureLabels")]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(ClothingSlot), Member = "UpdateSlotInfo")]
	[Calls(Type = typeof(GearItemCoverflow), Member = "SetSelected")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Clothing), Member = "UpdateGearStatsBlock")]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length")]
	private void RefreshVisuals()
	{
	}

	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "RefreshVisuals")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "UpdateGearItemDescription")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Clothing), Member = "GetCurrentlySelectedGearItem")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	private void UpdateGearStatsBlock()
	{
	}

	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "RefreshVisuals")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetTemperatureString")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(ClothingItem), Member = "GetWindproof")]
	[Calls(Type = typeof(Utils), Member = "GetTemperatureString")]
	[Calls(Type = typeof(ClothingItem), Member = "IsOutermostItemInClothingRegion")]
	[Calls(Type = typeof(ClothingItem), Member = "GetWarmth")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	private void UpdateGlobalStatBars()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "RefreshVisuals")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetTemperatureString")]
	[Calls(Type = typeof(Utils), Member = "GetTemperatureString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetTemperatureString")]
	[Calls(Type = typeof(Freezing), Member = "CalculateBodyTemperature")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	private void UpdateTemperatureLabels()
	{
	}

	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "OverrideDepthOfAllItems")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "ShowPaperDollOnly")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "RefreshVisuals")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshPaperDoll")]
	[Calls(Type = typeof(GamepadButtonSprite), Member = "UpdateSpriteForActiveController")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Clothing), Member = "GetCurrentlySelectedGearItem")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	private void UpdateButtonLegend()
	{
	}

	[CalledBy(Type = typeof(Panel_Clothing), Member = "RefreshVisuals")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "RefreshVisuals")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ClothingSlot), Member = "ToggleWidgetsActive")]
	[Calls(Type = typeof(ClothingSlot), Member = "ToggleWidgetsActive")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "RefreshVisuals")]
	private void ActivateTopLayerOnly(GenericClothingSlotSpawner[] layeredTextures)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetClothingInSlot")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "SetDefaultSelection")]
	[CallsUnknownMethods(Count = 3)]
	private void SelectDefaultSlot()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void SetSpriteAndLabelColor(UISprite sprite, UILabel label, Color color)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void ToggleTexturesActive(UITexture[] textures, bool toggle)
	{
	}

	[CalledBy(Type = typeof(Panel_Clothing), Member = "Navigate")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "MoveCursorRight")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "MoveCursorLeft")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "MoveCursorDown")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "MoveCursorUp")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Navigate")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Update")]
	[Calls(Type = typeof(Panel_Clothing), Member = "SetDefaultSelection")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_Clothing), Member = "SelectClothingSlot")]
	[Calls(Type = typeof(Panel_Clothing), Member = "SelectClothingSlot")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Update")]
	private void MoveCursorUntilFindMatch(int horizontal, int vertical)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	private void InstantiateItemDescriptionPage()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "UpdateGearStatsBlock")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "OnActionsButton")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "OnDropItem")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "OnUseClothingItem")]
	private GearItem GetCurrentlySelectedGearItem()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClothingSlot), Member = "ActivateMouseHoverHighlight")]
	[Calls(Type = typeof(ClothingSlot), Member = "SetSelected")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void DeselectItems()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsUsingSurvivalTabs")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Enable")]
	private void EnableNavigationTabs(bool enable)
	{
	}

	[CalledBy(Type = typeof(Panel_Clothing), Member = "Initialize")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void CacheComponents()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public Panel_Clothing()
	{
	}
}
