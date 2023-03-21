using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

[StructLayout(2, Pack = 1, Size = 16)]
internal struct AttributeDataValueInternal : ISettable, IDisposable
{
	[FieldOffset(0)]
	private long m_AsInt64;

	[FieldOffset(0)]
	private double m_AsDouble;

	[FieldOffset(0)]
	private int m_AsBool;

	[FieldOffset(0)]
	private IntPtr m_AsUtf8;

	[FieldOffset(8)]
	private AttributeType m_ValueType;

	public long? AsInt64
	{
		[CalledBy(Type = typeof(AttributeDataValue), Member = "Set")]
		[CalledBy(Type = typeof(AttributeDataValue), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(AttributeDataValueInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public double? AsDouble
	{
		[CalledBy(Type = typeof(AttributeDataValue), Member = "Set")]
		[CalledBy(Type = typeof(AttributeDataValue), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(AttributeDataValueInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public bool? AsBool
	{
		[CalledBy(Type = typeof(AttributeDataValue), Member = "Set")]
		[CalledBy(Type = typeof(AttributeDataValue), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(AttributeDataValueInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string AsUtf8
	{
		[CalledBy(Type = typeof(AttributeDataValue), Member = "Set")]
		[CalledBy(Type = typeof(AttributeDataValue), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(AttributeDataValueInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(AttributeDataValueInternal), Member = "Set")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AttributeDataValueInternal), Member = "set_AsInt64")]
	[Calls(Type = typeof(AttributeDataValueInternal), Member = "set_AsDouble")]
	[Calls(Type = typeof(AttributeDataValueInternal), Member = "set_AsBool")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[Calls(Type = typeof(AttributeDataValueInternal), Member = "set_AsUtf8")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	public void Set(AttributeDataValue other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AttributeDataValueInternal), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[CalledBy(Type = typeof(AttributeDataInternal), Member = "Dispose")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Dispose()
	{
	}
}
