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

	[Calls(Type = typeof(NPCCondition), Member = "GetCurrentConditionLevel")]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(NPC), Member = "DoConditionUpdate")]
	[Calls(Type = typeof(NPCVoice), Member = "Play")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCCondition), Member = "GetCurrentConditionLevel")]
	[Calls(Type = typeof(NPCCondition), Member = "AddHealth")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCCondition), Member = "IsAlive")]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetBloodLossCount")]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	[Calls(Type = typeof(NPCCondition), Member = "ApplyDamage")]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	[Calls(Type = typeof(NPCCondition), Member = "ApplyDamage")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NPCCondition), Member = "ApplyDamage")]
	public void DoUpdate(float deltaTODHours)
	{
	}

	[Calls(Type = typeof(NPCCondition), Member = "ApplyDamage")]
	[CallerCount(Count = 0)]
	public void UpdateHealthForFreezing(float dayFraction)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPCCondition), Member = "ApplyDamage")]
	public void UpdateHealthForDehydration(float dayFraction)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCCondition), Member = "AddHealth")]
	public void UpdateHealthForHealthy(float dayFraction)
	{
	}

	[Calls(Type = typeof(NPCCondition), Member = "ApplyDamage")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetBloodLossCount")]
	public void UpdateHeathForBloodLoss(float dayFraction)
	{
	}

	[CalledBy(Type = typeof(NPCCondition), Member = "DoUpdate")]
	[CalledBy(Type = typeof(NPC), Member = "IsAlive")]
	[CallerCount(Count = 2)]
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

	[CalledBy(Type = typeof(NPCCondition), Member = "AddHealth")]
	[CalledBy(Type = typeof(NPCStatusBar), Member = "GetReverseFillValueCondition")]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetTotalHitPointReduction")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public float GetAdjustedMaxHP()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NPCCondition), Member = "GetCurrentConditionLevel")]
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

	[CalledBy(Type = typeof(NPCCondition), Member = "UpdateHealthForHealthy")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(NPCCondition), Member = "ApplyDamage")]
	[CalledBy(Type = typeof(NPCCondition), Member = "DoUpdate")]
	[Calls(Type = typeof(GameManager), Member = "HandlePlayerDeath")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(NPCCondition), Member = "GetAdjustedMaxHP")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Replace")]
	public void AddHealth(float amount)
	{
	}

	[CalledBy(Type = typeof(NPCCondition), Member = "DoUpdate")]
	[CalledBy(Type = typeof(NPCFreezing), Member = "ApplyTODHours")]
	[CalledBy(Type = typeof(NPCCondition), Member = "UpdateHeathForBloodLoss")]
	[CalledBy(Type = typeof(NPCCondition), Member = "UpdateHealthForDehydration")]
	[CalledBy(Type = typeof(NPCCondition), Member = "UpdateHealthForFreezing")]
	[CalledBy(Type = typeof(NPCCondition), Member = "DoUpdate")]
	[CalledBy(Type = typeof(AiTarget), Member = "ApplyDamage")]
	[CalledBy(Type = typeof(NPCThirst), Member = "ApplyTODHours")]
	[Calls(Type = typeof(NPCVoice), Member = "Play")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCCondition), Member = "AddHealth")]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(NPCCondition), Member = "DoUpdate")]
	[CallsUnknownMethods(Count = 1)]
	public void ApplyDamage(DamageSource source, float damage)
	{
	}

	[CalledBy(Type = typeof(NPCCondition), Member = "Deserialize")]
	[CalledBy(Type = typeof(NPCCondition), Member = "MaybePlayVoiceOver")]
	[CalledBy(Type = typeof(NPCCondition), Member = "DoUpdate")]
	[CalledBy(Type = typeof(NPC), Member = "Deserialize")]
	[CalledBy(Type = typeof(NPCCondition), Member = "Start")]
	[CallerCount(Count = 5)]
	private Level GetCurrentConditionLevel()
	{
		return default(Level);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(GameManager), Member = "HandlePlayerDeath")]
	[CallsUnknownMethods(Count = 1)]
	private void HandleDeath()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(NPCVoice), Member = "Play")]
	[Calls(Type = typeof(NPCCondition), Member = "GetCurrentConditionLevel")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void MaybePlayVoiceOver()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void EndBloodLoss()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public NPCCondition()
	{
	}
}
