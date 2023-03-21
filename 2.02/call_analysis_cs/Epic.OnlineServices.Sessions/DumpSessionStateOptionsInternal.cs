using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

[StructLayout(0, Pack = 8, Size = 16)]
internal struct DumpSessionStateOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_SessionName;

	public string SessionName
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(DumpSessionStateOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(DumpSessionStateOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[Calls(Type = typeof(DumpSessionStateOptionsInternal), Member = "set_SessionName")]
	[CallerCount(Count = 0)]
	public void Set(DumpSessionStateOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(DumpSessionStateOptionsInternal), Member = "set_SessionName")]
	[CalledBy(Type = typeof(SessionsInterface), Member = "DumpSessionState")]
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
