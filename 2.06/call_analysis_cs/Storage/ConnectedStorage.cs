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
			return default(bool);
		}
	}

	public int GetMaxQuotaForStorage
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
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
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		remove
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Exception), Member = ".ctor")]
	[CallsUnknownMethods(Count = 17)]
	public static CreateConnectedStorageOp CreateAsync(int userId, string containerName, CreateConnectedStorageOp.ConnectedStorageInitializedCallback callback, ConnectedStorageCreationFlags flags = (ConnectedStorageCreationFlags)0, string serviceConfigurationId = null)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(DeleteContainerAsyncOp), Member = ".ctor")]
	[Calls(Type = typeof(ConnectedStoragePlugin), Member = "ConnectedStorage_DeleteContainer")]
	[CalledBy(Type = typeof(ConnectedStorage), Member = "DeleteContainer")]
	[CallsUnknownMethods(Count = 7)]
	public DeleteContainerAsyncOp DeleteThisContainer(DeleteContainerAsyncOp.DeleteContainerAsyncCallback callback)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(ConnectedStoragePlugin), Member = "ConnectedStorage_DeleteContainer")]
	[Calls(Type = typeof(DeleteContainerAsyncOp), Member = ".ctor")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConnectedStorage), Member = "DeleteThisContainer")]
	public DeleteContainerAsyncOp DeleteContainer(string containerName, DeleteContainerAsyncOp.DeleteContainerAsyncCallback callback)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	public QueryRemainingQuotaAsyncOp QueryRemainingQuotaAsync(QueryRemainingQuotaAsyncOp.QueryAsyncCallback callback)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	public ContainerInfoQueryAsyncOp QueryContainerInfoAsync(string query, ContainerInfoQueryAsyncOp.ContainerInfoQueryCallback callback)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(CreateConnectedStorageOp), Member = "Complete")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(ConnectedStorage), Member = "SetActiveContainer")]
	public ContainerContext OpenOrCreateContainer(string containerName)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 21)]
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
		return default(uint);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(ConnectedStoragePlugin), Member = "ConnectedStorage_ContainersChangedSinceLastSync_Size")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContainerContext), Member = "SubmitUpdatesAsync")]
	public SubmitDataMapUpdatesAsyncOp SubmitUpdatesAsync(DataMap toUpdate, string[] toDelete, SubmitDataMapUpdatesAsyncOp.UpdateAsyncCallback callback, string displayName = null)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ContainerContext), Member = "SubmitUpdatesAsync")]
	[CallerCount(Count = 0)]
	public SubmitDataMapUpdatesAsyncOp DeleteAsync(string[] toDelete, SubmitDataMapUpdatesAsyncOp.UpdateAsyncCallback callback, string displayName = null)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GCHandle), Member = ".ctor")]
	[CalledBy(Type = typeof(CreateConnectedStorageOp), Member = "Complete")]
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

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(StorageLog), Member = "LogCallbackException")]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[Calls(Type = typeof(CreateConnectedStorageOp), Member = "Complete")]
	[UnityAOT.MonoPInvokeCallback(typeof(ObjectResultCallback))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "op_Explicit")]
	private static void InitializedThunk(uint result, IntPtr self, IntPtr userData)
	{
	}

	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[Calls(Type = typeof(StorageLog), Member = "LogCallbackException")]
	[Calls(Type = typeof(GCHandle), Member = "op_Explicit")]
	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[UnityAOT.MonoPInvokeCallback(typeof(ConnectedStoragePlugin.UserSignedOutStorageInvalidCallback))]
	[CallsDeduplicatedMethods(Count = 2)]
	private static void OnUserSignedOutThunk(uint userId, IntPtr userData)
	{
	}

	[UnityAOT.MonoPInvokeCallback(typeof(GenericActionCallback))]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GCHandle), Member = "op_Explicit")]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[Calls(Type = typeof(StorageLog), Member = "LogCallbackException")]
	[CallsUnknownMethods(Count = 7)]
	private static void DeleteContainerAsyncThunk(uint result, uint status, IntPtr userData)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(StorageLog), Member = "LogCallbackException")]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[Calls(Type = typeof(QueryRemainingQuotaAsyncOp), Member = "Complete")]
	[Calls(Type = typeof(GCHandle), Member = "op_Explicit")]
	[CallerCount(Count = 0)]
	[UnityAOT.MonoPInvokeCallback(typeof(ConnectedStoragePlugin.QueryRemainingQuotaAsyncCallback))]
	[CallsDeduplicatedMethods(Count = 2)]
	private static void QueryRemainingQuotaAsyncThunk(uint result, long quota, IntPtr userData)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[UnityAOT.MonoPInvokeCallback(typeof(ConnectedStoragePlugin.ContainerInfoQueryAsyncCallback))]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GCHandle), Member = "op_Explicit")]
	[Calls(Type = typeof(ContainerInfoQueryAsyncOp), Member = "Complete")]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[Calls(Type = typeof(StorageLog), Member = "LogCallbackException")]
	private static void ContainerInfoQueryAsyncThunk(uint result, IntPtr queryHandle, IntPtr userData, uint totalResults)
	{
	}
}
