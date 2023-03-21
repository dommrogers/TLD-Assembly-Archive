using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ConditionOverTimeBuff : MonoBehaviour
{
	public float m_ConditionIncreasePerHour;

	public float m_NumHours;

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowBuffNotification")]
	[Calls(Type = typeof(Utils), Member = "SendGameplayAnalyticsEvent")]
	[CalledBy(Type = typeof(GearItem), Member = "ApplyBuffs")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_buffs_add_all")]
	[CallsUnknownMethods(Count = 13)]
	public void Apply(float normalizedValue)
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ConditionOverTimeBuff()
	{
	}
}
