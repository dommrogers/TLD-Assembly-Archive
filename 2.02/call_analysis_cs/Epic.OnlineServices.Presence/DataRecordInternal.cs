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
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(DataRecord), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(DataRecord), Member = "Set")]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(DataRecordInternal), Member = "Set")]
		[CalledBy(Type = typeof(DataRecordInternal), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
		set
		{
		}
	}

	public string Value
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(DataRecord), Member = "Set")]
		[CalledBy(Type = typeof(DataRecord), Member = "Set")]
		get
		{
			return null;
		}
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(DataRecordInternal), Member = "Set")]
		[CalledBy(Type = typeof(DataRecordInternal), Member = "Set")]
		set
		{
		}
	}

	[Calls(Type = typeof(DataRecordInternal), Member = "set_Value")]
	[Calls(Type = typeof(DataRecordInternal), Member = "set_Key")]
	[CallerCount(Count = 0)]
	public void Set(DataRecord other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(DataRecordInternal), Member = "set_Key")]
	[Calls(Type = typeof(DataRecordInternal), Member = "set_Value")]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	public void Dispose()
	{
	}
}
