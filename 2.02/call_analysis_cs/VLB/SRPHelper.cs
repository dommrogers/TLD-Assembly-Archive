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
		[CalledBy(Type = typeof(Config), Member = "OnStartup")]
		[CalledBy(Type = typeof(Config), Member = "get_actualRenderingMode")]
		[CalledBy(Type = typeof(Config), Member = "IsSRPBatcherSupported")]
		[CalledBy(Type = typeof(Config), Member = "get_hasRenderPipelineMismatch")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(SRPHelper), Member = "ComputeRenderPipeline")]
		get
		{
			return default(RenderPipeline);
		}
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CalledBy(Type = typeof(SRPHelper), Member = "get_renderPipelineType")]
	[CallsUnknownMethods(Count = 3)]
	private static RenderPipeline ComputeRenderPipeline()
	{
		return default(RenderPipeline);
	}

	[CalledBy(Type = typeof(DynamicOcclusionDepthBuffer), Member = "OnProcessOcclusion")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SRPHelper), Member = "UnregisterOnBeginCameraRendering")]
	[CalledBy(Type = typeof(SRPHelper), Member = "RegisterOnBeginCameraRendering")]
	[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMatricesPropertiesForGPUInstancingSRP")]
	[CalledBy(Type = typeof(BeamGeometry), Member = "OnDisable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	public static bool IsUsingCustomRenderPipeline()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(SRPHelper), Member = "IsUsingCustomRenderPipeline")]
	[Calls(Type = typeof(RenderPipelineManager), Member = "remove_beginCameraRendering")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CalledBy(Type = typeof(BeamGeometry), Member = "OnEnable")]
	[CallsUnknownMethods(Count = 1)]
	public static void RegisterOnBeginCameraRendering(Action<ScriptableRenderContext, Camera> cb)
	{
	}

	[Calls(Type = typeof(RenderPipelineManager), Member = "remove_beginCameraRendering")]
	[Calls(Type = typeof(SRPHelper), Member = "IsUsingCustomRenderPipeline")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void UnregisterOnBeginCameraRendering(Action<ScriptableRenderContext, Camera> cb)
	{
	}
}
