using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

[StructLayout(0, Pack = 8, Size = 16)]
internal struct SessionModificationSetHostAddressOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_HostAddress;

	public string HostAddress
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(SessionModificationSetHostAddressOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(SessionModificationSetHostAddressOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SessionModificationSetHostAddressOptionsInternal), Member = "set_HostAddress")]
	public void Set(SessionModificationSetHostAddressOptions other)
	{
	}

	[Calls(Type = typeof(SessionModificationSetHostAddressOptionsInternal), Member = "set_HostAddress")]
	[CalledBy(Type = typeof(SessionModification), Member = "SetHostAddress")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
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
