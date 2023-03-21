using System;
using Cpp2ILInjected.CallAnalysis;
using DigitalOpus.MB.Core;
using UnityEngine;

[Serializable]
public class MB_MaterialAndUVRect
{
	public Material material;

	public Rect atlasRect;

	public string srcObjName;

	public bool allPropsUseSameTiling;

	public Rect allPropsUseSameTiling_sourceMaterialTiling;

	public Rect allPropsUseSameTiling_samplingEncapsulatinRect;

	public Rect propsUseDifferntTiling_srcUVsamplingRect;

	public MB_TextureTilingTreatment tilingTreatment;

	[CallerCount(Count = 0)]
	public MB_MaterialAndUVRect(Material mat, Rect destRect, bool allPropsUseSameTiling, Rect sourceMaterialTiling, Rect samplingEncapsulatingRect, Rect srcUVsamplingRect, MB_TextureTilingTreatment treatment, string objName)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	[Calls(Type = typeof(Rect), Member = "GetHashCode")]
	[CallsUnknownMethods(Count = 1)]
	public override int GetHashCode()
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override bool Equals(object obj)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public Rect GetEncapsulatingRect()
	{
		return default(Rect);
	}

	[CallerCount(Count = 0)]
	public Rect GetMaterialTilingRect()
	{
		return default(Rect);
	}
}
