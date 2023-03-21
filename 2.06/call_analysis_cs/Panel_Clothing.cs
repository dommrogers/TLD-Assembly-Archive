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

	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Panel_Clothing), Member = "InstantiateItemDescriptionPage")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	public override void Initialize()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	[Calls(Type = typeof(Panel_Clothing), Member = "OnActionsButton")]
	[Calls(Type = typeof(Panel_Clothing), Member = "GetCurrentlySelectedGearItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "CanDrop")]
	[Calls(Type = typeof(GearItem), Member = "Drop")]
	[Calls(Type = typeof(Panel_Clothing), Member = "SetupScrollList")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Clothing), Member = "OnUseClothingItem")]
	[Calls(Type = typeof(Panel_Clothing), Member = "RefreshVisuals")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryAddToSatchelPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Clothing), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOff")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Panel_Clothing), Member = "RefreshVisuals")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Utils), Member = "GetMovementPressed")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(Panel_Clothing), Member = "MoveCursorUntilFindMatch")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(Panel_Clothing), Member = "MoveCursorUntilFindMatch")]
	[Calls(Type = typeof(Panel_Clothing), Member = "OnCancel")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryAddToSatchelPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetFirePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetAltFirePressed")]
	[Calls(Type = typeof(Panel_Inventory), Member = "Enable")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterLeftPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryExaminePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryDropPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterRightPressed")]
	private void Update()
	{
	}

	[Calls(Type = typeof(Panel_Clothing), Member = "SetupScrollList")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GameManager), Member = "MaybeForceGC")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(Panel_Clothing), Member = "RefreshVisuals")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Panel_Clothing), Member = "SetDefaultSelection")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Clothing), Member = "EnableNavigationTabs")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(ClothingSlot), Member = "SetSelected")]
	[Calls(Type = typeof(ClothingSlot), Member = "ActivateMouseHoverHighlight")]
	[Calls(Type = typeof(Panel_Clothing), Member = "EnableNavigationTabs")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetMovementPressed")]
	public override void Enable(bool enable)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Enable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "MoveCursorUntilFindMatch")]
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

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(InputManager), Member = "MaybeClosePanelDueToHotkey")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Update")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "MaybePlayOverrideCloseSound")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	public void OnCancel()
	{
	}

	[Calls(Type = typeof(Utils), Member = "GetMovementPressed")]
	[CallerCount(Count = 0)]
	private void MaybeFlagMovmentPressedOnEnable()
	{
	}

	[Calls(Type = typeof(Utils), Member = "GetMovementPressed")]
	[CallerCount(Count = 0)]
	private bool ShouldIgnoreNavigationInput()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetMovementPressed")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(Panel_Clothing), Member = "MoveCursorUntilFindMatch")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(Panel_Clothing), Member = "MoveCursorUntilFindMatch")]
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
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
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

	[Calls(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
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
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Update")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "DoDoubleClickAction")]
	[Calls(Type = typeof(Panel_Clothing), Member = "UnequipItemInSelectedSlot")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[Calls(Type = typeof(PlayerManager), Member = "PutOnClothingItem")]
	[Calls(Type = typeof(Panel_Clothing), Member = "UnequipItemInSelectedSlot")]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_Clothing), Member = "GetCurrentlySelectedGearItem")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	public void OnUseClothingItem()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_Clothing), Member = "RefreshVisuals")]
	[Calls(Type = typeof(Panel_Clothing), Member = "SetupScrollList")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "CanDrop")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Clothing), Member = "GetCurrentlySelectedGearItem")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearItem), Member = "Drop")]
	public void OnDropItem()
	{
	}

	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "Enable")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Update")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Clothing), Member = "GetCurrentlySelectedGearItem")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
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

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void PrevTool()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	[CallsUnknownMethods(Count = 1)]
	public void SelectItemByIndex(int index)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "MoveCursorUntilFindMatch")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "MoveCursorUntilFindMatch")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "DoClickAction")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_Clothing), Member = "RefreshVisuals")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GearItem), Member = "PlayPickUpClip")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_Clothing), Member = "SetupScrollList")]
	[Calls(Type = typeof(ClothingSlot), Member = "SetSelected")]
	[Calls(Type = typeof(ClothingSlot), Member = "SetSelected")]
	[CallerCount(Count = 3)]
	public bool SelectClothingSlot(int col, int row, bool skipAudio = false)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_Clothing), Member = "RefreshVisuals")]
	[Calls(Type = typeof(ClothingSlot), Member = "SetSelected")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_Clothing), Member = "SetupScrollList")]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	public void SelectItemIfEquipped(GearItem gearItem)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Clothing), Member = "MoveCursorUntilFindMatch")]
	public void MoveCursorUp()
	{
	}

	[Calls(Type = typeof(Panel_Clothing), Member = "MoveCursorUntilFindMatch")]
	[CallerCount(Count = 0)]
	public void MoveCursorDown()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Clothing), Member = "MoveCursorUntilFindMatch")]
	public void MoveCursorLeft()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Clothing), Member = "MoveCursorUntilFindMatch")]
	public void MoveCursorRight()
	{
	}

	[CalledBy(Type = typeof(Panel_Clothing), Member = "OnUseClothingItem")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "OnUseClothingItem")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 2)]
	public void UnequipItemInSelectedSlot()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Clothing), Member = "RefreshVisuals")]
	public void MaybeRefreshVisuals()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void ResetNotificationsData()
	{
	}

	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GearItemCoverflow), Member = "SetEmptySlot")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GearItemCoverflow), Member = "SetGearItem")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "SelectClothingSlot")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "OnDropItem")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "SelectItemIfEquipped")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetWornCarryingCapacityBuffClothing")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetClimbingBuffClothing")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InProgressCraftItem), Member = "IsProgressComplete")]
	[Calls(Type = typeof(PlayerManager), Member = "GetClothingInSlot")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private void SetupScrollList()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTopLayerGear")]
	[Calls(Type = typeof(Panel_Clothing), Member = "ToggleTexturesActive")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "GetTopLayerGear")]
	[Calls(Type = typeof(Panel_Clothing), Member = "ActivateTopLayerOnly")]
	[Calls(Type = typeof(Panel_Clothing), Member = "ToggleTexturesActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_Clothing), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(Panel_Clothing), Member = "ActivateTopLayerOnly")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "CheckForHide")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "OnDropItem")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "SelectClothingSlot")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "SelectItemIfEquipped")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "MaybeRefreshVisuals")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Clothing), Member = "ActivateTopLayerOnly")]
	[Calls(Type = typeof(Panel_Clothing), Member = "UpdateTemperatureLabels")]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ClothingSlot), Member = "UpdateSlotInfo")]
	[Calls(Type = typeof(GearItemCoverflow), Member = "SetSelected")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Clothing), Member = "UpdateGearStatsBlock")]
	[Calls(Type = typeof(Panel_Clothing), Member = "UpdateGlobalStatBars")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	private void RefreshVisuals()
	{
	}

	[CallsUnknownMethods(Count = 23)]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "RefreshVisuals")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "UpdateGearItemDescription")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Clothing), Member = "GetCurrentlySelectedGearItem")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	private void UpdateGearStatsBlock()
	{
	}

	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "RefreshVisuals")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetTemperatureString")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(ClothingItem), Member = "GetWindproof")]
	[Calls(Type = typeof(ClothingItem), Member = "IsOutermostItemInClothingRegion")]
	[Calls(Type = typeof(ClothingItem), Member = "GetWarmth")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetTemperatureString")]
	private void UpdateGlobalStatBars()
	{
	}

	[Calls(Type = typeof(Utils), Member = "GetTemperatureString")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "RefreshVisuals")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Freezing), Member = "CalculateBodyTemperature")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetTemperatureString")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetTemperatureString")]
	private void UpdateTemperatureLabels()
	{
	}

	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Update")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "ShowPaperDollOnly")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "RefreshVisuals")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshPaperDoll")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GamepadButtonSprite), Member = "UpdateSpriteForActiveController")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "OverrideDepthOfAllItems")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_Clothing), Member = "GetCurrentlySelectedGearItem")]
	private void UpdateButtonLegend()
	{
	}

	[CalledBy(Type = typeof(Panel_Clothing), Member = "RefreshVisuals")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(ClothingSlot), Member = "ToggleWidgetsActive")]
	[Calls(Type = typeof(ClothingSlot), Member = "ToggleWidgetsActive")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "RefreshVisuals")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "RefreshVisuals")]
	[CallsUnknownMethods(Count = 2)]
	private void ActivateTopLayerOnly(GenericClothingSlotSpawner[] layeredTextures)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "SetDefaultSelection")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetClothingInSlot")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	private void SelectDefaultSlot()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void SetSpriteAndLabelColor(UISprite sprite, UILabel label, Color color)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "RefreshVisuals")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "RefreshVisuals")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void ToggleTexturesActive(UITexture[] textures, bool toggle)
	{
	}

	[CalledBy(Type = typeof(Panel_Clothing), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "MoveCursorRight")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "MoveCursorLeft")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "MoveCursorDown")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "MoveCursorUp")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Navigate")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Navigate")]
	[Calls(Type = typeof(Panel_Clothing), Member = "SetDefaultSelection")]
	[Calls(Type = typeof(Panel_Clothing), Member = "SelectClothingSlot")]
	[Calls(Type = typeof(Panel_Clothing), Member = "SelectClothingSlot")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	private void MoveCursorUntilFindMatch(int horizontal, int vertical)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Initialize")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 9)]
	private void InstantiateItemDescriptionPage()
	{
	}

	[CallerCount(Count = 6)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "OnUseClothingItem")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "OnDropItem")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "OnActionsButton")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "UpdateGearStatsBlock")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "UpdateButtonLegend")]
	[CallsUnknownMethods(Count = 2)]
	private GearItem GetCurrentlySelectedGearItem()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(ClothingSlot), Member = "SetSelected")]
	[Calls(Type = typeof(ClothingSlot), Member = "ActivateMouseHoverHighlight")]
	[CallerCount(Count = 0)]
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

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void CacheComponents()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 21)]
	public Panel_Clothing()
	{
	}
}
