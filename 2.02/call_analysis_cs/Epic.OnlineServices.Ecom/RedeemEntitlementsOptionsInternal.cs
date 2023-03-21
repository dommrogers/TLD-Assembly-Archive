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
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(RedeemEntitlementsOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(RedeemEntitlementsOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public string[] EntitlementIds
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(RedeemEntitlementsOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(RedeemEntitlementsOptionsInternal), Member = "Set")]
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
	[Calls(Type = typeof(RedeemEntitlementsOptionsInternal), Member = "set_EntitlementIds")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RedeemEntitlementsOptionsInternal), Member = "set_LocalUserId")]
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
