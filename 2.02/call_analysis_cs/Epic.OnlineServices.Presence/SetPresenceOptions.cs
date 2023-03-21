using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Presence;

public class SetPresenceOptions
{
	private EpicAccountId _003CLocalUserId_003Ek__BackingField;

	private PresenceModification _003CPresenceModificationHandle_003Ek__BackingField;

	public EpicAccountId LocalUserId
	{
		[CallerCount(Count = 52)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CallerCount(Count = 101)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public PresenceModification PresenceModificationHandle
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 29)]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public SetPresenceOptions()
	{
	}
}
