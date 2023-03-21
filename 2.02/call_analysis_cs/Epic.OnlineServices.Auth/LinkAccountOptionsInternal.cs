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
		[CalledBy(Type = typeof(LinkAccountOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(LinkAccountOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public EpicAccountId LocalUserId
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
	[Calls(Type = typeof(LinkAccountOptionsInternal), Member = "set_ContinuanceToken")]
	[Calls(Type = typeof(LinkAccountOptionsInternal), Member = "set_LocalUserId")]
	public void Set(LinkAccountOptions other)
	{
	}

	[CalledBy(Type = typeof(AuthInterface), Member = "LinkAccount")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LinkAccountOptionsInternal), Member = "set_ContinuanceToken")]
	[Calls(Type = typeof(LinkAccountOptionsInternal), Member = "set_LocalUserId")]
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
