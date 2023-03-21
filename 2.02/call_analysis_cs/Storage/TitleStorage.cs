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
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommonPlugin), Member = "AmFullyInitialized")]
	[Calls(Type = typeof(Exception), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 15)]
	public static TitleStorage Create(int userId, TitleStorageTypes type = TitleStorageTypes.TrustedPlatformStorage, string configurationId = null)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncQuotaOp), Member = ".ctor")]
	[Calls(Type = typeof(AsyncOp<>), Member = "GetHandle")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	public AsyncQuotaOp RequestQuotaAsync(AsyncQuotaOp.QuotaRequestDelegate callback = null)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveLoadOp), Member = ".ctor")]
	[Calls(Type = typeof(AsyncOp<>), Member = "GetHandle")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	public SaveLoadOp UploadFileAsync(string filename, byte[] data, SaveLoadOp.SaveLoadDelegate callback)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveLoadOp), Member = ".ctor")]
	[Calls(Type = typeof(AsyncOp<>), Member = "GetHandle")]
	[Calls(Type = typeof(TitleStoragePlugin), Member = "TitleStorage_Download")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public SaveLoadOp DownloadFileAsync(string filename, byte[] buffer, SaveLoadOp.SaveLoadDelegate callback)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveLoadOp), Member = ".ctor")]
	[Calls(Type = typeof(AsyncOp<>), Member = "GetHandle")]
	[Calls(Type = typeof(TitleStoragePlugin), Member = "TitleStorage_Download")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public SaveLoadOp DownloadFileAsync(string targetXuid, string filename, byte[] buffer, SaveLoadOp.SaveLoadDelegate callback)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncOp<>), Member = "GetHandle")]
	[CallsDeduplicatedMethods(Count = 3)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "Free")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void Dispose()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "op_Explicit")]
	[Calls(Type = typeof(GCHandle), Member = "get_Target")]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[Calls(Type = typeof(StorageLog), Member = "LogCallbackException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	private static void QuotaRequestThunk(uint result, ulong outTotalBytes, IntPtr userData, ulong outUsedBytes)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "op_Explicit")]
	[Calls(Type = typeof(GCHandle), Member = "get_Target")]
	[Calls(Type = typeof(SaveLoadOp.SaveLoadDelegate), Member = "Invoke")]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[Calls(Type = typeof(StorageLog), Member = "LogCallbackException")]
	[CallsDeduplicatedMethods(Count = 3)]
	private static void SaveLoadRequestThunk(uint result, uint size, IntPtr userData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "op_Explicit")]
	[Calls(Type = typeof(GCHandle), Member = "get_Target")]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[Calls(Type = typeof(StorageLog), Member = "LogCallbackException")]
	[CallsDeduplicatedMethods(Count = 4)]
	private static void DeleteRequestThunk(uint result, int ok, IntPtr userData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "op_Explicit")]
	[Calls(Type = typeof(GCHandle), Member = "get_Target")]
	[Calls(Type = typeof(UnityPlugin.Utils), Member = "FormatException")]
	[Calls(Type = typeof(StorageLog), Member = "LogCallbackException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private static void UserSignedOutInvalidThunk(uint userId, IntPtr userData)
	{
	}
}
