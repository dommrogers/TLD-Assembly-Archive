using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Ecom;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct CopyTransactionByIdOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private IntPtr m_TransactionId;

	public EpicAccountId LocalUserId
	{
		[CalledBy(Type = typeof(CopyTransactionByIdOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyTransactionByIdOptionsInternal), Member = "Set")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallerCount(Count = 2)]
		set
		{
		}
	}

	public string TransactionId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(CopyTransactionByIdOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyTransactionByIdOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyTransactionByIdOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(CopyTransactionByIdOptionsInternal), Member = "set_TransactionId")]
	public void Set(CopyTransactionByIdOptions other)
	{
	}

	[CalledBy(Type = typeof(EcomInterface), Member = "CopyTransactionById")]
	[Calls(Type = typeof(CopyTransactionByIdOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(CopyTransactionByIdOptionsInternal), Member = "set_TransactionId")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
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
