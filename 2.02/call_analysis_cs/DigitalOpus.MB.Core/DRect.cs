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

	[CalledBy(TypeFullName = "DigitalOpus.MB.Core.MB3_TextureCombinerPipeline.<__Step1_CollectDistinctMatTexturesAndUsedObjects>d__8", Member = "MoveNext")]
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

	[CalledBy(Type = typeof(DRect), Member = "op_Equality")]
	[CalledBy(Type = typeof(DRect), Member = "op_Inequality")]
	[CalledBy(Type = typeof(MatAndTransformToMerged), Member = "Equals")]
	[CalledBy(Type = typeof(MB_TexSet), Member = "IsEqual")]
	[CalledBy(Type = typeof(MB3_TextureCombinerMerging), Member = "MergeOverlappingDistinctMaterialTexturesAndCalcMaterialSubrects")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override bool Equals(object obj)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DRect), Member = "Equals")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool operator ==(DRect a, DRect b)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DRect), Member = "Equals")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool operator !=(DRect a, DRect b)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatDouble")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 17)]
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
		return false;
	}

	[CallerCount(Count = 0)]
	public override int GetHashCode()
	{
		return 0;
	}
}
