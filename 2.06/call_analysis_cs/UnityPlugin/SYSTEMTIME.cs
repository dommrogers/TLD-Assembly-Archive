using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace UnityPlugin;

[StructLayout(0, Pack = 2, Size = 16)]
public struct SYSTEMTIME
{
	public short Year;

	public short Month;

	public short DayOfWeek;

	public short Day;

	public short Hour;

	public short Minute;

	public short Second;

	public short Milliseconds;

	public static readonly SYSTEMTIME MinValue;

	public static readonly SYSTEMTIME MaxValue;

	[CallerCount(Count = 0)]
	public SYSTEMTIME(short year, short month, short day, short hour = 0, short minute = 0, short second = 0, short millisecond = 0)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTime), Member = "ToUniversalTime")]
	[Calls(Type = typeof(DateTime), Member = "GetDatePart")]
	public SYSTEMTIME(DateTime dt)
	{
	}

	[CallerCount(Count = 0)]
	static SYSTEMTIME()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTime), Member = ".ctor")]
	public DateTime ToDateTime()
	{
		return default(DateTime);
	}

	[CallerCount(Count = 0)]
	public static bool operator ==(SYSTEMTIME s1, SYSTEMTIME s2)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public static bool operator !=(SYSTEMTIME s1, SYSTEMTIME s2)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ValueType), Member = "DefaultEquals")]
	[CallsUnknownMethods(Count = 1)]
	public override bool Equals(object obj)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ValueType), Member = "GetHashCode")]
	public override int GetHashCode()
	{
		return 0;
	}
}
