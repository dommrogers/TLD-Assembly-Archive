using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Ecom;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct CopyEntitlementByIdOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private IntPtr m_EntitlementId;

	public EpicAccountId LocalUserId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(CopyEntitlementByIdOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyEntitlementByIdOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public string EntitlementId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(CopyEntitlementByIdOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyEntitlementByIdOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[Calls(Type = typeof(CopyEntitlementByIdOptionsInternal), Member = "set_LocalUserId")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyEntitlementByIdOptionsInternal), Member = "set_EntitlementId")]
	public void Set(CopyEntitlementByIdOptions other)
	{
	}

	[Calls(Type = typeof(CopyEntitlementByIdOptionsInternal), Member = "set_EntitlementId")]
	[Calls(Type = typeof(CopyEntitlementByIdOptionsInternal), Member = "set_LocalUserId")]
	[CalledBy(Type = typeof(EcomInterface), Member = "CopyEntitlementById")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Dispose()
	{
	}
}
