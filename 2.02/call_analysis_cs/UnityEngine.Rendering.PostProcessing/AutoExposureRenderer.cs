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
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public AutoExposureRenderer()
	{
		((PostProcessEffectRenderer<>)(object)this)._002Ector();
	}

	[CallsUnknownMethods(Count = 39)]
	[CalledBy(Type = typeof(AutoExposureRenderer), Member = "Render")]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor")]
	[CalledBy(Type = typeof(AutoExposureRenderer), Member = "Render")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderTexture), Member = "GetCompatibleFormat")]
	private void CheckTexture(int eye, int id)
	{
	}

	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[CallsUnknownMethods(Count = 70)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "CopyTexture")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeVectorParam")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeVectorParam")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Exp2")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Exp2")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeBufferParam")]
	[Calls(Type = typeof(AutoExposureRenderer), Member = "CheckTexture")]
	[Calls(Type = typeof(AutoExposureRenderer), Member = "CheckTexture")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeVectorParam")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[CallsUnknownMethods(Count = 6)]
	public override void Release()
	{
	}
}
