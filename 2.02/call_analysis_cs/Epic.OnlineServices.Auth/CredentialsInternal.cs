using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;
using Epic.OnlineServices.Connect;

namespace Epic.OnlineServices.Auth;

[StructLayout(0, Pack = 8, Size = 48)]
internal struct CredentialsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_Id;

	private IntPtr m_Token;

	private LoginCredentialType m_Type;

	private IntPtr m_SystemAuthCredentialsOptions;

	private ExternalCredentialType m_ExternalType;

	public string Id
	{
		[CalledBy(Type = typeof(Credentials), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(CredentialsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CredentialsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string Token
	{
		[CalledBy(Type = typeof(Credentials), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(CredentialsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CredentialsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public LoginCredentialType Type
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		get
		{
			return default(LoginCredentialType);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public IntPtr SystemAuthCredentialsOptions
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 9)]
		get
		{
			return (IntPtr)0;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public ExternalCredentialType ExternalType
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		get
		{
			return default(ExternalCredentialType);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CredentialsInternal), Member = "set_Id")]
	[Calls(Type = typeof(CredentialsInternal), Member = "set_Token")]
	public void Set(Credentials other)
	{
	}

	[CalledBy(Type = typeof(LoginOptionsInternal), Member = "set_Credentials")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CredentialsInternal), Member = "set_Id")]
	[Calls(Type = typeof(CredentialsInternal), Member = "set_Token")]
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
