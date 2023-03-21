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
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(QueryProductUserIdMappingsOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(QueryProductUserIdMappingsOptionsInternal), Member = "Set")]
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
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(QueryProductUserIdMappingsOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(QueryProductUserIdMappingsOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[Calls(Type = typeof(QueryProductUserIdMappingsOptionsInternal), Member = "set_ProductUserIds")]
	[Calls(Type = typeof(QueryProductUserIdMappingsOptionsInternal), Member = "set_LocalUserId")]
	[CallerCount(Count = 0)]
	public void Set(QueryProductUserIdMappingsOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(QueryProductUserIdMappingsOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(QueryProductUserIdMappingsOptionsInternal), Member = "set_ProductUserIds")]
	[CalledBy(Type = typeof(ConnectInterface), Member = "QueryProductUserIdMappings")]
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
