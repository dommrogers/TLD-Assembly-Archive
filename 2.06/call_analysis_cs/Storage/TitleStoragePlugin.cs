using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Storage;

public class TitleStoragePlugin
{
	public delegate void TitleStorageQuotaCallback(uint result, ulong outTotalBytes, IntPtr userData, ulong outUsedBytes);

	public delegate void TitleStorageSaveLoadCallback(uint result, uint size, IntPtr userData);

	public delegate void TitleStorageDeleteCallback(uint result, int ok, IntPtr userData);

	public delegate void TitleStorageUserSignedOutStorageInvalidCallback(uint userId, IntPtr userData);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern IntPtr TitleStorage_Init(int userId, string configurationId, uint typeOfStorage);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern void TitleStorage_Destroy(IntPtr self);

	[PreserveSig]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(TitleStorage), Member = "DownloadFileAsync")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(TitleStorage), Member = "DownloadFileAsync")]
	public static extern bool TitleStorage_Download(IntPtr self, string name, string targetXuid, byte[] outData, uint dataLength, TitleStorageSaveLoadCallback callback, IntPtr userData);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static extern bool TitleStorage_Upload(IntPtr self, string name, byte[] inData, uint dataLength, TitleStorageSaveLoadCallback callback, IntPtr userData);

	[PreserveSig]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static extern bool TitleStorage_Delete(IntPtr self, string name, TitleStorageDeleteCallback callback, IntPtr userData);

	[PreserveSig]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public static extern bool TitleStorage_RequestQuota(IntPtr self, TitleStorageQuotaCallback callback, IntPtr userData);

	[PreserveSig]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static extern void TitleStorage_SetSignOutCallback(IntPtr storage, TitleStorageUserSignedOutStorageInvalidCallback callback, IntPtr userData);

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public TitleStoragePlugin()
	{
	}
}
