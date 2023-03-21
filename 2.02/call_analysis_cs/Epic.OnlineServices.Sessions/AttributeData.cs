using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

public class AttributeData : ISettable
{
	private string _003CKey_003Ek__BackingField;

	private AttributeDataValue _003CValue_003Ek__BackingField;

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

	public AttributeDataValue Value
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
	[Calls(Type = typeof(AttributeDataInternal), Member = "get_Key")]
	[Calls(Type = typeof(AttributeDataInternal), Member = "get_Value")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal void Set(AttributeDataInternal? other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AttributeDataInternal), Member = "get_Key")]
	[Calls(Type = typeof(AttributeDataInternal), Member = "get_Value")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public AttributeData()
	{
	}
}
