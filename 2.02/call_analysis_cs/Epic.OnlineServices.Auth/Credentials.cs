using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using Epic.OnlineServices.Connect;

namespace Epic.OnlineServices.Auth;

public class Credentials : ISettable
{
	private string _003CId_003Ek__BackingField;

	private string _003CToken_003Ek__BackingField;

	private LoginCredentialType _003CType_003Ek__BackingField;

	private IntPtr _003CSystemAuthCredentialsOptions_003Ek__BackingField;

	private ExternalCredentialType _003CExternalType_003Ek__BackingField;

	public string Id
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 59)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 103)]
		set
		{
		}
	}

	public string Token
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 35)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 77)]
		set
		{
		}
	}

	public LoginCredentialType Type
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		get
		{
			return default(LoginCredentialType);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public IntPtr SystemAuthCredentialsOptions
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 12)]
		get
		{
			return (IntPtr)0;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public ExternalCredentialType ExternalType
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(ExternalCredentialType);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(Credentials), Member = "Set")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CredentialsInternal), Member = "get_Id")]
	[Calls(Type = typeof(CredentialsInternal), Member = "get_Token")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	internal void Set(CredentialsInternal? other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Credentials), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public Credentials()
	{
	}
}
