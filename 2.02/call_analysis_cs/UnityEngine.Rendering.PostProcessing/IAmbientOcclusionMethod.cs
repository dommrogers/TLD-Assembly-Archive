using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

internal interface IAmbientOcclusionMethod
{
	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	DepthTextureMode GetCameraFlags();

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	void RenderAfterOpaque(PostProcessRenderContext context);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	void RenderAmbientOnly(PostProcessRenderContext context);

	[CallerCount(Count = 121780)]
	[DeduplicatedMethod]
	void CompositeAmbientOnly(PostProcessRenderContext context);

	[CallerCount(Count = 121780)]
	[DeduplicatedMethod]
	void Release();
}
