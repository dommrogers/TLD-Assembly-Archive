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
		[CalledBy(Type = typeof(Credentials), Member = "Set")]
		[CalledBy(Type = typeof(Credentials), Member = "Set")]
		[CallerCount(Count = 2)]
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

	public ExternalCredentialType Type
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
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
	[Calls(Type = typeof(CredentialsInternal), Member = "set_Token")]
	public void Set(Credentials other)
	{
	}

	[CalledBy(Type = typeof(LoginOptionsInternal), Member = "set_Credentials")]
	[CallerCount(Count = 1)]
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
