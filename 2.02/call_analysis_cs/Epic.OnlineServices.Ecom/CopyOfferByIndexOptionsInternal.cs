using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Ecom;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct CopyOfferByIndexOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private uint m_OfferIndex;

	public EpicAccountId LocalUserId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(CopyOfferByIndexOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyOfferByIndexOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public uint OfferIndex
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyOfferByIndexOptionsInternal), Member = "set_LocalUserId")]
	public void Set(CopyOfferByIndexOptions other)
	{
	}

	[CalledBy(Type = typeof(EcomInterface), Member = "CopyOfferByIndex")]
	[Calls(Type = typeof(CopyOfferByIndexOptionsInternal), Member = "set_LocalUserId")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Dispose()
	{
	}
}
