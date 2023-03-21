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
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
		set
		{
		}
	}

	public SessionDetails SessionHandle
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(JoinSessionOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(JoinSessionOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public ProductUserId LocalUserId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(JoinSessionOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(JoinSessionOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public bool PresenceEnabled
	{
		[CalledBy(Type = typeof(JoinSessionOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(JoinSessionOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
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

	[Calls(Type = typeof(JoinSessionOptionsInternal), Member = "set_PresenceEnabled")]
	[Calls(Type = typeof(JoinSessionOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(JoinSessionOptionsInternal), Member = "set_SessionHandle")]
	[CalledBy(Type = typeof(SessionsInterface), Member = "JoinSession")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JoinSessionOptionsInternal), Member = "set_SessionName")]
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
