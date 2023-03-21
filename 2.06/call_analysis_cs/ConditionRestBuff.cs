using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
using UnityEngine;

public class ConditionRestBuff : MonoBehaviour
{
	public float m_ConditionRestBonus;

	public float m_NumHoursRestAffected;

	private PanelReference<Panel_HUD> m_HUD;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void Start()
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_buffs_add_all")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowBuffNotification")]
	[Calls(Type = typeof(Utils), Member = "SendGameplayAnalyticsEvent")]
	[CalledBy(Type = typeof(GearItem), Member = "ApplyBuffs")]
	[CallsUnknownMethods(Count = 6)]
	public void Apply(float normalizedValue)
	{
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public ConditionRestBuff()
	{
	}
}
