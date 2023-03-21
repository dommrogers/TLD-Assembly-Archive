using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

internal sealed class AmbientOcclusionRenderer : PostProcessEffectRenderer<AmbientOcclusion>
{
	private IAmbientOcclusionMethod[] m_Methods;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScalableAO), Member = ".ctor")]
	[Calls(Type = typeof(MultiScaleVO), Member = ".ctor")]
	[CallsUnknownMethods(Count = 19)]
	public override void Init()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public bool IsAmbientOnly(PostProcessRenderContext context)
	{
		return false;
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public IAmbientOcclusionMethod Get()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public override DepthTextureMode GetCameraFlags()
	{
		return default(DepthTextureMode);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public override void Release()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public ScalableAO GetScalableAO()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public MultiScaleVO GetMultiScaleVO()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[CallerCount(Count = 0)]
	public AmbientOcclusionRenderer()
	{
		((PostProcessEffectRenderer<>)(object)this)._002Ector();
	}
}
