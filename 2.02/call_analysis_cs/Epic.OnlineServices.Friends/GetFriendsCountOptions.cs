using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Friends;

public class GetFriendsCountOptions
{
	private EpicAccountId _003CLocalUserId_003Ek__BackingField;

	public EpicAccountId LocalUserId
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 52)]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public GetFriendsCountOptions()
	{
	}
}
