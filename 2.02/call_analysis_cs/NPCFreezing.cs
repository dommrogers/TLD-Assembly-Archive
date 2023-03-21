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
		[CallerCount(Count = 2)]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	public float GetHealthyDelta(float delta)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(NPCCondition), Member = "ApplyDamage")]
	[CallsUnknownMethods(Count = 2)]
	public void ApplyTODHours(float delta)
	{
	}

	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	[Calls(Type = typeof(NPCAfflictions), Member = "HealedAffliction")]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	[CallsUnknownMethods(Count = 24)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCVoice), Member = "Play")]
	[CalledBy(Type = typeof(NPC), Member = "DoConditionUpdate")]
	[Calls(Type = typeof(NPCAfflictions), Member = "AddAffliction")]
	[Calls(Type = typeof(NPCAfflictions), Member = "HealedAffliction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(NPCFreezing), Member = "GetPosition")]
	[Calls(Type = typeof(NPCFreezing), Member = "CalculateCurrentTemperature")]
	[Calls(Type = typeof(FireManager), Member = "PointInRadiusOfBurningFire")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(NPCVoice), Member = "Play")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
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
	[CallsDeduplicatedMethods(Count = 2)]
	public void Deserialize(string serialized)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(NPC), Member = "Serialize")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(NPCFreezing), Member = "DoUpdate")]
	[Calls(Type = typeof(Bed), Member = "GetWarmthBonusCelsius")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCFreezing), Member = "GetPosition")]
	[Calls(Type = typeof(NPC), Member = "IsIndoors")]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[CalledBy(Type = typeof(NPCFreezing), Member = "DoUpdate")]
	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(NPCFreezing), Member = "CalculateCurrentTemperature")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BodyCarry), Member = "IsCarryingBody")]
	private Vector3 GetPosition()
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCVoice), Member = "Play")]
	[CallsUnknownMethods(Count = 3)]
	private void MaybePlayVoiceOver()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void EndHypothermia()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public NPCFreezing()
	{
	}
}
