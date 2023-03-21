using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Storage;

public class DataMapViewPlugin
{
	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static extern bool DataMapView_GetBufferData(IntPtr self, string name, int offset, byte[] data, int length);

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static extern uint DataMapView_BufferLength(IntPtr self, string name);

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static extern uint DataMapView_BufferCapacity(IntPtr self, string name);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern void DataMapView_Dispose(IntPtr self);

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public DataMapViewPlugin()
	{
	}
}
