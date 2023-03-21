using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;
using UnityAOT;
using UnityPlugin;

namespace Storage;

public class ConnectedStorage : IDisposable
{
	public delegate void OnUserSignedOutDelegate(uint userId, ConnectedStorage self);

	public bool AmSignedIn;

	public int UserId;

	private IntPtr m_Self;

	private GCHandle m_Handle;

	private ContainerContext m_ActiveContainer;

	private Dictionary<string, ContainerContext> m_KnownContainers;

	private static ObjectResultCallback gInitializedThunk;

	private static ConnectedStoragePlugin.ContainerInfoQueryAsyncCallback gContainerInfoQueryThunk;

	private static ConnectedStoragePlugin.QueryRemainingQuotaAsyncCallback gQueryRemainingQuotaThunk;

	private static ConnectedStoragePlugin.UserSignedOutStorageInvalidCallback gUserSignedOutThunk;

	private static GenericActionCallback gDeleteContainerThunk;

	public bool IsMachineStorage
	{
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
	}

	public int GetMaxQuotaForStorage
	{
		[CallerCount(Count = 0)]
		get
		{
			return 0;
		}
	}

	public event OnUserSignedOutDelegate OnUserSignedOut
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncOp<>), Member = "GetHandle")]
	[Calls(Type = typeof(Exception), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 17)]
	public static CreateConnectedStorageOp CreateAsync(int userId, string containerName, CreateConnectedStorageOp.ConnectedStorageInitializedCallback callback, ConnectedStorageCreationFlags flags = (ConnectedStorageCreationFlags)0, string serviceConfigurationId = null)
	{
		return null;
	}

	[CalledBy(Type = typeof(ConnectedStorage), Member = "DeleteContainer")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DeleteContainerAsyncOp), Member = ".ctor")]
	[Calls(Type = typeof(AsyncOp<>), Member = "GetHandle")]
	[Calls(Type = typeof(ConnectedStoragePlugin), Member = "ConnectedStorage_DeleteContainer")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public DeleteContainerAsyncOp DeleteThisContainer(DeleteContainerAsyncOp.DeleteContainerAsyncCallback callback)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(ConnectedStorage), Member = "DeleteThisContainer")]
	[Calls(Type = typeof(DeleteContainerAsyncOp), Member = ".ctor")]
	[Calls(Type = typeof(AsyncOp<>), Member = "GetHandle")]
	[Calls(Type = typeof(ConnectedStoragePlugin), Member = "ConnectedStorage_DeleteContainer")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public DeleteContainerAsyncOp DeleteContainer(string containerName, DeleteContainerAsyncOp.DeleteContainerAsyncCallback callback)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncOp<>), Member = "GetHandle")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public QueryRemainingQuotaAsyncOp QueryRemainingQuotaAsync(QueryRemainingQuotaAsyncOp.QueryAsyncCallback callback)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncOp<>), Member = "GetHandle")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public ContainerInfoQueryAsyncOp QueryContainerInfoAsync(string query, ContainerInfoQueryAsyncOp.ContainerInfoQueryCallback callback)
	{
		return null;
	}

	[CalledBy(Type = typeof(ConnectedStorage), Member = "SetActiveContainer")]
	[CalledBy(Type = typeof(CreateConnectedStorageOp), Member = "Complete")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public ContainerContext OpenOrCreateContainer(string containerName)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 25)]
	public void SetActiveContainer(ContainerContext context)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConnectedStorage), Member = "OpenOrCreateContainer")]
	public void SetActiveContainer(string name)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConnectedStoragePlugin), Member = "ConnectedStorage_ContainersChangedSinceLastSync_Size")]
	public uint GetNumberOfContainersChangedSinceLastSync()
	{
		return 0u;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConnectedStoragePlugin), Member = "ConnectedStorage_ContainersChangedSinceLastSync_Size")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public string GetContainerChangedSinceLastSync(uint idx)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContainerContext), Member = "GetAsync")]
	[CallsUnknownMethods(Count = 1)]
	public GetDataMapViewAsyncOp GetAsync(string[] names, GetDataMapViewAsyncOp.GetAsyncCallback callback)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContainerContext), Member = "ReadAsync")]
	[CallsUnknownMethods(Count = 1)]
	public ReadDataMapAsyncOp ReadAsync(DataMap map, ReadDataMapAsyncOp.ReadAsyncCallback callback)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContainerContext), Member = "SubmitUpdatesAsync")]
	[CallsUnknownMethods(Count = 1)]
	public SubmitDataMapUpdatesAsyncOp SubmitUpdatesAsync(DataMap toUpdate, string[] toDelete, SubmitDataMapUpdatesAsyncOp.UpdateAsyncCallback callback, string displayName = null)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContainerContext), Member = "SubmitUpdatesAsync")]
	[CallsUnknownMethods(Count = 1)]
	public SubmitDataMapUpdatesAsyncOp DeleteAsync(string[] toDelete, SubmitDataMapUpdatesAsyncOp.UpdateAsyncCallback callback, string displayName = null)
	{
		return null;
	}

	[CalledBy(Type = typeof(CreateConnectedStorageOp), Member = "Complete")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GCHandle), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public ConnectedStorage(IntPtr self, int userId)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public void Dispose()
	{
	}

	[UnityAOT.MonoPInvokeCallback(typeof(ObjectResultCallback))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "op_Explicit")]
	[Calls(Type = typeof(CreateConnectedStorageOp), Member = "Complete")]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[Calls(Type = typeof(StorageLog), Member = "LogCallbackException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private static void InitializedThunk(uint result, IntPtr self, IntPtr userData)
	{
	}

	[UnityAOT.MonoPInvokeCallback(typeof(ConnectedStoragePlugin.UserSignedOutStorageInvalidCallback))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "op_Explicit")]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[Calls(Type = typeof(StorageLog), Member = "LogCallbackException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	private static void OnUserSignedOutThunk(uint userId, IntPtr userData)
	{
	}

	[UnityAOT.MonoPInvokeCallback(typeof(GenericActionCallback))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "op_Explicit")]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[Calls(Type = typeof(StorageLog), Member = "LogCallbackException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	private static void DeleteContainerAsyncThunk(uint result, uint status, IntPtr userData)
	{
	}

	[UnityAOT.MonoPInvokeCallback(typeof(ConnectedStoragePlugin.QueryRemainingQuotaAsyncCallback))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "op_Explicit")]
	[Calls(Type = typeof(QueryRemainingQuotaAsyncOp), Member = "Complete")]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[Calls(Type = typeof(StorageLog), Member = "LogCallbackException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private static void QueryRemainingQuotaAsyncThunk(uint result, long quota, IntPtr userData)
	{
	}

	[UnityAOT.MonoPInvokeCallback(typeof(ConnectedStoragePlugin.ContainerInfoQueryAsyncCallback))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "op_Explicit")]
	[Calls(Type = typeof(ContainerInfoQueryAsyncOp), Member = "Complete")]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[Calls(Type = typeof(StorageLog), Member = "LogCallbackException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private static void ContainerInfoQueryAsyncThunk(uint result, IntPtr queryHandle, IntPtr userData, uint totalResults)
	{
	}
}
