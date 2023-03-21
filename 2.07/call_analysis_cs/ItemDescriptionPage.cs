using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using TLD.SaveState;
using TLD.UI.Generics;
using UnityEngine;

public class ItemDescriptionPage : MonoBehaviour
{
	private PanelReference<Panel_HUD> m_HUD;

	private PanelReference<Panel_Inventory> m_InventoryPanel;

	private PanelReference<Panel_GenericProgressBar> m_ProgressBar;

	public UILabel m_ItemNameLabel;

	public GameObject m_BGNormal;

	public GameObject m_BGClothing;

	public UISprite m_ItemNotesIcon;

	public UISprite m_ItemNotesIconShadow;

	public UILabel m_ItemNotesLabel;

	public string m_WearingIcon;

	public string m_InProgressIcon;

	public UISprite m_ClothingNotesIcon;

	public UISprite m_ClothingNotesIconShadow;

	public UILabel m_ClothingNotesLabel;

	public UISprite m_TopRightStatusIcon;

	public UISprite m_TopRightStatusIconShadow;

	public UILabel m_TopRightStatusLabel;

	public UISprite m_TopLeftStatusIcon;

	public UISprite m_TopLeftStatusIconShadow;

	public UILabel m_TopLeftStatusLabel;

	public UISprite m_StackStatusIcon;

	public UISprite m_StackStatusIconShadow;

	public UILabel m_StackStatusLabel;

	public Color m_StackStatusColor;

	public string m_LiquidIcon;

	public string m_LampFuelIcon;

	public GameObject m_FavoriteObject;

	public GameObject m_FavoriteCheckmark;

	public UILabel m_FavoriteLabel;

	public Color m_FavoriteLabelColorChecked;

	public Color m_FavoriteLabelColorUnchecked;

	public string m_FoodHotStatusIcon;

	public Color m_FoodHotStatusColor;

	public string m_FoodColdStatusIcon;

	public Color m_FoodColdStatusColor;

	public string m_FrozenStatusIcon;

	public Color m_FrozenStatusColor;

	public string m_WetStatusIcon;

	public Color m_WetStatusColor;

	public UISprite m_ClothingLayerStatusIcon;

	public UISprite m_ClothingLayerStatusIconShadow;

	public UILabel m_ClothingLayerStatusLabel;

	public string m_ClothingOuterLayerIcon;

	public string m_ClothingInnerLayerIcon;

	public UILabel m_ItemDescLabel;

	public GameObject m_ClothingStatsObject;

	public UISprite m_ItemConditionSprite;

	public UILabel m_ItemConditionLabel;

	public UISprite m_ItemConditionArrow;

	public UILabel m_ItemMobilityLabel;

	public UISprite m_ItemMobilityArrow;

	public UILabel m_ItemToughnessLabel;

	public UISlider m_ItemToughnessSlider;

	public UISprite m_ItemToughnessArrow;

	public float m_ItemToughnessMaxValue;

	public UISprite m_ItemToughnessFillSprite;

	public UILabel m_ItemWaterproofnessLabel;

	public UISlider m_ItemWaterproofnessSlider;

	public UISprite m_ItemWaterproofnessArrow;

	public UISprite m_ItemWaterproofFillSprite;

	public UILabel m_ItemWarmthLabel;

	public UISprite m_ItemWarmthArrow;

	public UILabel m_ItemWeightLabel;

	public UISprite m_ItemWeightArrow;

	public UILabel m_ItemWindproofLabel;

	public UISprite m_ItemWindproofArrow;

	public Color m_CompareColorBetter;

	public Color m_CompareColorWorse;

	public Color m_BlueGreenColor;

	public Color m_WhiteColor;

	public Color m_RedColor;

	public UIButton m_UIButton_ButtonEquip;

	public UIButton m_UIButton_ButtonDrop;

	public GameObject m_MouseButtonEquip;

	public GameObject m_MouseButtonExamine;

	public GameObject m_MouseButtonDrop;

	public UILabel m_Label_MouseButtonEquip;

