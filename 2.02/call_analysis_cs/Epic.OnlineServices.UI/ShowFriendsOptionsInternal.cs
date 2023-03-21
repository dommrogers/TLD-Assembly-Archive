using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.UI;

[StructLayout(0, Pack = 8, Size = 16)]
internal struct ShowFriendsOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	public EpicAccountId LocalUserId
	{
		[CalledBy(Type = typeof(ShowFriendsOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(ShowFriendsOptionsInternal), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ShowFriendsOptionsInternal), Member = "set_LocalUserId")]
	public void Set(ShowFriendsOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ShowFriendsOptionsInternal), Member = "set_LocalUserId")]
	[CalledBy(Type = typeof(UIInterface), Member = "ShowFriends")]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Dispose()
	{
	}
}
