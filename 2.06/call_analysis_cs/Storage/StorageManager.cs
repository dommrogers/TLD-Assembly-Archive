using Cpp2ILInjected.CallAnalysis;

namespace Storage;

public class StorageManager
{
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static void Create()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommonPlugin), Member = "AmFullyInitialized")]
	public static bool AmFullyInitialized()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public StorageManager()
	{
	}
}
