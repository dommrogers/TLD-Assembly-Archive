using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

[StructLayout(0, Pack = 8, Size = 56)]
internal struct CreateSessionModificationOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_SessionName;

	private IntPtr m_BucketId;

	private uint m_MaxPlayers;

	private IntPtr m_LocalUserId;

	private int m_PresenceEnabled;

	private IntPtr m_SessionId;

	public string SessionName
	{
		[CalledBy(Type = typeof(CreateSessionModificationOptionsInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string BucketId
	{
		[CalledBy(Type = typeof(CreateSessionModificationOptionsInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public uint MaxPlayers
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public ProductUserId LocalUserId
	{
		[CalledBy(Type = typeof(CreateSessionModificationOptionsInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public bool PresenceEnabled
	{
		[CalledBy(Type = typeof(CreateSessionModificationOptionsInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string SessionId
	{
		[CalledBy(Type = typeof(CreateSessionModificationOptionsInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(CreateSessionModificationOptionsInternal), Member = "Set")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CreateSessionModificationOptionsInternal), Member = "set_SessionName")]
	[Calls(Type = typeof(CreateSessionModificationOptionsInternal), Member = "set_BucketId")]
	[Calls(Type = typeof(CreateSessionModificationOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(CreateSessionModificationOptionsInternal), Member = "set_PresenceEnabled")]
	[Calls(Type = typeof(CreateSessionModificationOptionsInternal), Member = "set_SessionId")]
	public void Set(CreateSessionModificationOptions other)
	{
	}

	[CalledBy(Type = typeof(SessionsInterface), Member = "CreateSessionModification")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CreateSessionModificationOptionsInternal), Member = "Set")]
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
