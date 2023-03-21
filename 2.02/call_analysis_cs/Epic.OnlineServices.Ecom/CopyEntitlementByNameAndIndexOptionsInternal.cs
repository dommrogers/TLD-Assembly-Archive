using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Ecom;

[StructLayout(0, Pack = 8, Size = 32)]
internal struct CopyEntitlementByNameAndIndexOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private IntPtr m_EntitlementName;

	private uint m_Index;

	public EpicAccountId LocalUserId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(CopyEntitlementByNameAndIndexOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyEntitlementByNameAndIndexOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public string EntitlementName
	{
		[CalledBy(Type = typeof(CopyEntitlementByNameAndIndexOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyEntitlementByNameAndIndexOptionsInternal), Member = "Set")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		set
		{
		}
	}

	public uint Index
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyEntitlementByNameAndIndexOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(CopyEntitlementByNameAndIndexOptionsInternal), Member = "set_EntitlementName")]
	public void Set(CopyEntitlementByNameAndIndexOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CopyEntitlementByNameAndIndexOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(CopyEntitlementByNameAndIndexOptionsInternal), Member = "set_EntitlementName")]
	[CalledBy(Type = typeof(EcomInterface), Member = "CopyEntitlementByNameAndIndex")]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Dispose()
	{
	}
}
