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
		[CalledBy(Type = typeof(DeletePersistentAuthOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DeletePersistentAuthOptionsInternal), Member = "set_RefreshToken")]
	public void Set(DeletePersistentAuthOptions other)
	{
	}

	[CalledBy(Type = typeof(AuthInterface), Member = "DeletePersistentAuth")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DeletePersistentAuthOptionsInternal), Member = "set_RefreshToken")]
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
