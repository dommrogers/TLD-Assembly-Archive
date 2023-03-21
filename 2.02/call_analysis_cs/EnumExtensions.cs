using System;
using Cpp2ILInjected.CallAnalysis;

public static class EnumExtensions
{
	[DeduplicatedMethod]
	[CallAnalysisNotSupported]
	[CallerCount(Count = 121780)]
	public static bool HasFlag<T>(this T var, T flags) where T : struct, IConvertible
	{
		return default(bool);
	}

	[CallerCount(Count = 121780)]
	[DeduplicatedMethod]
	[CallAnalysisNotSupported]
	public static bool HasAnyFlag<T>(this T var, T flags) where T : struct, IConvertible
	{
		return default(bool);
	}
}
