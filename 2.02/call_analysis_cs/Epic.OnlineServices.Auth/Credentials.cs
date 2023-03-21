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
		[CallerCount(Count = 52)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 101)]
		set
		{
		}
	}

	public string Token
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 29)]
		get
		{
			return null;
		}
		[CallerCount(Count = 71)]
		[DeduplicatedMethod]
		[CompilerGenerated]
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
			return default(IntPtr);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
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

	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CredentialsInternal), Member = "get_Id")]
	[Calls(Type = typeof(CredentialsInternal), Member = "get_Token")]
	[CalledBy(Type = typeof(Credentials), Member = "Set")]
	internal void Set(CredentialsInternal? other)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Credentials), Member = "Set")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public Credentials()
	{
	}
}
