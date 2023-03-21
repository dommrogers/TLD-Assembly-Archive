using System;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace DigitalOpus.MB.Core;

public struct DVector2
{
	private static double epsilon;

	public double x;

	public double y;

	[CallerCount(Count = 0)]
	public static DVector2 Subtract(DVector2 a, DVector2 b)
	{
		return default(DVector2);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public DVector2(double xx, double yy)
	{
	}

	[CallerCount(Count = 0)]
	public DVector2(DVector2 r)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Vector2 GetVector2()
	{
		return default(Vector2);
	}

	[CallerCount(Count = 0)]
	public bool IsContainedIn(DRect r)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool IsContainedInWithMargin(DRect r)
	{
		return default(bool);
	}

	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override string ToString()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatDouble")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatDouble")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	public string ToString(string formatS)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static double Distance(DVector2 a, DVector2 b)
	{
		return default(double);
	}
}
