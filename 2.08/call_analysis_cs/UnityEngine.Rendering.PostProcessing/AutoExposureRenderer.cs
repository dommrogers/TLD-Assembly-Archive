using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

internal sealed class AutoExposureRenderer : PostProcessEffectRenderer<AutoExposure>
{
	private const int k_NumEyes = 2;

	private const int k_NumAutoExposureTextures = 2;

	private readonly RenderTexture[][] m_AutoExposurePool;

	private int[] m_AutoExposurePingPong;

	private RenderTexture m_CurrentAutoExposure;

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	public AutoExposureRenderer()
	{
		((PostProcessEffectRenderer<>)(object)this)._002Ector();
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(AutoExposureRenderer), Member = "Render")]
	[CalledBy(Type = typeof(AutoExposureRenderer), Member = "Render")]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void CheckTexture(int eye, int id)
	{
	}

	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeVectorParam")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(AutoExposureRenderer), Member = "CheckTexture")]
	[Calls(Type = typeof(AutoExposureRenderer), Member = "CheckTexture")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeBufferParam")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeVectorParam")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeVectorParam")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[CallsUnknownMethods(Count = 2)]
	public override void Release()
	{
	}
}
