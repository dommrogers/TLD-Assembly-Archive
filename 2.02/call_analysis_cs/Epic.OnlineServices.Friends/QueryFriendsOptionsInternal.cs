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
		[CalledBy(Type = typeof(QueryFriendsOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(QueryFriendsOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QueryFriendsOptionsInternal), Member = "set_LocalUserId")]
	public void Set(QueryFriendsOptions other)
	{
	}

	[CalledBy(Type = typeof(FriendsInterface), Member = "QueryFriends")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(QueryFriendsOptionsInternal), Member = "set_LocalUserId")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void Dispose()
	{
	}
}
