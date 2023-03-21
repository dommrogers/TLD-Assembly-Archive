using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Gear;
using TLD.Serialization;
using UnityEngine;

public class Feat_StraightToHeart : Feat
{
	public List<GearItemData> m_Items;

	public int m_ItemConsumedCountRequired;

	public int m_EffectiveLengthIncreasePercent;

	private static int s_ItemConsumedCount;

	private static float s_ItemConsumedAccumulator;

	private static Feat_StraightToHeartSaveData m_Feat_StraightToHeartSaveData;

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void ValidateSaveData(string text)
	{
	}

	[Calls(Type = typeof(Feat_StraightToHeart), Member = "IsHeartItem")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Feat), Member = "IsUnlockedAndEnabled")]
	public float GetEffectiveLengthModifier(GearItem gi)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(EmergencyStimItem), Member = "OnInject")]
	[Calls(Type = typeof(Feat), Member = "HandleOnFeatUnlocked")]
	[Calls(Type = typeof(Feat_StraightToHeart), Member = "IsHeartItem")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "EatingComplete_Internal")]
	[Calls(Type = typeof(Feat), Member = "ShouldBlockIncrement")]
	public void IncrementItemConsumed(GearItem gi, float itemFraction)
	{
	}

	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "ToString")]
	public override string GetDescription()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsUnknownMethods(Count = 1)]
	public override string GetShortDescription()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Replace")]
	public override string GetBonusDescription()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public override bool IsUnlocked()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public override float GetNormalizedProgress()
	{
		return default(float);
	}

	[Calls(Type = typeof(SaveGameSystem), Member = "SaveProfile")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public override void SetNormalizedProgress(float normalizedValue)
	{
	}

	[CalledBy(Type = typeof(Feat_StraightToHeart), Member = "IncrementItemConsumed")]
	[CalledBy(Type = typeof(Feat_StraightToHeart), Member = "GetEffectiveLengthModifier")]
	[CalledBy(Type = typeof(FatigueBuff), Member = "Apply")]
	[CalledBy(Type = typeof(EnergyBoost), Member = "ApplyEnergyBoost")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(EmergencyStim), Member = "ApplyEmergencyStim")]
	private bool IsHeartItem(GearItem gi)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public Feat_StraightToHeart()
	{
	}
}
