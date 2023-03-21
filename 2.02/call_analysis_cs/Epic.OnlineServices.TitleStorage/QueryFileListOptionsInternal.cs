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
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(QueryFileListOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(QueryFileListOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public string[] ListOfTags
	{
		[CalledBy(Type = typeof(QueryFileListOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(QueryFileListOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[Calls(Type = typeof(QueryFileListOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(QueryFileListOptionsInternal), Member = "set_ListOfTags")]
	[CallerCount(Count = 0)]
	public void Set(QueryFileListOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(QueryFileListOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(QueryFileListOptionsInternal), Member = "set_ListOfTags")]
	[CalledBy(Type = typeof(TitleStorageInterface), Member = "QueryFileList")]
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
