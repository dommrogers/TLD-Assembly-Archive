using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Connect;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct CopyProductUserExternalAccountByAccountIdOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_TargetUserId;

	private IntPtr m_AccountId;

	public ProductUserId TargetUserId
	{
		[CalledBy(Type = typeof(CopyProductUserExternalAccountByAccountIdOptionsInternal), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(CopyProductUserExternalAccountByAccountIdOptionsInternal), Member = "Set")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
		set
		{
		}
	}

	public string AccountId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(CopyProductUserExternalAccountByAccountIdOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyProductUserExternalAccountByAccountIdOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyProductUserExternalAccountByAccountIdOptionsInternal), Member = "set_TargetUserId")]
	[Calls(Type = typeof(CopyProductUserExternalAccountByAccountIdOptionsInternal), Member = "set_AccountId")]
	public void Set(CopyProductUserExternalAccountByAccountIdOptions other)
	{
	}

	[CalledBy(Type = typeof(ConnectInterface), Member = "CopyProductUserExternalAccountByAccountId")]
	[Calls(Type = typeof(CopyProductUserExternalAccountByAccountIdOptionsInternal), Member = "set_TargetUserId")]
	[Calls(Type = typeof(CopyProductUserExternalAccountByAccountIdOptionsInternal), Member = "set_AccountId")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
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
