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
		[CalledBy(Type = typeof(CheckoutOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CheckoutOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string OverrideCatalogNamespace
	{
		[CalledBy(Type = typeof(CheckoutOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CheckoutOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public CheckoutEntry[] Entries
	{
		[CalledBy(Type = typeof(CheckoutOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CheckoutOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 3)]
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

	[CalledBy(Type = typeof(EcomInterface), Member = "Checkout")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CheckoutOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(CheckoutOptionsInternal), Member = "set_OverrideCatalogNamespace")]
	[Calls(Type = typeof(CheckoutOptionsInternal), Member = "set_Entries")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Dispose()
	{
	}
}
