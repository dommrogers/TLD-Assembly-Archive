using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace DigitalOpus.MB.Core;

public class MatAndTransformToMerged
{
	public Material mat;

	private DRect _003CobUVRectIfTilingSame_003Ek__BackingField;

	private DRect _003CsamplingRectMatAndUVTiling_003Ek__BackingField;

	private DRect _003CmaterialTiling_003Ek__BackingField;

	public string objName;

	public DRect obUVRectIfTilingSame
	{
		[DeduplicatedMethod]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		get
		{
			return default(DRect);
		}
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private set
		{
		}
	}

	public DRect samplingRectMatAndUVTiling
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		get
		{
			return default(DRect);
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	public DRect materialTiling
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		get
		{
			return default(DRect);
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	[CallerCount(Count = 0)]
	public MatAndTransformToMerged(DRect obUVrect, bool fixOutOfBoundsUVs)
	{
	}

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public MatAndTransformToMerged(DRect obUVrect, bool fixOutOfBoundsUVs, Material m)
	{
	}

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	private void _init(DRect obUVrect, bool fixOutOfBoundsUVs, Material m)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(DRect), Member = "Equals")]
	[CallsUnknownMethods(Count = 1)]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(MB_TexSet), Member = "GetMatSubrectDescriptions")]
	[CalledBy(Type = typeof(MB_TexSet), Member = "GetDescription")]
	[CalledBy(Type = typeof(MB3_TextureCombinerPackerMeshBaker._003CCreateAtlases_003Ed__0), Member = "MoveNext")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallsDeduplicatedMethods(Count = 1)]
	public string GetMaterialName()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public void AssignInitialValuesForMaterialTilingAndSamplingRectMatAndUVTiling(bool allTexturesUseSameMatTiling, DRect matTiling)
	{
	}
}
