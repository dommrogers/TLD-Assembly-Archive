using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Presence;

public class GetJoinInfoOptions
{
	private EpicAccountId _003CLocalUserId_003Ek__BackingField;

	private EpicAccountId _003CTargetUserId_003Ek__BackingField;

	public EpicAccountId LocalUserId
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 59)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 103)]
		set
		{
		}
	}

	public EpicAccountId TargetUserId
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 35)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 77)]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public GetJoinInfoOptions()
	{
	}
}
