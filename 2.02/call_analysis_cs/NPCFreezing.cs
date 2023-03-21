using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class NPCFreezing : MonoBehaviour
{
	private class SaveData
	{
		public float m_CurrentFreezing;

		public float m_CurrentFreezingPerHour;

		public float m_CurrentWarmingPerHour;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public SaveData()
		{
		}
	}

	private enum Level
	{
		Freezing,
		Cold
	}

	public float m_CurrentFreezing;

	public float m_MaxFreezing;

	public float m_FreezingThreshold;

	public float m_TemperatureFreezingStarts;

	public float m_FreezingIncreasePerHourPerDegreeCelsius;

	public float m_WarmingIncreasePerHourPerDegreeCelsius;

	public float m_WarmthBonus;

	public float m_WindChillBonus;

	public float m_FreezingRateScale;

	public string m_FreezingVoiceOver;

	public string m_WarmingVoiceOver;

	[NonSerialized]
	public float m_CurrentFreezingPerHour;

	[NonSerialized]
	public float m_CurrentWarmingPerHour;

	[NonSerialized]
	public float m_CurrentTemperature;

	[NonSerialized]
	public NPC m_NPC;

	private Level m_LastVOLevel;

	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 1)]
	public float GetHealthyDelta(float delta)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(NPCCondition), Member = "ApplyDamage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void ApplyTODHours(float delta)
	{
	}

	[CalledBy(Type = typeof(NPC), Member = "DoConditionUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NPCFreezing), Member = "GetPosition")]
	[Calls(Type = typeof(FireManager), Member = "PointInRadiusOfBurningFire")]
	[Calls(Type = typeof(NPCFreezing), Member = "CalculateCurrentTemperature")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCVoice), Member = "Play")]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	[Calls(Type = typeof(AfflictionDefinitionTable), Member = "GetAfflictionDefinitionByName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(NPCAfflictions), Member = "AddAffliction")]
	[Calls(Type = typeof(NPCAfflictions), Member = "HealedAffliction")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 24)]
	public void DoUpdate(float deltaTODHours)
	{
	}

	[CallerCount(Count = 0)]
	public bool IsFreezing()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Deserialize(string serialized)
	{
	}

	[CalledBy(Type = typeof(NPC), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(NPCFreezing), Member = "DoUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NPC), Member = "IsIndoors")]
	[Calls(Type = typeof(NPCFreezing), Member = "GetPosition")]
	[Calls(Type = typeof(HeatSourceManager), Member = "GetTemperatureIncrease")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Bed), Member = "GetWarmthBonusCelsius")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 16)]
	private float CalculateCurrentTemperature(bool inRangeOfFire)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	private Level GetCurrentFreezingLevel()
	{
		return default(Level);
	}

	[CalledBy(Type = typeof(NPCFreezing), Member = "DoUpdate")]
	[CalledBy(Type = typeof(NPCFreezing), Member = "CalculateCurrentTemperature")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BodyCarry), Member = "IsCarryingBody")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 15)]
	private Vector3 GetPosition()
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCVoice), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void MaybePlayVoiceOver()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void EndHypothermia()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public NPCFreezing()
	{
	}
}
