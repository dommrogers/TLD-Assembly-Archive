using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

internal sealed class ScreenSpaceReflectionsRenderer : PostProcessEffectRenderer<ScreenSpaceReflections>
{
	private class QualityPreset
	{
		public int maximumIterationCount;

		public float thickness;

		public ScreenSpaceReflectionResolution downsampling;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public QualityPreset()
		{
		}
	}

	private enum Pass
	{
		Test,
		Resolve,
		Reproject,
		Composite
	}

	private RenderTexture m_Resolve;

	private RenderTexture m_History;

	private int[] m_MipIDs;

	private readonly QualityPreset[] m_Presets;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public override DepthTextureMode GetCameraFlags()
	{
		return default(DepthTextureMode);
	}

	[CalledBy(Type = typeof(ScreenSpaceReflectionsRenderer), Member = "Render")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(ScreenSpaceReflectionsRenderer), Member = "Render")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor")]
	internal void CheckRT(ref RenderTexture rt, int width, int height, FilterMode filterMode, bool useMipMap)
	{
	}

	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(CommandBuffer), Member = "CopyTexture")]
	[Calls(Type = typeof(CommandBuffer), Member = "ReleaseTemporaryRT")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(CommandBuffer), Member = "ReleaseTemporaryRT")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(ComputeShader), Member = "FindKernel")]
	[Calls(Type = typeof(CommandBuffer), Member = "GetTemporaryRT")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeVectorParam")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(CommandBuffer), Member = "CopyTexture")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(CommandBuffer), Member = "ReleaseTemporaryRT")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(CommandBuffer), Member = "EndSample")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(CommandBuffer), Member = "GetTemporaryRT")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(ScreenSpaceReflectionsRenderer), Member = "CheckRT")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[Calls(Type = typeof(Camera), Member = "get_projectionMatrix")]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply")]
	[Calls(Type = typeof(Camera), Member = "get_worldToCameraMatrix")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetMatrix")]
	[Calls(Type = typeof(Camera), Member = "get_worldToCameraMatrix")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetMatrix")]
	[Calls(Type = typeof(Matrix4x4), Member = "get_inverse")]
	[Calls(Type = typeof(Matrix4x4), Member = "get_inverse")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetMatrix")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(CommandBuffer), Member = "GetTemporaryRT")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetMatrix")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(ScreenSpaceReflectionsRenderer), Member = "CheckRT")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVector")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVector")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	public override void Release()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 29)]
	public ScreenSpaceReflectionsRenderer()
	{
		((PostProcessEffectRenderer<>)(object)this)._002Ector();
	}
}
