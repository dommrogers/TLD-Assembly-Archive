using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.PlayerDataStorage;

[StructLayout(0, Pack = 8, Size = 48)]
internal struct ReadFileOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private IntPtr m_Filename;

	private uint m_ReadChunkLengthBytes;

	private OnReadFileDataCallbackInternal m_ReadFileDataCallback;

	private OnFileTransferProgressCallbackInternal m_FileTransferProgressCallback;

	private static OnReadFileDataCallbackInternal s_ReadFileDataCallback;

	private static OnFileTransferProgressCallbackInternal s_FileTransferProgressCallback;

	public ProductUserId LocalUserId
	{
		[CalledBy(Type = typeof(ReadFileOptionsInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		set
		{
		}
	}

	public string Filename
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallerCount(Count = 1)]
		[CalledBy(Type = typeof(ReadFileOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public uint ReadChunkLengthBytes
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public static OnReadFileDataCallbackInternal ReadFileDataCallback
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(PlayerDataStorageInterface), Member = "ReadFile")]
		[CalledBy(Type = typeof(ReadFileOptionsInternal), Member = "Set")]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return null;
		}
	}

	public static OnFileTransferProgressCallbackInternal FileTransferProgressCallback
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(PlayerDataStorageInterface), Member = "ReadFile")]
		[CalledBy(Type = typeof(ReadFileOptionsInternal), Member = "Set")]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return null;
		}
	}

	[CalledBy(Type = typeof(ReadFileOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(ReadFileOptionsInternal), Member = "get_FileTransferProgressCallback")]
	[Calls(Type = typeof(ReadFileOptionsInternal), Member = "get_ReadFileDataCallback")]
	[Calls(Type = typeof(ReadFileOptionsInternal), Member = "set_Filename")]
	[Calls(Type = typeof(ReadFileOptionsInternal), Member = "set_LocalUserId")]
	[CallerCount(Count = 1)]
	public void Set(ReadFileOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ReadFileOptionsInternal), Member = "Set")]
	[CalledBy(Type = typeof(PlayerDataStorageInterface), Member = "ReadFile")]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	public void Dispose()
	{
	}
}
