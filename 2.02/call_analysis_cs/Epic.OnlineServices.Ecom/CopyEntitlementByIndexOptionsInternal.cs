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
		[CalledBy(Type = typeof(CopyEntitlementByIndexOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyEntitlementByIndexOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
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

	[CalledBy(Type = typeof(EcomInterface), Member = "CopyEntitlementByIndex")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CopyEntitlementByIndexOptionsInternal), Member = "set_LocalUserId")]
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
