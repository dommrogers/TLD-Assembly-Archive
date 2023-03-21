using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Friends;

[StructLayout(0, Pack = 8, Size = 16)]
internal struct GetFriendsCountOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	public EpicAccountId LocalUserId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(GetFriendsCountOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(GetFriendsCountOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetFriendsCountOptionsInternal), Member = "set_LocalUserId")]
	public void Set(GetFriendsCountOptions other)
	{
	}

	[CalledBy(Type = typeof(FriendsInterface), Member = "GetFriendsCount")]
	[Calls(Type = typeof(GetFriendsCountOptionsInternal), Member = "set_LocalUserId")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Dispose()
	{
	}
}
