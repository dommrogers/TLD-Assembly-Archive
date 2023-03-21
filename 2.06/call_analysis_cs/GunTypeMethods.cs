using Cpp2ILInjected.CallAnalysis;

internal static class GunTypeMethods
{
	[CallerCount(Count = 0)]
	public static BodyDamage.Weapon ToBodyDamageWeapon(this GunType gt)
	{
		return default(BodyDamage.Weapon);
	}
}
