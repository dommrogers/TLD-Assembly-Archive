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
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string InviteId
	{
		[CalledBy(Type = typeof(RejectInviteOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(RejectInviteOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RejectInviteOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(RejectInviteOptionsInternal), Member = "set_InviteId")]
	public void Set(RejectInviteOptions other)
	{
	}

	[CalledBy(Type = typeof(SessionsInterface), Member = "RejectInvite")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RejectInviteOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(RejectInviteOptionsInternal), Member = "set_InviteId")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Dispose()
	{
	}
}
