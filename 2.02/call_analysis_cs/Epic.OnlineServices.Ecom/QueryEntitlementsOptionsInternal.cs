using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Ecom;

[StructLayout(0, Pack = 8, Size = 32)]
internal struct QueryEntitlementsOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private IntPtr m_EntitlementNames;

	private uint m_EntitlementNameCount;

	private int m_IncludeRedeemed;

	public EpicAccountId LocalUserId
	{
		[CalledBy(Type = typeof(QueryEntitlementsOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(QueryEntitlementsOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string[] EntitlementNames
	{
		[CalledBy(Type = typeof(QueryEntitlementsOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(QueryEntitlementsOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public bool IncludeRedeemed
	{
		[CalledBy(Type = typeof(QueryEntitlementsOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(QueryEntitlementsOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QueryEntitlementsOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(QueryEntitlementsOptionsInternal), Member = "set_EntitlementNames")]
	[Calls(Type = typeof(QueryEntitlementsOptionsInternal), Member = "set_IncludeRedeemed")]
	public void Set(QueryEntitlementsOptions other)
	{
	}

	[CalledBy(Type = typeof(EcomInterface), Member = "QueryEntitlements")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(QueryEntitlementsOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(QueryEntitlementsOptionsInternal), Member = "set_EntitlementNames")]
	[Calls(Type = typeof(QueryEntitlementsOptionsInternal), Member = "set_IncludeRedeemed")]
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
