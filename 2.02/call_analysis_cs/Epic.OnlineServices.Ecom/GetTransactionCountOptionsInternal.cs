using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Ecom;

[StructLayout(0, Pack = 8, Size = 16)]
internal struct GetTransactionCountOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	public EpicAccountId LocalUserId
	{
		[CalledBy(Type = typeof(GetTransactionCountOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(GetTransactionCountOptionsInternal), Member = "Set")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetTransactionCountOptionsInternal), Member = "set_LocalUserId")]
	public void Set(GetTransactionCountOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GetTransactionCountOptionsInternal), Member = "set_LocalUserId")]
	[CalledBy(Type = typeof(EcomInterface), Member = "GetTransactionCount")]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Dispose()
	{
	}
}
