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
		[CalledBy(Type = typeof(GetProductUserIdMappingOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(GetProductUserIdMappingOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
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
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
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

	[CalledBy(Type = typeof(ConnectInterface), Member = "GetProductUserIdMapping")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GetProductUserIdMappingOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(GetProductUserIdMappingOptionsInternal), Member = "set_TargetProductUserId")]
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
