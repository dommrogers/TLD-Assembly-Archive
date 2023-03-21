using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

internal interface IAmbientOcclusionMethod
{
	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	DepthTextureMode GetCameraFlags();

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	void RenderAfterOpaque(PostProcessRenderContext context);

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	void RenderAmbientOnly(PostProcessRenderContext context);

	[CallerCount(Count = 101262)]
	[DeduplicatedMethod]
	void CompositeAmbientOnly(PostProcessRenderContext context);

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	void Release();
}
