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
		[CallerCount(Count = 59)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 103)]
		set
		{
		}
	}

	public string Value
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 35)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 77)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataRecordInternal), Member = "get_Key")]
	[Calls(Type = typeof(DataRecordInternal), Member = "get_Value")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal void Set(DataRecordInternal? other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataRecordInternal), Member = "get_Key")]
	[Calls(Type = typeof(DataRecordInternal), Member = "get_Value")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public DataRecord()
	{
	}
}
