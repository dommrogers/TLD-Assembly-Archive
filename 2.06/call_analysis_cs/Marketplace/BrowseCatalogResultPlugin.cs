using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Marketplace;

public class BrowseCatalogResultPlugin
{
	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern void BrowseCatalogResult_Dispose(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern uint BrowseCatalogResult_TotalCount(IntPtr self);

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static extern uint BrowseCatalogResult_Items_Length(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern IntPtr BrowseCatalogResult_Items_GetAt(IntPtr self, uint idx);

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public BrowseCatalogResultPlugin()
	{
	}
}
