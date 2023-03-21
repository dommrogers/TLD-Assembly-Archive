using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Connect;

[StructLayout(0, Pack = 8, Size = 32)]
internal struct GetProductUserIdMappingOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private ExternalAccountType m_AccountIdType;

	private IntPtr m_TargetProductUserId;

	public ProductUserId LocalUserId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(GetProductUserIdMappingOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(GetProductUserIdMappingOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public ExternalAccountType AccountIdType
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public ProductUserId TargetProductUserId
	{
		[CalledBy(Type = typeof(GetProductUserIdMappingOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(GetProductUserIdMappingOptionsInternal), Member = "Set")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetProductUserIdMappingOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(GetProductUserIdMappingOptionsInternal), Member = "set_TargetProductUserId")]
	public void Set(GetProductUserIdMappingOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GetProductUserIdMappingOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(GetProductUserIdMappingOptionsInternal), Member = "set_TargetProductUserId")]
	[CalledBy(Type = typeof(ConnectInterface), Member = "GetProductUserIdMapping")]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Dispose()
	{
	}
}
