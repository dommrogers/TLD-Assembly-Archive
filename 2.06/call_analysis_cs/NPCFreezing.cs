using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using UnityEngine;

public class NPCFreezing : MonoBehaviour
{
	private class SaveData
	{
		public float m_CurrentFreezing;

		public float m_CurrentFreezingPerHour;

		public float m_CurrentWarmingPerHour;

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
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
	public float GetHealthyDelta(float delta)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPCCondition), Member = "UpdateHealthForFreezing")]
	public void ApplyTODHours(float delta)
	{
	}

	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	[CalledBy(Type = typeof(NPC), Member = "DoConditionUpdate")]
	[Calls(Type = typeof(NPCVoice), Member = "Play")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(NPCAfflictions), Member = "HealedAffliction")]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	[Calls(Type = typeof(NPCAfflictions), Member = "HealedAffliction")]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(NPCAfflictions), Member = "AddAffliction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NPCFreezing), Member = "GetPosition")]
	[Calls(Type = typeof(FireManager), Member = "PointInRadiusOfBurningFire")]
	[Calls(Type = typeof(NPCFreezing), Member = "CalculateCurrentTemperature")]
	[Calls(Type = typeof(NPCVoice), Member = "Play")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AfflictionDefinitionTable), Member = "GetAfflictionDefinitionByName")]
	public void DoUpdate(float deltaTODHours)
	{
	}

	[CallerCount(Count = 0)]
	public bool IsFreezing()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Deserialize(string serialized)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 6)]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(NPCFreezing), Member = "DoUpdate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Bed), Member = "GetWarmthBonusCelsius")]
	[Calls(Type = typeof(NPCFreezing), Member = "GetPosition")]
	[Calls(Type = typeof(NPC), Member = "IsIndoors")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HeatSourceManager), Member = "GetTemperatureIncrease")]
	private float CalculateCurrentTemperature(bool inRangeOfFire)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	private Level GetCurrentFreezingLevel()
	{
		return default(Level);
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(NPCFreezing), Member = "CalculateCurrentTemperature")]
	[CalledBy(Type = typeof(NPCFreezing), Member = "DoUpdate")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(BodyCarry), Member = "IsCarryingBody")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	private Vector3 GetPosition()
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPCVoice), Member = "Play")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void MaybePlayVoiceOver()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void EndHypothermia()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public NPCFreezing()
	{
	}
}
