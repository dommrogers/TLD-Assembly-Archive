using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
using UnityEngine;

public class ConditionRestBuff : MonoBehaviour
{
	public float m_ConditionRestBonus;

	public float m_NumHoursRestAffected;

	private PanelReference<Panel_HUD> m_HUD;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	private void Start()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowBuffNotification")]
	[Calls(Type = typeof(Utils), Member = "SendGameplayAnalyticsEvent")]
	[CalledBy(Type = typeof(GearItem), Member = "ApplyBuffs")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_buffs_add_all")]
	[CallsUnknownMethods(Count = 1)]
	public void Apply(float normalizedValue)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public ConditionRestBuff()
	{
	}
}
