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
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		remove
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(CommonPlugin), Member = "AmFullyInitialized")]
	[Calls(Type = typeof(GCHandle), Member = ".ctor")]
	[Calls(Type = typeof(Exception), Member = ".ctor")]
	[Calls(Type = typeof(Exception), Member = ".ctor")]
	[CallsUnknownMethods(Count = 21)]
	public static TitleStorage Create(int userId, TitleStorageTypes type = TitleStorageTypes.TrustedPlatformStorage, string configurationId = null)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(AsyncQuotaOp), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public AsyncQuotaOp RequestQuotaAsync(AsyncQuotaOp.QuotaRequestDelegate callback = null)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(SaveLoadOp), Member = ".ctor")]
	[CallsUnknownMethods(Count = 8)]
	public SaveLoadOp UploadFileAsync(string filename, byte[] data, SaveLoadOp.SaveLoadDelegate callback)
	{
		return null;
	}

	[Calls(Type = typeof(TitleStoragePlugin), Member = "TitleStorage_Download")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SaveLoadOp), Member = ".ctor")]
	[CallsUnknownMethods(Count = 6)]
	public SaveLoadOp DownloadFileAsync(string filename, byte[] buffer, SaveLoadOp.SaveLoadDelegate callback)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(TitleStoragePlugin), Member = "TitleStorage_Download")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SaveLoadOp), Member = ".ctor")]
	public SaveLoadOp DownloadFileAsync(string targetXuid, string filename, byte[] buffer, SaveLoadOp.SaveLoadDelegate callback)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public DeleteFileOp DeleteFileAsync(string filename, DeleteFileOp.DeleteFileDelegate callback)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GCHandle), Member = ".ctor")]
	[CallsUnknownMethods(Count = 2)]
	private TitleStorage(IntPtr self)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Dispose()
	{
	}

	[UnityAOT.MonoPInvokeCallback(typeof(TitleStoragePlugin.TitleStorageQuotaCallback))]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GCHandle), Member = "op_Explicit")]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[Calls(Type = typeof(StorageLog), Member = "LogCallbackException")]
	[CallsUnknownMethods(Count = 13)]
	private static void QuotaRequestThunk(uint result, ulong outTotalBytes, IntPtr userData, ulong outUsedBytes)
	{
	}

	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(StorageLog), Member = "LogCallbackException")]
	[Calls(Type = typeof(GCHandle), Member = "op_Explicit")]
	[CallerCount(Count = 0)]
	[UnityAOT.MonoPInvokeCallback(typeof(TitleStoragePlugin.TitleStorageSaveLoadCallback))]
	[CallsDeduplicatedMethods(Count = 3)]
	private static void SaveLoadRequestThunk(uint result, uint size, IntPtr userData)
	{
	}

	[UnityAOT.MonoPInvokeCallback(typeof(TitleStoragePlugin.TitleStorageDeleteCallback))]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GCHandle), Member = "op_Explicit")]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[Calls(Type = typeof(StorageLog), Member = "LogCallbackException")]
	[CallsUnknownMethods(Count = 7)]
	private static void DeleteRequestThunk(uint result, int ok, IntPtr userData)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(StorageLog), Member = "LogCallbackException")]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[UnityAOT.MonoPInvokeCallback(typeof(TitleStoragePlugin.TitleStorageUserSignedOutStorageInvalidCallback))]
	[Calls(Type = typeof(GCHandle), Member = "op_Explicit")]
	private static void UserSignedOutInvalidThunk(uint userId, IntPtr userData)
	{
	}
}
