using System;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace DigitalOpus.MB.Core;

public struct DRect
{
	public double x;

	public double y;

	public double width;

	public double height;

	public DVector2 minD
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(DVector2);
		}
	}

	public DVector2 maxD
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(DVector2);
		}
	}

	public Vector2 min
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(Vector2);
		}
	}

	public Vector2 max
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(Vector2);
		}
	}

	public Vector2 size
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(Vector2);
		}
	}

	public DVector2 center
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(DVector2);
		}
	}

	[CallerCount(Count = 0)]
	public DRect(Rect r)
	{
	}

	[CalledBy(Type = typeof(MB3_TextureCombinerPipeline._003C__Step1_CollectDistinctMatTexturesAndUsedObjects_003Ed__8), Member = "MoveNext")]
	[CallerCount(Count = 1)]
	public DRect(Vector2 o, Vector2 s)
	{
	}

	[CallerCount(Count = 0)]
	public DRect(DRect r)
	{
	}

	[CallerCount(Count = 0)]
	public DRect(float xx, float yy, float w, float h)
	{
	}

	[CallerCount(Count = 0)]
	public DRect(double xx, double yy, double w, double h)
	{
	}

	[CallerCount(Count = 0)]
	public Rect GetRect()
	{
		return default(Rect);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(MB_TexSet), Member = "IsEqual")]
	[CalledBy(Type = typeof(MatAndTransformToMerged), Member = "Equals")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(DRect), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(DRect), Member = "op_Inequality")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Calls(Type = typeof(DRect), Member = "Equals")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool operator ==(DRect a, DRect b)
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(DRect), Member = "Equals")]
	[CallerCount(Count = 0)]
	public static bool operator !=(DRect a, DRect b)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(System.Number), Member = "FormatDouble")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(System.Number), Member = "FormatDouble")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatDouble")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Number), Member = "FormatDouble")]
	public override string ToString()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public void Expand(float amt)
	{
	}

	[CallerCount(Count = 0)]
	public bool Encloses(DRect smallToTestIfFits)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public override int GetHashCode()
	{
		return default(int);
	}
}
