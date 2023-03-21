using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace VLB;

public static class BatchingHelper
{
	public const bool isGpuInstancingSupported = true;

	public static bool forceEnableDepthBlend
	{
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Config), Member = "GetInstance")]
		[Calls(Type = typeof(SRPHelper), Member = "get_renderPipelineType")]
		[Calls(Type = typeof(Config), Member = "GetInstance")]
		[Calls(Type = typeof(SRPHelper), Member = "get_renderPipelineType")]
		[CalledBy(Type = typeof(BatchingHelper), Member = "CanBeBatched")]
		[CalledBy(Type = typeof(BeamGeometry), Member = "get_isDepthBlendEnabled")]
		[CalledBy(Type = typeof(BeamGeometry), Member = "ApplyMaterial")]
		[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(bool);
		}
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public static bool IsGpuInstancingEnabled(Material material)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static void SetMaterialProperties(Material material, bool enableGpuInstancing)
	{
	}

	[Calls(Type = typeof(BatchingHelper), Member = "AppendErrorMessage")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(BatchingHelper), Member = "AppendErrorMessage")]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(BatchingHelper), Member = "AppendErrorMessage")]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[Calls(Type = typeof(BatchingHelper), Member = "get_forceEnableDepthBlend")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(BatchingHelper), Member = "AppendErrorMessage")]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(BatchingHelper), Member = "AppendErrorMessage")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(BatchingHelper), Member = "AppendErrorMessage")]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[Calls(Type = typeof(SRPHelper), Member = "get_renderPipelineType")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(SRPHelper), Member = "get_renderPipelineType")]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(BatchingHelper), Member = "CanBeBatched")]
	[Calls(Type = typeof(BatchingHelper), Member = "CanBeBatched")]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Format")]
	public static bool CanBeBatched(VolumetricLightBeam beamA, VolumetricLightBeam beamB, ref string reasons)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(BatchingHelper), Member = "CanBeBatched")]
	[CalledBy(Type = typeof(BatchingHelper), Member = "CanBeBatched")]
	[Calls(Type = typeof(BatchingHelper), Member = "AppendErrorMessage")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(SRPHelper), Member = "get_renderPipelineType")]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BatchingHelper), Member = "AppendErrorMessage")]
	public static bool CanBeBatched(VolumetricLightBeam beam, ref string reasons)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BatchingHelper), Member = "CanBeBatched")]
	[CalledBy(Type = typeof(BatchingHelper), Member = "CanBeBatched")]
	[CalledBy(Type = typeof(BatchingHelper), Member = "CanBeBatched")]
	[CalledBy(Type = typeof(BatchingHelper), Member = "CanBeBatched")]
	[CalledBy(Type = typeof(BatchingHelper), Member = "CanBeBatched")]
	[CalledBy(Type = typeof(BatchingHelper), Member = "CanBeBatched")]
	[CalledBy(Type = typeof(BatchingHelper), Member = "CanBeBatched")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(BatchingHelper), Member = "CanBeBatched")]
	private static void AppendErrorMessage(ref string message, string toAppend)
	{
	}
}
