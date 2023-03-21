using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering.PostProcessing;

internal sealed class ScreenSpaceReflectionsRenderer : PostProcessEffectRenderer<ScreenSpaceReflections>
{
	private class QualityPreset
	{
		public int maximumIterationCount;

		public float thickness;

		public ScreenSpaceReflectionResolution downsampling;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
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

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override DepthTextureMode GetCameraFlags()
	{
		return default(DepthTextureMode);
	}

	[CalledBy(Type = typeof(ScreenSpaceReflectionsRenderer), Member = "Render")]
	[CalledBy(Type = typeof(ScreenSpaceReflectionsRenderer), Member = "Render")]
	[CallsUnknownMethods(Count = 20)]
	[Calls(Type = typeof(RenderTexture), Member = "GetCompatibleFormat")]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	internal void CheckRT(ref RenderTexture rt, int width, int height, FilterMode filterMode, bool useMipMap)
	{
	}

	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(CommandBuffer), Member = "GetTemporaryRT")]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetGraphicsFormat")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(ScreenSpaceReflectionsRenderer), Member = "CheckRT")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(CommandBuffer), Member = "GetTemporaryRT")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(CommandBuffer), Member = "GetTemporaryRT")]
	[CallsUnknownMethods(Count = 108)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetGraphicsFormat")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[Calls(Type = typeof(Matrix4x4), Member = "get_inverse")]
	[Calls(Type = typeof(Matrix4x4), Member = "get_inverse")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 29)]
	[Calls(Type = typeof(Mathf), Member = "Log")]
	[Calls(Type = typeof(ScreenSpaceReflectionsRenderer), Member = "CheckRT")]
	[Calls(Type = typeof(Matrix4x4), Member = "set_Item")]
	[Calls(Type = typeof(Matrix4x4), Member = "set_Item")]
	[Calls(Type = typeof(Matrix4x4), Member = "set_Item")]
	[Calls(Type = typeof(Matrix4x4), Member = "set_Item")]
	[Calls(Type = typeof(Matrix4x4), Member = "set_Item")]
	[Calls(Type = typeof(Matrix4x4), Member = "set_Item")]
	[Calls(Type = typeof(Matrix4x4), Member = "set_Item")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(Matrix4x4), Member = "set_Item")]
	[Calls(Type = typeof(Matrix4x4), Member = "set_Item")]
	[Calls(Type = typeof(Matrix4x4), Member = "set_Item")]
	[Calls(Type = typeof(Matrix4x4), Member = "set_Item")]
	[Calls(Type = typeof(Matrix4x4), Member = "set_Item")]
	[Calls(Type = typeof(Matrix4x4), Member = "set_Item")]
	[Calls(Type = typeof(Matrix4x4), Member = "set_Item")]
	[Calls(Type = typeof(Matrix4x4), Member = "set_Item")]
	[Calls(Type = typeof(Camera), Member = "get_projectionMatrix")]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply")]
	[Calls(Type = typeof(Camera), Member = "get_worldToCameraMatrix")]
	[Calls(Type = typeof(Camera), Member = "get_worldToCameraMatrix")]
	[Calls(Type = typeof(Matrix4x4), Member = "set_Item")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void Release()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 85)]
	public ScreenSpaceReflectionsRenderer()
	{
		((PostProcessEffectRenderer<>)(object)this)._002Ector();
	}
}
