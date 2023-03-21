using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Connect;

[StructLayout(0, Pack = 8, Size = 16)]
internal struct UnlinkAccountOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	public ProductUserId LocalUserId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(UnlinkAccountOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(UnlinkAccountOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[Calls(Type = typeof(UnlinkAccountOptionsInternal), Member = "set_LocalUserId")]
	[CallerCount(Count = 0)]
	public void Set(UnlinkAccountOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnlinkAccountOptionsInternal), Member = "set_LocalUserId")]
	[CalledBy(Type = typeof(ConnectInterface), Member = "UnlinkAccount")]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Dispose()
	{
	}
}
