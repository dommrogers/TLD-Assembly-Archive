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
		[CalledBy(Type = typeof(Config), Member = "IsSRPBatcherSupported")]
		[CalledBy(Type = typeof(Config), Member = "get_actualRenderingMode")]
		[CalledBy(Type = typeof(Config), Member = "get_hasRenderPipelineMismatch")]
		[CalledBy(Type = typeof(Config), Member = "OnStartup")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(SRPHelper), Member = "ComputeRenderPipeline")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return default(RenderPipeline);
		}
	}

	[CalledBy(Type = typeof(SRPHelper), Member = "get_renderPipelineType")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private static RenderPipeline ComputeRenderPipeline()
	{
		return default(RenderPipeline);
	}

	[CalledBy(Type = typeof(BeamGeometry), Member = "OnDisable")]
	[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMatricesPropertiesForGPUInstancingSRP")]
	[CalledBy(Type = typeof(DynamicOcclusionDepthBuffer), Member = "OnProcessOcclusion")]
	[CalledBy(Type = typeof(SRPHelper), Member = "RegisterOnBeginCameraRendering")]
	[CalledBy(Type = typeof(SRPHelper), Member = "UnregisterOnBeginCameraRendering")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsUsingCustomRenderPipeline()
	{
		return false;
	}

	[CalledBy(Type = typeof(BeamGeometry), Member = "OnEnable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SRPHelper), Member = "IsUsingCustomRenderPipeline")]
	[Calls(Type = typeof(RenderPipelineManager), Member = "remove_beginCameraRendering")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void RegisterOnBeginCameraRendering(Action<ScriptableRenderContext, Camera> cb)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SRPHelper), Member = "IsUsingCustomRenderPipeline")]
	[Calls(Type = typeof(RenderPipelineManager), Member = "remove_beginCameraRendering")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void UnregisterOnBeginCameraRendering(Action<ScriptableRenderContext, Camera> cb)
	{
	}
}
