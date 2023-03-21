using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
using UnityEngine;

public class FreezingBuff : MonoBehaviour
{
	public float m_InitialPercentDecrease;

	public float m_RateOfIncreaseScale;

	public float m_DurationHours;

	private PanelReference<Panel_HUD> m_HUD;

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_buffs_add_all")]
	[CalledBy(Type = typeof(GearItem), Member = "ApplyBuffs")]
	[Calls(Type = typeof(Utils), Member = "SendGameplayAnalyticsEvent")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Freezing), Member = "AddFreezing")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowBuffNotification")]
	public void Apply(float normalizedValue)
	{
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public FreezingBuff()
	{
	}
}
