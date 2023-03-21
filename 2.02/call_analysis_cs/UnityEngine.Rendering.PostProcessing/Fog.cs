using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class Fog
{
	public bool enabled;

	public bool excludeSkybox;

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal DepthTextureMode GetCameraFlags()
	{
		return default(DepthTextureMode);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_scriptableRenderPipelineActive")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Shader), Member = "get_isSupported")]
	[Calls(Type = typeof(Camera), Member = "get_actualRenderingPath")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "SetLegacyCameraFlags")]
	[CallsUnknownMethods(Count = 8)]
	internal bool IsEnabledAndSupported(PostProcessRenderContext context)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(Color), Member = "get_linear")]
	[CallsUnknownMethods(Count = 17)]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	internal void Render(PostProcessRenderContext context)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Fog()
	{
	}
}
