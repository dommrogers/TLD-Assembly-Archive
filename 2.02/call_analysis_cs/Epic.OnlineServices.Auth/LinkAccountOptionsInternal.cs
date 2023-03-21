using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Auth;

[StructLayout(0, Pack = 8, Size = 32)]
internal struct LinkAccountOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private LinkAccountFlags m_LinkAccountFlags;

	private IntPtr m_ContinuanceToken;

	private IntPtr m_LocalUserId;

	public LinkAccountFlags LinkAccountFlags
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
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

	public EpicAccountId LocalUserId
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LinkAccountOptionsInternal), Member = "set_ContinuanceToken")]
	[Calls(Type = typeof(LinkAccountOptionsInternal), Member = "set_LocalUserId")]
	public void Set(LinkAccountOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(LinkAccountOptionsInternal), Member = "set_ContinuanceToken")]
	[Calls(Type = typeof(LinkAccountOptionsInternal), Member = "set_LocalUserId")]
	[CalledBy(Type = typeof(AuthInterface), Member = "LinkAccount")]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Dispose()
	{
	}
}
