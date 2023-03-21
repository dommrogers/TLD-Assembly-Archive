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
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(QueryOwnershipTokenOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(QueryOwnershipTokenOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public string[] CatalogItemIds
	{
		[CalledBy(Type = typeof(QueryOwnershipTokenOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(QueryOwnershipTokenOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public string CatalogNamespace
	{
		[CalledBy(Type = typeof(QueryOwnershipTokenOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(QueryOwnershipTokenOptionsInternal), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallerCount(Count = 2)]
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
	[Calls(Type = typeof(QueryOwnershipTokenOptionsInternal), Member = "set_CatalogItemIds")]
	[Calls(Type = typeof(QueryOwnershipTokenOptionsInternal), Member = "set_CatalogNamespace")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(QueryOwnershipTokenOptionsInternal), Member = "set_LocalUserId")]
	public void Set(object other)
	{
	}

	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Dispose()
	{
	}
}
