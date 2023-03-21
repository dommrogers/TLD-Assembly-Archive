using System;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;

namespace TinyJSON;

public sealed class ProxyNumber : Variant
{
	private static readonly char[] floatingPointCharacters;

	private IConvertible value;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ProxyNumber), Member = "Parse")]
	public ProxyNumber(IConvertible value)
	{
	}

	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleFloatingPoint")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[Calls(Type = typeof(System.Number), Member = "TryParseDecimal")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo")]
	[CalledBy(Type = typeof(Decoder), Member = "DecodeNumber")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo")]
	[CalledBy(Type = typeof(ProxyNumber), Member = ".ctor")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(decimal), Member = "op_Equality")]
	[Calls(Type = typeof(System.Number), Member = "TryParseInt64")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleInteger")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo")]
	[Calls(Type = typeof(System.Number), Member = "TryParseUInt64")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleInteger")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "IndexOfAny")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	private IConvertible Parse(string value)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public override bool ToBoolean(IFormatProvider provider)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override byte ToByte(IFormatProvider provider)
	{
		return default(byte);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override char ToChar(IFormatProvider provider)
	{
		return default(char);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override decimal ToDecimal(IFormatProvider provider)
	{
		return default(decimal);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public override double ToDouble(IFormatProvider provider)
	{
		return default(double);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override short ToInt16(IFormatProvider provider)
	{
		return default(short);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override int ToInt32(IFormatProvider provider)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override long ToInt64(IFormatProvider provider)
	{
		return default(long);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override sbyte ToSByte(IFormatProvider provider)
	{
		return default(sbyte);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public override float ToSingle(IFormatProvider provider)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override string ToString(IFormatProvider provider)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override ushort ToUInt16(IFormatProvider provider)
	{
		return default(ushort);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override uint ToUInt32(IFormatProvider provider)
	{
		return default(uint);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override ulong ToUInt64(IFormatProvider provider)
	{
		return default(ulong);
	}
}
