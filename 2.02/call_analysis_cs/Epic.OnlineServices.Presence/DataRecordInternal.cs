using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Presence;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct DataRecordInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_Key;

	private IntPtr m_Value;

	public string Key
	{
		[CalledBy(Type = typeof(DataRecord), Member = "Set")]
		[CalledBy(Type = typeof(DataRecord), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(DataRecordInternal), Member = "Set")]
		[CalledBy(Type = typeof(DataRecordInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string Value
	{
		[CalledBy(Type = typeof(DataRecord), Member = "Set")]
		[CalledBy(Type = typeof(DataRecord), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(DataRecordInternal), Member = "Set")]
		[CalledBy(Type = typeof(DataRecordInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataRecordInternal), Member = "set_Key")]
	[Calls(Type = typeof(DataRecordInternal), Member = "set_Value")]
	public void Set(DataRecord other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataRecordInternal), Member = "set_Key")]
	[Calls(Type = typeof(DataRecordInternal), Member = "set_Value")]
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
