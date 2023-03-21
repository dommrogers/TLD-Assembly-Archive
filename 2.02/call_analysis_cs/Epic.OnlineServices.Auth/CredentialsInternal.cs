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
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(Credentials), Member = "Set")]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(CredentialsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(CredentialsInternal), Member = "Set")]
		set
		{
		}
	}

	public string Token
	{
		[CalledBy(Type = typeof(Credentials), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(CredentialsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CredentialsInternal), Member = "Set")]
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
		[CallerCount(Count = 5)]
		get
		{
			return default(IntPtr);
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
		[CallerCount(Count = 0)]
		get
		{
			return default(ExternalCredentialType);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	[Calls(Type = typeof(CredentialsInternal), Member = "set_Id")]
	[Calls(Type = typeof(CredentialsInternal), Member = "set_Token")]
	[CallerCount(Count = 0)]
	public void Set(Credentials other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CredentialsInternal), Member = "set_Id")]
	[Calls(Type = typeof(CredentialsInternal), Member = "set_Token")]
	[CalledBy(Type = typeof(LoginOptionsInternal), Member = "set_Credentials")]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	public void Dispose()
	{
	}
}
