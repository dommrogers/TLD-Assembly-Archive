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
		[DeduplicatedMethod]
		[CompilerGenerated]
		[CallerCount(Count = 52)]
		get
		{
			return null;
		}
		[CallerCount(Count = 101)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		set
		{
		}
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(ContainerContextPlugin), Member = "ContainerContext_GetAsync")]
	[CalledBy(Type = typeof(ConnectedStorage), Member = "GetAsync")]
	[CallsUnknownMethods(Count = 8)]
	public GetDataMapViewAsyncOp GetAsync(string[] names, GetDataMapViewAsyncOp.GetAsyncCallback callback)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CalledBy(Type = typeof(ConnectedStorage), Member = "ReadAsync")]
	[CallsUnknownMethods(Count = 10)]
	public ReadDataMapAsyncOp ReadAsync(DataMap map, ReadDataMapAsyncOp.ReadAsyncCallback callback)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(ContainerContext), Member = "DeleteAsync")]
	[CalledBy(Type = typeof(ConnectedStorage), Member = "DeleteAsync")]
	[CalledBy(Type = typeof(ConnectedStorage), Member = "SubmitUpdatesAsync")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ContainerContextPlugin), Member = "ContainerContext_SubmitUpdatesAsync")]
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
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(BlobInfoQueryAsyncOp), Member = ".ctor")]
	[CallsUnknownMethods(Count = 10)]
	public BlobInfoQueryAsyncOp QueryBlobInfoAsync(string query, BlobInfoQueryAsyncOp.BlobInfoQueryCallback callback)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Exception), Member = ".ctor")]
	[CallsUnknownMethods(Count = 2)]
	public ContainerContext(IntPtr self, string name)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Dispose()
	{
	}

	[UnityAOT.MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GCHandle), Member = "op_Explicit")]
	[Calls(Type = typeof(GCHandle), Member = "get_Target")]
	[Calls(Type = typeof(GetDataMapViewAsyncOp), Member = "Complete")]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[Calls(Type = typeof(StorageLog), Member = "LogCallbackException")]
	private static void GetAsyncThunk(uint result, IntPtr map, IntPtr userData)
	{
	}

	[Calls(Type = typeof(StorageLog), Member = "LogCallbackException")]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[Calls(Type = typeof(GCHandle), Member = "op_Explicit")]
	[Calls(Type = typeof(GCHandle), Member = "get_Target")]
	[CallerCount(Count = 0)]
	[UnityAOT.MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallsDeduplicatedMethods(Count = 4)]
	private static void ReadAsyncThunk(uint result, IntPtr map, IntPtr userData)
	{
	}

	[UnityAOT.MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(GCHandle), Member = "op_Explicit")]
	[Calls(Type = typeof(GCHandle), Member = "get_Target")]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[Calls(Type = typeof(StorageLog), Member = "LogCallbackException")]
	private static void SubmitUpdatesAsyncThunk(uint result, uint status, IntPtr userData)
	{
	}

	[Calls(Type = typeof(BlobInfoQueryAsyncOp), Member = "Complete")]
	[Calls(Type = typeof(StorageLog), Member = "LogCallbackException")]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[Calls(Type = typeof(GCHandle), Member = "get_Target")]
	[Calls(Type = typeof(GCHandle), Member = "op_Explicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[UnityAOT.MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	private static void BlobInfoQueryAsyncThunk(uint result, IntPtr queryHandle, IntPtr userData, uint totalResults)
	{
	}
}
