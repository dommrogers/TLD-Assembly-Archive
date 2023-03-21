using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Rendering;

namespace VLB;

public static class SRPHelper
{
	public enum RenderPipeline
	{
		Undefined,
		BuiltIn,
		URP,
		LWRP,
		HDRP
	}

	private static RenderPipeline m_RenderPipelineCached;

	public static RenderPipeline renderPipelineType
	{
		[CalledBy(Type = typeof(Config), Member = "get_requiresDoubleSidedMesh")]
		[CalledBy(Type = typeof(Config), Member = "get_actualRenderingMode")]
		[CalledBy(Type = typeof(Config), Member = "get_useSinglePassShader")]
		[CalledBy(Type = typeof(Config), Member = "get_hasRenderPipelineMismatch")]
		[CalledBy(Type = typeof(BatchingHelper), Member = "CanBeBatched")]
		[CalledBy(Type = typeof(GlobalMesh), Member = "Get")]
		[CalledBy(Type = typeof(MeshGenerator), Member = "GetSharedMeshVertexCount")]
		[CalledBy(Type = typeof(MeshGenerator), Member = "GetSharedMeshIndicesCount")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(Config), Member = "IsSRPBatcherSupported")]
		[CalledBy(Type = typeof(Config), Member = "OnStartup")]
		[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMatricesPropertiesForGPUInstancingSRP")]
		[CalledBy(Type = typeof(BatchingHelper), Member = "CanBeBatched")]
		[CalledBy(Type = typeof(BatchingHelper), Member = "CanBeBatched")]
		[CalledBy(Type = typeof(BeamGeometry), Member = "get_shouldUseGPUInstancedMaterial")]
		[CalledBy(Type = typeof(BatchingHelper), Member = "get_forceEnableDepthBlend")]
		[CalledBy(Type = typeof(BatchingHelper), Member = "get_forceEnableDepthBlend")]
		[Calls(Type = typeof(string), Member = "Contains")]
		[Calls(Type = typeof(string), Member = "Contains")]
		[Calls(Type = typeof(string), Member = "Contains")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 16)]
		get
		{
			return default(RenderPipeline);
		}
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "Contains")]
	private static RenderPipeline ComputeRenderPipeline()
	{
		return default(RenderPipeline);
	}

	[CalledBy(Type = typeof(DynamicOcclusionDepthBuffer), Member = "OnProcessOcclusion")]
	[CalledBy(Type = typeof(SRPHelper), Member = "UnregisterOnBeginCameraRendering")]
	[CalledBy(Type = typeof(SRPHelper), Member = "RegisterOnBeginCameraRendering")]
	[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMatricesPropertiesForGPUInstancingSRP")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(BeamGeometry), Member = "OnDisable")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(BeamGeometry), Member = "OnEnable")]
	public static bool IsUsingCustomRenderPipeline()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SRPHelper), Member = "IsUsingCustomRenderPipeline")]
	[Calls(Type = typeof(RenderPipelineManager), Member = "remove_beginCameraRendering")]
	[Calls(Type = typeof(RenderPipelineManager), Member = "add_beginCameraRendering")]
	public static void RegisterOnBeginCameraRendering(Action<ScriptableRenderContext, Camera> cb)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SRPHelper), Member = "IsUsingCustomRenderPipeline")]
	[Calls(Type = typeof(RenderPipelineManager), Member = "remove_beginCameraRendering")]
	public static void UnregisterOnBeginCameraRendering(Action<ScriptableRenderContext, Camera> cb)
	{
	}
}
