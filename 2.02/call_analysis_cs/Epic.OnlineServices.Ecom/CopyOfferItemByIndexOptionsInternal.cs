using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Ecom;

[StructLayout(0, Pack = 8, Size = 32)]
internal struct CopyOfferItemByIndexOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private IntPtr m_OfferId;

	private uint m_ItemIndex;

	public EpicAccountId LocalUserId
	{
		[CalledBy(Type = typeof(CopyOfferItemByIndexOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyOfferItemByIndexOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string OfferId
	{
		[CalledBy(Type = typeof(CopyOfferItemByIndexOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyOfferItemByIndexOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public uint ItemIndex
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyOfferItemByIndexOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(CopyOfferItemByIndexOptionsInternal), Member = "set_OfferId")]
	public void Set(CopyOfferItemByIndexOptions other)
	{
	}

	[CalledBy(Type = typeof(EcomInterface), Member = "CopyOfferItemByIndex")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CopyOfferItemByIndexOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(CopyOfferItemByIndexOptionsInternal), Member = "set_OfferId")]
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
