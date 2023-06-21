using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Gear;

public class FoodMaxStatBuff : MonoBehaviour, IFoodItemBuff, IFoodEffect
{
	public enum StatType
	{
		Condition,
		Stamina
	}

	private StatType m_Stat;

	private float m_Buff;

	private float m_TimeActiveHours;

	private bool m_CanStack;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FoodMaxStatBuffManager), Member = "AddStatBuff")]
	[CallsUnknownMethods(Count = 1)]
	public void Apply(float fractionConsumed)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FoodEffectUtils), Member = "GetEffectFromBuff")]
	public IFoodEffect.Effect GetEffect(IFoodEffect.EffectType effectType)
	{
		return default(IFoodEffect.Effect);
	}

	[CallerCount(Count = 0)]
	public FoodMaxStatBuff()
	{
	}
}
