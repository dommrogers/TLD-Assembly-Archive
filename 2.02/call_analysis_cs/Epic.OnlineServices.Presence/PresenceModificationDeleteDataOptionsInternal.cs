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
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PresenceModificationDeleteDataOptionsInternal), Member = "set_Records")]
	public void Set(PresenceModificationDeleteDataOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PresenceModificationDeleteDataOptionsInternal), Member = "set_Records")]
	[CalledBy(Type = typeof(PresenceModification), Member = "DeleteData")]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	public void Dispose()
	{
	}
}
