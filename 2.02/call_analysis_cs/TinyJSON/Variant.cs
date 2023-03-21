using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace TinyJSON;

public abstract class Variant : IConvertible
{
	protected static IFormatProvider formatProvider;

	public virtual Variant Item
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 3)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 3)]
		set
		{
		}
	}

	public virtual Variant Item
	{
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 3)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 3)]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Make<T>(out T item)
	{
		System.Runtime.CompilerServices.Unsafe.As<T, @null>(ref item) = null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public T Make<T>()
	{
		return (T)null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public virtual TypeCode GetTypeCode()
	{
		return default(TypeCode);
	}

	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public virtual object ToType(Type conversionType, IFormatProvider provider)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor")]
	[CallsUnknownMethods(Count = 3)]
	public virtual DateTime ToDateTime(IFormatProvider provider)
	{
		return default(DateTime);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor")]
	[CallsUnknownMethods(Count = 3)]
	public virtual bool ToBoolean(IFormatProvider provider)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public virtual byte ToByte(IFormatProvider provider)
	{
		return default(byte);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor")]
	[CallsUnknownMethods(Count = 3)]
	public virtual char ToChar(IFormatProvider provider)
	{
		return default(char);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor")]
	[CallsUnknownMethods(Count = 3)]
	public virtual decimal ToDecimal(IFormatProvider provider)
	{
		return default(decimal);
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public virtual double ToDouble(IFormatProvider provider)
	{
		return default(double);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor")]
	[CallsUnknownMethods(Count = 3)]
	public virtual short ToInt16(IFormatProvider provider)
	{
		return default(short);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor")]
	[CallsUnknownMethods(Count = 3)]
	public virtual int ToInt32(IFormatProvider provider)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public virtual long ToInt64(IFormatProvider provider)
	{
		return default(long);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor")]
	[CallsUnknownMethods(Count = 3)]
	public virtual sbyte ToSByte(IFormatProvider provider)
	{
		return default(sbyte);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor")]
	[CallsUnknownMethods(Count = 3)]
	public virtual float ToSingle(IFormatProvider provider)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual string ToString(IFormatProvider provider)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor")]
	[CallsUnknownMethods(Count = 3)]
	public virtual ushort ToUInt16(IFormatProvider provider)
	{
		return default(ushort);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor")]
	[CallsUnknownMethods(Count = 3)]
	public virtual uint ToUInt32(IFormatProvider provider)
	{
		return default(uint);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public virtual ulong ToUInt64(IFormatProvider provider)
	{
		return default(ulong);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public override string ToString()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static implicit operator bool(Variant variant)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static implicit operator float(Variant variant)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static implicit operator double(Variant variant)
	{
		return default(double);
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static implicit operator ushort(Variant variant)
	{
		return default(ushort);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static implicit operator short(Variant variant)
	{
		return default(short);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static implicit operator uint(Variant variant)
	{
		return default(uint);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static implicit operator int(Variant variant)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static implicit operator ulong(Variant variant)
	{
		return default(ulong);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public static implicit operator long(Variant variant)
	{
		return default(long);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static implicit operator decimal(Variant variant)
	{
		return default(decimal);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static implicit operator string(Variant variant)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	protected Variant()
	{
	}
}
