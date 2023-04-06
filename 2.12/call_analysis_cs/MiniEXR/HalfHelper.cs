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
		return 0u;
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
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static ushort[] GenerateBaseTable()
	{
		return null;
	}

	[CalledBy(Type = typeof(HalfHelper), Member = ".cctor")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static sbyte[] GenerateShiftTable()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentException")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 2)]
	public static float HalfToSingle(ushort half)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentException")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 2)]
	public static ushort SingleToHalf(float single)
	{
		return 0;
	}

	[CalledBy(Type = typeof(MiniEXR), Member = "MiniEXRWrite")]
	[CalledBy(Type = typeof(MiniEXR), Member = "MiniEXRWrite_Depth")]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public static ushort SingleToHalf(uint singleAsUint)
	{
		return 0;
	}
}
