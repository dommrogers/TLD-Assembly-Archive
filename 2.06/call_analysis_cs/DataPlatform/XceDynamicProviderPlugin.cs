using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEtx;

namespace DataPlatform;

public class XceDynamicProviderPlugin
{
	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern void XceDynamicProvider_Uninitialize();

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public static extern void XceDynamicProvider_Create(string name, string guid);

	[PreserveSig]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern bool XceDynamicProvider_Initialize();

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static extern void XceDynamicProvider_SetDefaults(EtxProviderLatency latency, EtxProviderPriority priority, EtxProviderEnabledState enabled, EtxPopulationSample sample);

	[PreserveSig]
	[CallsUnknownMethods(Count = 21)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 11)]
	public static extern IntPtr XceDynamicProvider_CreateEvent(string name, uint eventId, EtxEventLatency latency, EtxEventPriority priority, EtxPopulationSample sample, EtxEventEnabledState enabled, string partBAbbreviation, string partBVersion, string partCAbbreviation, string partCVersion);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public static extern IntPtr XceDynamicProvider_CreateField(IntPtr self, string name, EtxFieldType fieldType);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern uint XceDynamicProvider_WriteEvent(IntPtr evt);

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public XceDynamicProviderPlugin()
	{
	}
}
