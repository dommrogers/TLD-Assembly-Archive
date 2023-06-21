using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Gear;

public class FoodStatEffect : MonoBehaviour, IFoodItemBuff, IFoodEffect
{
	public enum StatType
	{
		Condition,
		Stamina,
		Fatigue,
		Freezing,
		Thirst,
		Hunger
	}

	private StatType m_Stat;

	private float m_Effect;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hunger), Member = "AddReserveCalories")]
	[Calls(Type = typeof(Thirst), Member = "AddThirst")]
	[Calls(Type = typeof(Freezing), Member = "AddFreezing")]
	[Calls(Type = typeof(Fatigue), Member = "AddFatigue")]
	[Calls(Type = typeof(PlayerMovement), Member = "AddSprintStamina")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[CallsUnknownMethods(Count = 7)]
	public void Apply(float fractionConsumed)
	{
	}

	[CallerCount(Count = 0)]
	public float GetStatEffect(StatType stat)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FoodEffectUtils), Member = "GetEffectFromBuff")]
	public IFoodEffect.Effect GetEffect(IFoodEffect.EffectType effectType)
	{
		return default(IFoodEffect.Effect);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public FoodStatEffect()
	{
	}
}
