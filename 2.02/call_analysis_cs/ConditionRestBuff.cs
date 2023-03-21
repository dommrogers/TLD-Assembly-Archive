using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ConditionRestBuff : MonoBehaviour
{
	public float m_ConditionRestBonus;

	public float m_NumHoursRestAffected;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	private void Start()
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "ApplyBuffs")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_buffs_add_all")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowBuffNotification")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Utils), Member = "SendGameplayAnalyticsEvent")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 13)]
	public void Apply(float normalizedValue)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public ConditionRestBuff()
	{
	}
}
