using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.PlayerDataStorage;

public sealed class PlayerDataStorageInterface : Handle
{
	public const int CopyfilemetadataatindexoptionsApiLatest = 1;

	public const int CopyfilemetadatabyfilenameoptionsApiLatest = 1;

	public const int DeletecacheoptionsApiLatest = 1;

	public const int DeletefileoptionsApiLatest = 1;

	public const int DuplicatefileoptionsApiLatest = 1;

	public const int FileMaxSizeBytes = 67108864;

	public const int FilemetadataApiLatest = 1;

	public const int FilenameMaxLengthBytes = 64;

	public const int GetfilemetadatacountoptionsApiLatest = 1;

	public const int QueryfilelistoptionsApiLatest = 1;

	public const int QueryfileoptionsApiLatest = 1;

	public const int ReadfileoptionsApiLatest = 1;

	public const int WritefileoptionsApiLatest = 1;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public PlayerDataStorageInterface()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public PlayerDataStorageInterface(IntPtr innerHandle)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(CopyFileMetadataAtIndexOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(PlayerDataStorageInterface), Member = "EOS_PlayerDataStorage_FileMetadata_Release")]
	[CallsUnknownMethods(Count = 1)]
	public Result CopyFileMetadataAtIndex(CopyFileMetadataAtIndexOptions copyFileMetadataOptions, out FileMetadata outMetadata)
	{
		outMetadata = null;
		return default(Result);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PlayerDataStorageInterface), Member = "EOS_PlayerDataStorage_FileMetadata_Release")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyFileMetadataByFilenameOptionsInternal), Member = "Set")]
	public Result CopyFileMetadataByFilename(CopyFileMetadataByFilenameOptions copyFileMetadataOptions, out FileMetadata outMetadata)
	{
		outMetadata = null;
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(DeleteCacheOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 9)]
	public Result DeleteCache(DeleteCacheOptions options, object clientData, OnDeleteCacheCompleteCallback completionCallback)
	{
		return default(Result);
	}

	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DeleteFileOptionsInternal), Member = "Set")]
	public void DeleteFile(DeleteFileOptions deleteOptions, object clientData, OnDeleteFileCompleteCallback completionCallback)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(DuplicateFileOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 9)]
	public void DuplicateFile(DuplicateFileOptions duplicateOptions, object clientData, OnDuplicateFileCompleteCallback completionCallback)
	{
	}

	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(GetFileMetadataCountOptionsInternal), Member = "Set")]
	[CallsUnknownMethods(Count = 1)]
	public Result GetFileMetadataCount(GetFileMetadataCountOptions getFileMetadataCountOptions, out int outFileMetadataCount)
	{
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref outFileMetadataCount) = null;
		return default(Result);
	}

	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(QueryFileOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	public void QueryFile(QueryFileOptions queryFileOptions, object clientData, OnQueryFileCompleteCallback completionCallback)
	{
	}

	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[CallsUnknownMethods(Count = 9)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QueryFileListOptionsInternal), Member = "Set")]
	public void QueryFileList(QueryFileListOptions queryFileListOptions, object clientData, OnQueryFileListCompleteCallback completionCallback)
	{
	}

	[CallsUnknownMethods(Count = 27)]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(ReadFileOptionsInternal), Member = "get_FileTransferProgressCallback")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReadFileOptionsInternal), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(ReadFileOptionsInternal), Member = "get_ReadFileDataCallback")]
	public PlayerDataStorageFileTransferRequest ReadFile(ReadFileOptions readOptions, object clientData, OnReadFileCompleteCallback completionCallback)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(WriteFileOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(WriteFileOptionsInternal), Member = "get_WriteFileDataCallback")]
	[Calls(Type = typeof(WriteFileOptionsInternal), Member = "get_FileTransferProgressCallback")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 27)]
	public PlayerDataStorageFileTransferRequest WriteFile(WriteFileOptions writeOptions, object clientData, OnWriteFileCompleteCallback completionCallback)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	internal static void OnDeleteCacheCompleteCallbackInternalImplementation(IntPtr data)
	{
	}

	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnDeleteFileCompleteCallbackInternalImplementation(IntPtr data)
	{
	}

	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnDuplicateFileCompleteCallbackInternalImplementation(IntPtr data)
	{
	}

	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnFileTransferProgressCallbackInternalImplementation(IntPtr data)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	internal static void OnQueryFileCompleteCallbackInternalImplementation(IntPtr data)
	{
	}

	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnQueryFileListCompleteCallbackInternalImplementation(IntPtr data)
	{
	}

	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnReadFileCompleteCallbackInternalImplementation(IntPtr data)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	internal static ReadResult OnReadFileDataCallbackInternalImplementation(IntPtr data)
	{
		return default(ReadResult);
	}

	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnWriteFileCompleteCallbackInternalImplementation(IntPtr data)
	{
	}

	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(Marshal), Member = "Copy")]
	[CallsUnknownMethods(Count = 1)]
	internal static WriteResult OnWriteFileDataCallbackInternalImplementation(IntPtr data, IntPtr outDataBuffer, ref uint outDataWritten)
	{
		return default(WriteResult);
	}

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	internal static extern Result EOS_PlayerDataStorage_CopyFileMetadataAtIndex(IntPtr handle, IntPtr copyFileMetadataOptions, ref IntPtr outMetadata);

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	internal static extern Result EOS_PlayerDataStorage_CopyFileMetadataByFilename(IntPtr handle, IntPtr copyFileMetadataOptions, ref IntPtr outMetadata);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern Result EOS_PlayerDataStorage_DeleteCache(IntPtr handle, IntPtr options, IntPtr clientData, OnDeleteCacheCompleteCallbackInternal completionCallback);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern void EOS_PlayerDataStorage_DeleteFile(IntPtr handle, IntPtr deleteOptions, IntPtr clientData, OnDeleteFileCompleteCallbackInternal completionCallback);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern void EOS_PlayerDataStorage_DuplicateFile(IntPtr handle, IntPtr duplicateOptions, IntPtr clientData, OnDuplicateFileCompleteCallbackInternal completionCallback);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_PlayerDataStorage_GetFileMetadataCount(IntPtr handle, IntPtr getFileMetadataCountOptions, ref int outFileMetadataCount);

	[PreserveSig]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	internal static extern void EOS_PlayerDataStorage_QueryFile(IntPtr handle, IntPtr queryFileOptions, IntPtr clientData, OnQueryFileCompleteCallbackInternal completionCallback);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern void EOS_PlayerDataStorage_QueryFileList(IntPtr handle, IntPtr queryFileListOptions, IntPtr clientData, OnQueryFileListCompleteCallbackInternal completionCallback);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern IntPtr EOS_PlayerDataStorage_ReadFile(IntPtr handle, IntPtr readOptions, IntPtr clientData, OnReadFileCompleteCallbackInternal completionCallback);

	[PreserveSig]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(PlayerDataStorageInterface), Member = "CopyFileMetadataAtIndex")]
	[CalledBy(Type = typeof(PlayerDataStorageInterface), Member = "CopyFileMetadataByFilename")]
	[CallsUnknownMethods(Count = 1)]
	internal static extern void EOS_PlayerDataStorage_FileMetadata_Release(IntPtr fileMetadata);

	[PreserveSig]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	internal static extern IntPtr EOS_PlayerDataStorage_WriteFile(IntPtr handle, IntPtr writeOptions, IntPtr clientData, OnWriteFileCompleteCallbackInternal completionCallback);
}
