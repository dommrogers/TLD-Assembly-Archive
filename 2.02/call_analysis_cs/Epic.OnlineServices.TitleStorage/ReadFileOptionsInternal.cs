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
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string Filename
	{
		[CalledBy(Type = typeof(ReadFileOptionsInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
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
		[CalledBy(Type = typeof(ReadFileOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(TitleStorageInterface), Member = "ReadFile")]
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
		[CalledBy(Type = typeof(ReadFileOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(TitleStorageInterface), Member = "ReadFile")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return null;
		}
	}

	[CalledBy(Type = typeof(ReadFileOptionsInternal), Member = "Set")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReadFileOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(ReadFileOptionsInternal), Member = "set_Filename")]
	[Calls(Type = typeof(ReadFileOptionsInternal), Member = "get_ReadFileDataCallback")]
	[Calls(Type = typeof(ReadFileOptionsInternal), Member = "get_FileTransferProgressCallback")]
	public void Set(ReadFileOptions other)
	{
	}

	[CalledBy(Type = typeof(TitleStorageInterface), Member = "ReadFile")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReadFileOptionsInternal), Member = "Set")]
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
