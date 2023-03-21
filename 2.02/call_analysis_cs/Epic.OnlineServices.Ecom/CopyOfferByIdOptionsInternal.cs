using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Ecom;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct CopyOfferByIdOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private IntPtr m_OfferId;

	public EpicAccountId LocalUserId
	{
		[CalledBy(Type = typeof(CopyOfferByIdOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyOfferByIdOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string OfferId
	{
		[CalledBy(Type = typeof(CopyOfferByIdOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyOfferByIdOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyOfferByIdOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(CopyOfferByIdOptionsInternal), Member = "set_OfferId")]
	public void Set(CopyOfferByIdOptions other)
	{
	}

	[CalledBy(Type = typeof(EcomInterface), Member = "CopyOfferById")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CopyOfferByIdOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(CopyOfferByIdOptionsInternal), Member = "set_OfferId")]
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
