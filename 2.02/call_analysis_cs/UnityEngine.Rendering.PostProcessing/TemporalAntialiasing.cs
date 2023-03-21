using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class TemporalAntialiasing
{
	private enum Pass
	{
		SolverDilate,
		SolverNoDilate
	}

	public float jitterSpread;

	public float sharpness;

	public float stationaryBlending;

	public float motionBlending;

	public Func<Camera, Vector2, Matrix4x4> jitteredMatrixFunc;

	private Vector2 _003Cjitter_003Ek__BackingField;

	private readonly RenderTargetIdentifier[] m_Mrt;

	private bool m_ResetHistory;

	private const int k_SampleCount = 8;

	private int _003CsampleIndex_003Ek__BackingField;

	private const int k_NumEyes = 2;

	private const int k_NumHistoryTextures = 2;

	private readonly RenderTexture[][] m_HistoryTextures;

	private readonly int[] m_HistoryPingPong;

	public Vector2 jitter
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(Vector2);
		}
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set
		{
		}
	}

	public int sampleIndex
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnPostRender")]
	[CalledBy(Type = typeof(RuntimeUtilities), Member = "IsTemporalAntialiasingActive")]
	[CalledBy(Type = typeof(PostProcessRenderContext), Member = "IsTemporalAntialiasingActive")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "SetLegacyCameraFlags")]
	[CalledBy(Type = typeof(DepthOfFieldRenderer), Member = "Render")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(MaskedBlurEffectRenderer), Member = "Render")]
	[CalledBy(Type = typeof(MaskedBlurEffectRenderer), Member = "Render")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(DepthOfFieldRenderer), Member = "Render")]
	public bool IsSupported()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	internal DepthTextureMode GetCameraFlags()
	{
		return default(DepthTextureMode);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	internal void ResetHistory()
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(TemporalAntialiasing), Member = "GetJitteredProjectionMatrix")]
	[CalledBy(Type = typeof(TemporalAntialiasing), Member = "ConfigureStereoJitteredProjectionMatrices")]
	private Vector2 GenerateRandomOffset()
	{
		return default(Vector2);
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "GetJitteredPerspectiveProjectionMatrix")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "GetJitteredOrthographicProjectionMatrix")]
	[CalledBy(Type = typeof(TemporalAntialiasing), Member = "ConfigureJitteredProjectionMatrix")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TemporalAntialiasing), Member = "GenerateRandomOffset")]
	public Matrix4x4 GetJitteredProjectionMatrix(Camera camera)
	{
		return default(Matrix4x4);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Camera), Member = "get_projectionMatrix")]
	[Calls(Type = typeof(TemporalAntialiasing), Member = "GetJitteredProjectionMatrix")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[CallsUnknownMethods(Count = 4)]
	public void ConfigureJitteredProjectionMatrix(PostProcessRenderContext context)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "GenerateJitteredProjectionMatrixFromOriginal")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(TemporalAntialiasing), Member = "GenerateRandomOffset")]
	public void ConfigureStereoJitteredProjectionMatrices(PostProcessRenderContext context)
	{
	}

	[Calls(Type = typeof(Object), Member = "set_name")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(TemporalAntialiasing), Member = "CheckHistory")]
	[CalledBy(Type = typeof(TemporalAntialiasing), Member = "CheckHistory")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	private void GenerateHistoryName(RenderTexture rt, int id, PostProcessRenderContext context)
	{
	}

	[CallsUnknownMethods(Count = 41)]
	[CalledBy(Type = typeof(TemporalAntialiasing), Member = "Render")]
	[CalledBy(Type = typeof(TemporalAntialiasing), Member = "Render")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(TemporalAntialiasing), Member = "GenerateHistoryName")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetScreenSpaceTemporaryRT")]
	[Calls(Type = typeof(RenderTexture), Member = "ReleaseTemporary")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(Texture), Member = "set_filterMode")]
	[Calls(Type = typeof(TemporalAntialiasing), Member = "GenerateHistoryName")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetScreenSpaceTemporaryRT")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	private RenderTexture CheckHistory(int id, PostProcessRenderContext context)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 31)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get")]
	[Calls(Type = typeof(TemporalAntialiasing), Member = "CheckHistory")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TemporalAntialiasing), Member = "CheckHistory")]
	internal void Render(PostProcessRenderContext context)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderTexture), Member = "ReleaseTemporary")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnDisable")]
	[CallsUnknownMethods(Count = 15)]
	internal void Release()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public TemporalAntialiasing()
	{
	}
}
