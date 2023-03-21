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
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		set
		{
		}
	}

	public string BucketId
	{
		[CalledBy(Type = typeof(CreateSessionModificationOptionsInternal), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallerCount(Count = 1)]
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
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(CreateSessionModificationOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public bool PresenceEnabled
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(CreateSessionModificationOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public string SessionId
	{
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(CreateSessionModificationOptionsInternal), Member = "Set")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CreateSessionModificationOptionsInternal), Member = "set_SessionName")]
	[Calls(Type = typeof(CreateSessionModificationOptionsInternal), Member = "set_BucketId")]
	[Calls(Type = typeof(CreateSessionModificationOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(CreateSessionModificationOptionsInternal), Member = "set_PresenceEnabled")]
	[Calls(Type = typeof(CreateSessionModificationOptionsInternal), Member = "set_SessionId")]
	[CalledBy(Type = typeof(CreateSessionModificationOptionsInternal), Member = "Set")]
	public void Set(CreateSessionModificationOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CreateSessionModificationOptionsInternal), Member = "Set")]
	[CalledBy(Type = typeof(SessionsInterface), Member = "CreateSessionModification")]
	public void Set(object other)
	{
	}

	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Dispose()
	{
	}
}
