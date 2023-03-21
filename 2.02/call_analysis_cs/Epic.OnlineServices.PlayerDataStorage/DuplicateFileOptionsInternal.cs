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
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(DuplicateFileOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(DuplicateFileOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public string SourceFilename
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(DuplicateFileOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(DuplicateFileOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public string DestinationFilename
	{
		[CalledBy(Type = typeof(DuplicateFileOptionsInternal), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(DuplicateFileOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[Calls(Type = typeof(DuplicateFileOptionsInternal), Member = "set_DestinationFilename")]
	[Calls(Type = typeof(DuplicateFileOptionsInternal), Member = "set_SourceFilename")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DuplicateFileOptionsInternal), Member = "set_LocalUserId")]
	public void Set(DuplicateFileOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(DuplicateFileOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(DuplicateFileOptionsInternal), Member = "set_SourceFilename")]
	[Calls(Type = typeof(DuplicateFileOptionsInternal), Member = "set_DestinationFilename")]
	[CalledBy(Type = typeof(PlayerDataStorageInterface), Member = "DuplicateFile")]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	public void Dispose()
	{
	}
}
