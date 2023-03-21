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
		[CallerCount(Count = 8)]
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
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ClothingItem), Member = "DoDryOrFreeze")]
	public void Update()
	{
	}

	[Calls(Type = typeof(Fire), Member = "GetRemainingLifeTimeSeconds")]
	[CalledBy(Type = typeof(GearItem), Member = "Serialize")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(ClothingItem), Member = "IsNearFire")]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FireManager), Member = "GetClosestFire")]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ClothingItem), Member = "PutOn")]
	[Calls(Type = typeof(ClothingItem), Member = "DoDryOrFreeze")]
	[Calls(Type = typeof(ClothingItem), Member = "DoDryOrFreeze")]
	[CallsUnknownMethods(Count = 2)]
	public void Deserialize(string text)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 29)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool IsWearing()
	{
		return default(bool);
	}

	[CallerCount(Count = 5)]
	[Calls(Type = typeof(PlayerManager), Member = "PutOnClothingItem")]
	[CalledBy(Type = typeof(ClothingItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseClothingItem")]
	[CalledBy(Type = typeof(StartGearData), Member = "AddStartingGearToPlayer")]
	[CalledBy(Type = typeof(StartGearData), Member = "AddStartingGearToPlayer")]
	[CallsUnknownMethods(Count = 1)]
	public void PutOn(ClothingLayer layerToPutOn = ClothingLayer.NumLayers)
	{
	}

	[CalledBy(Type = typeof(Inventory), Member = "RemoveGear")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseClothingItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseClothingItem")]
	[CalledBy(Type = typeof(GearItem), Member = "WearOut")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(GearItem), Member = "Drop")]
	[Calls(Type = typeof(PlayerManager), Member = "TakeOffClothingItem")]
	public void TakeOff()
	{
	}

	[CallerCount(Count = 0)]
	public bool IsDry()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Weather), Member = "GetWeatherStage")]
	[Calls(Type = typeof(Weather), Member = "GetWeatherStage")]
	[Calls(Type = typeof(Weather), Member = "GetWeatherStage")]
	[CallsUnknownMethods(Count = 5)]
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

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
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

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ClothingItem), Member = "IsNearFire")]
	[CalledBy(Type = typeof(WetZoneApplyOnlyTrigger), Member = "IncreaseWetness")]
	[CalledBy(Type = typeof(WetZoneTrigger), Member = "IncreaseWetness")]
	public void IncreaseWetnessPercent(float wetnessPercentIncrease)
	{
	}

	[CalledBy(Type = typeof(ClothingItem), Member = "DoDryOrFreeze")]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[CallerCount(Count = 1)]
	public void Dry(float amountToDry)
	{
	}

	[CallerCount(Count = 0)]
	public void Freeze(float amountToFreeze)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(GearItem), Member = "GetItemPostFixForInventoryInterfaces")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(GearItem), Member = "GetHoverStateText")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public string GetWetnessString()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateTopRightStatus")]
	[CallsUnknownMethods(Count = 3)]
	public string GetWetnessOnlyString()
	{
		return null;
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateTopRightStatus")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Replace")]
	public string GetFrozenOnlyString()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[CallsUnknownMethods(Count = 2)]
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

	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateBonusValuesFromWornClothing")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "RefreshSelectedBlueprint")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "UpdateGlobalStatBars")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(ClothingItem), Member = "GetWarmthAndWindchillBonusString")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateItemWarmthArrow")]
	[CalledBy(Type = typeof(ClothingItem), Member = "GetWindchillBonusString")]
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

	[CalledBy(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "PutOnClothingItem")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "ApplyCraftingProgress")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "GetEmptyLayerForRegion")]
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
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(GearItem), Member = "GetTextToDisplayWhenSelected")]
	[CallsUnknownMethods(Count = 89)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ClothingItem), Member = "GetWarmth")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(ClothingItem), Member = "GetWindproof")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public string GetWarmthAndWindchillBonusString(float normalizedCondition)
	{
		return null;
	}

	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(ClothingItem), Member = "GetWarmth")]
	[Calls(Type = typeof(ClothingItem), Member = "GetWindproof")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
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
	[Calls(Type = typeof(PlayerManager), Member = "GetTopLayerGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
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
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(ClothingItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(ClothingItem), Member = "Deserialize")]
	[Calls(Type = typeof(ClothingItem), Member = "Dry")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(ClothingItem), Member = "IsNearFire")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(ClothingItem), Member = "Update")]
	private void DoDryOrFreeze(float numHoursDelta, bool nearFireOverride = false)
	{
	}

	[CalledBy(Type = typeof(ClothingItem), Member = "DoDryOrFreeze")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateClothingWetness")]
	[CalledBy(Type = typeof(GearItem), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(ClothingItem), Member = "IncreaseWetnessPercent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(ClothingItem), Member = "Serialize")]
	[Calls(Type = typeof(FireManager), Member = "GetDistanceToClosestFire")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(ClothingItem), Member = "MaybeGetWetOnGround")]
	private bool IsNearFire()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsUnknownMethods(Count = 2)]
	public float GetDailyHPDecay()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public ClothingItem()
	{
	}
}
