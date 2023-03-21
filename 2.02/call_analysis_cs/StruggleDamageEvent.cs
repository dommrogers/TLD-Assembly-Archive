using System;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public abstract class StruggleDamageEvent
{
	[Serializable]
	public class XPModeChance
	{
		public int m_Pilgrim;

		public int m_Voyageur;

		public int m_Stalker;

		public int m_Story;

		public int m_Interloper;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public XPModeChance()
		{
		}
	}

	[Serializable]
	public class XPModeMaxExecution
	{
		public int m_Pilgrim;

		public int m_Voyageur;

		public int m_Stalker;

		public int m_Story;

		public int m_Interloper;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public XPModeMaxExecution()
		{
		}
	}

	public XPModeChance m_Chance;

	public XPModeMaxExecution m_MaxExecution;

	public int m_MaxShowing;

	public string m_IconName;

	public string m_DamageEventName;

	public string m_DamageEventType;

	public Color m_TintColor;

	private int m_ExecutionCount;

	private int m_ShowingCount;

	[CallerCount(Count = 0)]
	public void Reset()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnDamageEvent")]
	[CalledBy(Type = typeof(DamageEventTable), Member = "MaybeApplyAttack")]
	[CallsUnknownMethods(Count = 3)]
	public void Execute()
	{
	}

	[CallerCount(Count = 121780)]
	[DeduplicatedMethod]
	public abstract void OnExecute();

	[CallerCount(Count = 121780)]
	[DeduplicatedMethod]
	public abstract bool IsLocationAvailable();

	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(StruggleDamageEvent), Member = "GetChance")]
	public int GetMaxExecutions()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 25)]
	[CalledBy(Type = typeof(DamageEventTable), Member = "GetWeightedRandomAttack")]
	[CalledBy(Type = typeof(DamageEventTable), Member = "GetWeightedRandomAttack")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(SpecialEvent), Member = "MatchesExperienceMode")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(StruggleDamageEvent), Member = "GetMaxExecutions")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	public int GetChance()
	{
		return default(int);
	}

	[Calls(Type = typeof(Condition), Member = "MaybeShowPainEffect")]
	[CalledBy(Type = typeof(BloodLossEvent), Member = "OnExecute")]
	[CalledBy(Type = typeof(MinorBruisingEvent), Member = "OnExecute")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(AiDifficultySetting), Member = "GetStrugglePlayerDamageReceivedScale")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetStrugglePlayerDamageReceivedScale")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	protected void ApplyDamage(float damage)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	protected StruggleDamageEvent()
	{
	}
}
