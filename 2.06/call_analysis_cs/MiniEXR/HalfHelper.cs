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

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
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

	[CalledBy(Type = typeof(HalfHelper), Member = ".cctor")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 1)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BitConverter), Member = "ToSingle")]
	[CallsUnknownMethods(Count = 2)]
	public static float HalfToSingle(ushort half)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BitConverter), Member = "ToUInt32")]
	[CallsUnknownMethods(Count = 2)]
	public static ushort SingleToHalf(float single)
	{
		return default(ushort);
	}

	[CalledBy(Type = typeof(MiniEXR), Member = "MiniEXRWrite_Depth")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(MiniEXR), Member = "MiniEXRWrite")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(MiniEXR), Member = "MiniEXRWrite")]
	[CalledBy(Type = typeof(MiniEXR), Member = "MiniEXRWrite")]
	public static ushort SingleToHalf(uint singleAsUint)
	{
		return default(ushort);
	}
}
