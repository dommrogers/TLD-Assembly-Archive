using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Connect;

[StructLayout(0, Pack = 8, Size = 32)]
internal struct GetExternalAccountMappingsOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private ExternalAccountType m_AccountIdType;

	private IntPtr m_TargetExternalUserId;

	public ProductUserId LocalUserId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(GetExternalAccountMappingsOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(GetExternalAccountMappingsOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public ExternalAccountType AccountIdType
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public string TargetExternalUserId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(GetExternalAccountMappingsOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(GetExternalAccountMappingsOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[Calls(Type = typeof(GetExternalAccountMappingsOptionsInternal), Member = "set_TargetExternalUserId")]
	[Calls(Type = typeof(GetExternalAccountMappingsOptionsInternal), Member = "set_LocalUserId")]
	[CallerCount(Count = 0)]
	public void Set(GetExternalAccountMappingsOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GetExternalAccountMappingsOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(GetExternalAccountMappingsOptionsInternal), Member = "set_TargetExternalUserId")]
	[CalledBy(Type = typeof(ConnectInterface), Member = "GetExternalAccountMapping")]
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
