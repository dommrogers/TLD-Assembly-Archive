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
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private static uint[] GenerateMantissaTable()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	private static uint[] GenerateExponentTable()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	[CallerCount(Count = 0)]
	private static ushort[] GenerateOffsetTable()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(HalfHelper), Member = ".cctor")]
	[CallsUnknownMethods(Count = 25)]
	private static ushort[] GenerateBaseTable()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(HalfHelper), Member = ".cctor")]
	[CallsUnknownMethods(Count = 25)]
	private static sbyte[] GenerateShiftTable()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(BitConverter), Member = "GetBytes")]
	[Calls(Type = typeof(BitConverter), Member = "ToSingle")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static float HalfToSingle(ushort half)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BitConverter), Member = "GetBytes")]
	[Calls(Type = typeof(BitConverter), Member = "ToUInt32")]
	[CallsUnknownMethods(Count = 6)]
	public static ushort SingleToHalf(float single)
	{
		return default(ushort);
	}

	[CalledBy(Type = typeof(MiniEXR), Member = "MiniEXRWrite_Depth")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(MiniEXR), Member = "MiniEXRWrite")]
	[CalledBy(Type = typeof(MiniEXR), Member = "MiniEXRWrite")]
	[CalledBy(Type = typeof(MiniEXR), Member = "MiniEXRWrite")]
	[CallsUnknownMethods(Count = 6)]
	public static ushort SingleToHalf(uint singleAsUint)
	{
		return default(ushort);
	}
}
