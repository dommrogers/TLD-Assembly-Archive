using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;
using UnityAOT;
using UnityPlugin;

namespace Storage;

public class ContainerContext : IDisposable
{
	private string _003CName_003Ek__BackingField;

	private IntPtr m_Self;

	private static ObjectResultCallback gGetAsyncThunk;

	private static ObjectResultCallback gReadAsyncThunk;

	private static GenericActionCallback gSubmitUpdatesThunk;

	private static ContainerContextPlugin.BlobInfoQueryAsyncCallback gBlobInfoQueryThunk;

	public string Name
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 59)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 103)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(ConnectedStorage), Member = "GetAsync")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncOp<>), Member = "GetHandle")]
	[Calls(Type = typeof(ContainerContextPlugin), Member = "ContainerContext_GetAsync")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	public GetDataMapViewAsyncOp GetAsync(string[] names, GetDataMapViewAsyncOp.GetAsyncCallback callback)
	{
		return null;
	}

	[CalledBy(Type = typeof(ConnectedStorage), Member = "ReadAsync")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncOp<>), Member = "GetHandle")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 10)]
	public ReadDataMapAsyncOp ReadAsync(DataMap map, ReadDataMapAsyncOp.ReadAsyncCallback callback)
	{
		return null;
	}

	[CalledBy(Type = typeof(ConnectedStorage), Member = "SubmitUpdatesAsync")]
	[CalledBy(Type = typeof(ConnectedStorage), Member = "DeleteAsync")]
	[CalledBy(Type = typeof(ContainerContext), Member = "DeleteAsync")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AsyncOp<>), Member = "GetHandle")]
	[Calls(Type = typeof(ContainerContextPlugin), Member = "ContainerContext_SubmitUpdatesAsync")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	public SubmitDataMapUpdatesAsyncOp SubmitUpdatesAsync(DataMap toUpdate, string[] toDelete, SubmitDataMapUpdatesAsyncOp.UpdateAsyncCallback callback, string displayName = null)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContainerContext), Member = "SubmitUpdatesAsync")]
	public SubmitDataMapUpdatesAsyncOp DeleteAsync(string[] toDelete, SubmitDataMapUpdatesAsyncOp.UpdateAsyncCallback callback, string displayName = null)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BlobInfoQueryAsyncOp), Member = ".ctor")]
	[Calls(Type = typeof(AsyncOp<>), Member = "GetHandle")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	public BlobInfoQueryAsyncOp QueryBlobInfoAsync(string query, BlobInfoQueryAsyncOp.BlobInfoQueryCallback callback)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Exception), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public ContainerContext(IntPtr self, string name)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void Dispose()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "op_Explicit")]
	[Calls(Type = typeof(GCHandle), Member = "get_Target")]
	[Calls(Type = typeof(GetDataMapViewAsyncOp), Member = "Complete")]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[Calls(Type = typeof(StorageLog), Member = "LogCallbackException")]
	[CallsDeduplicatedMethods(Count = 2)]
	private static void GetAsyncThunk(uint result, IntPtr map, IntPtr userData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "op_Explicit")]
	[Calls(Type = typeof(GCHandle), Member = "get_Target")]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[Calls(Type = typeof(StorageLog), Member = "LogCallbackException")]
	[CallsDeduplicatedMethods(Count = 4)]
	private static void ReadAsyncThunk(uint result, IntPtr map, IntPtr userData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "op_Explicit")]
	[Calls(Type = typeof(GCHandle), Member = "get_Target")]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[Calls(Type = typeof(StorageLog), Member = "LogCallbackException")]
	[CallsDeduplicatedMethods(Count = 4)]
	private static void SubmitUpdatesAsyncThunk(uint result, uint status, IntPtr userData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "op_Explicit")]
	[Calls(Type = typeof(GCHandle), Member = "get_Target")]
	[Calls(Type = typeof(BlobInfoQueryAsyncOp), Member = "Complete")]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[Calls(Type = typeof(StorageLog), Member = "LogCallbackException")]
	[CallsDeduplicatedMethods(Count = 2)]
	private static void BlobInfoQueryAsyncThunk(uint result, IntPtr queryHandle, IntPtr userData, uint totalResults)
	{
	}
}
