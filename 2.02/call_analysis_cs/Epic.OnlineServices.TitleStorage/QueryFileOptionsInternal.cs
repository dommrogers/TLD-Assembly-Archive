using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.TitleStorage;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct QueryFileOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private IntPtr m_Filename;

	public ProductUserId LocalUserId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(QueryFileOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(QueryFileOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public string Filename
	{
		[CalledBy(Type = typeof(QueryFileOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(QueryFileOptionsInternal), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QueryFileOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(QueryFileOptionsInternal), Member = "set_Filename")]
	public void Set(QueryFileOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(QueryFileOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(QueryFileOptionsInternal), Member = "set_Filename")]
	[CalledBy(Type = typeof(TitleStorageInterface), Member = "QueryFile")]
	public void Set(object other)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallerCount(Count = 0)]
	public void Dispose()
	{
	}
}
