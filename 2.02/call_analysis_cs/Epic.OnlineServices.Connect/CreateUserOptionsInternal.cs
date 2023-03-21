using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Connect;

[StructLayout(0, Pack = 8, Size = 16)]
internal struct CreateUserOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_ContinuanceToken;

	public ContinuanceToken ContinuanceToken
	{
		[CalledBy(Type = typeof(CreateUserOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(CreateUserOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[Calls(Type = typeof(CreateUserOptionsInternal), Member = "set_ContinuanceToken")]
	[CallerCount(Count = 0)]
	public void Set(CreateUserOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CreateUserOptionsInternal), Member = "set_ContinuanceToken")]
	[CalledBy(Type = typeof(ConnectInterface), Member = "CreateUser")]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Dispose()
	{
	}
}
