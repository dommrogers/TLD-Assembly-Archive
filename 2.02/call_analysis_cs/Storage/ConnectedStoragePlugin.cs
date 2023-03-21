using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;
using UnityAOT;

namespace Storage;

public class ConnectedStoragePlugin
{
	public delegate void UserSignedOutStorageInvalidCallback(uint userId, IntPtr userData);

	public delegate void QueryRemainingQuotaAsyncCallback(uint result, long quotaRemaining, IntPtr userData);

	public delegate void ContainerInfoQueryAsyncCallback(uint result, IntPtr queryHandle, IntPtr userData, uint totalInfos);

	[PreserveSig]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static extern IntPtr ConnectedStorage_Init(int userId, string serviceConfigurationId, int flags, ObjectResultCallback callback, IntPtr userData);

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static extern void ConnectedStorage_Destroy(IntPtr self);

	[PreserveSig]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static extern void ConnectedStorage_SetSignOutCallback(IntPtr self, UserSignedOutStorageInvalidCallback callback, IntPtr userData);

	[PreserveSig]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(ConnectedStorage), Member = "DeleteThisContainer")]
	[CalledBy(Type = typeof(ConnectedStorage), Member = "DeleteContainer")]
	[CallsUnknownMethods(Count = 2)]
	public static extern bool ConnectedStorage_DeleteContainer(IntPtr self, string containerName, GenericActionCallback callback, IntPtr userData);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static extern bool ConnectedStorage_QueryRemainingQuotaAsync(IntPtr self, QueryRemainingQuotaAsyncCallback callback, IntPtr userData);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static extern bool ConnectedStorage_QueryContainerInfoAsync(IntPtr self, ContainerInfoQueryAsyncCallback callback, string query, IntPtr userData);

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static extern IntPtr ConnectedStorage_OpenOrCreateContainer(IntPtr self, string containerName);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern void ConnectedStorage_ContainerInfo_Dispose(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern uint ConnectedStorage_ContainerInfo_Length(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern ulong ConnectedStorage_ContainerInfo_TotalSize(IntPtr self, uint idx);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern IntPtr ConnectedStorage_ContainerInfo_Name(IntPtr self, uint idx);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern IntPtr ConnectedStorage_ContainerInfo_DisplayName(IntPtr self, uint idx);

	[PreserveSig]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern bool ConnectedStorage_ContainerInfo_NeedsSync(IntPtr self, uint idx);

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static extern ulong ConnectedStorage_ContainerInfo_LastModifiedTime(IntPtr self, uint idx);

	[PreserveSig]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(ConnectedStorage), Member = "GetNumberOfContainersChangedSinceLastSync")]
	[CalledBy(Type = typeof(ConnectedStorage), Member = "GetContainerChangedSinceLastSync")]
	[CallsUnknownMethods(Count = 1)]
	public static extern uint ConnectedStorage_ContainersChangedSinceLastSync_Size(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern IntPtr ConnectedStorage_ContainersChangedSinceLastSync_Name(IntPtr self, uint idx);

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public ConnectedStoragePlugin()
	{
	}
}
