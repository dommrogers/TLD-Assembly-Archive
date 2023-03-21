using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Ecom;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct CopyTransactionByIndexOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private uint m_TransactionIndex;

	public EpicAccountId LocalUserId
	{
		[CalledBy(Type = typeof(CopyTransactionByIndexOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyTransactionByIndexOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public uint TransactionIndex
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyTransactionByIndexOptionsInternal), Member = "set_LocalUserId")]
	public void Set(CopyTransactionByIndexOptions other)
	{
	}

	[CalledBy(Type = typeof(EcomInterface), Member = "CopyTransactionByIndex")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CopyTransactionByIndexOptionsInternal), Member = "set_LocalUserId")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void Dispose()
	{
	}
}
