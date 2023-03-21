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
		[CalledBy(Type = typeof(ActiveSessionInfo), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(ActiveSessionInfoInternal), Member = "Set")]
		[CalledBy(Type = typeof(ActiveSessionInfoInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public ProductUserId LocalUserId
	{
		[CalledBy(Type = typeof(ActiveSessionInfo), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(ActiveSessionInfoInternal), Member = "Set")]
		[CalledBy(Type = typeof(ActiveSessionInfoInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
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
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public SessionDetailsInfo SessionDetails
	{
		[CalledBy(Type = typeof(ActiveSessionInfo), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(ActiveSessionInfoInternal), Member = "Set")]
		[CalledBy(Type = typeof(ActiveSessionInfoInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(SessionDetailsInfoInternal), Member = "Set")]
		[CallsDeduplicatedMethods(Count = 4)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActiveSessionInfoInternal), Member = "set_SessionName")]
	[Calls(Type = typeof(ActiveSessionInfoInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(ActiveSessionInfoInternal), Member = "set_SessionDetails")]
	public void Set(ActiveSessionInfo other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActiveSessionInfoInternal), Member = "set_SessionName")]
	[Calls(Type = typeof(ActiveSessionInfoInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(ActiveSessionInfoInternal), Member = "set_SessionDetails")]
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
