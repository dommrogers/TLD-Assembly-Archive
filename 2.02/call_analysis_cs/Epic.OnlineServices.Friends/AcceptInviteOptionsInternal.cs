using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Friends;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct AcceptInviteOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private IntPtr m_TargetUserId;

	public EpicAccountId LocalUserId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(AcceptInviteOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(AcceptInviteOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public EpicAccountId TargetUserId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(AcceptInviteOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(AcceptInviteOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[Calls(Type = typeof(AcceptInviteOptionsInternal), Member = "set_TargetUserId")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AcceptInviteOptionsInternal), Member = "set_LocalUserId")]
	public void Set(AcceptInviteOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AcceptInviteOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(AcceptInviteOptionsInternal), Member = "set_TargetUserId")]
	[CalledBy(Type = typeof(FriendsInterface), Member = "AcceptInvite")]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Dispose()
	{
	}
}
