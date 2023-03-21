using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

[StructLayout(0, Pack = 8, Size = 16)]
internal struct SessionSearchSetSessionIdOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_SessionId;

	public string SessionId
	{
		[CalledBy(Type = typeof(SessionSearchSetSessionIdOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(SessionSearchSetSessionIdOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SessionSearchSetSessionIdOptionsInternal), Member = "set_SessionId")]
	public void Set(SessionSearchSetSessionIdOptions other)
	{
	}

	[CalledBy(Type = typeof(SessionSearch), Member = "SetSessionId")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SessionSearchSetSessionIdOptionsInternal), Member = "set_SessionId")]
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
