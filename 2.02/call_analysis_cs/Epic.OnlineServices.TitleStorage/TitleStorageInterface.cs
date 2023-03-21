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

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public TitleStorageInterface()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public TitleStorageInterface(IntPtr innerHandle)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyFileMetadataAtIndexOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[Calls(Type = typeof(TitleStorageInterface), Member = "EOS_TitleStorage_FileMetadata_Release")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result CopyFileMetadataAtIndex(CopyFileMetadataAtIndexOptions options, out FileMetadata outMetadata)
	{
		outMetadata = null;
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyFileMetadataByFilenameOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[Calls(Type = typeof(TitleStorageInterface), Member = "EOS_TitleStorage_FileMetadata_Release")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result CopyFileMetadataByFilename(CopyFileMetadataByFilenameOptions options, out FileMetadata outMetadata)
	{
		outMetadata = null;
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DeleteCacheOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	public Result DeleteCache(DeleteCacheOptions options, object clientData, OnDeleteCacheCompleteCallback completionCallback)
	{
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetFileMetadataCountOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public uint GetFileMetadataCount(GetFileMetadataCountOptions options)
	{
		return 0u;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QueryFileOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	public void QueryFile(QueryFileOptions options, object clientData, OnQueryFileCompleteCallback completionCallback)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QueryFileListOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	public void QueryFileList(QueryFileListOptions options, object clientData, OnQueryFileListCompleteCallback completionCallback)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReadFileOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(ReadFileOptionsInternal), Member = "get_ReadFileDataCallback")]
	[Calls(Type = typeof(ReadFileOptionsInternal), Member = "get_FileTransferProgressCallback")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 27)]
	public TitleStorageFileTransferRequest ReadFile(ReadFileOptions options, object clientData, OnReadFileCompleteCallback completionCallback)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnDeleteCacheCompleteCallbackInternalImplementation(IntPtr data)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnFileTransferProgressCallbackInternalImplementation(IntPtr data)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnQueryFileCompleteCallbackInternalImplementation(IntPtr data)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnQueryFileListCompleteCallbackInternalImplementation(IntPtr data)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnReadFileCompleteCallbackInternalImplementation(IntPtr data)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static ReadResult OnReadFileDataCallbackInternalImplementation(IntPtr data)
	{
		return default(ReadResult);
	}

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
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
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern IntPtr EOS_TitleStorage_ReadFile(IntPtr handle, IntPtr options, IntPtr clientData, OnReadFileCompleteCallbackInternal completionCallback);

	[PreserveSig]
	[CalledBy(Type = typeof(TitleStorageInterface), Member = "CopyFileMetadataAtIndex")]
	[CalledBy(Type = typeof(TitleStorageInterface), Member = "CopyFileMetadataByFilename")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern void EOS_TitleStorage_FileMetadata_Release(IntPtr fileMetadata);
}
