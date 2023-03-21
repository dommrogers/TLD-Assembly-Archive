using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Marketplace;

public class ConsumeInventoryItemResultPlugin
{
	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern uint ConsumeInventoryItemResult_ConsumableBalance(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern IntPtr ConsumeInventoryItemResult_ConsumableUrl(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern IntPtr ConsumeInventoryItemResult_TransactionId(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern void ConsumeInventoryItemResult_Dispose(IntPtr self);

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public ConsumeInventoryItemResultPlugin()
	{
	}
}
