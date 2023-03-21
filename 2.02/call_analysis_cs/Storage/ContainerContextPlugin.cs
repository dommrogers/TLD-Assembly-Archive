using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;
using UnityAOT;

namespace Storage;

public class ContainerContextPlugin
{
	public delegate void BlobInfoQueryAsyncCallback(uint result, IntPtr queryHandle, IntPtr userData, uint totalInfos);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern void ContainerContext_Destroy(IntPtr self);

	[PreserveSig]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(ContainerContext), Member = "GetAsync")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	public static extern bool ContainerContext_GetAsync(IntPtr self, string[] names, int numNames, ObjectResultCallback callback, IntPtr userData);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static extern bool ContainerContext_ReadAsync(IntPtr self, IntPtr map, ObjectResultCallback callback, IntPtr userData);

	[PreserveSig]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CalledBy(Type = typeof(ContainerContext), Member = "SubmitUpdatesAsync")]
	[CallsUnknownMethods(Count = 2)]
	public static extern bool ContainerContext_SubmitUpdatesAsync(IntPtr self, IntPtr toUpdate, string[] toDeleteNames, int numNames, GenericActionCallback callback, IntPtr userData, string displayName);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static extern bool ContainerContext_QueryBlobInfoAsync(IntPtr self, BlobInfoQueryAsyncCallback callback, string query, IntPtr userData);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern IntPtr ContainerContext_GetName(IntPtr self);

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static extern void ContainerContext_BlobInfo_Dispose(IntPtr self);

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static extern uint ContainerContext_BlobInfo_Length(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern uint ContainerContext_BlobInfo_TotalSize(IntPtr self, uint idx);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern IntPtr ContainerContext_BlobInfo_Name(IntPtr self, uint idx);

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public ContainerContextPlugin()
	{
	}
}
