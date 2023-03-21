using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.PlayerDataStorage;

[StructLayout(0, Pack = 8, Size = 48)]
internal struct WriteFileOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private IntPtr m_Filename;

	private uint m_ChunkLengthBytes;

	private OnWriteFileDataCallbackInternal m_WriteFileDataCallback;

	private OnFileTransferProgressCallbackInternal m_FileTransferProgressCallback;

	private static OnWriteFileDataCallbackInternal s_WriteFileDataCallback;

	private static OnFileTransferProgressCallbackInternal s_FileTransferProgressCallback;

	public ProductUserId LocalUserId
	{
		[CalledBy(Type = typeof(WriteFileOptionsInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string Filename
	{
		[CalledBy(Type = typeof(WriteFileOptionsInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public uint ChunkLengthBytes
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public static OnWriteFileDataCallbackInternal WriteFileDataCallback
	{
		[CalledBy(Type = typeof(PlayerDataStorageInterface), Member = "WriteFile")]
		[CalledBy(Type = typeof(WriteFileOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return null;
		}
	}

	public static OnFileTransferProgressCallbackInternal FileTransferProgressCallback
	{
		[CalledBy(Type = typeof(PlayerDataStorageInterface), Member = "WriteFile")]
		[CalledBy(Type = typeof(WriteFileOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return null;
		}
	}

	[CalledBy(Type = typeof(WriteFileOptionsInternal), Member = "Set")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(WriteFileOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(WriteFileOptionsInternal), Member = "set_Filename")]
	[Calls(Type = typeof(WriteFileOptionsInternal), Member = "get_WriteFileDataCallback")]
	[Calls(Type = typeof(WriteFileOptionsInternal), Member = "get_FileTransferProgressCallback")]
	public void Set(WriteFileOptions other)
	{
	}

	[CalledBy(Type = typeof(PlayerDataStorageInterface), Member = "WriteFile")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(WriteFileOptionsInternal), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Dispose()
	{
	}
}
