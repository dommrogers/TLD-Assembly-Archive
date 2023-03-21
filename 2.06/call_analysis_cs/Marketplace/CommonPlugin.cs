using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Marketplace;

public class CommonPlugin
{
	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern int InitializePlugin(uint creationFlags);

	[PreserveSig]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static extern bool AmFullyInitialized();

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static extern int GetPluginVersion();

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern int GetPluginFrameworkVersion();

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public CommonPlugin()
	{
	}
}
