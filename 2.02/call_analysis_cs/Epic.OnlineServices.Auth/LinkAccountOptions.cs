using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Auth;

public class LinkAccountOptions
{
	private LinkAccountFlags _003CLinkAccountFlags_003Ek__BackingField;

	private ContinuanceToken _003CContinuanceToken_003Ek__BackingField;

	private EpicAccountId _003CLocalUserId_003Ek__BackingField;

	public LinkAccountFlags LinkAccountFlags
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 52)]
		get
		{
			return default(LinkAccountFlags);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public ContinuanceToken ContinuanceToken
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

	public EpicAccountId LocalUserId
	{
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 41)]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public LinkAccountOptions()
	{
	}
}
