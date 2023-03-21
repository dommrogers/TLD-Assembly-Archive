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
		[CalledBy(Type = typeof(BatchingHelper), Member = "get_forceEnableDepthBlend")]
		[CalledBy(Type = typeof(BatchingHelper), Member = "CanBeBatched")]
		[CalledBy(Type = typeof(BatchingHelper), Member = "CanBeBatched")]
		[CalledBy(Type = typeof(BeamGeometry), Member = "get_shouldUseGPUInstancedMaterial")]
		[CalledBy(Type = typeof(BeamGeometry), Member = "RegenerateMesh")]
		[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMatricesPropertiesForGPUInstancingSRP")]
		[CalledBy(Type = typeof(Config), Member = "IsSRPBatcherSupported")]
		[CalledBy(Type = typeof(Config), Member = "get_actualRenderingMode")]
		[CalledBy(Type = typeof(Config), Member = "get_useSinglePassShader")]
		[CalledBy(Type = typeof(Config), Member = "get_requiresDoubleSidedMesh")]
		[CalledBy(Type = typeof(Config), Member = "get_hasRenderPipelineMismatch")]
		[CalledBy(Type = typeof(Config), Member = "OnStartup")]
		[CalledBy(Type = typeof(GlobalMesh), Member = "Get")]
		[CalledBy(Type = typeof(MeshGenerator), Member = "GetSharedMeshVertexCount")]
		[CalledBy(Type = typeof(MeshGenerator), Member = "GetSharedMeshIndicesCount")]
		[CallerCount(Count = 17)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(string), Member = "IndexOf")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(RenderPipeline);
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private static RenderPipeline ComputeRenderPipeline()
	{
		return default(RenderPipeline);
	}

	[CalledBy(Type = typeof(BeamGeometry), Member = "OnDisable")]
	[CalledBy(Type = typeof(BeamGeometry), Member = "OnEnable")]
	[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMatricesPropertiesForGPUInstancingSRP")]
	[CalledBy(Type = typeof(DynamicOcclusionDepthBuffer), Member = "OnProcessOcclusion")]
	[CalledBy(Type = typeof(SRPHelper), Member = "RegisterOnBeginCameraRendering")]
	[CalledBy(Type = typeof(SRPHelper), Member = "UnregisterOnBeginCameraRendering")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool IsUsingCustomRenderPipeline()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SRPHelper), Member = "IsUsingCustomRenderPipeline")]
	[Calls(Type = typeof(RenderPipelineManager), Member = "remove_beginCameraRendering")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsUnknownMethods(Count = 2)]
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
