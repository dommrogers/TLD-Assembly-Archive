using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Ecom;

[StructLayout(0, Pack = 8, Size = 16)]
internal struct CheckoutEntryInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_OfferId;

	public string OfferId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(CheckoutEntry), Member = "Set")]
		[CalledBy(Type = typeof(CheckoutEntry), Member = "Set")]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(CheckoutEntryInternal), Member = "Set")]
		[CalledBy(Type = typeof(CheckoutEntryInternal), Member = "Set")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CheckoutEntryInternal), Member = "set_OfferId")]
	public void Set(CheckoutEntry other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CheckoutEntryInternal), Member = "set_OfferId")]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Dispose()
	{
	}
}
