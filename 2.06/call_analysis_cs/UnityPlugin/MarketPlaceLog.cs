using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace UnityPlugin;

internal class MarketPlaceLog
{
	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern void LogCallbackException(string message);

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public MarketPlaceLog()
	{
	}
}
