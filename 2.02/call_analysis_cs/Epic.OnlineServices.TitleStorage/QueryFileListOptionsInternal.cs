using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.TitleStorage;

[StructLayout(0, Pack = 8, Size = 32)]
internal struct QueryFileListOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private IntPtr m_ListOfTags;

	private uint m_ListOfTagsCount;

	public ProductUserId LocalUserId
	{
		[CalledBy(Type = typeof(QueryFileListOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(QueryFileListOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string[] ListOfTags
	{
		[CalledBy(Type = typeof(QueryFileListOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(QueryFileListOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QueryFileListOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(QueryFileListOptionsInternal), Member = "set_ListOfTags")]
	public void Set(QueryFileListOptions other)
	{
	}

	[CalledBy(Type = typeof(TitleStorageInterface), Member = "QueryFileList")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(QueryFileListOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(QueryFileListOptionsInternal), Member = "set_ListOfTags")]
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
