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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
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

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Feat), Member = "ShouldBlockIncrement")]
	[Calls(Type = typeof(Feat_StraightToHeart), Member = "IsHeartItem")]
	[Calls(Type = typeof(Feat), Member = "HandleOnFeatUnlocked")]
	[CalledBy(Type = typeof(EmergencyStimItem), Member = "OnInject")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EatingComplete_Internal")]
	public void IncrementItemConsumed(GearItem gi, float itemFraction)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsUnknownMethods(Count = 1)]
	public override string GetDescription()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "ToString")]
	public override string GetShortDescription()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsUnknownMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveProfile")]
	[CallsUnknownMethods(Count = 1)]
	public override void SetNormalizedProgress(float normalizedValue)
	{
	}

	[CalledBy(Type = typeof(Feat_StraightToHeart), Member = "GetEffectiveLengthModifier")]
	[CalledBy(Type = typeof(Feat_StraightToHeart), Member = "IncrementItemConsumed")]
	[CalledBy(Type = typeof(EnergyBoost), Member = "ApplyEnergyBoost")]
	[CalledBy(Type = typeof(FatigueBuff), Member = "Apply")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(EmergencyStim), Member = "ApplyEmergencyStim")]
	[CallsUnknownMethods(Count = 5)]
	private bool IsHeartItem(GearItem gi)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public Feat_StraightToHeart()
	{
	}
}
