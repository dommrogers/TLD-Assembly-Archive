using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.PlayerDataStorage;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct QueryFileOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private IntPtr m_Filename;

	public ProductUserId LocalUserId
	{
		[CalledBy(Type = typeof(QueryFileOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(QueryFileOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
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
		[CalledBy(Type = typeof(QueryFileOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(QueryFileOptionsInternal), Member = "Set")]
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

	[CalledBy(Type = typeof(PlayerDataStorageInterface), Member = "QueryFile")]
	[Calls(Type = typeof(QueryFileOptionsInternal), Member = "set_Filename")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(QueryFileOptionsInternal), Member = "set_LocalUserId")]
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
