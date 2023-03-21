using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Ecom;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct GetEntitlementsByNameCountOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private IntPtr m_EntitlementName;

	public EpicAccountId LocalUserId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(GetEntitlementsByNameCountOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(GetEntitlementsByNameCountOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public string EntitlementName
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(GetEntitlementsByNameCountOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(GetEntitlementsByNameCountOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[Calls(Type = typeof(GetEntitlementsByNameCountOptionsInternal), Member = "set_EntitlementName")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetEntitlementsByNameCountOptionsInternal), Member = "set_LocalUserId")]
	public void Set(GetEntitlementsByNameCountOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GetEntitlementsByNameCountOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(GetEntitlementsByNameCountOptionsInternal), Member = "set_EntitlementName")]
	[CalledBy(Type = typeof(EcomInterface), Member = "GetEntitlementsByNameCount")]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Dispose()
	{
	}
}
