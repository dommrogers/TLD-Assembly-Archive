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
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(Exception), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(CreateConnectedStorageOp), Member = ".ctor")]
	public static CreateConnectedStorageOp CreateAsync(int userId, string containerName, CreateConnectedStorageOp.ConnectedStorageInitializedCallback callback, ConnectedStorageCreationFlags flags = (ConnectedStorageCreationFlags)0, string serviceConfigurationId = null)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(DeleteContainerAsyncOp), Member = ".ctor")]
	[Calls(Type = typeof(ConnectedStoragePlugin), Member = "ConnectedStorage_DeleteContainer")]
	[CalledBy(Type = typeof(ConnectedStorage), Member = "DeleteContainer")]
	[CallsUnknownMethods(Count = 12)]
	public DeleteContainerAsyncOp DeleteThisContainer(DeleteContainerAsyncOp.DeleteContainerAsyncCallback callback)
	{
		return null;
	}

	[Calls(Type = typeof(DeleteContainerAsyncOp), Member = ".ctor")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(ConnectedStorage), Member = "DeleteThisContainer")]
	[Calls(Type = typeof(ConnectedStoragePlugin), Member = "ConnectedStorage_DeleteContainer")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	public DeleteContainerAsyncOp DeleteContainer(string containerName, DeleteContainerAsyncOp.DeleteContainerAsyncCallback callback)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 10)]
	public QueryRemainingQuotaAsyncOp QueryRemainingQuotaAsync(QueryRemainingQuotaAsyncOp.QueryAsyncCallback callback)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(ContainerInfoQueryAsyncOp), Member = ".ctor")]
	[CallsUnknownMethods(Count = 10)]
	public ContainerInfoQueryAsyncOp QueryContainerInfoAsync(string query, ContainerInfoQueryAsyncOp.ContainerInfoQueryCallback callback)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CalledBy(Type = typeof(ConnectedStorage), Member = "SetActiveContainer")]
	[CalledBy(Type = typeof(CreateConnectedStorageOp), Member = "Complete")]
	[CallsUnknownMethods(Count = 10)]
	public ContainerContext OpenOrCreateContainer(string containerName)
	{
		return null;
	}

	[CallerCount(Count = 20)]
	[DeduplicatedMethod]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ConnectedStoragePlugin), Member = "ConnectedStorage_ContainersChangedSinceLastSync_Size")]
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
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ContainerContext), Member = "ReadAsync")]
	public ReadDataMapAsyncOp ReadAsync(DataMap map, ReadDataMapAsyncOp.ReadAsyncCallback callback)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ContainerContext), Member = "SubmitUpdatesAsync")]
	[CallerCount(Count = 0)]
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

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(CreateConnectedStorageOp), Member = "Complete")]
	[CallsUnknownMethods(Count = 11)]
	public ConnectedStorage(IntPtr self, int userId)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GCHandle), Member = "Free")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void Dispose()
	{
	}

	[UnityAOT.MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GCHandle), Member = "op_Explicit")]
	[Calls(Type = typeof(GCHandle), Member = "get_Target")]
	[Calls(Type = typeof(CreateConnectedStorageOp), Member = "Complete")]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[Calls(Type = typeof(StorageLog), Member = "LogCallbackException")]
	private static void InitializedThunk(uint result, IntPtr self, IntPtr userData)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(StorageLog), Member = "LogCallbackException")]
	[Calls(Type = typeof(GCHandle), Member = "get_Target")]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[UnityAOT.MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[Calls(Type = typeof(GCHandle), Member = "op_Explicit")]
	private static void OnUserSignedOutThunk(uint userId, IntPtr userData)
	{
	}

	[UnityAOT.MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(GCHandle), Member = "op_Explicit")]
	[Calls(Type = typeof(GCHandle), Member = "get_Target")]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[Calls(Type = typeof(StorageLog), Member = "LogCallbackException")]
	private static void DeleteContainerAsyncThunk(uint result, uint status, IntPtr userData)
	{
	}

	[Calls(Type = typeof(StorageLog), Member = "LogCallbackException")]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[Calls(Type = typeof(QueryRemainingQuotaAsyncOp), Member = "Complete")]
	[Calls(Type = typeof(GCHandle), Member = "get_Target")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[UnityAOT.MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[Calls(Type = typeof(GCHandle), Member = "op_Explicit")]
	private static void QueryRemainingQuotaAsyncThunk(uint result, long quota, IntPtr userData)
	{
	}

	[Calls(Type = typeof(StorageLog), Member = "LogCallbackException")]
	[UnityAOT.MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GCHandle), Member = "op_Explicit")]
	[Calls(Type = typeof(GCHandle), Member = "get_Target")]
	[Calls(Type = typeof(ContainerInfoQueryAsyncOp), Member = "Complete")]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	private static void ContainerInfoQueryAsyncThunk(uint result, IntPtr queryHandle, IntPtr userData, uint totalResults)
	{
	}
}
