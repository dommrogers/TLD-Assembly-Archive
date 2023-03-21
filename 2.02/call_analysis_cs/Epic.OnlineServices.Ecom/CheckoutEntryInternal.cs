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
		[CalledBy(Type = typeof(CheckoutEntry), Member = "Set")]
		[CalledBy(Type = typeof(CheckoutEntry), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(CheckoutEntryInternal), Member = "Set")]
		[CalledBy(Type = typeof(CheckoutEntryInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
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
	[Calls(Type = typeof(CheckoutEntryInternal), Member = "set_OfferId")]
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
