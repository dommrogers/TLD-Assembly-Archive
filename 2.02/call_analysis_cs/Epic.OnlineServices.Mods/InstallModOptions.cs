using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Mods;

public class InstallModOptions
{
	private EpicAccountId _003CLocalUserId_003Ek__BackingField;

	private ModIdentifier _003CMod_003Ek__BackingField;

	private bool _003CRemoveAfterExit_003Ek__BackingField;

	public EpicAccountId LocalUserId
	{
		[CallerCount(Count = 52)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 101)]
		[CompilerGenerated]
		set
		{
		}
	}

	public ModIdentifier Mod
	{
		[CallerCount(Count = 29)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 71)]
		set
		{
		}
	}

	public bool RemoveAfterExit
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		get
		{
			return default(bool);
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
	public InstallModOptions()
	{
	}
}
