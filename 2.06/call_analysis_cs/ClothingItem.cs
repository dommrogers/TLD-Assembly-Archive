using System.Globalization;
using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using TLD.Gear;
using TLD.SaveState;
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
		[CallerCount(Count = 12)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	public void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void Start()
	{
	}

	[CalledBy(Type = typeof(Inventory), Member = "ProcessItems")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ClothingItem), Member = "DoDryOrFreeze")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[Calls(Type = typeof(ClothingItem), Member = "IsNearFire")]
	[Calls(Type = typeof(FireManager), Member = "GetClosestFire")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Fire), Member = "GetRemainingLifeTimeSeconds")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(ClothingItem), Member = "PutOn")]
	[Calls(Type = typeof(ClothingItem), Member = "DoDryOrFreeze")]
	[CallsUnknownMethods(Count = 2)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 29)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 2)]
	public bool IsWearing()
	{
		return false;
	}

	[CalledBy(Type = typeof(ClothingItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseClothingItem")]
	[CalledBy(Type = typeof(StartGearData), Member = "AddStartingGearToPlayer")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(PlayerManager), Member = "PutOnClothingItem")]
	[CallsUnknownMethods(Count = 1)]
	public void PutOn(ClothingLayer layerToPutOn = ClothingLayer.NumLayers)
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "WearOut")]
	[CalledBy(Type = typeof(GearItem), Member = "Drop")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseClothingItem")]
	[CalledBy(Type = typeof(Inventory), Member = "RemoveGear")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(PlayerManager), Member = "TakeOffClothingItem")]
	[CallsUnknownMethods(Count = 1)]
	public void TakeOff()
	{
	}

	[CallerCount(Count = 0)]
	public bool IsDry()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Weather), Member = "GetWeatherStage")]
	[CallsUnknownMethods(Count = 5)]
	public bool IsGettingWet()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool IsFrozen()
	{
		return false;
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

	[CalledBy(Type = typeof(WetZoneApplyOnlyTrigger), Member = "IncreaseWetness")]
	[CalledBy(Type = typeof(WetZoneTrigger), Member = "IncreaseWetness")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ClothingItem), Member = "IsNearFire")]
	public void IncreaseWetnessPercent(float wetnessPercentIncrease)
	{
	}

	[CalledBy(Type = typeof(ClothingItem), Member = "DoDryOrFreeze")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	public void Dry(float amountToDry)
	{
	}

	[CallerCount(Count = 0)]
	public void Freeze(float amountToFreeze)
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "GetItemPostFixForInventoryInterfaces")]
	[CalledBy(Type = typeof(GearItem), Member = "GetHoverStateText")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[CallsUnknownMethods(Count = 4)]
	public string GetWetnessString()
	{
		return null;
	}

	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateTopRightStatus")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsUnknownMethods(Count = 3)]
	public string GetWetnessOnlyString()
	{
		return null;
	}

	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateTopRightStatus")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsUnknownMethods(Count = 3)]
	public string GetFrozenOnlyString()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[CallsUnknownMethods(Count = 2)]
	public float GetWeightModifier()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[CallerCount(Count = 1)]
	public float GetWeightModifierNoWornBonus()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public float GetWetnessDebuffNormalized()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public float GetWetnessNormalized()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public float GetFrozenNormalized()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public float GetWarmthWhenWet()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateGearItemDescription")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateWarmthDisplay")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateComparisonArrows")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateItemWarmthArrow")]
	[CalledBy(Type = typeof(ClothingItem), Member = "GetWarmthAndWindchillBonusString")]
	[CalledBy(Type = typeof(ClothingItem), Member = "GetWindchillBonusString")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "UpdateGlobalStatBars")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "RefreshSelectedBlueprint")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateBonusValuesFromWornClothing")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public float GetWarmth()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateGearItemDescription")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateWindproofDisplay")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateComparisonArrows")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateItemWindproofArrow")]
	[CalledBy(Type = typeof(ClothingItem), Member = "GetWarmthAndWindchillBonusString")]
	[CalledBy(Type = typeof(ClothingItem), Member = "GetWindchillBonusString")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "UpdateGlobalStatBars")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "RefreshSelectedBlueprint")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateBonusValuesFromWornClothing")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public float GetWindproof()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsUnknownMethods(Count = 1)]
	public void Dropped()
	{
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "ApplyCraftingProgress")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetEmptyLayerForRegion")]
	[Calls(Type = typeof(PlayerManager), Member = "PutOnClothingItem")]
	[CallsUnknownMethods(Count = 3)]
	public void PickedUp()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsUnknownMethods(Count = 1)]
	public void OnFirstInspect()
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "GetTextToDisplayWhenSelected")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ClothingItem), Member = "GetWarmth")]
	[Calls(Type = typeof(ClothingItem), Member = "GetWindproof")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 89)]
	public string GetWarmthAndWindchillBonusString(float normalizedCondition)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClothingItem), Member = "GetWindproof")]
	[Calls(Type = typeof(ClothingItem), Member = "GetWarmth")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetEquippedLayer(ClothingLayer layer)
	{
	}

	[CalledBy(Type = typeof(Panel_Clothing), Member = "UpdateGlobalStatBars")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateBonusValuesFromWornClothing")]
	[CalledBy(Type = typeof(WetZoneApplyOnlyTrigger), Member = "IncreaseWetness")]
	[CalledBy(Type = typeof(WetZoneTrigger), Member = "IncreaseWetness")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PlayerManager), Member = "GetTopLayerGear")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 2)]
	public bool IsOutermostItemInClothingRegion()
	{
		return false;
	}

	[CalledBy(Type = typeof(ClothingItem), Member = "Update")]
	[CalledBy(Type = typeof(ClothingItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ClothingItem), Member = "IsNearFire")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(ClothingItem), Member = "Dry")]
	[CallsUnknownMethods(Count = 2)]
	private void DoDryOrFreeze(float numHoursDelta, bool nearFireOverride = false)
	{
	}

	[CalledBy(Type = typeof(ClothingItem), Member = "Serialize")]
	[CalledBy(Type = typeof(ClothingItem), Member = "MaybeGetWetOnGround")]
	[CalledBy(Type = typeof(ClothingItem), Member = "IncreaseWetnessPercent")]
	[CalledBy(Type = typeof(ClothingItem), Member = "DoDryOrFreeze")]
	[CalledBy(Type = typeof(GearItem), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateClothingWetness")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(FireManager), Member = "GetDistanceToClosestFire")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private bool IsNearFire()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsUnknownMethods(Count = 2)]
	public float GetDailyHPDecay()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public ClothingItem()
	{
	}
}
