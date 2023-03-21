using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Connect;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct LinkAccountOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private IntPtr m_ContinuanceToken;

	public ProductUserId LocalUserId
	{
		[CalledBy(Type = typeof(LinkAccountOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(LinkAccountOptionsInternal), Member = "Set")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		set
		{
		}
	}

	public ContinuanceToken ContinuanceToken
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(LinkAccountOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(LinkAccountOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LinkAccountOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(LinkAccountOptionsInternal), Member = "set_ContinuanceToken")]
	public void Set(LinkAccountOptions other)
	{
	}

	[Calls(Type = typeof(LinkAccountOptionsInternal), Member = "set_ContinuanceToken")]
	[CalledBy(Type = typeof(ConnectInterface), Member = "LinkAccount")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LinkAccountOptionsInternal), Member = "set_LocalUserId")]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Dispose()
	{
	}
}
