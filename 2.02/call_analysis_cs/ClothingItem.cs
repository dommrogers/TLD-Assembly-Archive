using System;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ClothingItem : MonoBehaviour
{
	public ClothingRegion m_Region;

	public ClothingLayer m_MinLayer;

	public ClothingLayer m_MaxLayer;

	public ClothingMovementSound m_WornMovementSoundCategory;

	public FootwearType m_FootwearType;

	public float m_DailyHPDecayWhenWornOutside;

	public float m_DailyHPDecayWhenWornInside;

	public float m_Warmth;

	public float m_WarmthWhenWet;

	public float m_Windproof;

	public float m_Toughness;

	public float m_SprintBarReductionPercent;

	public float m_Waterproofness;

	public float m_DryPercentPerHour;

	public float m_DryPercentPerHourNoFire;

	public float m_FreezePercentPerHour;

	public float m_DryBonusWhenNotWorn;

	public string m_PaperDollTextureName;

	public string m_PaperDollBlendmapName;

	public uint m_ClothingMaterialSwitch;

	private float m_PercentWet;

	private float m_PercentFrozen;

	private float m_CurrentTemp;

	private bool m_DroppedIndoors;

	private ClothingLayer m_EquippedLayer;

	private GearItem m_GearItem;

	private static ClothingItemSaveDataProxy m_ClothingItemSaveDataProxy;

	[Calls(Type = typeof(ClothingItem), Member = "CacheClothingSoundSwitch")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Start()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ClothingItem), Member = "DoDryOrFreeze")]
	[CalledBy(Type = typeof(Inventory), Member = "ProcessItems")]
	[CallsUnknownMethods(Count = 4)]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(GearItem), Member = "Serialize")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Fire), Member = "GetRemainingLifeTimeSeconds")]
	[Calls(Type = typeof(ClothingItem), Member = "IsNearFire")]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FireManager), Member = "GetClosestFire")]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ClothingItem), Member = "PutOn")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(ClothingItem), Member = "DoDryOrFreeze")]
	[Calls(Type = typeof(ClothingItem), Member = "DoDryOrFreeze")]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 4)]
	public void Deserialize(string text)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "IsWearingClothingItem")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 28)]
	public bool IsWearing()
	{
		return default(bool);
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "PutOnClothingItem")]
	[CalledBy(Type = typeof(ClothingItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseClothingItem")]
	[CalledBy(Type = typeof(StartGear), Member = "AddAllToInventory")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(StartGear), Member = "AddAllToInventory")]
	public void PutOn(ClothingLayer layerToPutOn = ClothingLayer.NumLayers)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UseClothingItem")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Inventory), Member = "RemoveGear")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseClothingItem")]
	[CalledBy(Type = typeof(GearItem), Member = "Drop")]
	[Calls(Type = typeof(PlayerManager), Member = "TakeOffClothingItem")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(GearItem), Member = "WearOut")]
	public void TakeOff()
	{
	}

	[CallerCount(Count = 0)]
	public bool IsDry()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Weather), Member = "GetWeatherStage")]
	[Calls(Type = typeof(Weather), Member = "GetWeatherStage")]
	[Calls(Type = typeof(Weather), Member = "GetWeatherStage")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	public bool IsGettingWet()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool IsFrozen()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public void SetFullyWet()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetFullyUnfrozen()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetWetnessIncreasePerHour")]
	[Calls(Type = typeof(ClothingItem), Member = "IncreaseWetnessPercent")]
	[CallsUnknownMethods(Count = 2)]
	public void MaybeGetWetOnGround(float deltaTODHours)
	{
	}

	[CalledBy(Type = typeof(WetZoneApplyOnlyTrigger), Member = "IncreaseWetness")]
	[CalledBy(Type = typeof(WetZoneTrigger), Member = "IncreaseWetness")]
	[CalledBy(Type = typeof(GearItem), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateClothingWetness")]
	[Calls(Type = typeof(ClothingItem), Member = "IsNearFire")]
	[CalledBy(Type = typeof(ClothingItem), Member = "MaybeGetWetOnGround")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	public void IncreaseWetnessPercent(float wetnessPercentIncrease)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[CalledBy(Type = typeof(ClothingItem), Member = "DoDryOrFreeze")]
	public void Dry(float amountToDry)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Freeze(float amountToFreeze)
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "GetItemPostFixForInventoryInterfaces")]
	[CalledBy(Type = typeof(GearItem), Member = "GetHoverText")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	public string GetWetnessString()
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public string GetWetnessOnlyString()
	{
		return null;
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	public string GetFrozenOnlyString()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[CalledBy(Type = typeof(GearItem), Member = "GetSingleItemWeightKG")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	public float GetWeightModifier()
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(GearItem), Member = "GetItemWeightIgnoreClothingWornBonusKG")]
	public float GetWeightModifierNoWornBonus()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public float GetWetnessDebuffNormalized()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public float GetWetnessNormalized()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public float GetFrozenNormalized()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public float GetWarmthWhenWet()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateItemWarmthArrow")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateBonusValuesFromWornClothing")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "RefreshSelectedBlueprint")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "UpdateGlobalStatBars")]
	[CalledBy(Type = typeof(ClothingItem), Member = "GetWindchillBonusString")]
	[CalledBy(Type = typeof(ClothingItem), Member = "GetWarmthAndWindchillBonusString")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateItemWarmthArrow")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateComparisonArrows")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateWarmthDisplay")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateGearItemDescription")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateComparisonArrows")]
	public float GetWarmth()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(ClothingItem), Member = "GetWindchillBonusString")]
	[CalledBy(Type = typeof(ClothingItem), Member = "GetWarmthAndWindchillBonusString")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "UpdateGlobalStatBars")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateItemWindproofArrow")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateBonusValuesFromWornClothing")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "RefreshSelectedBlueprint")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateItemWindproofArrow")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateComparisonArrows")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateWindproofDisplay")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateGearItemDescription")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateComparisonArrows")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 11)]
	public float GetWindproof()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsUnknownMethods(Count = 2)]
	public void Dropped()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "ApplyCraftingProgress")]
	[Calls(Type = typeof(PlayerManager), Member = "PutOnClothingItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "GetEmptyLayerForRegion")]
	public void PickedUp()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsUnknownMethods(Count = 2)]
	public void OnFirstInspect()
	{
	}

	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 94)]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(GearItem), Member = "GetTextToDisplayWhenSelected")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ClothingItem), Member = "GetWarmth")]
	[Calls(Type = typeof(ClothingItem), Member = "GetWindproof")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	public string GetWarmthAndWindchillBonusString(float normalizedCondition)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(ClothingItem), Member = "GetWarmth")]
	[Calls(Type = typeof(ClothingItem), Member = "GetWindproof")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallerCount(Count = 0)]
	public string GetWindchillBonusString(float normalizedCondition)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public ClothingLayer GetEquippedLayer()
	{
		return default(ClothingLayer);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void SetEquippedLayer(ClothingLayer layer)
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetTopLayerGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "UpdateGlobalStatBars")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateBonusValuesFromWornClothing")]
	[CalledBy(Type = typeof(WetZoneApplyOnlyTrigger), Member = "IncreaseWetness")]
	[CalledBy(Type = typeof(WetZoneTrigger), Member = "IncreaseWetness")]
	[CallsUnknownMethods(Count = 2)]
	public bool IsOutermostItemInClothingRegion()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(ClothingItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(ClothingItem), Member = "Deserialize")]
	[Calls(Type = typeof(ClothingItem), Member = "Dry")]
	[CalledBy(Type = typeof(ClothingItem), Member = "Update")]
	[Calls(Type = typeof(ClothingItem), Member = "IsNearFire")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	private void DoDryOrFreeze(float numHoursDelta, bool nearFireOverride = false)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(FireManager), Member = "GetDistanceToClosestFire")]
	[CalledBy(Type = typeof(ClothingItem), Member = "Serialize")]
	[CalledBy(Type = typeof(ClothingItem), Member = "IncreaseWetnessPercent")]
	[CalledBy(Type = typeof(ClothingItem), Member = "DoDryOrFreeze")]
	[CallsUnknownMethods(Count = 7)]
	private bool IsNearFire()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(ClothingItem), Member = "Awake")]
	private void CacheClothingSoundSwitch()
	{
	}

	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public float GetDailyHPDecay()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public ClothingItem()
	{
	}
}
