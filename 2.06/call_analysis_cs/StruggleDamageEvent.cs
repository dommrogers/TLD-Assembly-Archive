using System;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public abstract class StruggleDamageEvent
{
	public int m_PercentChance;

	public int m_MaxExecutionCount;

	public int m_MaxShowing;

	public StruggleDamageEventUISettings m_UISettings;

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

	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnDamageEvent")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void Execute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected virtual bool CanExecute()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	public abstract void OnExecute();

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	public abstract bool IsLocationAvailable();

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public int GetMaxExecutions()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(DamageEventTable), Member = "GetWeightedRandomAttack")]
	[CalledBy(Type = typeof(DamageEventTable), Member = "GetWeightedRandomAttack")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	public int GetChance()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BloodLossEvent), Member = "OnExecute")]
	[CalledBy(Type = typeof(MinorBruisingEvent), Member = "OnExecute")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[Calls(Type = typeof(Condition), Member = "MaybeShowPainEffect")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetStrugglePlayerDamageReceivedScale")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AiDifficultySetting), Member = "GetStrugglePlayerDamageReceivedScale")]
	protected void ApplyDamage(float damage)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected StruggleDamageEvent()
	{
	}
}
