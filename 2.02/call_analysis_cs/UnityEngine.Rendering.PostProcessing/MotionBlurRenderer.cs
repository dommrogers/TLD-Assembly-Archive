using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

internal sealed class MotionBlurRenderer : PostProcessEffectRenderer<MotionBlur>
{
	private enum Pass
	{
		VelocitySetup,
		TileMax1,
		TileMax2,
		TileMaxV,
		NeighborMax,
		Reconstruction
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override DepthTextureMode GetCameraFlags()
	{
		return default(DepthTextureMode);
	}

	[CalledBy(Type = typeof(MotionBlurRenderer), Member = "Render")]
	[CalledBy(Type = typeof(MotionBlurRenderer), Member = "Render")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(MotionBlurRenderer), Member = "Render")]
	[CalledBy(Type = typeof(MotionBlurRenderer), Member = "Render")]
	[CalledBy(Type = typeof(MotionBlurRenderer), Member = "Render")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetDescriptor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(MotionBlurRenderer), Member = "Render")]
	private void CreateTemporaryRT(PostProcessRenderContext context, int nameID, int width, int height, RenderTextureFormat RTFormat)
	{
	}

	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(Vector2), Member = "get_one")]
	[Calls(Type = typeof(MotionBlurRenderer), Member = "CreateTemporaryRT")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[CallsUnknownMethods(Count = 25)]
	[Calls(Type = typeof(MotionBlurRenderer), Member = "CreateTemporaryRT")]
	[Calls(Type = typeof(MotionBlurRenderer), Member = "CreateTemporaryRT")]
	[Calls(Type = typeof(TextureFormatUtilities), Member = "IsSupported")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 15)]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(MotionBlurRenderer), Member = "CreateTemporaryRT")]
	[Calls(Type = typeof(MotionBlurRenderer), Member = "CreateTemporaryRT")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(MotionBlurRenderer), Member = "CreateTemporaryRT")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public MotionBlurRenderer()
	{
		((PostProcessEffectRenderer<>)(object)this)._002Ector();
	}
}
