using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class FatigueBuff : MonoBehaviour
{
	public float m_InitialPercentDecrease;

	public float m_RateOfIncreaseScale;

	public float m_DurationHours;

	private GearItem m_GearItem;

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void Start()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Feat), Member = "IsUnlockedAndEnabled")]
	[Calls(Type = typeof(Feat_StraightToHeart), Member = "IsHeartItem")]
	[Calls(Type = typeof(Fatigue), Member = "AddFatigue")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowBuffNotification")]
	[Calls(Type = typeof(Utils), Member = "SendGameplayAnalyticsEvent")]
	[CalledBy(Type = typeof(GearItem), Member = "ApplyBuffs")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_buffs_add_all")]
	[CallsUnknownMethods(Count = 18)]
	public void Apply(float normalizedValue)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	public FatigueBuff()
	{
	}
}
