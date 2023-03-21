using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Connect;

[StructLayout(0, Pack = 8, Size = 16)]
internal struct GetProductUserExternalAccountCountOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_TargetUserId;

	public ProductUserId TargetUserId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(GetProductUserExternalAccountCountOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(GetProductUserExternalAccountCountOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetProductUserExternalAccountCountOptionsInternal), Member = "set_TargetUserId")]
	public void Set(GetProductUserExternalAccountCountOptions other)
	{
	}

	[Calls(Type = typeof(GetProductUserExternalAccountCountOptionsInternal), Member = "set_TargetUserId")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(ConnectInterface), Member = "GetProductUserExternalAccountCount")]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void Dispose()
	{
	}
}
