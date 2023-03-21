using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Ecom;

[StructLayout(0, Pack = 8, Size = 16)]
internal struct GetEntitlementsCountOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	public EpicAccountId LocalUserId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(GetEntitlementsCountOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(GetEntitlementsCountOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetEntitlementsCountOptionsInternal), Member = "set_LocalUserId")]
	public void Set(GetEntitlementsCountOptions other)
	{
	}

	[CalledBy(Type = typeof(EcomInterface), Member = "GetEntitlementsCount")]
	[Calls(Type = typeof(GetEntitlementsCountOptionsInternal), Member = "set_LocalUserId")]
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
