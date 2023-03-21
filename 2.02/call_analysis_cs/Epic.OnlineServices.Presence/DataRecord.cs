using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Presence;

public class DataRecord : ISettable
{
	private string _003CKey_003Ek__BackingField;

	private string _003CValue_003Ek__BackingField;

	public string Key
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 52)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 101)]
		set
		{
		}
	}

	public string Value
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 29)]
		get
		{
			return null;
		}
		[CallerCount(Count = 71)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(DataRecordInternal), Member = "get_Key")]
	[Calls(Type = typeof(DataRecordInternal), Member = "get_Value")]
	[CallsUnknownMethods(Count = 2)]
	internal void Set(DataRecordInternal? other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(DataRecordInternal), Member = "get_Key")]
	[Calls(Type = typeof(DataRecordInternal), Member = "get_Value")]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public DataRecord()
	{
	}
}
