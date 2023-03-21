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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnDamageEvent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void Execute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected virtual bool CanExecute()
	{
		return false;
	}

	public abstract void OnExecute();

	public abstract bool IsLocationAvailable();

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public int GetMaxExecutions()
	{
		return 0;
	}

	[CalledBy(Type = typeof(DamageEventTable), Member = "GetWeightedRandomAttack")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
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
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiDifficultySetting), Member = "GetStrugglePlayerDamageReceivedScale")]
	[Calls(Type = typeof(Condition), Member = "MaybeShowPainEffect")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 2)]
	protected void ApplyDamage(float damage)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected StruggleDamageEvent()
	{
	}
}
