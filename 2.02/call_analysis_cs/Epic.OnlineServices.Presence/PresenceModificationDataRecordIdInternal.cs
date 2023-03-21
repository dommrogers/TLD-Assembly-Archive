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
		[CalledBy(Type = typeof(PresenceModificationDataRecordId), Member = "Set")]
		[CalledBy(Type = typeof(PresenceModificationDataRecordId), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(PresenceModificationDataRecordIdInternal), Member = "Set")]
		[CalledBy(Type = typeof(PresenceModificationDataRecordIdInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PresenceModificationDataRecordIdInternal), Member = "set_Key")]
	public void Set(PresenceModificationDataRecordId other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PresenceModificationDataRecordIdInternal), Member = "set_Key")]
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
