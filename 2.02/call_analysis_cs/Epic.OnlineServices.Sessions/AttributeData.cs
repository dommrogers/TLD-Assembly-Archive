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
		[CallerCount(Count = 52)]
		get
		{
			return null;
		}
		[CallerCount(Count = 101)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public AttributeDataValue Value
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 29)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 71)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AttributeDataInternal), Member = "get_Key")]
	[Calls(Type = typeof(AttributeDataInternal), Member = "get_Value")]
	[CallsUnknownMethods(Count = 2)]
	internal void Set(AttributeDataInternal? other)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(AttributeDataInternal), Member = "get_Value")]
	[Calls(Type = typeof(AttributeDataInternal), Member = "get_Key")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public AttributeData()
	{
	}
}
