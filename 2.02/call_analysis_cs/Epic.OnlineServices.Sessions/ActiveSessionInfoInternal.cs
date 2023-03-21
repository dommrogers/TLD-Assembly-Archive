using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

[StructLayout(0, Pack = 8, Size = 40)]
internal struct ActiveSessionInfoInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_SessionName;

	private IntPtr m_LocalUserId;

	private OnlineSessionState m_State;

	private IntPtr m_SessionDetails;

	public string SessionName
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(ActiveSessionInfo), Member = "Set")]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(ActiveSessionInfoInternal), Member = "Set")]
		[CalledBy(Type = typeof(ActiveSessionInfoInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		set
		{
		}
	}

	public ProductUserId LocalUserId
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(ActiveSessionInfo), Member = "Set")]
		get
		{
			return null;
		}
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(ActiveSessionInfoInternal), Member = "Set")]
		[CalledBy(Type = typeof(ActiveSessionInfoInternal), Member = "Set")]
		set
		{
		}
	}

	public OnlineSessionState State
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		get
		{
			return default(OnlineSessionState);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public SessionDetailsInfo SessionDetails
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(ActiveSessionInfo), Member = "Set")]
		get
		{
			return null;
		}
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 4)]
		[Calls(Type = typeof(SessionDetailsInfoInternal), Member = "Set")]
		[CalledBy(Type = typeof(ActiveSessionInfoInternal), Member = "Set")]
		[CalledBy(Type = typeof(ActiveSessionInfoInternal), Member = "Set")]
		set
		{
		}
	}

	[Calls(Type = typeof(ActiveSessionInfoInternal), Member = "set_SessionDetails")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActiveSessionInfoInternal), Member = "set_SessionName")]
	[Calls(Type = typeof(ActiveSessionInfoInternal), Member = "set_LocalUserId")]
	public void Set(ActiveSessionInfo other)
	{
	}

	[Calls(Type = typeof(ActiveSessionInfoInternal), Member = "set_SessionDetails")]
	[Calls(Type = typeof(ActiveSessionInfoInternal), Member = "set_LocalUserId")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActiveSessionInfoInternal), Member = "set_SessionName")]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	public void Dispose()
	{
	}
}
