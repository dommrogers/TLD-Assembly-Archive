using System;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;

namespace TinyJSON;

public sealed class ProxyNumber : Variant
{
	private static readonly char[] floatingPointCharacters;

	private IConvertible value;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProxyNumber), Member = "Parse")]
	[CallsDeduplicatedMethods(Count = 1)]
	public ProxyNumber(IConvertible value)
	{
	}

	[CalledBy(Type = typeof(Decoder), Member = "DecodeNumber")]
	[CalledBy(Type = typeof(ProxyNumber), Member = ".ctor")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "IndexOfAny")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleInteger")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[Calls(TypeFullName = "System.Number", Member = "TryParseUInt64")]
	[Calls(TypeFullName = "System.Number", Member = "TryParseInt64")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleFloatingPoint")]
	[Calls(TypeFullName = "System.Number", Member = "TryParseDecimal")]
	[Calls(Type = typeof(double), Member = "TryParse")]
	[Calls(Type = typeof(decimal), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private IConvertible Parse(string value)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override bool ToBoolean(IFormatProvider provider)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override byte ToByte(IFormatProvider provider)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override char ToChar(IFormatProvider provider)
	{
		return '\0';
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override decimal ToDecimal(IFormatProvider provider)
	{
		return default(decimal);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override double ToDouble(IFormatProvider provider)
	{
		return 0.0;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override short ToInt16(IFormatProvider provider)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override int ToInt32(IFormatProvider provider)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override long ToInt64(IFormatProvider provider)
	{
		return 0L;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override sbyte ToSByte(IFormatProvider provider)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override float ToSingle(IFormatProvider provider)
	{
		return 0f;
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
		return 0;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override uint ToUInt32(IFormatProvider provider)
	{
		return 0u;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override ulong ToUInt64(IFormatProvider provider)
	{
		return 0uL;
	}
}
