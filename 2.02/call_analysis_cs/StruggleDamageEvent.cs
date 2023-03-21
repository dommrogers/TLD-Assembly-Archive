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
		[CallerCount(Count = 7)]
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
		[CallerCount(Count = 7)]
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

	[CalledBy(Type = typeof(DamageEventTable), Member = "MaybeApplyAttack")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnDamageEvent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void Execute()
	{
	}

	public abstract void OnExecute();

	public abstract bool IsLocationAvailable();

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(StruggleDamageEvent), Member = "GetChance")]
	[CallerCount(Count = 1)]
	public int GetMaxExecutions()
	{
		return 0;
	}

	[CalledBy(Type = typeof(DamageEventTable), Member = "GetWeightedRandomAttack")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StruggleDamageEvent), Member = "GetMaxExecutions")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(SpecialEvent), Member = "MatchesExperienceMode")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 25)]
	public int GetChance()
	{
		return 0;
	}

	[CalledBy(Type = typeof(MinorBruisingEvent), Member = "OnExecute")]
	[CalledBy(Type = typeof(BloodLossEvent), Member = "OnExecute")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetStrugglePlayerDamageReceivedScale")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiDifficultySetting), Member = "GetStrugglePlayerDamageReceivedScale")]
	[Calls(Type = typeof(Condition), Member = "MaybeShowPainEffect")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	protected void ApplyDamage(float damage)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	protected StruggleDamageEvent()
	{
	}
}
