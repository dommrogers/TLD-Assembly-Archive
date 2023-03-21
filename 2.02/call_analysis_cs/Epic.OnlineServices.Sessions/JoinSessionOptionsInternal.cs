using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

[StructLayout(0, Pack = 8, Size = 40)]
internal struct JoinSessionOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_SessionName;

	private IntPtr m_SessionHandle;

	private IntPtr m_LocalUserId;

	private int m_PresenceEnabled;

	public string SessionName
	{
		[CalledBy(Type = typeof(JoinSessionOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(JoinSessionOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public SessionDetails SessionHandle
	{
		[CalledBy(Type = typeof(JoinSessionOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(JoinSessionOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public ProductUserId LocalUserId
	{
		[CalledBy(Type = typeof(JoinSessionOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(JoinSessionOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public bool PresenceEnabled
	{
		[CalledBy(Type = typeof(JoinSessionOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(JoinSessionOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JoinSessionOptionsInternal), Member = "set_SessionName")]
	[Calls(Type = typeof(JoinSessionOptionsInternal), Member = "set_SessionHandle")]
	[Calls(Type = typeof(JoinSessionOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(JoinSessionOptionsInternal), Member = "set_PresenceEnabled")]
	public void Set(JoinSessionOptions other)
	{
	}

	[CalledBy(Type = typeof(SessionsInterface), Member = "JoinSession")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JoinSessionOptionsInternal), Member = "set_SessionName")]
	[Calls(Type = typeof(JoinSessionOptionsInternal), Member = "set_SessionHandle")]
	[Calls(Type = typeof(JoinSessionOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(JoinSessionOptionsInternal), Member = "set_PresenceEnabled")]
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
