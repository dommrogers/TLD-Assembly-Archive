using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

[StructLayout(0, Pack = 8, Size = 16)]
internal struct CopyActiveSessionHandleOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_SessionName;

	public string SessionName
	{
		[CalledBy(Type = typeof(CopyActiveSessionHandleOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyActiveSessionHandleOptionsInternal), Member = "Set")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyActiveSessionHandleOptionsInternal), Member = "set_SessionName")]
	public void Set(CopyActiveSessionHandleOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CopyActiveSessionHandleOptionsInternal), Member = "set_SessionName")]
	[CalledBy(Type = typeof(SessionsInterface), Member = "CopyActiveSessionHandle")]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	public void Dispose()
	{
	}
}
