using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace DigitalOpus.MB.Core;

public class MB3_UVTransformUtility
{
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Vector2), Member = "ToString")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Vector2), Member = "ToString")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Vector2), Member = "ToString")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static void Test()
	{
	}

	[CallerCount(Count = 0)]
	public static float TransformX(DRect r, double x)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public static DRect CombineTransforms(ref DRect r1, ref DRect r2)
	{
		return default(DRect);
	}

	[CallerCount(Count = 0)]
	public static Rect CombineTransforms(ref Rect r1, ref Rect r2)
	{
		return default(Rect);
	}

	[CallerCount(Count = 0)]
	public static DRect InverseTransform(ref DRect t)
	{
		return default(DRect);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ToInt32")]
	[Calls(Type = typeof(Convert), Member = "ToInt32")]
	[CalledBy(Type = typeof(MB_TexSet), Member = "DrawRectsToMergeGizmos")]
	[CalledBy(Type = typeof(MB3_TextureCombinerMerging), Member = "BuildTransformMeshUV2AtlasRect")]
	public static DRect GetShiftTransformToFitBinA(ref DRect A, ref DRect B)
	{
		return default(DRect);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ToInt32")]
	[Calls(Type = typeof(Convert), Member = "ToInt32")]
	public static DRect GetEncapsulatingRectShifted(ref DRect uvRect1, ref DRect willBeIn)
	{
		return default(DRect);
	}

	[CallerCount(Count = 0)]
	public static DRect GetEncapsulatingRect(ref DRect uvRect1, ref DRect uvRect2)
	{
		return default(DRect);
	}

	[Calls(Type = typeof(Convert), Member = "ToInt32")]
	[Calls(Type = typeof(Convert), Member = "ToInt32")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool RectContainsShifted(ref DRect bucket, ref DRect tryFit)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ToInt32")]
	[Calls(Type = typeof(Convert), Member = "ToInt32")]
	[CalledBy(Type = typeof(MB2_TextureBakeResults), Member = "IsMeshAndMaterialRectEnclosedByAtlasRect")]
	public static bool RectContainsShifted(ref Rect bucket, ref Rect tryFit)
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ToInt32")]
	[CalledBy(Type = typeof(MB2_TextureBakeResults), Member = "IsMeshAndMaterialRectEnclosedByAtlasRect")]
	[CalledBy(Type = typeof(MB2_TextureBakeResults), Member = "IsMeshAndMaterialRectEnclosedByAtlasRect")]
	public static bool LineSegmentContainsShifted(float bucketOffset, float bucketLength, float tryFitOffset, float tryFitLength)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public static bool RectContains(ref DRect bigRect, ref DRect smallToTestIfFits)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public static bool RectContains(ref Rect bigRect, ref Rect smallToTestIfFits)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public static Vector2 TransformPoint(ref DRect r, Vector2 p)
	{
		return default(Vector2);
	}

	[CallerCount(Count = 0)]
	public static DVector2 TransformPoint(ref DRect r, DVector2 p)
	{
		return default(DVector2);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public MB3_UVTransformUtility()
	{
	}
}
