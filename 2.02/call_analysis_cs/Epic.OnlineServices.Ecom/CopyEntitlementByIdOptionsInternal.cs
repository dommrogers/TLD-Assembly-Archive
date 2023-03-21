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
		[CalledBy(Type = typeof(CopyEntitlementByIdOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyEntitlementByIdOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string EntitlementId
	{
		[CalledBy(Type = typeof(CopyEntitlementByIdOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyEntitlementByIdOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyEntitlementByIdOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(CopyEntitlementByIdOptionsInternal), Member = "set_EntitlementId")]
	public void Set(CopyEntitlementByIdOptions other)
	{
	}

	[CalledBy(Type = typeof(EcomInterface), Member = "CopyEntitlementById")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CopyEntitlementByIdOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(CopyEntitlementByIdOptionsInternal), Member = "set_EntitlementId")]
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
