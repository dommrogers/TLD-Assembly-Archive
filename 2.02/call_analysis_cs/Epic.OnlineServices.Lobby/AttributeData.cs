using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Lobby;

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
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 101)]
		set
		{
		}
	}

	public AttributeDataValue Value
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 29)]
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

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(AttributeDataInternal), Member = "get_Value")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AttributeDataInternal), Member = "get_Key")]
	internal void Set(AttributeDataInternal? other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(AttributeDataInternal), Member = "get_Key")]
	[Calls(Type = typeof(AttributeDataInternal), Member = "get_Value")]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public AttributeData()
	{
	}
}
