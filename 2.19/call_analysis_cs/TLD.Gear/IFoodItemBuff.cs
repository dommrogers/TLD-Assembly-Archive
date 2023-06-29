namespace TLD.Gear;

public interface IFoodItemBuff : IFoodEffect
{
	void Apply(float fractionConsumed);
}
