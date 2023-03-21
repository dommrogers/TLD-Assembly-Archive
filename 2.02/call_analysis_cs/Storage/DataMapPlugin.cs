using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Storage;

public class DataMapPlugin
{
	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern IntPtr DataMap_CreateEmptyDataMap();

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern IntPtr DataMap_FromDataMapView(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern void DataMap_AddEmptyBuffer(IntPtr self, string name, int length);

	[PreserveSig]
	[CalledBy(Type = typeof(DataMap), Member = "AddOrReplaceBuffer")]
	[CalledBy(Type = typeof(DataMap), Member = "AddOrReplaceBuffer")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static extern void DataMap_AddOrReplaceBuffer(IntPtr self, string name, byte[] data, int length);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static extern bool DataMap_UpdateBuffer(IntPtr self, string name, int start, byte[] data, int offset, int length);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static extern bool DataMap_GetBufferData(IntPtr self, string name, int offset, byte[] data, int length);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern uint DataMap_BufferLength(IntPtr self, string name);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern uint DataMap_BufferCapacity(IntPtr self, string name);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern void DataMap_Dispose(IntPtr self);

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public DataMapPlugin()
	{
	}
}
