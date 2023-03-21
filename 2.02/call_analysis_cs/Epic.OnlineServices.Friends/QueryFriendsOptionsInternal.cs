using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Friends;

[StructLayout(0, Pack = 8, Size = 16)]
internal struct QueryFriendsOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	public EpicAccountId LocalUserId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(QueryFriendsOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(QueryFriendsOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QueryFriendsOptionsInternal), Member = "set_LocalUserId")]
	public void Set(QueryFriendsOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(QueryFriendsOptionsInternal), Member = "set_LocalUserId")]
	[CalledBy(Type = typeof(FriendsInterface), Member = "QueryFriends")]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void Dispose()
	{
	}
}
