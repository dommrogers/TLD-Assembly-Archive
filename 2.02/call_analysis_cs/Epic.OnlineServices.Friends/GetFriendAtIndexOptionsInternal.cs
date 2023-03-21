using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Friends;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct GetFriendAtIndexOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private int m_Index;

	public EpicAccountId LocalUserId
	{
		[CalledBy(Type = typeof(GetFriendAtIndexOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(GetFriendAtIndexOptionsInternal), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
		set
		{
		}
	}

	public int Index
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetFriendAtIndexOptionsInternal), Member = "set_LocalUserId")]
	public void Set(GetFriendAtIndexOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GetFriendAtIndexOptionsInternal), Member = "set_LocalUserId")]
	[CalledBy(Type = typeof(FriendsInterface), Member = "GetFriendAtIndex")]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Dispose()
	{
	}
}
