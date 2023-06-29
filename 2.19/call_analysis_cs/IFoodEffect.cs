public interface IFoodEffect
{
	public enum EffectType
	{
		MaxCondition,
		MaxStamina,
		MaxCarryWeight,
		Rest,
		Fatigue,
		Condition,
		Stamina,
		CabinFever,
		Headache
	}

	public enum Effect
	{
		Detriment = -1,
		Neutral,
		Benefit
	}

	Effect GetEffect(EffectType effectType);
}