	public UILabel m_Label_MouseButtonExamine;

	public OnButtonDelegate m_OnDropDelegate;

	public OnButtonDelegate m_OnActionsDelegate;

	public OnButtonDelegate m_OnEquipDelegate;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 13)]
	public void OnEnable()
	{
	}

	[CalledBy(Type = typeof(Panel_Clothing), Member = "UpdateGearStatsBlock")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateGearStatsBlock")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GearItem), Member = "get_Description")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(EvolveItem), Member = "GetTimeToDryStringInventory")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(ResearchItem), Member = "IsResearchComplete")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "GetItemInfoString")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "GetColorForInfoString")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "UpdateConditionDisplay")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(Utils), Member = "GetWeightTwoDecimalPlacesWithUnitsString")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "UpdateTopRightStatus")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "UpdateTopLeftStatus")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "UpdateStackStatus")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "UpdateClothingLayerStatus")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "UpdateFavoriteStatus")]
	[Calls(Type = typeof(float), Member = "ToString")]
	[Calls(Type = typeof(ClothingItem), Member = "GetWarmth")]
	[Calls(Type = typeof(Utils), Member = "GetTemperatureString")]
	[Calls(Type = typeof(ClothingItem), Member = "GetWindproof")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "UpdateWaterproofnessDisplay")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "UpdateToughnessDisplay")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "UpdateComparisonArrows")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "UpdateButtons")]
	[CallsDeduplicatedMethods(Count = 21)]
	[CallsUnknownMethods(Count = 15)]
	public void UpdateGearItemDescription(GearItem gi, GearItem compareItem, OnButtonDelegate onDrop, OnButtonDelegate onActions, OnButtonDelegate onEquip)
	{
	}

	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateButtons")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateButtonStates")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnExamine")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BodyHarvest), Member = "NoMoreResources")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "CanClean")]
	[CallsUnknownMethods(Count = 3)]
	public bool CanExamine(GearItem gi)
	{
		return false;
	}

	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateButtons")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "OnDropItem")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnDrop")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnPlace")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInShelter")]
	[Calls(Type = typeof(PlayerManager), Member = "CheckIfCanDropGearItem")]
	[CallsUnknownMethods(Count = 6)]
	public bool CanDrop(GearItem gi)
	{
		return false;
	}

	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateButtons")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "UpdateTreatWoundsLocalizationId")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateButtonStates")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnEquip")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ResearchItem), Member = "IsResearchComplete")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsPanelEnabled")]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[CallsUnknownMethods(Count = 3)]
	public static string GetEquipButtonLocalizationId(GearItem gi)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnDrop()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnActions()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnEquip()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Inventory), Member = "OnAddToSatchel")]
	[CallsUnknownMethods(Count = 1)]
	public void OnFavorite()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearItem), Member = "get_Description")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(EvolveItem), Member = "GetTimeToDryStringInventory")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(ResearchItem), Member = "IsResearchComplete")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	private string BuildItemDescription(GearItem gi)
	{
		return null;
	}

	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateGearItemDescription")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GearItem), Member = "GetColorBasedOnCondition")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateConditionDisplay(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateTopRightStatus")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateAndEnableTopRightStatus(string text, string spriteName, Color c)
	{
	}

	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateTopLeftStatus")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateAndEnableTopLeftStatus(string text, string spriteName, Color c)
	{
	}

	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateStackStatus")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateAndEnableStackStatus(string text, string spriteName, Color c)
	{
	}

	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateClothingLayerStatus")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateAndEnableClothingLayerStatus(string text, string spriteName, Color c)
	{
	}

	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateGearItemDescription")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ClothingItem), Member = "GetWetnessOnlyString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "StripBraces")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "UpdateAndEnableTopRightStatus")]
	[Calls(Type = typeof(ClothingItem), Member = "GetFrozenOnlyString")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateTopRightStatus(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateGearItemDescription")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "UpdateAndEnableTopLeftStatus")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateTopLeftStatus(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateGearItemDescription")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "UpdateAndEnableStackStatus")]
	[Calls(Type = typeof(BowItem), Member = "GetNumArrowsInInventory")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(float), Member = "ToString")]
	[Calls(Type = typeof(PanelReference<>), Member = "GetPanel")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	private void UpdateStackStatus(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateGearItemDescription")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "UpdateAndEnableClothingLayerStatus")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateClothingLayerStatus(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateGearItemDescription")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PanelReference<>), Member = "GetPanel")]
	[Calls(Type = typeof(Panel_Inventory), Member = "CanBeAddedToSatchel")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateFavoriteStatus(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateTopRightStatus")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[CallsUnknownMethods(Count = 1)]
	private string StripBraces(string text)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(Utils), Member = "GetWeightTwoDecimalPlacesWithUnitsString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateWeightDisplay(GearItem gi)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClothingItem), Member = "GetWindproof")]
	[Calls(Type = typeof(Utils), Member = "GetTemperatureString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateWindproofDisplay(GearItem gi)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClothingItem), Member = "GetWarmth")]
	[Calls(Type = typeof(Utils), Member = "GetTemperatureString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateWarmthDisplay(GearItem gi)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateMobilityDisplay(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateGearItemDescription")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateWaterproofnessDisplay(GearItem gi, GearItem compareItem)
	{
	}

	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateGearItemDescription")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(float), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateToughnessDisplay(GearItem gi, GearItem compareItem)
	{
	}

	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateGearItemDescription")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnControllerScheme")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "GetEquipButtonLocalizationId")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "CanDrop")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "GetExamineButtonLocalizationID")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "CanExamine")]
	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 5)]
	public void UpdateButtons(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateButtons")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateButtonStates")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public static string GetExamineButtonLocalizationID(GearItem gi)
	{
		return null;
	}

	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateGearItemDescription")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[Calls(Type = typeof(EvolveItem), Member = "GetEvolvedPercentString")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsUnknownMethods(Count = 2)]
	private string GetItemInfoString(GearItem gi)
	{
		return null;
	}

	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateGearItemDescription")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[CallsUnknownMethods(Count = 2)]
	private Color GetColorForInfoString(GearItem gi)
	{
		return default(Color);
	}

	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateGearItemDescription")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "UpdateArrow")]
	[Calls(Type = typeof(ClothingItem), Member = "GetWarmth")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(ClothingItem), Member = "GetWindproof")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "DisableAllComparisonArrows")]
	[CallsUnknownMethods(Count = 15)]
	private void UpdateComparisonArrows(GearItem gi, GearItem compareItem)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "UpdateArrow")]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateItemConditionArrow(GearItem gi, GearItem compareItem)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "UpdateArrow")]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateItemMobilityArrow(GearItem gi, GearItem compareItem)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "UpdateArrow")]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateItemToughnessArrow(GearItem gi, GearItem compareItem)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "UpdateArrow")]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateItemWaterproofnessArrow(GearItem gi, GearItem compareItem)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClothingItem), Member = "GetWarmth")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "UpdateArrow")]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateItemWarmthArrow(GearItem gi, GearItem compareItem)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "UpdateArrow")]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateItemWeightArrow(GearItem gi, GearItem compareItem)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClothingItem), Member = "GetWindproof")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "UpdateArrow")]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateItemWindproofArrow(GearItem gi, GearItem compareItem)
	{
	}

	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateComparisonArrows")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateItemConditionArrow")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateItemMobilityArrow")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateItemToughnessArrow")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateItemWaterproofnessArrow")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateItemWarmthArrow")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateItemWeightArrow")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateItemWindproofArrow")]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateArrow(UISprite sprite, int baseValue, int compareValue)
	{
	}

	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateComparisonArrows")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 15)]
	private void DisableAllComparisonArrows()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ItemDescriptionPage()
	{
	}
}
