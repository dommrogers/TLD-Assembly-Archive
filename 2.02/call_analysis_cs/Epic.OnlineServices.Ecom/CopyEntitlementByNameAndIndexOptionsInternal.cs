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
		[CalledBy(Type = typeof(CopyEntitlementByNameAndIndexOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyEntitlementByNameAndIndexOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string EntitlementName
	{
		[CalledBy(Type = typeof(CopyEntitlementByNameAndIndexOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyEntitlementByNameAndIndexOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
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

	[CalledBy(Type = typeof(EcomInterface), Member = "CopyEntitlementByNameAndIndex")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CopyEntitlementByNameAndIndexOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(CopyEntitlementByNameAndIndexOptionsInternal), Member = "set_EntitlementName")]
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
