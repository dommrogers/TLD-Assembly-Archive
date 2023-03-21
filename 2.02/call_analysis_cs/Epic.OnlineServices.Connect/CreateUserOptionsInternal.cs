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
		[CalledBy(Type = typeof(CreateUserOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CreateUserOptionsInternal), Member = "set_ContinuanceToken")]
	public void Set(CreateUserOptions other)
	{
	}

	[CalledBy(Type = typeof(ConnectInterface), Member = "CreateUser")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CreateUserOptionsInternal), Member = "set_ContinuanceToken")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void Dispose()
	{
	}
}
