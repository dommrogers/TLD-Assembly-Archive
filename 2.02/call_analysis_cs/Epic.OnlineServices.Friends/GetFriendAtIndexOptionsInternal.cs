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
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
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

	[CalledBy(Type = typeof(FriendsInterface), Member = "GetFriendAtIndex")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GetFriendAtIndexOptionsInternal), Member = "set_LocalUserId")]
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
