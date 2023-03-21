using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using UnityEngine;

public class NPCCondition : MonoBehaviour
{
	private enum Level
	{
		Dead,
		Critical,
		Alive
	}

	private class SaveData
	{
		public float m_CurrentHP;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public SaveData()
		{
		}
	}

	public float m_CurrentHP;

	public float m_MaxHP;

	public float m_CriticalHP;

	public float m_HPIncreasePerDayWhileHealthy;

	public float m_HPDecreasePerDayFromFreezing;

	public float m_HPDecreasePerDayFromDehydration;

	public float m_HPDecreasePerDayFromBloodLoss;

	public string m_NearDeathVoiceOver;

	public string m_WolfAttackVoiceOver;

	[NonSerialized]
	public NPC m_NPC;

	[NonSerialized]
	public DamageSource m_LastDamageSource;

	private Level m_LastVOLevel;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPCCondition), Member = "IsAlive")]
	private void Start()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCCondition), Member = "AddHealth")]
	[Calls(Type = typeof(NPCCondition), Member = "IsAlive")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(NPCVoice), Member = "Play")]
	[CalledBy(Type = typeof(NPC), Member = "DoConditionUpdate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCCondition), Member = "IsAlive")]
	[Calls(Type = typeof(NPCCondition), Member = "IsAlive")]
	[Calls(Type = typeof(NPCCondition), Member = "IsAlive")]
	[Calls(Type = typeof(NPCCondition), Member = "AddHealth")]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetBloodLossCount")]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	[Calls(Type = typeof(NPCCondition), Member = "UpdateHealthForDehydration")]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	[Calls(Type = typeof(NPCCondition), Member = "UpdateHealthForFreezing")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void DoUpdate(float deltaTODHours)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(NPCFreezing), Member = "ApplyTODHours")]
	[CalledBy(Type = typeof(NPCCondition), Member = "DoUpdate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCCondition), Member = "AddHealth")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NPCCondition), Member = "IsAlive")]
	public void UpdateHealthForFreezing(float dayFraction)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NPCCondition), Member = "AddHealth")]
	[Calls(Type = typeof(NPCCondition), Member = "IsAlive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(NPCCondition), Member = "DoUpdate")]
	[CalledBy(Type = typeof(NPCThirst), Member = "ApplyTODHours")]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateHealthForDehydration(float dayFraction)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCCondition), Member = "AddHealth")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void UpdateHealthForHealthy(float dayFraction)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetBloodLossCount")]
	[Calls(Type = typeof(NPCCondition), Member = "AddHealth")]
	[Calls(Type = typeof(NPCCondition), Member = "IsAlive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateHeathForBloodLoss(float dayFraction)
	{
	}

	[CalledBy(Type = typeof(NPCCondition), Member = "MaybePlayVoiceOver")]
	[CalledBy(Type = typeof(NPCCondition), Member = "MaybePlayVoiceOver")]
	[CalledBy(Type = typeof(NPCCondition), Member = "GetCurrentConditionLevel")]
	[CalledBy(Type = typeof(NPCCondition), Member = "Deserialize")]
	[CalledBy(Type = typeof(NPCCondition), Member = "UpdateHeathForBloodLoss")]
	[CalledBy(Type = typeof(NPCCondition), Member = "UpdateHealthForDehydration")]
	[CalledBy(Type = typeof(NPCCondition), Member = "UpdateHealthForFreezing")]
	[CalledBy(Type = typeof(NPCCondition), Member = "ApplyDamage")]
	[CalledBy(Type = typeof(NPCCondition), Member = "DoUpdate")]
	[CalledBy(Type = typeof(NPCCondition), Member = "DoUpdate")]
	[CalledBy(Type = typeof(NPCCondition), Member = "DoUpdate")]
	[CalledBy(Type = typeof(NPCCondition), Member = "Start")]
	[CalledBy(Type = typeof(NPC), Member = "Deserialize")]
	[CalledBy(Type = typeof(NPC), Member = "IsAlive")]
	[CallerCount(Count = 15)]
	[CalledBy(Type = typeof(NPCCondition), Member = "DoUpdate")]
	public bool IsAlive()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetNormalizedCondition()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(NPCCondition), Member = "AddHealth")]
	[CalledBy(Type = typeof(NPCStatusBar), Member = "GetReverseFillValueCondition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetTotalHitPointReduction")]
	public float GetAdjustedMaxHP()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NPCCondition), Member = "IsAlive")]
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

	[CalledBy(Type = typeof(NPCCondition), Member = "UpdateHealthForFreezing")]
	[CalledBy(Type = typeof(NPCCondition), Member = "UpdateHealthForHealthy")]
	[CalledBy(Type = typeof(NPCCondition), Member = "DoUpdate")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(NPCCondition), Member = "ApplyDamage")]
	[CalledBy(Type = typeof(NPCCondition), Member = "DoUpdate")]
	[CalledBy(Type = typeof(NPCCondition), Member = "UpdateHeathForBloodLoss")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(GameManager), Member = "HandlePlayerDeath")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(NPCCondition), Member = "GetAdjustedMaxHP")]
	[CalledBy(Type = typeof(NPCCondition), Member = "UpdateHealthForDehydration")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public void AddHealth(float amount)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NPCCondition), Member = "AddHealth")]
	[Calls(Type = typeof(NPCCondition), Member = "IsAlive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCVoice), Member = "Play")]
	[CalledBy(Type = typeof(AiTarget), Member = "ApplyDamage")]
	[CallsUnknownMethods(Count = 1)]
	public void ApplyDamage(DamageSource source, float damage)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPCCondition), Member = "IsAlive")]
	private Level GetCurrentConditionLevel()
	{
		return default(Level);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "HandlePlayerDeath")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void HandleDeath()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPCCondition), Member = "IsAlive")]
	[Calls(Type = typeof(NPCCondition), Member = "IsAlive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCVoice), Member = "Play")]
	[CallsUnknownMethods(Count = 1)]
	private void MaybePlayVoiceOver()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public void EndBloodLoss()
	{
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public NPCCondition()
	{
	}
}
