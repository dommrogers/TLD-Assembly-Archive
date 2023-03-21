using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
using UnityEngine;

public class ConditionOverTimeBuff : MonoBehaviour
{
	public float m_ConditionIncreasePerHour;

	public float m_NumHours;

	private PanelReference<Panel_HUD> m_HUD;

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(GearItem), Member = "ApplyBuffs")]
	[Calls(Type = typeof(Utils), Member = "SendGameplayAnalyticsEvent")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_buffs_add_all")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowBuffNotification")]
	public void Apply(float normalizedValue)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public ConditionOverTimeBuff()
	{
	}
}
