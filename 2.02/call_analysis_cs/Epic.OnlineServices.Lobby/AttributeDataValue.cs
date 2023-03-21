using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Lobby;

public class AttributeDataValue : ISettable
{
	private long? m_AsInt64;

	private double? m_AsDouble;

	private bool? m_AsBool;

	private string m_AsUtf8;

	private AttributeType m_ValueType;

	public long? AsInt64
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(AttributeDataValue), Member = "op_Implicit")]
		[CalledBy(Type = typeof(AttributeDataValue), Member = "Set")]
		[CalledBy(Type = typeof(AttributeDataValue), Member = "Set")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public double? AsDouble
	{
		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(AttributeDataValue), Member = "op_Implicit")]
		[CalledBy(Type = typeof(AttributeDataValue), Member = "Set")]
		[CalledBy(Type = typeof(AttributeDataValue), Member = "Set")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public bool? AsBool
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(AttributeDataValue), Member = "Set")]
		[CalledBy(Type = typeof(AttributeDataValue), Member = "Set")]
		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 3)]
		[CalledBy(Type = typeof(AttributeDataValue), Member = "op_Implicit")]
		set
		{
		}
	}

	public string AsUtf8
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(AttributeDataValue), Member = "op_Implicit")]
		[CalledBy(Type = typeof(AttributeDataValue), Member = "Set")]
		[CalledBy(Type = typeof(AttributeDataValue), Member = "Set")]
		set
		{
		}
	}

	public AttributeType ValueType
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(AttributeType);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(AttributeDataValue), Member = "set_AsInt64")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static implicit operator AttributeDataValue(long? value)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AttributeDataValue), Member = "set_AsDouble")]
	[CallsUnknownMethods(Count = 8)]
	public static implicit operator AttributeDataValue(double? value)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AttributeDataValue), Member = "set_AsBool")]
	[CallsUnknownMethods(Count = 8)]
	public static implicit operator AttributeDataValue(bool? value)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AttributeDataValue), Member = "set_AsUtf8")]
	public static implicit operator AttributeDataValue(string value)
	{
		return null;
	}

	[Calls(Type = typeof(AttributeDataValueInternal), Member = "get_AsUtf8")]
	[Calls(Type = typeof(AttributeDataValue), Member = "set_AsBool")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(AttributeDataValue), Member = "set_AsUtf8")]
	[Calls(Type = typeof(AttributeDataValueInternal), Member = "get_AsBool")]
	[Calls(Type = typeof(AttributeDataValueInternal), Member = "get_AsInt64")]
	[Calls(Type = typeof(AttributeDataValueInternal), Member = "get_AsDouble")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AttributeDataValue), Member = "set_AsDouble")]
	[Calls(Type = typeof(AttributeDataValue), Member = "set_AsInt64")]
	internal void Set(AttributeDataValueInternal? other)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(AttributeDataValueInternal), Member = "get_AsUtf8")]
	[Calls(Type = typeof(AttributeDataValue), Member = "set_AsBool")]
	[Calls(Type = typeof(AttributeDataValueInternal), Member = "get_AsBool")]
	[Calls(Type = typeof(AttributeDataValue), Member = "set_AsDouble")]
	[Calls(Type = typeof(AttributeDataValue), Member = "set_AsUtf8")]
	[Calls(Type = typeof(AttributeDataValue), Member = "set_AsInt64")]
	[Calls(Type = typeof(AttributeDataValueInternal), Member = "get_AsInt64")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(AttributeDataValueInternal), Member = "get_AsDouble")]
	[CallerCount(Count = 0)]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public AttributeDataValue()
	{
	}
}
