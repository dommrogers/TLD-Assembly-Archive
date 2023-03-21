using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityPlugin;

public struct FILETIME
{
	public uint DateTimeLow;

	public uint DateTimeHigh;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTime), Member = "ToFileTimeUtc")]
	public FILETIME(DateTime dt)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTime), Member = "FromFileTimeUtc")]
	[CallsDeduplicatedMethods(Count = 1)]
	public DateTime ToDateTime()
	{
		return default(DateTime);
	}
}
