using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Storage;

public class CommonPlugin
{
	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern int InitializePlugin(uint creationFlags);

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(TitleStorage), Member = "Create")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(StorageManager), Member = "AmFullyInitialized")]
	public static extern bool AmFullyInitialized();

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern int GetPluginFrameworkVersion();

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern int GetPluginVersion();

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public CommonPlugin()
	{
	}
}
