using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Connect;

public class LinkAccountOptions
{
	private ProductUserId _003CLocalUserId_003Ek__BackingField;

	private ContinuanceToken _003CContinuanceToken_003Ek__BackingField;

	public ProductUserId LocalUserId
	{
		[CallerCount(Count = 52)]
		[DeduplicatedMethod]
		[CompilerGenerated]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public LinkAccountOptions()
	{
	}
}
