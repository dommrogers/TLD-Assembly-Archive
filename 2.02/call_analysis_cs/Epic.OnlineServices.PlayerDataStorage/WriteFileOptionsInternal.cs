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
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(WriteFileOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public string Filename
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(WriteFileOptionsInternal), Member = "Set")]
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
		[CallsUnknownMethods(Count = 7)]
		[CalledBy(Type = typeof(PlayerDataStorageInterface), Member = "WriteFile")]
		[CalledBy(Type = typeof(WriteFileOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public static OnFileTransferProgressCallbackInternal FileTransferProgressCallback
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(PlayerDataStorageInterface), Member = "WriteFile")]
		[CalledBy(Type = typeof(WriteFileOptionsInternal), Member = "Set")]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(WriteFileOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(WriteFileOptionsInternal), Member = "set_Filename")]
	[Calls(Type = typeof(WriteFileOptionsInternal), Member = "get_WriteFileDataCallback")]
	[Calls(Type = typeof(WriteFileOptionsInternal), Member = "get_FileTransferProgressCallback")]
	[CalledBy(Type = typeof(WriteFileOptionsInternal), Member = "Set")]
	public void Set(WriteFileOptions other)
	{
	}

	[CalledBy(Type = typeof(PlayerDataStorageInterface), Member = "WriteFile")]
	[Calls(Type = typeof(WriteFileOptionsInternal), Member = "Set")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
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
