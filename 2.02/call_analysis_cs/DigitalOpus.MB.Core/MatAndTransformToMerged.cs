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
		[CompilerGenerated]
		[DeduplicatedMethod]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public MatAndTransformToMerged(DRect obUVrect, bool fixOutOfBoundsUVs, Material m)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	private void _init(DRect obUVrect, bool fixOutOfBoundsUVs, Material m)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(DRect), Member = "Equals")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public override bool Equals(object obj)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override int GetHashCode()
	{
		return 0;
	}

	[CalledBy(Type = typeof(MB_TexSet), Member = "GetDescription")]
	[CalledBy(Type = typeof(MB_TexSet), Member = "GetMatSubrectDescriptions")]
	[CalledBy(TypeFullName = "DigitalOpus.MB.Core.MB3_TextureCombinerPackerMeshBaker.<CreateAtlases>d__0", Member = "MoveNext")]
	[CalledBy(TypeFullName = "DigitalOpus.MB.Core.MB3_TextureCombinerPipeline.<CalculateIdealSizesForTexturesInAtlasAndPadding>d__10", Member = "MoveNext")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public string GetMaterialName()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public void AssignInitialValuesForMaterialTilingAndSamplingRectMatAndUVTiling(bool allTexturesUseSameMatTiling, DRect matTiling)
	{
	}
}
