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
		[CallerCount(Count = 7)]
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

	[CalledBy(Type = typeof(NPC), Member = "DoConditionUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NPCCondition), Member = "ApplyDamage")]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetBloodLossCount")]
	[Calls(Type = typeof(NPCCondition), Member = "IsAlive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCVoice), Member = "Play")]
	[Calls(Type = typeof(NPCCondition), Member = "AddHealth")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 17)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCCondition), Member = "AddHealth")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
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

	[CalledBy(Type = typeof(NPC), Member = "IsAlive")]
	[CalledBy(Type = typeof(NPC), Member = "Deserialize")]
	[CalledBy(Type = typeof(NPCCondition), Member = "Start")]
	[CalledBy(Type = typeof(NPCCondition), Member = "DoUpdate")]
	[CalledBy(Type = typeof(NPCCondition), Member = "Deserialize")]
	[CalledBy(Type = typeof(NPCCondition), Member = "ApplyDamage")]
	[CalledBy(Type = typeof(NPCCondition), Member = "GetCurrentConditionLevel")]
	[CalledBy(Type = typeof(NPCCondition), Member = "MaybePlayVoiceOver")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool IsAlive()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetNormalizedCondition()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(NPCStatusBar), Member = "GetReverseFillValueCondition")]
	[CalledBy(Type = typeof(NPCCondition), Member = "AddHealth")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetTotalHitPointReduction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public float GetAdjustedMaxHP()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPCCondition), Member = "IsAlive")]
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

	[CalledBy(Type = typeof(NPCCondition), Member = "DoUpdate")]
	[CalledBy(Type = typeof(NPCCondition), Member = "UpdateHealthForHealthy")]
	[CalledBy(Type = typeof(NPCCondition), Member = "ApplyDamage")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NPCCondition), Member = "GetAdjustedMaxHP")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(GameManager), Member = "HandlePlayerDeath")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void AddHealth(float amount)
	{
	}

	[CalledBy(Type = typeof(AiTarget), Member = "ApplyDamage")]
	[CalledBy(Type = typeof(NPCCondition), Member = "DoUpdate")]
	[CalledBy(Type = typeof(NPCCondition), Member = "UpdateHealthForFreezing")]
	[CalledBy(Type = typeof(NPCCondition), Member = "UpdateHealthForDehydration")]
	[CalledBy(Type = typeof(NPCCondition), Member = "UpdateHeathForBloodLoss")]
	[CalledBy(Type = typeof(NPCFreezing), Member = "ApplyTODHours")]
	[CalledBy(Type = typeof(NPCThirst), Member = "ApplyTODHours")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(NPCCondition), Member = "AddHealth")]
	[Calls(Type = typeof(NPCCondition), Member = "IsAlive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCVoice), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void ApplyDamage(DamageSource source, float damage)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPCCondition), Member = "IsAlive")]
	private Level GetCurrentConditionLevel()
	{
		return default(Level);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(GameManager), Member = "HandlePlayerDeath")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void HandleDeath()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPCCondition), Member = "IsAlive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCVoice), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void MaybePlayVoiceOver()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
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
