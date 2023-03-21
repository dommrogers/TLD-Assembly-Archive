using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Marketplace;

public class ProductPurchasedEventArgsPlugin
{
	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern IntPtr ProductPurchasedEventArgs_Receipt(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern void ProductPurchasedEventArgs_Dispose(IntPtr self);

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public ProductPurchasedEventArgsPlugin()
	{
	}
}
