using System;
using System.Collections.Generic;
using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using TLD.Cooking;
using TLD.Gear;
using TLD.SaveState;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Pool;

public class Panel_Cooking : Panel_AutoReferenced, IAccelerateTimeProvider
{
	private enum NavArea
	{
		Category,
		CookingItem
	}

	private const string ACTION_INVENTORY_SORT = "Inventory_Sort";

	private const string ACTION_PICKUP_COOKINGPOT = "FeedFire_TakeTorch";

	private const string ACTION_CONTINUE = "Continue";

	private const string ACTION_BACK = "Escape";

	private const string LOCID_HEATUP = "GAMEPLAY_HeatUp";

	private const string LOCID_PICKUP = "GAMEPLAY_PickUp";

	private const string LOCID_SELECT = "GAMEPLAY_Select";

	private const string LOCID_COOK = "GAMEPLAY_Cook";

	private const string LOCID_SORT = "GAMEPLAY_Sort";

	private const string LOCID_BACK = "GAMEPLAY_ButtonBack";

	private const string LOCID_CANNOTCOOKWITHPOT = "GAMEPLAY_CannotCookWithSelectedPot";

	private const string LOCID_EMBERS = "GAMEPLAY_Embers";

	private const string TEXT_INFINITY = "∞";

	private UILabel m_PanelTitleLabel;

	private LocalizedString m_CookingTitle;

	private LocalizedString m_RecipeBookTitle;

	private ButtonLegendContainer m_ButtonLegendContainer;

	private ButtonLegendContainer m_SortButtonLegendContainer;

	private GameObject m_MouseButtonParent;

	private GameObject m_ActionButtonObject;

	private GameObject m_ActionSecondaryButtonObject;

	private GameObject[] m_ActiveOnlyWhenFoodListHasItems;

	private Color m_RequirementMetColor;

	private Color m_RequirementNotMetColor;

	private UILabel m_Label_EstimatedFireDuration;

	private UILabel m_Label_FireTemperature;

	private GameObject m_ActiveCookingDetails;

	private UITexture m_Texture_CookedItem;

	private UILabel m_Label_CookedItemName;

	private UILabel m_Label_CookedItemDesc;

	private UILabel m_Label_CookedItemCondition;

	private UILabel m_Label_CookedItemCalories;

	private UILabel m_Label_CookedItemHydration;

	private UILabel m_Label_CookedItemWeight;

	private UILabel m_Label_CookedItemCookTime;

	private DishEffectInfo m_DishEffectInfo;

	private GameObject m_SmallStatsBG;

	private GameObject m_StatsBG;

	private GameObject m_SpecialRecipeIndicator;

	private LocalizedString m_RecipePreparationText;

	private float m_RecipePreparationDisplayTimeSeconds;

	private string m_RecipePreparationSprite;

	private float m_SkillIncreaseChanceOnFailure;

	private float m_SkillIncreaseChanceOnSuccess;

	private GameObject m_IngredientsRoot;

	private Transform m_IngredientsParent;

	private UILabel m_SelectedIngredientLabel;

	private RecipeIngredientListItem m_IngredientItemPrefab;

	private Vector2Int m_IngredientGridSize;

	private Vector2 m_IngredientGridOffsets;

	private LiquidType m_PotableWater;

	private GameObject m_WarningIndicator;

	private UILabel m_WarningLabel;

	private GameObject m_SortLabel;

	private GameObject m_SortButtonsObject;

	private UIButton[] m_SortButtons;

	private UILabel m_RecipesHeader;

	private ScrollList m_FoodScrollList;

	private GameObject m_ScrollbarSpawner;

	private CategoryButtonNavigation m_CategoryNavigation;

	private List<CookingToolPanelFilterButton> m_FilterButtons;

	private AssetLabelReference m_RecipeLabel;

	private GameObject m_EmptyListContent;

	private AK.Wwise.Event m_OpenAudio;

	private LocalizedString m_ErrorSkillTooLow;

	private LocalizedString m_ErrorWrongCookingPot;

	private LocalizedString m_ErrorMissingIngredient;

	private LocalizedString m_ErrorMissingNoCookingPotInInventory;

	private PanelReference<Panel_CanOpening> m_CanOpening;

	private PanelReference<Panel_Confirmation> m_Confirmation;

	private PanelReference<Panel_GenericProgressBar> m_GenericProgressBar;

	private PanelReference<Panel_RecipeBook> m_RecipeBook;

	public bool m_ShowingAsRecipeBook;

	private UILabel m_Label_ButtonAction;

	private UILabel m_Label_ButtonSecondaryAction;

	private UISlider m_FoodScrollSlider;

	private Fire m_Fire;

	private CookingSlot m_CookingSlot;

	private CookingPotItem m_CookingPotInteractedWith;

