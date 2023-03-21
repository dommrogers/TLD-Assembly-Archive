using System;
using Cpp2ILInjected.CallAnalysis;

namespace MiniEXR;

internal static class HalfHelper
{
	private static uint[] mantissaTable;

	private static uint[] exponentTable;

	private static ushort[] offsetTable;

	private static ushort[] baseTable;

	private static sbyte[] shiftTable;

	[CallerCount(Count = 0)]
	private static uint ConvertMantissa(int i)
	{
		return default(uint);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static uint[] GenerateMantissaTable()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private static uint[] GenerateExponentTable()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static ushort[] GenerateOffsetTable()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(HalfHelper), Member = ".cctor")]
	[CallsUnknownMethods(Count = 2)]
	private static ushort[] GenerateBaseTable()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(HalfHelper), Member = ".cctor")]
	[CallsUnknownMethods(Count = 2)]
	private static sbyte[] GenerateShiftTable()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentException")]
	public static float HalfToSingle(ushort half)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 2)]
	public static ushort SingleToHalf(float single)
	{
		return default(ushort);
	}

	[CalledBy(Type = typeof(MiniEXR), Member = "MiniEXRWrite_Depth")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(MiniEXR), Member = "MiniEXRWrite")]
	[CalledBy(Type = typeof(MiniEXR), Member = "MiniEXRWrite")]
	[CalledBy(Type = typeof(MiniEXR), Member = "MiniEXRWrite")]
	[CallsUnknownMethods(Count = 2)]
	public static ushort SingleToHalf(uint singleAsUint)
	{
		return default(ushort);
	}
}
