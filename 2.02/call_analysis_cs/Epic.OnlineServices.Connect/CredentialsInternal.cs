using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Connect;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct CredentialsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_Token;

	private ExternalCredentialType m_Type;

	public string Token
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(Credentials), Member = "Set")]
		[CalledBy(Type = typeof(Credentials), Member = "Set")]
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

	public ExternalCredentialType Type
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CredentialsInternal), Member = "set_Token")]
	public void Set(Credentials other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CredentialsInternal), Member = "set_Token")]
	[CalledBy(Type = typeof(LoginOptionsInternal), Member = "set_Credentials")]
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
