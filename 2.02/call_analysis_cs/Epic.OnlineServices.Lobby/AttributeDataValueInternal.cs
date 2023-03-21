using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Lobby;

[StructLayout(2, Pack = 1, Size = 16)]
internal struct AttributeDataValueInternal : ISettable, IDisposable
{
	private long m_AsInt64;

	private double m_AsDouble;

	private int m_AsBool;

	private IntPtr m_AsUtf8;

	private AttributeType m_ValueType;

	public long? AsInt64
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(AttributeDataValue), Member = "Set")]
		[CalledBy(Type = typeof(AttributeDataValue), Member = "Set")]
		get
		{
			return null;
		}
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(AttributeDataValueInternal), Member = "Set")]
		set
		{
		}
	}

	public double? AsDouble
	{
		[CalledBy(Type = typeof(AttributeDataValue), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(AttributeDataValue), Member = "Set")]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(AttributeDataValueInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		set
		{
		}
	}

	public bool? AsBool
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(AttributeDataValue), Member = "Set")]
		[CalledBy(Type = typeof(AttributeDataValue), Member = "Set")]
		get
		{
			return null;
		}
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(AttributeDataValueInternal), Member = "Set")]
		set
		{
		}
	}

	public string AsUtf8
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(AttributeDataValue), Member = "Set")]
		[CalledBy(Type = typeof(AttributeDataValue), Member = "Set")]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(AttributeDataValueInternal), Member = "Set")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(AttributeDataValueInternal), Member = "set_AsInt64")]
	[Calls(Type = typeof(AttributeDataValueInternal), Member = "set_AsDouble")]
	[Calls(Type = typeof(AttributeDataValueInternal), Member = "set_AsBool")]
	[Calls(Type = typeof(AttributeDataValueInternal), Member = "set_AsUtf8")]
	[CalledBy(Type = typeof(AttributeDataValueInternal), Member = "Set")]
	[CallsUnknownMethods(Count = 3)]
	public void Set(AttributeDataValue other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AttributeDataValueInternal), Member = "Set")]
	[CalledBy(Type = typeof(Helper), Member = "TryConvert")]
	public void Set(object other)
	{
	}

	[CalledBy(Type = typeof(AttributeDataInternal), Member = "Dispose")]
	[CalledBy(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Dispose()
	{
	}
}
