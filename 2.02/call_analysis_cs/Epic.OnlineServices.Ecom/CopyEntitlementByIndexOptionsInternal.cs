using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Ecom;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct CopyEntitlementByIndexOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private uint m_EntitlementIndex;

	public EpicAccountId LocalUserId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(CopyEntitlementByIndexOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyEntitlementByIndexOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public uint EntitlementIndex
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyEntitlementByIndexOptionsInternal), Member = "set_LocalUserId")]
	public void Set(CopyEntitlementByIndexOptions other)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(EcomInterface), Member = "CopyEntitlementByIndex")]
	[Calls(Type = typeof(CopyEntitlementByIndexOptionsInternal), Member = "set_LocalUserId")]
	[CallerCount(Count = 1)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Dispose()
	{
	}
}
