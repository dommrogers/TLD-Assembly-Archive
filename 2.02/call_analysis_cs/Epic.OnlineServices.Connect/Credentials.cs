using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Connect;

public class Credentials : ISettable
{
	private string _003CToken_003Ek__BackingField;

	private ExternalCredentialType _003CType_003Ek__BackingField;

	public string Token
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

	public ExternalCredentialType Type
	{
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		[CompilerGenerated]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CredentialsInternal), Member = "get_Token")]
	[CallsUnknownMethods(Count = 2)]
	internal void Set(CredentialsInternal? other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(CredentialsInternal), Member = "get_Token")]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public Credentials()
	{
	}
}
