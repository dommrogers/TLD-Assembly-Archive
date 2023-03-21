using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace VLB;

public static class BatchingHelper
{
	public const bool isGpuInstancingSupported = true;

	public static bool forceEnableDepthBlend
	{
		[CalledBy(Type = typeof(BatchingHelper), Member = "CanBeBatched")]
		[CalledBy(Type = typeof(BeamGeometry), Member = "get_isDepthBlendEnabled")]
		[CalledBy(Type = typeof(BeamGeometry), Member = "ApplyMaterial")]
		[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Config), Member = "GetInstance")]
		[Calls(Type = typeof(SRPHelper), Member = "get_renderPipelineType")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static bool IsGpuInstancingEnabled(Material material)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static void SetMaterialProperties(Material material, bool enableGpuInstancing)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[Calls(Type = typeof(SRPHelper), Member = "get_renderPipelineType")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(BatchingHelper), Member = "CanBeBatched")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(BatchingHelper), Member = "AppendErrorMessage")]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(BatchingHelper), Member = "get_forceEnableDepthBlend")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public static bool CanBeBatched(VolumetricLightBeam beamA, VolumetricLightBeam beamB, ref string reasons)
	{
		return false;
	}

	[CalledBy(Type = typeof(BatchingHelper), Member = "CanBeBatched")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[Calls(Type = typeof(SRPHelper), Member = "get_renderPipelineType")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(BatchingHelper), Member = "AppendErrorMessage")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static bool CanBeBatched(VolumetricLightBeam beam, ref string reasons)
	{
		return false;
	}

	[CalledBy(Type = typeof(BatchingHelper), Member = "CanBeBatched")]
	[CalledBy(Type = typeof(BatchingHelper), Member = "CanBeBatched")]
	[CallerCount(Count = 8)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	private static void AppendErrorMessage(ref string message, string toAppend)
	{
	}
}
