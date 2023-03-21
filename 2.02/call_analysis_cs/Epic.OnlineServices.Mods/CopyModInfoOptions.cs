using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Mods;

public class CopyModInfoOptions
{
	private EpicAccountId _003CLocalUserId_003Ek__BackingField;

	private ModEnumerationType _003CType_003Ek__BackingField;

	public EpicAccountId LocalUserId
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 52)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 101)]
		set
		{
		}
	}

	public ModEnumerationType Type
	{
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		get
		{
			return default(ModEnumerationType);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public CopyModInfoOptions()
	{
	}
}
