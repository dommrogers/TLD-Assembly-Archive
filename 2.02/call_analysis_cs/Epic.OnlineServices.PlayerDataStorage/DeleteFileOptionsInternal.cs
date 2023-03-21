using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.PlayerDataStorage;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct DeleteFileOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private IntPtr m_Filename;

	public ProductUserId LocalUserId
	{
		[CalledBy(Type = typeof(DeleteFileOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(DeleteFileOptionsInternal), Member = "Set")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		set
		{
		}
	}

	public string Filename
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(DeleteFileOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(DeleteFileOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DeleteFileOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(DeleteFileOptionsInternal), Member = "set_Filename")]
	public void Set(DeleteFileOptions other)
	{
	}

	[CalledBy(Type = typeof(PlayerDataStorageInterface), Member = "DeleteFile")]
	[Calls(Type = typeof(DeleteFileOptionsInternal), Member = "set_Filename")]
	[Calls(Type = typeof(DeleteFileOptionsInternal), Member = "set_LocalUserId")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
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
