using System;
using Cpp2ILInjected.CallAnalysis;
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
		[CallerCount(Count = 2)]
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

	[Calls(Type = typeof(NPCCondition), Member = "IsAlive")]
	[Calls(Type = typeof(NPCVoice), Member = "Play")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCCondition), Member = "AddHealth")]
	[CalledBy(Type = typeof(NPC), Member = "DoConditionUpdate")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCCondition), Member = "IsAlive")]
	[Calls(Type = typeof(NPCCondition), Member = "ApplyDamage")]
	[Calls(Type = typeof(NPCCondition), Member = "ApplyDamage")]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetBloodLossCount")]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	[Calls(Type = typeof(NPCCondition), Member = "IsAlive")]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	[Calls(Type = typeof(NPCCondition), Member = "ApplyDamage")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public void DoUpdate(float deltaTODHours)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPCCondition), Member = "ApplyDamage")]
	public void UpdateHealthForFreezing(float dayFraction)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPCCondition), Member = "ApplyDamage")]
	public void UpdateHealthForDehydration(float dayFraction)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(NPCCondition), Member = "AddHealth")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void UpdateHealthForHealthy(float dayFraction)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetBloodLossCount")]
	[Calls(Type = typeof(NPCCondition), Member = "ApplyDamage")]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateHeathForBloodLoss(float dayFraction)
	{
	}

	[CalledBy(Type = typeof(NPCCondition), Member = "Deserialize")]
	[CalledBy(Type = typeof(NPCCondition), Member = "MaybePlayVoiceOver")]
	[CalledBy(Type = typeof(NPCCondition), Member = "MaybePlayVoiceOver")]
	[CalledBy(Type = typeof(NPCCondition), Member = "GetCurrentConditionLevel")]
	[CalledBy(Type = typeof(NPCCondition), Member = "ApplyDamage")]
	[CalledBy(Type = typeof(NPCCondition), Member = "DoUpdate")]
	[CalledBy(Type = typeof(NPCCondition), Member = "DoUpdate")]
	[CalledBy(Type = typeof(NPCCondition), Member = "Start")]
	[CalledBy(Type = typeof(NPC), Member = "Deserialize")]
	[CalledBy(Type = typeof(NPC), Member = "IsAlive")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 11)]
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

	[CalledBy(Type = typeof(NPCCondition), Member = "AddHealth")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(NPCStatusBar), Member = "GetReverseFillValueCondition")]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetTotalHitPointReduction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public float GetAdjustedMaxHP()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(NPCCondition), Member = "IsAlive")]
	public void Deserialize(string serialized)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(NPC), Member = "Serialize")]
	[CallsUnknownMethods(Count = 8)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(NPCCondition), Member = "DoUpdate")]
	[CalledBy(Type = typeof(NPCCondition), Member = "UpdateHealthForHealthy")]
	[Calls(Type = typeof(GameManager), Member = "HandlePlayerDeath")]
	[CalledBy(Type = typeof(NPCCondition), Member = "ApplyDamage")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(NPCCondition), Member = "GetAdjustedMaxHP")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	public void AddHealth(float amount)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(NPCThirst), Member = "ApplyTODHours")]
	[CalledBy(Type = typeof(NPCFreezing), Member = "ApplyTODHours")]
	[CalledBy(Type = typeof(NPCCondition), Member = "UpdateHeathForBloodLoss")]
	[CalledBy(Type = typeof(NPCCondition), Member = "UpdateHealthForDehydration")]
	[CalledBy(Type = typeof(NPCCondition), Member = "UpdateHealthForFreezing")]
	[CalledBy(Type = typeof(NPCCondition), Member = "DoUpdate")]
	[CalledBy(Type = typeof(NPCCondition), Member = "DoUpdate")]
	[CalledBy(Type = typeof(NPCCondition), Member = "DoUpdate")]
	[Calls(Type = typeof(NPCVoice), Member = "Play")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCCondition), Member = "IsAlive")]
	[Calls(Type = typeof(NPCCondition), Member = "AddHealth")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(AiTarget), Member = "ApplyDamage")]
	public void ApplyDamage(DamageSource source, float damage)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPCCondition), Member = "IsAlive")]
	private Level GetCurrentConditionLevel()
	{
		return default(Level);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "HandlePlayerDeath")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	private void HandleDeath()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NPCCondition), Member = "IsAlive")]
	[Calls(Type = typeof(NPCCondition), Member = "IsAlive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCVoice), Member = "Play")]
	[CallsUnknownMethods(Count = 3)]
	private void MaybePlayVoiceOver()
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void EndBloodLoss()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public NPCCondition()
	{
	}
}
