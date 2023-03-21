using System;
using System.Globalization;
using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using TLD.Gear;
using TLD.Serialization;
using UnityEngine;

public class ClothingItem : MonoBehaviour
{
	public ClothingRegion m_Region;

	public ClothingLayer m_MinLayer;

	public ClothingLayer m_MaxLayer;

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

	private Switch m_MaterialSwitch;

	private float m_PercentWet;

	private float m_PercentFrozen;

	private bool m_DroppedIndoors;

	private ClothingLayer m_EquippedLayer;

	private GearItem m_GearItem;

	private static ClothingItemSaveDataProxy m_ClothingItemSaveDataProxy;

	public Switch MaterialAudioSwitch
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 4)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void Start()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Inventory), Member = "ProcessItems")]
	[Calls(Type = typeof(ClothingItem), Member = "DoDryOrFreeze")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(GearItem), Member = "Serialize")]
	[Calls(Type = typeof(Fire), Member = "GetRemainingLifeTimeSeconds")]
	[Calls(Type = typeof(FireManager), Member = "GetClosestFire")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ClothingItem), Member = "IsNearFire")]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ClothingItem), Member = "PutOn")]
	[Calls(Type = typeof(ClothingItem), Member = "DoDryOrFreeze")]
	[Calls(Type = typeof(ClothingItem), Member = "DoDryOrFreeze")]
	public void Deserialize(string text)
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "IsWearingClothingItem")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 29)]
	public bool IsWearing()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(PlayerManager), Member = "PutOnClothingItem")]
	[CalledBy(Type = typeof(ClothingItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseClothingItem")]
	[CalledBy(Type = typeof(StartGearData), Member = "AddStartingGearToPlayer")]
	[CalledBy(Type = typeof(StartGearData), Member = "AddStartingGearToPlayer")]
	public void PutOn(ClothingLayer layerToPutOn = ClothingLayer.NumLayers)
	{
	}

	[CalledBy(Type = typeof(Inventory), Member = "RemoveGear")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseClothingItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseClothingItem")]
	[Calls(Type = typeof(PlayerManager), Member = "TakeOffClothingItem")]
	[CalledBy(Type = typeof(GearItem), Member = "WearOut")]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(GearItem), Member = "Drop")]
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
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
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
	[Calls(Type = typeof(PlayerManager), Member = "GetWetnessIncreasePerHour")]
	[Calls(Type = typeof(ClothingItem), Member = "IsNearFire")]
	[CallsUnknownMethods(Count = 2)]
	public void MaybeGetWetOnGround(float deltaTODHours)
	{
	}

	[CalledBy(Type = typeof(WetZoneTrigger), Member = "IncreaseWetness")]
	[CalledBy(Type = typeof(WetZoneApplyOnlyTrigger), Member = "IncreaseWetness")]
	[Calls(Type = typeof(ClothingItem), Member = "IsNearFire")]
	[CallerCount(Count = 2)]
	public void IncreaseWetnessPercent(float wetnessPercentIncrease)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[CalledBy(Type = typeof(ClothingItem), Member = "DoDryOrFreeze")]
	public void Dry(float amountToDry)
	{
	}

	[CallerCount(Count = 0)]
	public void Freeze(float amountToFreeze)
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "GetHoverStateText")]
	[CalledBy(Type = typeof(GearItem), Member = "GetItemPostFixForInventoryInterfaces")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public string GetWetnessString()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateTopRightStatus")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	public string GetWetnessOnlyString()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateTopRightStatus")]
	public string GetFrozenOnlyString()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[CallerCount(Count = 0)]
	public float GetWeightModifier()
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(GearItem), Member = "GetItemWeightKG")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public float GetWarmthWhenWet()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "RefreshSelectedBlueprint")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "UpdateGlobalStatBars")]
	[CalledBy(Type = typeof(ClothingItem), Member = "GetWindchillBonusString")]
	[CalledBy(Type = typeof(ClothingItem), Member = "GetWarmthAndWindchillBonusString")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateItemWarmthArrow")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateBonusValuesFromWornClothing")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateComparisonArrows")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateComparisonArrows")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateWarmthDisplay")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateGearItemDescription")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateItemWarmthArrow")]
	public float GetWarmth()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateBonusValuesFromWornClothing")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "RefreshSelectedBlueprint")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "UpdateGlobalStatBars")]
	[CalledBy(Type = typeof(ClothingItem), Member = "GetWindchillBonusString")]
	[CalledBy(Type = typeof(ClothingItem), Member = "GetWarmthAndWindchillBonusString")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateItemWindproofArrow")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateItemWindproofArrow")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateComparisonArrows")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateWindproofDisplay")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateGearItemDescription")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateComparisonArrows")]
	public float GetWindproof()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsUnknownMethods(Count = 1)]
	public void Dropped()
	{
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "ApplyCraftingProgress")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedGearItem")]
	[Calls(Type = typeof(PlayerManager), Member = "PutOnClothingItem")]
	[Calls(Type = typeof(PlayerManager), Member = "GetEmptyLayerForRegion")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallerCount(Count = 3)]
	public void PickedUp()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsUnknownMethods(Count = 1)]
	public void OnFirstInspect()
	{
	}

	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(GearItem), Member = "GetTextToDisplayWhenSelected")]
	[CallsUnknownMethods(Count = 89)]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(ClothingItem), Member = "GetWarmth")]
	[Calls(Type = typeof(ClothingItem), Member = "GetWindproof")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public string GetWarmthAndWindchillBonusString(float normalizedCondition)
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ClothingItem), Member = "GetWindproof")]
	[Calls(Type = typeof(ClothingItem), Member = "GetWarmth")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 2)]
	public string GetWindchillBonusString(float normalizedCondition)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ClothingLayer GetEquippedLayer()
	{
		return default(ClothingLayer);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void SetEquippedLayer(ClothingLayer layer)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(WetZoneTrigger), Member = "IncreaseWetness")]
	[CalledBy(Type = typeof(WetZoneApplyOnlyTrigger), Member = "IncreaseWetness")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTopLayerGear")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "UpdateGlobalStatBars")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateBonusValuesFromWornClothing")]
	public bool IsOutermostItemInClothingRegion()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(ClothingItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(ClothingItem), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(ClothingItem), Member = "Dry")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(ClothingItem), Member = "IsNearFire")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(ClothingItem), Member = "Update")]
	private void DoDryOrFreeze(float numHoursDelta, bool nearFireOverride = false)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateClothingWetness")]
	[CalledBy(Type = typeof(GearItem), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(ClothingItem), Member = "DoDryOrFreeze")]
	[CalledBy(Type = typeof(ClothingItem), Member = "IncreaseWetnessPercent")]
	[CalledBy(Type = typeof(ClothingItem), Member = "Serialize")]
	[Calls(Type = typeof(FireManager), Member = "GetDistanceToClosestFire")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(ClothingItem), Member = "MaybeGetWetOnGround")]
	private bool IsNearFire()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	public float GetDailyHPDecay()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public ClothingItem()
	{
	}
}
