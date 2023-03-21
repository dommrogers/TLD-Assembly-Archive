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
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(SessionDetailsInfoInternal), Member = "Set")]
		[CalledBy(Type = typeof(SessionDetailsInfoInternal), Member = "Set")]
		set
		{
		}
	}

	public string HostAddress
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(SessionDetailsInfo), Member = "Set")]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(SessionDetailsInfoInternal), Member = "Set")]
		[CalledBy(Type = typeof(SessionDetailsInfoInternal), Member = "Set")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
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
			return default(uint);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public SessionDetailsSettings Settings
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(SessionDetailsInfo), Member = "Set")]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(SessionDetailsInfoInternal), Member = "Set")]
		[Calls(Type = typeof(SessionDetailsSettingsInternal), Member = "Set")]
		[CalledBy(Type = typeof(SessionDetailsInfoInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 4)]
		set
		{
		}
	}

	[Calls(Type = typeof(SessionDetailsInfoInternal), Member = "set_Settings")]
	[Calls(Type = typeof(SessionDetailsInfoInternal), Member = "set_HostAddress")]
	[Calls(Type = typeof(SessionDetailsInfoInternal), Member = "set_SessionId")]
	[CallerCount(Count = 0)]
	public void Set(SessionDetailsInfo other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SessionDetailsInfoInternal), Member = "set_SessionId")]
	[Calls(Type = typeof(SessionDetailsInfoInternal), Member = "set_HostAddress")]
	[Calls(Type = typeof(SessionDetailsInfoInternal), Member = "set_Settings")]
	[CalledBy(Type = typeof(ActiveSessionInfoInternal), Member = "set_SessionDetails")]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	public void Dispose()
	{
	}
}
