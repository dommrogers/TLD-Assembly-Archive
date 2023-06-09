using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

internal sealed class AmbientOcclusionRenderer : PostProcessEffectRenderer<AmbientOcclusion>
{
	private IAmbientOcclusionMethod[] m_Methods;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScalableAO), Member = ".ctor")]
	[Calls(Type = typeof(MultiScaleVO), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 23)]
	public override void Init()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public bool IsAmbientOnly(PostProcessRenderContext context)
	{
		return false;
	}

	[CalledBy(Type = typeof(AmbientOcclusionRenderer), Member = "GetCameraFlags")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public IAmbientOcclusionMethod Get()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AmbientOcclusionRenderer), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override DepthTextureMode GetCameraFlags()
	{
		return default(DepthTextureMode);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public override void Release()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public ScalableAO GetScalableAO()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public MultiScaleVO GetMultiScaleVO()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public AmbientOcclusionRenderer()
	{
		((PostProcessEffectRenderer<>)(object)this)._002Ector();
	}
}
