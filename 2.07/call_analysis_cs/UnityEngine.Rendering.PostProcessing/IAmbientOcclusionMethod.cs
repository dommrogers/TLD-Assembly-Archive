using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

internal interface IAmbientOcclusionMethod
{
	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	DepthTextureMode GetCameraFlags();

	[CallerCount(Count = 101261)]
	[DeduplicatedMethod]
	void RenderAfterOpaque(PostProcessRenderContext context);

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	void RenderAmbientOnly(PostProcessRenderContext context);

	[CallerCount(Count = 101261)]
	[DeduplicatedMethod]
	void CompositeAmbientOnly(PostProcessRenderContext context);

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	void Release();
}
