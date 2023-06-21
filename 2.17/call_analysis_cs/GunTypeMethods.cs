using Cpp2ILInjected.CallAnalysis;

internal static class GunTypeMethods
{
	[CallerCount(Count = 0)]
	public static WeaponSource ToWeaponSource(this GunType gt)
	{
		return default(WeaponSource);
	}
}
