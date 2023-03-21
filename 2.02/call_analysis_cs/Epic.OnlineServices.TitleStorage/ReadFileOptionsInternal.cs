using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.TitleStorage;

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
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string Filename
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(ReadFileOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public uint ReadChunkLengthBytes
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public static OnReadFileDataCallbackInternal ReadFileDataCallback
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(ReadFileOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(TitleStorageInterface), Member = "ReadFile")]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return null;
		}
	}

	public static OnFileTransferProgressCallbackInternal FileTransferProgressCallback
	{
		[CallsUnknownMethods(Count = 7)]
		[CalledBy(Type = typeof(TitleStorageInterface), Member = "ReadFile")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
		[CalledBy(Type = typeof(ReadFileOptionsInternal), Member = "Set")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReadFileOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(ReadFileOptionsInternal), Member = "set_Filename")]
	[Calls(Type = typeof(ReadFileOptionsInternal), Member = "get_ReadFileDataCallback")]
	[Calls(Type = typeof(ReadFileOptionsInternal), Member = "get_FileTransferProgressCallback")]
	[CalledBy(Type = typeof(ReadFileOptionsInternal), Member = "Set")]
	public void Set(ReadFileOptions other)
	{
	}

	[CalledBy(Type = typeof(TitleStorageInterface), Member = "ReadFile")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ReadFileOptionsInternal), Member = "Set")]
	public void Set(object other)
	{
	}

	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Dispose()
	{
	}
}
