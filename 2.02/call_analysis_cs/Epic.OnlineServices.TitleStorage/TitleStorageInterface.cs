using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.TitleStorage;

public sealed class TitleStorageInterface : Handle
{
	public const int CopyfilemetadataatindexoptionsApiLatest = 1;

	public const int CopyfilemetadatabyfilenameoptionsApiLatest = 1;

	public const int DeletecacheoptionsApiLatest = 1;

	public const int FilemetadataApiLatest = 1;

	public const int FilenameMaxLengthBytes = 64;

	public const int GetfilemetadatacountoptionsApiLatest = 1;

	public const int QueryfilelistoptionsApiLatest = 1;

	public const int QueryfileoptionsApiLatest = 1;

	public const int ReadfileoptionsApiLatest = 1;

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public TitleStorageInterface()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public TitleStorageInterface(IntPtr innerHandle)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(CopyFileMetadataAtIndexOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(TitleStorageInterface), Member = "EOS_TitleStorage_FileMetadata_Release")]
	[CallsUnknownMethods(Count = 1)]
	public Result CopyFileMetadataAtIndex(CopyFileMetadataAtIndexOptions options, out FileMetadata outMetadata)
	{
		outMetadata = null;
		return default(Result);
	}

	[Calls(Type = typeof(TitleStorageInterface), Member = "EOS_TitleStorage_FileMetadata_Release")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyFileMetadataByFilenameOptionsInternal), Member = "Set")]
	public Result CopyFileMetadataByFilename(CopyFileMetadataByFilenameOptions options, out FileMetadata outMetadata)
	{
		outMetadata = null;
		return default(Result);
	}

	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[CallsUnknownMethods(Count = 9)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DeleteCacheOptionsInternal), Member = "Set")]
	public Result DeleteCache(DeleteCacheOptions options, object clientData, OnDeleteCacheCompleteCallback completionCallback)
	{
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(GetFileMetadataCountOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 1)]
	public uint GetFileMetadataCount(GetFileMetadataCountOptions options)
	{
		return default(uint);
	}

	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QueryFileOptionsInternal), Member = "Set")]
	public void QueryFile(QueryFileOptions options, object clientData, OnQueryFileCompleteCallback completionCallback)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(QueryFileListOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 9)]
	public void QueryFileList(QueryFileListOptions options, object clientData, OnQueryFileListCompleteCallback completionCallback)
	{
	}

	[Calls(Type = typeof(ReadFileOptionsInternal), Member = "get_FileTransferProgressCallback")]
	[CallsUnknownMethods(Count = 27)]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(ReadFileOptionsInternal), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReadFileOptionsInternal), Member = "get_ReadFileDataCallback")]
	public TitleStorageFileTransferRequest ReadFile(ReadFileOptions options, object clientData, OnReadFileCompleteCallback completionCallback)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	internal static void OnDeleteCacheCompleteCallbackInternalImplementation(IntPtr data)
	{
	}

	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	internal static void OnFileTransferProgressCallbackInternalImplementation(IntPtr data)
	{
	}

	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
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

	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	internal static ReadResult OnReadFileDataCallbackInternalImplementation(IntPtr data)
	{
		return default(ReadResult);
	}

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	internal static extern Result EOS_TitleStorage_CopyFileMetadataAtIndex(IntPtr handle, IntPtr options, ref IntPtr outMetadata);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_TitleStorage_CopyFileMetadataByFilename(IntPtr handle, IntPtr options, ref IntPtr outMetadata);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern Result EOS_TitleStorage_DeleteCache(IntPtr handle, IntPtr options, IntPtr clientData, OnDeleteCacheCompleteCallbackInternal completionCallback);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern uint EOS_TitleStorage_GetFileMetadataCount(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern void EOS_TitleStorage_QueryFile(IntPtr handle, IntPtr options, IntPtr clientData, OnQueryFileCompleteCallbackInternal completionCallback);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern void EOS_TitleStorage_QueryFileList(IntPtr handle, IntPtr options, IntPtr clientData, OnQueryFileListCompleteCallbackInternal completionCallback);

	[PreserveSig]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static extern IntPtr EOS_TitleStorage_ReadFile(IntPtr handle, IntPtr options, IntPtr clientData, OnReadFileCompleteCallbackInternal completionCallback);

	[PreserveSig]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(TitleStorageInterface), Member = "CopyFileMetadataAtIndex")]
	[CalledBy(Type = typeof(TitleStorageInterface), Member = "CopyFileMetadataByFilename")]
	[CallsUnknownMethods(Count = 1)]
	internal static extern void EOS_TitleStorage_FileMetadata_Release(IntPtr fileMetadata);
}
