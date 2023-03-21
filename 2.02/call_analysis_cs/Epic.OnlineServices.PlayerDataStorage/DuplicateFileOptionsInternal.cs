using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.PlayerDataStorage;

[StructLayout(0, Pack = 8, Size = 32)]
internal struct DuplicateFileOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private IntPtr m_SourceFilename;

	private IntPtr m_DestinationFilename;

	public ProductUserId LocalUserId
	{
		[CalledBy(Type = typeof(DuplicateFileOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(DuplicateFileOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string SourceFilename
	{
		[CalledBy(Type = typeof(DuplicateFileOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(DuplicateFileOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string DestinationFilename
	{
		[CalledBy(Type = typeof(DuplicateFileOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(DuplicateFileOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DuplicateFileOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(DuplicateFileOptionsInternal), Member = "set_SourceFilename")]
	[Calls(Type = typeof(DuplicateFileOptionsInternal), Member = "set_DestinationFilename")]
	public void Set(DuplicateFileOptions other)
	{
	}

	[CalledBy(Type = typeof(PlayerDataStorageInterface), Member = "DuplicateFile")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DuplicateFileOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(DuplicateFileOptionsInternal), Member = "set_SourceFilename")]
	[Calls(Type = typeof(DuplicateFileOptionsInternal), Member = "set_DestinationFilename")]
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
