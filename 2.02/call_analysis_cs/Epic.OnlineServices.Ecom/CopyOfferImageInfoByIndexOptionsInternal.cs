using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Ecom;

[StructLayout(0, Pack = 8, Size = 32)]
internal struct CopyOfferImageInfoByIndexOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private IntPtr m_OfferId;

	private uint m_ImageInfoIndex;

	public EpicAccountId LocalUserId
	{
		[CalledBy(Type = typeof(CopyOfferImageInfoByIndexOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(CopyOfferImageInfoByIndexOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public string OfferId
	{
		[CalledBy(Type = typeof(CopyOfferImageInfoByIndexOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyOfferImageInfoByIndexOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		set
		{
		}
	}

	public uint ImageInfoIndex
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyOfferImageInfoByIndexOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(CopyOfferImageInfoByIndexOptionsInternal), Member = "set_OfferId")]
	public void Set(CopyOfferImageInfoByIndexOptions other)
	{
	}

	[Calls(Type = typeof(CopyOfferImageInfoByIndexOptionsInternal), Member = "set_OfferId")]
	[Calls(Type = typeof(CopyOfferImageInfoByIndexOptionsInternal), Member = "set_LocalUserId")]
	[CalledBy(Type = typeof(EcomInterface), Member = "CopyOfferImageInfoByIndex")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void Dispose()
	{
	}
}
