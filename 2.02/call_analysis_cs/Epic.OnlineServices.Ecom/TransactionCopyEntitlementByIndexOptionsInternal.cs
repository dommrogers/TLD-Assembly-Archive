using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Ecom;

[StructLayout(0, Pack = 8, Size = 8)]
internal struct TransactionCopyEntitlementByIndexOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private uint m_EntitlementIndex;

	public uint EntitlementIndex
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void Set(TransactionCopyEntitlementByIndexOptions other)
	{
	}

	[CalledBy(Type = typeof(Transaction), Member = "CopyEntitlementByIndex")]
	[CallerCount(Count = 1)]
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
