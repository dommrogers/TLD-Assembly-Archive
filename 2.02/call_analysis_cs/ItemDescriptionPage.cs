using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ItemDescriptionPage : MonoBehaviour
{
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
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 24)]
	public void OnEnable()
	{
	}

	[CalledBy(Type = typeof(Panel_Clothing), Member = "UpdateGearStatsBlock")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateGearStatsBlock")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "BuildItemDescription")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "GetItemInfoString")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "GetColorForInfoString")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "UpdateConditionDisplay")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightIgnoreClothingWornBonusKG")]
	[Calls(Type = typeof(Utils), Member = "GetWeightTwoDecimalPlacesWithUnitsString")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "UpdateTopRightStatus")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "UpdateTopLeftStatus")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "UpdateStackStatus")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "UpdateClothingLayerStatus")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "UpdateFavoriteStatus")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(ClothingItem), Member = "GetWarmth")]
	[Calls(Type = typeof(Utils), Member = "GetTemperatureString")]
	[Calls(Type = typeof(ClothingItem), Member = "GetWindproof")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "UpdateWaterproofnessDisplay")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "UpdateToughnessDisplay")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "UpdateComparisonArrows")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "UpdateButtons")]
	[CallsDeduplicatedMethods(Count = 30)]
	[CallsUnknownMethods(Count = 89)]
	public void UpdateGearItemDescription(GearItem gi, GearItem compareItem, OnButtonDelegate onDrop, OnButtonDelegate onActions, OnButtonDelegate onEquip)
	{
	}

	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateButtons")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateButtonStates")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnExamine")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GunItem), Member = "NumRoundsInClip")]
	[Calls(Type = typeof(BodyHarvest), Member = "NoMoreResources")]
	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "CanClean")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
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
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 22)]
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
	[Calls(Type = typeof(Panel_Inventory), Member = "OnAddToSatchel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnFavorite()
	{
	}

	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateGearItemDescription")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(EvolveItem), Member = "GetTimeToDryStringInventory")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(ResearchItem), Member = "IsResearchComplete")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private string BuildItemDescription(GearItem gi)
	{
		return null;
	}

	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateGearItemDescription")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GearItem), Member = "GetColorBasedOnCondition")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	private void UpdateConditionDisplay(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateTopRightStatus")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateAndEnableTopRightStatus(string text, string spriteName, Color c)
	{
	}

	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateTopLeftStatus")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
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
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 14)]
	private void UpdateAndEnableStackStatus(string text, string spriteName, Color c)
	{
	}

	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateClothingLayerStatus")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateAndEnableClothingLayerStatus(string text, string spriteName, Color c)
	{
	}

	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateGearItemDescription")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "StripBraces")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "UpdateAndEnableTopRightStatus")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 31)]
	private void UpdateTopRightStatus(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateGearItemDescription")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "UpdateAndEnableTopLeftStatus")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 12)]
	private void UpdateTopLeftStatus(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateGearItemDescription")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "UpdateAndEnableStackStatus")]
	[Calls(Type = typeof(BowItem), Member = "GetNumArrowsInInventory")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(GunItem), Member = "NumRoundsInClip")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 26)]
	private void UpdateStackStatus(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateGearItemDescription")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "UpdateAndEnableClothingLayerStatus")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 11)]
	private void UpdateClothingLayerStatus(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateGearItemDescription")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Inventory), Member = "CanBeAddedToSatchel")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateFavoriteStatus(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateTopRightStatus")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private string StripBraces(string text)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightIgnoreClothingWornBonusKG")]
	[Calls(Type = typeof(Utils), Member = "GetWeightTwoDecimalPlacesWithUnitsString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateWeightDisplay(GearItem gi)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClothingItem), Member = "GetWindproof")]
	[Calls(Type = typeof(Utils), Member = "GetTemperatureString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateWindproofDisplay(GearItem gi)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClothingItem), Member = "GetWarmth")]
	[Calls(Type = typeof(Utils), Member = "GetTemperatureString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateWarmthDisplay(GearItem gi)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void UpdateMobilityDisplay(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateGearItemDescription")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 13)]
	private void UpdateWaterproofnessDisplay(GearItem gi, GearItem compareItem)
	{
	}

	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateGearItemDescription")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 13)]
	private void UpdateToughnessDisplay(GearItem gi, GearItem compareItem)
	{
	}

	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateGearItemDescription")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnControllerScheme")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "GetEquipButtonLocalizationId")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "CanDrop")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "GetExamineButtonLocalizationID")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "CanExamine")]
	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 23)]
	public void UpdateButtons(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateButtons")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateButtonStates")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static string GetExamineButtonLocalizationID(GearItem gi)
	{
		return null;
	}

	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateGearItemDescription")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[Calls(Type = typeof(EvolveItem), Member = "GetEvolvedPercentString")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	private string GetItemInfoString(GearItem gi)
	{
		return null;
	}

	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateGearItemDescription")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private Color GetColorForInfoString(GearItem gi)
	{
		return default(Color);
	}

	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateGearItemDescription")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "UpdateArrow")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(ClothingItem), Member = "GetWarmth")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightIgnoreClothingWornBonusKG")]
	[Calls(Type = typeof(ClothingItem), Member = "GetWindproof")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "DisableAllComparisonArrows")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 12)]
	private void UpdateComparisonArrows(GearItem gi, GearItem compareItem)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "UpdateArrow")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateItemConditionArrow(GearItem gi, GearItem compareItem)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "UpdateArrow")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateItemMobilityArrow(GearItem gi, GearItem compareItem)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "UpdateArrow")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateItemToughnessArrow(GearItem gi, GearItem compareItem)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "UpdateArrow")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateItemWaterproofnessArrow(GearItem gi, GearItem compareItem)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClothingItem), Member = "GetWarmth")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "UpdateArrow")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateItemWarmthArrow(GearItem gi, GearItem compareItem)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightIgnoreClothingWornBonusKG")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "UpdateArrow")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateItemWeightArrow(GearItem gi, GearItem compareItem)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClothingItem), Member = "GetWindproof")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "UpdateArrow")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
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
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 4)]
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
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public ItemDescriptionPage()
	{
	}
}