	private readonly CraftingOperation m_RecipePrepOperation;

	private int m_SelectedCookItemIndex;

	private readonly List<CookableItem> m_FoodList;

	private readonly List<CookableListItem> m_CookableAndRecipesListItems;

	private bool[] m_SortFlipDictionary;

	private readonly List<RecipeIngredientListItem> m_IngredientItems;

	private readonly List<HighlightButton> m_SortHighlightButtons;

	private NavArea m_CurrentNavArea;

	private List<CookingToolPanelFilterButton> m_ValidFilterButtons;

	private int m_SelectedFilterIndex;

	private int m_SelectedSortIndex;

	private int m_LastFireMinutes;

	private int m_LastFireTemperature;

	private bool m_RecipesRefreshed;

	private bool m_HasAnyRecipes;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(CraftingOperation), Member = "add_Interrupted")]
	[Calls(Type = typeof(CraftingOperation), Member = "add_Success")]
	[Calls(Type = typeof(CraftingOperation), Member = "add_End")]
	[Calls(Type = typeof(HighlightButton), Member = ".ctor")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(Utils), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(CollectionPool<, >), Member = "Get")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(CookingToolPanelFilterButton), Member = "Initialize")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(CategoryButtonNavigation), Member = "Initialize")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(PooledObject<>), Member = "System.IDisposable.Dispose")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 30)]
	public override void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CraftingOperation), Member = "remove_Interrupted")]
	[Calls(Type = typeof(CraftingOperation), Member = "remove_Success")]
	[Calls(Type = typeof(CraftingOperation), Member = "remove_End")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	protected override void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(CategoryButtonNavigation), Member = "SetSelected")]
	[Calls(Type = typeof(PanelReference<>), Member = "IsEnabled")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CraftingOperation), Member = "Update")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(Panel_Cooking), Member = "ScrollDown")]
	[Calls(Type = typeof(Panel_Cooking), Member = "ScrollUp")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(Panel_Cooking), Member = "RefreshFoodList")]
	[Calls(Type = typeof(Panel_Cooking), Member = "RefreshFireDurationLabel")]
	[Calls(Type = typeof(Panel_Cooking), Member = "UpdateCookableItem")]
	[Calls(Type = typeof(Panel_Cooking), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(Panel_Cooking), Member = "UpdateGamepadControls")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(CraftingOperation), Member = "HandleInterrupt")]
	[Calls(Type = typeof(Panel_Cooking), Member = "ExitCookingInterface")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Cooking), Member = "RefreshFoodList")]
	[Calls(Type = typeof(Panel_Cooking), Member = "RefreshFireDurationLabel")]
	[Calls(Type = typeof(Panel_Cooking), Member = "UpdateCookableItem")]
	public void Refresh()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(MiniTopNav), Member = "Hide")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(CategoryButtonNavigation), Member = "SetSelected")]
	[Calls(Type = typeof(Panel_Cooking), Member = "UpdateFilterButtons")]
	[Calls(Type = typeof(Panel_Cooking), Member = "UpdateSortButtons")]
	[Calls(Type = typeof(Panel_Cooking), Member = "SetSelectedFoodIndex")]
	[Calls(Type = typeof(Panel_Cooking), Member = "RefreshFoodList")]
	[Calls(Type = typeof(Panel_Cooking), Member = "RefreshFireDurationLabel")]
	[Calls(Type = typeof(Panel_Cooking), Member = "UpdateCookableItem")]
	[Calls(Type = typeof(Panel_Cooking), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[Calls(Type = typeof(Panel_Cooking), Member = "LookAtCookingSlot")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public override void Enable(bool enable)
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "Enable")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void LookAtCookingSlot()
	{
	}

	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "CookingPotCookCallback")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "DoFirePickerAction")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public void SetCookingSlot(CookingSlot cookingSlot)
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "CookingPotCookCallback")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "DoFirePickerAction")]
	[CallerCount(Count = 2)]
	public void SetCookingPot(CookingPotItem cookingPot)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(CookableListItem), Member = "CanCookItem")]
	[Calls(Type = typeof(CookableListItem), Member = "SetAvailability")]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateCookingPotOnFoodItems()
	{
	}

	[CallerCount(Count = 0)]
	private int GetSelectedFoodIndex()
	{
		return 0;
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnScrollItemSelect")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "ScrollDown")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "ScrollUp")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "MakeDefaultSelections")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateFilterIndex")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateSortIndex")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	[Calls(Type = typeof(CookableListItem), Member = "SetSelected")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void SetSelectedFoodIndex(int value)
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Enable")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "GetDurationString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(Fire), Member = "GetHeatIncreaseText")]
	[CallsUnknownMethods(Count = 3)]
	private void RefreshFireDurationLabel()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_Cooking), Member = "SetSelectedFoodIndex")]
	public void OnScrollItemSelect(int itemIndex)
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateGamepadControls")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Cooking), Member = "GetSelectedCookableItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookableItem), Member = "GetCookableItemCookability")]
	[Calls(Type = typeof(CookableItem), Member = "GetRecipeCookability")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_Cooking), Member = "OnCookNormalFood")]
	[Calls(Type = typeof(Panel_Cooking), Member = "OnCookRecipe")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnDoAction()
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateGamepadControls")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	[Calls(Type = typeof(Panel_Cooking), Member = "ExitCookingInterface")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void OnDoActionSecondary()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void OnCook()
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnDoAction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BlueprintData), Member = "HasRequiredMaterials")]
	[Calls(Type = typeof(BlueprintData), Member = "HasRequiredTool")]
	[Calls(Type = typeof(CraftingOperation), Member = "StartCrafting")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 5)]
	private void OnCookRecipe(RecipeData recipe)
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnDoAction")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnRecipePrepSuccess")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQualityString")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Cooking), Member = "ExitCookingInterface")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(CookingPotItem), Member = "StartCooking")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(GearPlacePoint), Member = "DropAndPlaceItem")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	private void OnCookNormalFood(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(Rest.PassTimeHelper), Member = "PassTime")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnDoActionSecondary")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnCookNormalFood")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnRecipePrepSuccess")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "CloseOverlaysDueToSceneLoad")]
	[CalledBy(Type = typeof(Action_PassTime), Member = "OnExecute")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(Panel_Cooking), Member = "GetSelectedCookableItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void ExitCookingInterface()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void UpdateScrollLists()
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_Cooking), Member = "SetSelectedFoodIndex")]
	[CallsUnknownMethods(Count = 1)]
	private void ScrollDown()
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_Cooking), Member = "SetSelectedFoodIndex")]
	private void ScrollUp()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	[CallsUnknownMethods(Count = 3)]
	public void OnScrollbarBlueprintsChanged()
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnDoAction")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "ExitCookingInterface")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateCookableItem")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateButtonLegend")]
	[CallerCount(Count = 5)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private CookableItem GetSelectedCookableItem()
	{
		return default(CookableItem);
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateFilterIndex")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateSortIndex")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Cooking), Member = "HaveEnoughUnitsToStartCooking")]
	[Calls(Type = typeof(CookingToolPanelFilterButton), Member = "PassesFilter")]
	[Calls(Type = typeof(CookableItem), Member = "CanCookItem")]
	[Calls(Type = typeof(CollectionPool<, >), Member = "Get")]
	[Calls(Type = typeof(RecipeBook), Member = "GetAllUnlockedRecipes")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(CookableItem), Member = ".ctor")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(Utils), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(CookableListItem), Member = "SetCookable")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallsUnknownMethods(Count = 40)]
	private void RefreshFoodList()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Cooking), Member = "SetSelectedFoodIndex")]
	private void MakeDefaultSelections()
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Enable")]
	[CallerCount(Count = 1)]
	private void UpdateFilterButtons()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CookingToolPanelFilterButton), Member = "IsGearItemInFilter")]
	[Calls(Type = typeof(CategoryButtonNavigation), Member = "SetCurrentIndex")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void SetFilterBasedOnCookingPot()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(CookingToolPanelFilterButton), Member = "GetCookingPotItem")]
	[Calls(Type = typeof(Panel_Cooking), Member = "RefreshFoodList")]
	[Calls(Type = typeof(Panel_Cooking), Member = "SetSelectedFoodIndex")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateFilterIndex(int filterIndex)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Cooking), Member = "UpdateSortIndex")]
	[CallsUnknownMethods(Count = 2)]
	public void OnSortButtonClicked(UIButton sortButtonClicked)
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnSortButtonClicked")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateGamepadControls")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Cooking), Member = "UpdateSortButtons")]
	[Calls(Type = typeof(Panel_Cooking), Member = "RefreshFoodList")]
	[Calls(Type = typeof(Panel_Cooking), Member = "SetSelectedFoodIndex")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateSortIndex(int sortIndex)
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateSortIndex")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(HighlightButton), Member = "SetHighlighted")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateSortButtons()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "TryGetComponent")]
	[Calls(Type = typeof(Component), Member = "GetComponentInParent")]
	[CallsUnknownMethods(Count = 1)]
	private bool TryGetFireplaceInteraction(out FireplaceInteraction fireplaceInteraction)
	{
		fireplaceInteraction = null;
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	private static bool PlayerHasEnoughPotableWaterForCookingItem(Cookable cookable)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "RefreshFoodList")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private static bool HaveEnoughUnitsToStartCooking(GearItem gi)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Enable")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Cooking), Member = "GetSelectedCookableItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Cooking), Member = "GetCookedItemConditionPercent")]
	[Calls(Type = typeof(CookableItem), Member = "GetCookTimeInMinutes")]
	[Calls(Type = typeof(CookingPotItem), Member = "GetTotalCookMultiplier")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GearItem), Member = "get_Description")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Utils), Member = "GetExpandedDurationString")]
	[Calls(Type = typeof(Utils), Member = "GetDurationString")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(CollectionPool<, >), Member = "Get")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Component), Member = "GetComponents")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Utils), Member = "GetWeightTwoDecimalPlacesWithUnitsString")]
	[Calls(Type = typeof(DishEffectInfo), Member = "ShowDishBenefits")]
	[Calls(Type = typeof(Panel_Cooking), Member = "UpdateRecipeContent")]
	[Calls(Type = typeof(Panel_Cooking), Member = "UpdateRecipeWarning")]
	[Calls(Type = typeof(PooledObject<>), Member = "System.IDisposable.Dispose")]
	[Calls(Type = typeof(Panel_Cooking), Member = "ClearCookableItemFields")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 24)]
	[CallsUnknownMethods(Count = 36)]
	private void UpdateCookableItem()
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateCookableItem")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Cooking), Member = "UpdateRecipeContent")]
	[Calls(Type = typeof(Panel_Cooking), Member = "UpdateRecipeWarning")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void ClearCookableItemFields()
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateCookableItem")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "ClearCookableItemFields")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Cooking), Member = "UpdateRecipeIngredients")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateRecipeContent(RecipeData recipe)
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateCookableItem")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "ClearCookableItemFields")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookableItem), Member = "GetCookability")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private void UpdateRecipeWarning(CookableItem cookableItem)
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateRecipeContent")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RecipeIngredientListItem), Member = "SetRequirementByQuantity")]
	[Calls(Type = typeof(RecipeIngredientListItem), Member = "SetRequirementByCount")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(RecipeIngredientListItem), Member = "SetName")]
	[Calls(Type = typeof(Inventory), Member = "GetTotalLiquidVolume")]
	[Calls(Type = typeof(RecipeIngredientListItem), Member = "SetLabels")]
	[Calls(Type = typeof(RecipeIngredientListItem), Member = "SetRequirementMet")]
	[Calls(Type = typeof(RecipeIngredientListItem), Member = "SetIconFromGearItemData")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Inventory), Member = "GetTotalPowderWeight")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "TryGetComponent")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(RecipeIngredientListItem), Member = "SetIconFromGearItem")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 13)]
	private void UpdateRecipeIngredients(RecipeData recipe)
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateCookableItem")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "GetCookedHp")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static float GetCookedItemConditionPercent(GearItem rawItem)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIButtonColor), Member = "UpdateColor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void EnableActionButton(bool enabled)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CraftingOperation), Member = "HandleInterrupt")]
	[CallsUnknownMethods(Count = 1)]
	private void OnCancelRecipePreparation()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void OnRecipePrepEnd()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Cooking), Member = "OnCookNormalFood")]
	[Calls(Type = typeof(Panel_Cooking), Member = "ExitCookingInterface")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void OnRecipePrepSuccess()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsUnknownMethods(Count = 1)]
	private void OnRecipePrepInterruped(CraftingInterruptReason reason)
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Enable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Cooking), Member = "GetSelectedCookableItem")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookableItem), Member = "GetCookableItemCookability")]
	[Calls(Type = typeof(CookableItem), Member = "GetRecipeCookability")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UIButtonColor), Member = "UpdateColor")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateButtonLegend()
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(InputManager), Member = "GetInventorySortPressed")]
	[Calls(Type = typeof(Panel_Cooking), Member = "UpdateSortIndex")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_Cooking), Member = "OnDoAction")]
	[Calls(Type = typeof(InputManager), Member = "GetFeedFireTakeTorchePressed")]
	[Calls(Type = typeof(Panel_Cooking), Member = "OnDoActionSecondary")]
	[Calls(Type = typeof(CategoryButtonNavigation), Member = "SetSelected")]
	[Calls(Type = typeof(CategoryButtonNavigation), Member = "OnNavigateUp")]
	[Calls(Type = typeof(CategoryButtonNavigation), Member = "OnNavigateDown")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateGamepadControls()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CategoryButtonNavigation), Member = "SetSelected")]
	[CallsUnknownMethods(Count = 1)]
	private void SetNavigationArea(NavArea target)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsAcceleratingTime()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	public string GetActionText()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public string GetSpriteName()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	public UIPanel GetPanelToFade()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public UIWidget GetWidgetToFade()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Action GetCancelAction()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public UIProgressBar GetActionProgress()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void StartAcceleratingTime()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void StopAcceleratingTime()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	public Panel_Cooking()
	{
	}
}
