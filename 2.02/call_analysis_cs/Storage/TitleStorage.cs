using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;
using UnityAOT;
using UnityPlugin;

namespace Storage;

public class TitleStorage : IDisposable
{
	public delegate void OnUserSignedOutDelegate(uint userId, TitleStorage self);

	private bool AmSignedIn;

	private bool RequireUser;

	private IntPtr m_Self;

	private GCHandle m_Handle;

	private static TitleStoragePlugin.TitleStorageSaveLoadCallback gSaveLoadThunk;

	private static TitleStoragePlugin.TitleStorageQuotaCallback gQuotaThunk;

	private static TitleStoragePlugin.TitleStorageDeleteCallback gDeleteThunk;

	private static TitleStoragePlugin.TitleStorageUserSignedOutStorageInvalidCallback gUserSignedOutInvalidThunk;

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

	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(Exception), Member = ".ctor")]
	[Calls(Type = typeof(Exception), Member = ".ctor")]
	[Calls(Type = typeof(CommonPlugin), Member = "AmFullyInitialized")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	public static TitleStorage Create(int userId, TitleStorageTypes type = TitleStorageTypes.TrustedPlatformStorage, string configurationId = null)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(AsyncQuotaOp), Member = ".ctor")]
	[CallsUnknownMethods(Count = 10)]
	public AsyncQuotaOp RequestQuotaAsync(AsyncQuotaOp.QuotaRequestDelegate callback = null)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(SaveLoadOp), Member = ".ctor")]
	[CallsUnknownMethods(Count = 11)]
	public SaveLoadOp UploadFileAsync(string filename, byte[] data, SaveLoadOp.SaveLoadDelegate callback)
	{
		return null;
	}

	[Calls(Type = typeof(TitleStoragePlugin), Member = "TitleStorage_Download")]
	[Calls(Type = typeof(SaveLoadOp), Member = ".ctor")]
	[CallsUnknownMethods(Count = 9)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public SaveLoadOp DownloadFileAsync(string filename, byte[] buffer, SaveLoadOp.SaveLoadDelegate callback)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(SaveLoadOp), Member = ".ctor")]
	[Calls(Type = typeof(TitleStoragePlugin), Member = "TitleStorage_Download")]
	[CallsUnknownMethods(Count = 9)]
	public SaveLoadOp DownloadFileAsync(string targetXuid, string filename, byte[] buffer, SaveLoadOp.SaveLoadDelegate callback)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 10)]
	public DeleteFileOp DeleteFileAsync(string filename, DeleteFileOp.DeleteFileDelegate callback)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private TitleStorage(IntPtr self)
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
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(GCHandle), Member = "op_Explicit")]
	[Calls(Type = typeof(GCHandle), Member = "get_Target")]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[Calls(Type = typeof(StorageLog), Member = "LogCallbackException")]
	[CallsUnknownMethods(Count = 7)]
	private static void QuotaRequestThunk(uint result, ulong outTotalBytes, IntPtr userData, ulong outUsedBytes)
	{
	}

	[Calls(Type = typeof(SaveLoadOp.SaveLoadDelegate), Member = "Invoke")]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[Calls(Type = typeof(StorageLog), Member = "LogCallbackException")]
	[Calls(Type = typeof(GCHandle), Member = "get_Target")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[UnityAOT.MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[Calls(Type = typeof(GCHandle), Member = "op_Explicit")]
	private static void SaveLoadRequestThunk(uint result, uint size, IntPtr userData)
	{
	}

	[UnityAOT.MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(GCHandle), Member = "op_Explicit")]
	[Calls(Type = typeof(GCHandle), Member = "get_Target")]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[Calls(Type = typeof(StorageLog), Member = "LogCallbackException")]
	private static void DeleteRequestThunk(uint result, int ok, IntPtr userData)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(StorageLog), Member = "LogCallbackException")]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[Calls(Type = typeof(GCHandle), Member = "get_Target")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[UnityAOT.MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[Calls(Type = typeof(GCHandle), Member = "op_Explicit")]
	private static void UserSignedOutInvalidThunk(uint userId, IntPtr userData)
	{
	}
}
