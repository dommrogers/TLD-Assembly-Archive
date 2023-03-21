using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Friends;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct SendInviteOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private IntPtr m_TargetUserId;

	public EpicAccountId LocalUserId
	{
		[CalledBy(Type = typeof(SendInviteOptionsInternal), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(SendInviteOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public EpicAccountId TargetUserId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(SendInviteOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(SendInviteOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SendInviteOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(SendInviteOptionsInternal), Member = "set_TargetUserId")]
	public void Set(SendInviteOptions other)
	{
	}

	[Calls(Type = typeof(SendInviteOptionsInternal), Member = "set_TargetUserId")]
	[Calls(Type = typeof(SendInviteOptionsInternal), Member = "set_LocalUserId")]
	[CalledBy(Type = typeof(FriendsInterface), Member = "SendInvite")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void Dispose()
	{
	}
}
