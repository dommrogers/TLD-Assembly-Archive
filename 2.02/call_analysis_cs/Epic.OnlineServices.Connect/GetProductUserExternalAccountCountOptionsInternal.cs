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
		[CalledBy(Type = typeof(GetProductUserExternalAccountCountOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(GetProductUserExternalAccountCountOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetProductUserExternalAccountCountOptionsInternal), Member = "set_TargetUserId")]
	public void Set(GetProductUserExternalAccountCountOptions other)
	{
	}

	[CalledBy(Type = typeof(ConnectInterface), Member = "GetProductUserExternalAccountCount")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GetProductUserExternalAccountCountOptionsInternal), Member = "set_TargetUserId")]
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
