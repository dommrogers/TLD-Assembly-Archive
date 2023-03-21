using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace DigitalOpus.MB.Core;

public class MB3_UVTransformUtility
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Vector2), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void Test()
	{
	}

	[CallerCount(Count = 0)]
	public static float TransformX(DRect r, double x)
	{
		return 0f;
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

	[CalledBy(Type = typeof(MB_TexSet), Member = "DrawRectsToMergeGizmos")]
	[CalledBy(Type = typeof(MB3_TextureCombinerMerging), Member = "BuildTransformMeshUV2AtlasRect")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Convert), Member = "ToInt32")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static DRect GetShiftTransformToFitBinA(ref DRect A, ref DRect B)
	{
		return default(DRect);
	}

	[CalledBy(Type = typeof(MB3_TextureCombinerMerging), Member = "MergeOverlappingDistinctMaterialTexturesAndCalcMaterialSubrects")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Convert), Member = "ToInt32")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static DRect GetEncapsulatingRectShifted(ref DRect uvRect1, ref DRect willBeIn)
	{
		return default(DRect);
	}

	[CallerCount(Count = 0)]
	public static DRect GetEncapsulatingRect(ref DRect uvRect1, ref DRect uvRect2)
	{
		return default(DRect);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToInt32")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool RectContainsShifted(ref DRect bucket, ref DRect tryFit)
	{
		return false;
	}

	[CalledBy(Type = typeof(MB2_TextureBakeResults), Member = "IsMeshAndMaterialRectEnclosedByAtlasRect")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ToInt32")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool RectContainsShifted(ref Rect bucket, ref Rect tryFit)
	{
		return false;
	}

	[CalledBy(Type = typeof(MB2_TextureBakeResults), Member = "IsMeshAndMaterialRectEnclosedByAtlasRect")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Convert), Member = "ToInt32")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool LineSegmentContainsShifted(float bucketOffset, float bucketLength, float tryFitOffset, float tryFitLength)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public static bool RectContains(ref DRect bigRect, ref DRect smallToTestIfFits)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public static bool RectContains(ref Rect bigRect, ref Rect smallToTestIfFits)
	{
		return false;
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
	[CallerCount(Count = 7)]
	public MB3_UVTransformUtility()
	{
	}
}
