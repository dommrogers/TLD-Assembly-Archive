using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct RejectInviteOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private IntPtr m_InviteId;

	public ProductUserId LocalUserId
	{
		[CalledBy(Type = typeof(RejectInviteOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(RejectInviteOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		set
		{
		}
	}

	public string InviteId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(RejectInviteOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(RejectInviteOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[Calls(Type = typeof(RejectInviteOptionsInternal), Member = "set_LocalUserId")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RejectInviteOptionsInternal), Member = "set_InviteId")]
	public void Set(RejectInviteOptions other)
	{
	}

	[Calls(Type = typeof(RejectInviteOptionsInternal), Member = "set_InviteId")]
	[Calls(Type = typeof(RejectInviteOptionsInternal), Member = "set_LocalUserId")]
	[CalledBy(Type = typeof(SessionsInterface), Member = "RejectInvite")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallerCount(Count = 0)]
	public void Dispose()
	{
	}
}
