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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Rect), Member = "GetHashCode")]
	[Calls(Type = typeof(Rect), Member = "GetHashCode")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 1)]
	public override bool Equals(object obj)
	{
		return default(bool);
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
