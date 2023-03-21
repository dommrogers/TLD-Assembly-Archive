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
		[CalledBy(Type = typeof(SendInviteOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public ProductUserId LocalUserId
	{
		[CalledBy(Type = typeof(SendInviteOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(SendInviteOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public ProductUserId TargetUserId
	{
		[CalledBy(Type = typeof(SendInviteOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(SendInviteOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SendInviteOptionsInternal), Member = "set_SessionName")]
	[Calls(Type = typeof(SendInviteOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(SendInviteOptionsInternal), Member = "set_TargetUserId")]
	public void Set(SendInviteOptions other)
	{
	}

	[CalledBy(Type = typeof(SessionsInterface), Member = "SendInvite")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SendInviteOptionsInternal), Member = "set_SessionName")]
	[Calls(Type = typeof(SendInviteOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(SendInviteOptionsInternal), Member = "set_TargetUserId")]
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
