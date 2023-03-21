using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Auth;

[StructLayout(0, Pack = 8, Size = 16)]
internal struct VerifyUserAuthOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_AuthToken;

	public Token AuthToken
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 4)]
		[Calls(Type = typeof(TokenInternal), Member = "Set")]
		[CalledBy(Type = typeof(VerifyUserAuthOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(VerifyUserAuthOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VerifyUserAuthOptionsInternal), Member = "set_AuthToken")]
	public void Set(VerifyUserAuthOptions other)
	{
	}

	[CalledBy(Type = typeof(AuthInterface), Member = "VerifyUserAuth")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(VerifyUserAuthOptionsInternal), Member = "set_AuthToken")]
	public void Set(object other)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallerCount(Count = 0)]
	public void Dispose()
	{
	}
}
