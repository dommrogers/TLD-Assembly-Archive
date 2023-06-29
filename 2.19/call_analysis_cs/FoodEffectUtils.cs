using Cpp2ILInjected.CallAnalysis;
using TLD.Gear;

public static class FoodEffectUtils
{
	[CalledBy(Type = typeof(FoodMaxStatBuff), Member = "GetEffect")]
	[CalledBy(Type = typeof(FoodStatEffect), Member = "GetEffect")]
	[CalledBy(Type = typeof(IngestedCarryCapacityBuff), Member = "GetEffect")]
	[CallerCount(Count = 4)]
	public static IFoodEffect.Effect GetEffectFromBuff(float buff)
	{
		return default(IFoodEffect.Effect);
	}
}
