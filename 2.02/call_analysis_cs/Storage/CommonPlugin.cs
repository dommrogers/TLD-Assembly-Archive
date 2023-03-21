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
	[CalledBy(Type = typeof(StorageManager), Member = "AmFullyInitialized")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(TitleStorage), Member = "Create")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static extern bool AmFullyInitialized();

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern int GetPluginFrameworkVersion();

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern int GetPluginVersion();

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public CommonPlugin()
	{
	}
}
