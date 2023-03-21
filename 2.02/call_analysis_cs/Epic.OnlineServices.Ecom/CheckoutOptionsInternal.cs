using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Ecom;

[StructLayout(0, Pack = 8, Size = 40)]
internal struct CheckoutOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private IntPtr m_OverrideCatalogNamespace;

	private uint m_EntryCount;

	private IntPtr m_Entries;

	public EpicAccountId LocalUserId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(CheckoutOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CheckoutOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public string OverrideCatalogNamespace
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(CheckoutOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CheckoutOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public CheckoutEntry[] Entries
	{
		[CalledBy(Type = typeof(CheckoutOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CheckoutOptionsInternal), Member = "Set")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallerCount(Count = 2)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CheckoutOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(CheckoutOptionsInternal), Member = "set_OverrideCatalogNamespace")]
	[Calls(Type = typeof(CheckoutOptionsInternal), Member = "set_Entries")]
	public void Set(CheckoutOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CheckoutOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(CheckoutOptionsInternal), Member = "set_OverrideCatalogNamespace")]
	[Calls(Type = typeof(CheckoutOptionsInternal), Member = "set_Entries")]
	[CalledBy(Type = typeof(EcomInterface), Member = "Checkout")]
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
