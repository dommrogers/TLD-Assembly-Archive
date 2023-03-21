using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Presence;

[StructLayout(0, Pack = 8, Size = 16)]
internal struct PresenceModificationSetDataOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private int m_RecordsCount;

	private IntPtr m_Records;

	public DataRecord[] Records
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(PresenceModificationSetDataOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(PresenceModificationSetDataOptionsInternal), Member = "Set")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PresenceModificationSetDataOptionsInternal), Member = "set_Records")]
	public void Set(PresenceModificationSetDataOptions other)
	{
	}

	[CalledBy(Type = typeof(PresenceModification), Member = "SetData")]
	[Calls(Type = typeof(PresenceModificationSetDataOptionsInternal), Member = "set_Records")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
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
