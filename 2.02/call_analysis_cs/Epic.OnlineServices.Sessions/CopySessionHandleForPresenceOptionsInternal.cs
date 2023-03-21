using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

[StructLayout(0, Pack = 8, Size = 16)]
internal struct CopySessionHandleForPresenceOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	public ProductUserId LocalUserId
	{
		[CalledBy(Type = typeof(CopySessionHandleForPresenceOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopySessionHandleForPresenceOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopySessionHandleForPresenceOptionsInternal), Member = "set_LocalUserId")]
	public void Set(CopySessionHandleForPresenceOptions other)
	{
	}

	[CalledBy(Type = typeof(SessionsInterface), Member = "CopySessionHandleForPresence")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CopySessionHandleForPresenceOptionsInternal), Member = "set_LocalUserId")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void Dispose()
	{
	}
}
