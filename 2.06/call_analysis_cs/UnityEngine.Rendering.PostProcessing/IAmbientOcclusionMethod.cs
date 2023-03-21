using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

internal interface IAmbientOcclusionMethod
{
	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	DepthTextureMode GetCameraFlags();

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	void RenderAfterOpaque(PostProcessRenderContext context);

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	void RenderAmbientOnly(PostProcessRenderContext context);

	[CallerCount(Count = 101224)]
	[DeduplicatedMethod]
	void CompositeAmbientOnly(PostProcessRenderContext context);

	[CallerCount(Count = 101224)]
	[DeduplicatedMethod]
	void Release();
}
