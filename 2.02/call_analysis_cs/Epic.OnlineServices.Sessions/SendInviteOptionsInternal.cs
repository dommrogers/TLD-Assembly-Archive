using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

[StructLayout(0, Pack = 8, Size = 32)]
internal struct SendInviteOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_SessionName;

	private IntPtr m_LocalUserId;

	private IntPtr m_TargetUserId;

	public string SessionName
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

	public ProductUserId LocalUserId
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

	public ProductUserId TargetUserId
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

	[Calls(Type = typeof(SendInviteOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(SendInviteOptionsInternal), Member = "set_TargetUserId")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SendInviteOptionsInternal), Member = "set_SessionName")]
	public void Set(SendInviteOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SendInviteOptionsInternal), Member = "set_SessionName")]
	[Calls(Type = typeof(SendInviteOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(SendInviteOptionsInternal), Member = "set_TargetUserId")]
	[CalledBy(Type = typeof(SessionsInterface), Member = "SendInvite")]
	public void Set(object other)
	{
	}

	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Dispose()
	{
	}
}
