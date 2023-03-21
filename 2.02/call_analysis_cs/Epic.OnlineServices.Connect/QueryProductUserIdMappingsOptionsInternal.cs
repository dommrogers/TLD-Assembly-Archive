using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Connect;

[StructLayout(0, Pack = 8, Size = 40)]
internal struct QueryProductUserIdMappingsOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private ExternalAccountType m_AccountIdType_DEPRECATED;

	private IntPtr m_ProductUserIds;

	private uint m_ProductUserIdCount;

	public ProductUserId LocalUserId
	{
		[CalledBy(Type = typeof(QueryProductUserIdMappingsOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(QueryProductUserIdMappingsOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public ExternalAccountType AccountIdType_DEPRECATED
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public ProductUserId[] ProductUserIds
	{
		[CalledBy(Type = typeof(QueryProductUserIdMappingsOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(QueryProductUserIdMappingsOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QueryProductUserIdMappingsOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(QueryProductUserIdMappingsOptionsInternal), Member = "set_ProductUserIds")]
	public void Set(QueryProductUserIdMappingsOptions other)
	{
	}

	[CalledBy(Type = typeof(ConnectInterface), Member = "QueryProductUserIdMappings")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(QueryProductUserIdMappingsOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(QueryProductUserIdMappingsOptionsInternal), Member = "set_ProductUserIds")]
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
