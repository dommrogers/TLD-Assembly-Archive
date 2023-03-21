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
		[CalledBy(Type = typeof(GetExternalAccountMappingsOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(GetExternalAccountMappingsOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
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
		[CalledBy(Type = typeof(GetExternalAccountMappingsOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(GetExternalAccountMappingsOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetExternalAccountMappingsOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(GetExternalAccountMappingsOptionsInternal), Member = "set_TargetExternalUserId")]
	public void Set(GetExternalAccountMappingsOptions other)
	{
	}

	[CalledBy(Type = typeof(ConnectInterface), Member = "GetExternalAccountMapping")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GetExternalAccountMappingsOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(GetExternalAccountMappingsOptionsInternal), Member = "set_TargetExternalUserId")]
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
