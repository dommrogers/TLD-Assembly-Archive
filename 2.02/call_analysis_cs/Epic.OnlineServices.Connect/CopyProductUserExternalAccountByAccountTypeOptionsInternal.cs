using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Connect;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct CopyProductUserExternalAccountByAccountTypeOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_TargetUserId;

	private ExternalAccountType m_AccountIdType;

	public ProductUserId TargetUserId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(CopyProductUserExternalAccountByAccountTypeOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyProductUserExternalAccountByAccountTypeOptionsInternal), Member = "Set")]
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

	[Calls(Type = typeof(CopyProductUserExternalAccountByAccountTypeOptionsInternal), Member = "set_TargetUserId")]
	[CallerCount(Count = 0)]
	public void Set(CopyProductUserExternalAccountByAccountTypeOptions other)
	{
	}

	[CalledBy(Type = typeof(ConnectInterface), Member = "CopyProductUserExternalAccountByAccountType")]
	[Calls(Type = typeof(CopyProductUserExternalAccountByAccountTypeOptionsInternal), Member = "set_TargetUserId")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Dispose()
	{
	}
}
