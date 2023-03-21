using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Presence;

[StructLayout(0, Pack = 8, Size = 16)]
internal struct PresenceModificationDataRecordIdInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_Key;

	public string Key
	{
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(PresenceModificationDataRecordId), Member = "Set")]
		[CalledBy(Type = typeof(PresenceModificationDataRecordId), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(PresenceModificationDataRecordIdInternal), Member = "Set")]
		[CalledBy(Type = typeof(PresenceModificationDataRecordIdInternal), Member = "Set")]
		set
		{
		}
	}

	[Calls(Type = typeof(PresenceModificationDataRecordIdInternal), Member = "set_Key")]
	[CallerCount(Count = 0)]
	public void Set(PresenceModificationDataRecordId other)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PresenceModificationDataRecordIdInternal), Member = "set_Key")]
	[CallerCount(Count = 0)]
	public void Set(object other)
	{
	}

	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Dispose()
	{
	}
}
