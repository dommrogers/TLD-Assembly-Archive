using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Ecom;

[StructLayout(0, Pack = 8, Size = 32)]
internal struct RedeemEntitlementsOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private uint m_EntitlementIdCount;

	private IntPtr m_EntitlementIds;

	public EpicAccountId LocalUserId
	{
		[CalledBy(Type = typeof(RedeemEntitlementsOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(RedeemEntitlementsOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string[] EntitlementIds
	{
		[CalledBy(Type = typeof(RedeemEntitlementsOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(RedeemEntitlementsOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RedeemEntitlementsOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(RedeemEntitlementsOptionsInternal), Member = "set_EntitlementIds")]
	public void Set(RedeemEntitlementsOptions other)
	{
	}

	[CalledBy(Type = typeof(EcomInterface), Member = "RedeemEntitlements")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RedeemEntitlementsOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(RedeemEntitlementsOptionsInternal), Member = "set_EntitlementIds")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Dispose()
	{
	}
}
