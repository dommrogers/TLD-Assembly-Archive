using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class FuelSourceItem : MonoBehaviour
{
	public float m_FireStartSkillModifier;

	public float m_FireStartDurationModifier;

	public float m_BurnDurationHours;

	public float m_HeatIncrease;

	public float m_HeatInnerRadius;

	public float m_HeatOuterRadius;

	public float m_FireAgeMinutesBeforeAdding;

	public bool m_IsTinder;

	public bool m_IsWet;

	public bool m_IsBurntInFireTracked;

	public bool m_CanInitiateFire;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void Start()
	{
	}

	[CalledBy(Type = typeof(Fire), Member = "AddFuel")]
	[CalledBy(Type = typeof(Fire), Member = "TurnOn")]
	[CalledBy(Type = typeof(Container), Member = "GetHoursFuel")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnFeedFire")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "RefreshEstimatedDurationLabel")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(GameManager), Member = "GetSkillFireStarting")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public float GetModifiedBurnDurationHours(float normalizedCondition)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public FuelSourceItem()
	{
	}
}
