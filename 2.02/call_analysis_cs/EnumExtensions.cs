using System;

public static class EnumExtensions
{
	public static bool HasFlag<T>(this T var, T flags) where T : struct, IConvertible
	{
		return false;
	}

	public static bool HasAnyFlag<T>(this T var, T flags) where T : struct, IConvertible
	{
		return false;
	}
}
