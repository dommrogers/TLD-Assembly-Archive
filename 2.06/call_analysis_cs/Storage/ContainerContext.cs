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
		[CallerCount(Count = 98)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 265)]
		set
		{
		}
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ContainerContextPlugin), Member = "ContainerContext_GetAsync")]
	[CalledBy(Type = typeof(ConnectedStorage), Member = "GetAsync")]
	[CallsUnknownMethods(Count = 6)]
	public GetDataMapViewAsyncOp GetAsync(string[] names, GetDataMapViewAsyncOp.GetAsyncCallback callback)
	{
		return null;
	}

	[CalledBy(Type = typeof(ConnectedStorage), Member = "ReadAsync")]
	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	public ReadDataMapAsyncOp ReadAsync(DataMap map, ReadDataMapAsyncOp.ReadAsyncCallback callback)
	{
		return null;
	}

	[CalledBy(Type = typeof(ContainerContext), Member = "DeleteAsync")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ContainerContextPlugin), Member = "ContainerContext_SubmitUpdatesAsync")]
	[CalledBy(Type = typeof(ConnectedStorage), Member = "SubmitUpdatesAsync")]
	[CalledBy(Type = typeof(ConnectedStorage), Member = "DeleteAsync")]
	[CallsUnknownMethods(Count = 6)]
	public SubmitDataMapUpdatesAsyncOp SubmitUpdatesAsync(DataMap toUpdate, string[] toDelete, SubmitDataMapUpdatesAsyncOp.UpdateAsyncCallback callback, string displayName = null)
	{
		return null;
	}

	[Calls(Type = typeof(ContainerContext), Member = "SubmitUpdatesAsync")]
	[CallerCount(Count = 0)]
	public SubmitDataMapUpdatesAsyncOp DeleteAsync(string[] toDelete, SubmitDataMapUpdatesAsyncOp.UpdateAsyncCallback callback, string displayName = null)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public BlobInfoQueryAsyncOp QueryBlobInfoAsync(string query, BlobInfoQueryAsyncOp.BlobInfoQueryCallback callback)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Exception), Member = ".ctor")]
	[CallsUnknownMethods(Count = 6)]
	public ContainerContext(IntPtr self, string name)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Dispose()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(StorageLog), Member = "LogCallbackException")]
	[Calls(Type = typeof(GetDataMapViewAsyncOp), Member = "Complete")]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[UnityAOT.MonoPInvokeCallback(typeof(ObjectResultCallback))]
	[Calls(Type = typeof(GCHandle), Member = "op_Explicit")]
	private static void GetAsyncThunk(uint result, IntPtr map, IntPtr userData)
	{
	}

	[UnityAOT.MonoPInvokeCallback(typeof(ObjectResultCallback))]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GCHandle), Member = "op_Explicit")]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[Calls(Type = typeof(StorageLog), Member = "LogCallbackException")]
	[CallsUnknownMethods(Count = 7)]
	private static void ReadAsyncThunk(uint result, IntPtr map, IntPtr userData)
	{
	}

	[Calls(Type = typeof(StorageLog), Member = "LogCallbackException")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[UnityAOT.MonoPInvokeCallback(typeof(GenericActionCallback))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "op_Explicit")]
	private static void SubmitUpdatesAsyncThunk(uint result, uint status, IntPtr userData)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[Calls(Type = typeof(BlobInfoQueryAsyncOp), Member = "Complete")]
	[Calls(Type = typeof(StorageLog), Member = "LogCallbackException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[UnityAOT.MonoPInvokeCallback(typeof(ContainerContextPlugin.BlobInfoQueryAsyncCallback))]
	[Calls(Type = typeof(GCHandle), Member = "op_Explicit")]
	private static void BlobInfoQueryAsyncThunk(uint result, IntPtr queryHandle, IntPtr userData, uint totalResults)
	{
	}
}
