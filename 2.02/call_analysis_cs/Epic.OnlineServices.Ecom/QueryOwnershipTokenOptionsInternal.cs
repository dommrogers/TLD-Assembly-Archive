using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Ecom;

[StructLayout(0, Pack = 8, Size = 40)]
internal struct QueryOwnershipTokenOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private IntPtr m_CatalogItemIds;

	private uint m_CatalogItemIdCount;

	private IntPtr m_CatalogNamespace;

	public EpicAccountId LocalUserId
	{
		[CalledBy(Type = typeof(QueryOwnershipTokenOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(QueryOwnershipTokenOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string[] CatalogItemIds
	{
		[CalledBy(Type = typeof(QueryOwnershipTokenOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(QueryOwnershipTokenOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string CatalogNamespace
	{
		[CalledBy(Type = typeof(QueryOwnershipTokenOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(QueryOwnershipTokenOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QueryOwnershipTokenOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(QueryOwnershipTokenOptionsInternal), Member = "set_CatalogItemIds")]
	[Calls(Type = typeof(QueryOwnershipTokenOptionsInternal), Member = "set_CatalogNamespace")]
	public void Set(QueryOwnershipTokenOptions other)
	{
	}

	[CalledBy(Type = typeof(EcomInterface), Member = "QueryOwnershipToken")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(QueryOwnershipTokenOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(QueryOwnershipTokenOptionsInternal), Member = "set_CatalogItemIds")]
	[Calls(Type = typeof(QueryOwnershipTokenOptionsInternal), Member = "set_CatalogNamespace")]
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
