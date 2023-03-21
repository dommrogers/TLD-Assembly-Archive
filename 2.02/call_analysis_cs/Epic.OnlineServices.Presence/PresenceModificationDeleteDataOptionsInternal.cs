using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Presence;

[StructLayout(0, Pack = 8, Size = 16)]
internal struct PresenceModificationDeleteDataOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private int m_RecordsCount;

	private IntPtr m_Records;

	public PresenceModificationDataRecordId[] Records
	{
		[CalledBy(Type = typeof(PresenceModificationDeleteDataOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(PresenceModificationDeleteDataOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PresenceModificationDeleteDataOptionsInternal), Member = "set_Records")]
	public void Set(PresenceModificationDeleteDataOptions other)
	{
	}

	[CalledBy(Type = typeof(PresenceModification), Member = "DeleteData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PresenceModificationDeleteDataOptionsInternal), Member = "set_Records")]
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
