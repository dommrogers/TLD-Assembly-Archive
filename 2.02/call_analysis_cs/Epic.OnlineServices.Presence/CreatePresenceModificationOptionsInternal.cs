using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Presence;

[StructLayout(0, Pack = 8, Size = 16)]
internal struct CreatePresenceModificationOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	public EpicAccountId LocalUserId
	{
		[CalledBy(Type = typeof(CreatePresenceModificationOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CreatePresenceModificationOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CreatePresenceModificationOptionsInternal), Member = "set_LocalUserId")]
	public void Set(CreatePresenceModificationOptions other)
	{
	}

	[CalledBy(Type = typeof(PresenceInterface), Member = "CreatePresenceModification")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CreatePresenceModificationOptionsInternal), Member = "set_LocalUserId")]
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
