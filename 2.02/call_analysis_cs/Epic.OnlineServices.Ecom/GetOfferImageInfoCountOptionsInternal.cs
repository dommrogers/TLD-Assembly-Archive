using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Ecom;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct GetOfferImageInfoCountOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private IntPtr m_OfferId;

	public EpicAccountId LocalUserId
	{
		[CalledBy(Type = typeof(GetOfferImageInfoCountOptionsInternal), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(GetOfferImageInfoCountOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string OfferId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(GetOfferImageInfoCountOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(GetOfferImageInfoCountOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetOfferImageInfoCountOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(GetOfferImageInfoCountOptionsInternal), Member = "set_OfferId")]
	public void Set(GetOfferImageInfoCountOptions other)
	{
	}

	[Calls(Type = typeof(GetOfferImageInfoCountOptionsInternal), Member = "set_OfferId")]
	[Calls(Type = typeof(GetOfferImageInfoCountOptionsInternal), Member = "set_LocalUserId")]
	[CalledBy(Type = typeof(EcomInterface), Member = "GetOfferImageInfoCount")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Dispose()
	{
	}
}
