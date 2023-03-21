using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Ecom;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct QueryOffersOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private IntPtr m_OverrideCatalogNamespace;

	public EpicAccountId LocalUserId
	{
		[CalledBy(Type = typeof(QueryOffersOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(QueryOffersOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		set
		{
		}
	}

	public string OverrideCatalogNamespace
	{
		[CalledBy(Type = typeof(QueryOffersOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(QueryOffersOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[Calls(Type = typeof(QueryOffersOptionsInternal), Member = "set_LocalUserId")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QueryOffersOptionsInternal), Member = "set_OverrideCatalogNamespace")]
	public void Set(QueryOffersOptions other)
	{
	}

	[CalledBy(Type = typeof(EcomInterface), Member = "QueryOffers")]
	[Calls(Type = typeof(QueryOffersOptionsInternal), Member = "set_OverrideCatalogNamespace")]
	[Calls(Type = typeof(QueryOffersOptionsInternal), Member = "set_LocalUserId")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
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
