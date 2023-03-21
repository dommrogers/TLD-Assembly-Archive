using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Connect;

[StructLayout(0, Pack = 8, Size = 40)]
internal struct QueryExternalAccountMappingsOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private ExternalAccountType m_AccountIdType;

	private IntPtr m_ExternalAccountIds;

	private uint m_ExternalAccountIdCount;

	public ProductUserId LocalUserId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(QueryExternalAccountMappingsOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(QueryExternalAccountMappingsOptionsInternal), Member = "Set")]
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

	public string[] ExternalAccountIds
	{
		[CalledBy(Type = typeof(QueryExternalAccountMappingsOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(QueryExternalAccountMappingsOptionsInternal), Member = "Set")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[Calls(Type = typeof(QueryExternalAccountMappingsOptionsInternal), Member = "set_ExternalAccountIds")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QueryExternalAccountMappingsOptionsInternal), Member = "set_LocalUserId")]
	public void Set(QueryExternalAccountMappingsOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(QueryExternalAccountMappingsOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(QueryExternalAccountMappingsOptionsInternal), Member = "set_ExternalAccountIds")]
	[CalledBy(Type = typeof(ConnectInterface), Member = "QueryExternalAccountMappings")]
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
