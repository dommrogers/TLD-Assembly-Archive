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

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
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
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPCCondition), Member = "ApplyDamage")]
	[CallsUnknownMethods(Count = 1)]
	public void ApplyTODHours(float delta)
	{
	}

	[CalledBy(Type = typeof(NPC), Member = "DoConditionUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NPCFreezing), Member = "GetPosition")]
	[Calls(Type = typeof(FireManager), Member = "PointInRadiusOfBurningFire")]
	[Calls(Type = typeof(NPCFreezing), Member = "CalculateCurrentTemperature")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCVoice), Member = "Play")]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	[Calls(Type = typeof(AfflictionDefinitionTable), Member = "GetAfflictionDefinitionByName")]
	[Calls(Type = typeof(NPCAfflictions), Member = "AddAffliction")]
	[Calls(Type = typeof(NPCAfflictions), Member = "HealedAffliction")]
	[CallsUnknownMethods(Count = 2)]
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
	public void Deserialize(string serialized)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
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
	[CallsUnknownMethods(Count = 3)]
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
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	private Vector3 GetPosition()
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCVoice), Member = "Play")]
	[CallsUnknownMethods(Count = 1)]
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
