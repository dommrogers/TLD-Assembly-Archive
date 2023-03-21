using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Ecom;

public sealed class Transaction : Handle
{
	public const int TransactionCopyentitlementbyindexApiLatest = 1;

	public const int TransactionGetentitlementscountApiLatest = 1;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public Transaction()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Transaction(IntPtr innerHandle)
	{
	}

	[Calls(Type = typeof(EcomInterface), Member = "EOS_Ecom_Entitlement_Release")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(TransactionCopyEntitlementByIndexOptionsInternal), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallerCount(Count = 0)]
	public Result CopyEntitlementByIndex(TransactionCopyEntitlementByIndexOptions options, out Entitlement outEntitlement)
	{
		outEntitlement = null;
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(TransactionGetEntitlementsCountOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 1)]
	public uint GetEntitlementsCount(TransactionGetEntitlementsCountOptions options)
	{
		return default(uint);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalAllocate")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 1)]
	public Result GetTransactionId(out string outBuffer)
	{
		outBuffer = null;
		return default(Result);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Release()
	{
	}

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_Ecom_Transaction_CopyEntitlementByIndex(IntPtr handle, IntPtr options, ref IntPtr outEntitlement);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern uint EOS_Ecom_Transaction_GetEntitlementsCount(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_Ecom_Transaction_GetTransactionId(IntPtr handle, IntPtr outBuffer, ref int inOutBufferLength);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern void EOS_Ecom_Transaction_Release(IntPtr transaction);
}
