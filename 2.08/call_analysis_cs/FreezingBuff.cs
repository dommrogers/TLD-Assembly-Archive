using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
using UnityEngine;

public class FreezingBuff : MonoBehaviour
{
	public float m_InitialPercentDecrease;

	public float m_RateOfIncreaseScale;

	public float m_DurationHours;

	private PanelReference<Panel_HUD> m_HUD;

	[CalledBy(Type = typeof(GearItem), Member = "ApplyBuffs")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SendGameplayAnalyticsEvent")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_buffs_add_all")]
	[Calls(Type = typeof(Freezing), Member = "AddFreezing")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowBuffNotification")]
	[CallerCount(Count = 2)]
	public void Apply(float normalizedValue)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public FreezingBuff()
	{
	}
}
