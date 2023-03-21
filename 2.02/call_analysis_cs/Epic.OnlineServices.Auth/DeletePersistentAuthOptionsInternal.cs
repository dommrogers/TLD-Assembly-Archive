using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Auth;

[StructLayout(0, Pack = 8, Size = 16)]
internal struct DeletePersistentAuthOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_RefreshToken;

	public string RefreshToken
	{
		[CalledBy(Type = typeof(DeletePersistentAuthOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(DeletePersistentAuthOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[Calls(Type = typeof(DeletePersistentAuthOptionsInternal), Member = "set_RefreshToken")]
	[CallerCount(Count = 0)]
	public void Set(DeletePersistentAuthOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(DeletePersistentAuthOptionsInternal), Member = "set_RefreshToken")]
	[CalledBy(Type = typeof(AuthInterface), Member = "DeletePersistentAuth")]
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
