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
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public ContinuanceToken ContinuanceToken
	{
		[CalledBy(Type = typeof(LinkAccountOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(LinkAccountOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
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

	[CalledBy(Type = typeof(ConnectInterface), Member = "LinkAccount")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LinkAccountOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(LinkAccountOptionsInternal), Member = "set_ContinuanceToken")]
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
