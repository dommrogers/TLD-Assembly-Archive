using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

[StructLayout(0, Pack = 8, Size = 40)]
internal struct SessionDetailsInfoInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_SessionId;

	private IntPtr m_HostAddress;

	private uint m_NumOpenPublicConnections;

	private IntPtr m_Settings;

	public string SessionId
	{
		[CalledBy(Type = typeof(SessionDetailsInfo), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(SessionDetailsInfoInternal), Member = "Set")]
		[CalledBy(Type = typeof(SessionDetailsInfoInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string HostAddress
	{
		[CalledBy(Type = typeof(SessionDetailsInfo), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(SessionDetailsInfoInternal), Member = "Set")]
		[CalledBy(Type = typeof(SessionDetailsInfoInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public uint NumOpenPublicConnections
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		get
		{
			return 0u;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public SessionDetailsSettings Settings
	{
		[CalledBy(Type = typeof(SessionDetailsInfo), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(SessionDetailsInfoInternal), Member = "Set")]
		[CalledBy(Type = typeof(SessionDetailsInfoInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(SessionDetailsSettingsInternal), Member = "Set")]
		[CallsDeduplicatedMethods(Count = 4)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SessionDetailsInfoInternal), Member = "set_SessionId")]
	[Calls(Type = typeof(SessionDetailsInfoInternal), Member = "set_HostAddress")]
	[Calls(Type = typeof(SessionDetailsInfoInternal), Member = "set_Settings")]
	public void Set(SessionDetailsInfo other)
	{
	}

	[CalledBy(Type = typeof(ActiveSessionInfoInternal), Member = "set_SessionDetails")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SessionDetailsInfoInternal), Member = "set_SessionId")]
	[Calls(Type = typeof(SessionDetailsInfoInternal), Member = "set_HostAddress")]
	[Calls(Type = typeof(SessionDetailsInfoInternal), Member = "set_Settings")]
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
