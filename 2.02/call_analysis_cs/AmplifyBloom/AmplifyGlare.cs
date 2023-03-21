using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace AmplifyBloom;

[Serializable]
public sealed class AmplifyGlare : IAmplifyItem
{
	public const int MaxLineSamples = 8;

	public const int MaxTotalSamples = 16;

	public const int MaxStarLines = 4;

	public const int MaxPasses = 4;

	public const int MaxCustomGlare = 32;

	private GlareDefData[] m_customGlareDef;

	private int m_customGlareDefIdx;

	private int m_customGlareDefAmount;

	private bool m_applyGlare;

	private Color _overallTint;

	private Gradient m_cromaticAberrationGrad;

	private int m_glareMaxPassCount;

	private StarDefData[] m_starDefArr;

	private GlareDefData[] m_glareDefArr;

	private Matrix4x4[] m_weigthsMat;

	private Matrix4x4[] m_offsetsMat;

	private Color m_whiteReference;

	private float m_aTanFoV;

	private AmplifyGlareCache m_amplifyGlareCache;

	private int m_currentWidth;

	private int m_currentHeight;

	private GlareLibType m_currentGlareType;

	private int m_currentGlareIdx;

	private float m_perPassDisplacement;

	private float m_intensity;

	private float m_overallStreakScale;

	private bool m_isDirty;

	private RenderTexture[] _rtBuffer;

	public GlareLibType CurrentGlare
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(GlareLibType);
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public int GlareMaxPassCount
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0;
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public float PerPassDisplacement
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0f;
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public float Intensity
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0f;
		}
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public Color OverallTint
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(Color);
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public bool ApplyLensGlare
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		get
		{
			return false;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public Gradient CromaticColorGradient
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 9)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public float OverallStreakScale
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0f;
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public GlareDefData[] CustomGlareDef
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 59)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 103)]
		set
		{
		}
	}

	public int CustomGlareDefIdx
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		get
		{
			return 0;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public int CustomGlareDefAmount
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GlareDefData), Member = ".ctor")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 16)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(AmplifyBloomBase), Member = ".ctor")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Gradient), Member = "SetKeys")]
	[Calls(Type = typeof(AmplifyGlareCache), Member = ".ctor")]
	[Calls(Type = typeof(StarDefData), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 195)]
	public AmplifyGlare()
	{
	}

	[CalledBy(Type = typeof(AmplifyBloomBase), Member = "OnDestroy")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(AmplifyUtils), Member = "ReleaseTempRenderTarget")]
	[Calls(Type = typeof(AmplifyGlareCache), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	public void Destroy()
	{
	}

	[CallerCount(Count = 0)]
	public void SetDirty()
	{
	}

	[CalledBy(Type = typeof(AmplifyGlare), Member = "OnRenderImage")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AmplifyUtils), Member = "GetTempRenderTarget")]
	[Calls(Type = typeof(AmplifyGlare), Member = "UpdateMatrixesForPass")]
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	[Calls(Type = typeof(Material), Member = "SetVector")]
	[Calls(Type = typeof(RenderTexture), Member = "DiscardContents")]
	[Calls(Type = typeof(AmplifyUtils), Member = "ReleaseTempRenderTarget")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 58)]
	public void OnRenderFromCache(RenderTexture source, RenderTexture dest, Material material, float glareIntensity, float cameraRotation)
	{
	}

	[CalledBy(Type = typeof(AmplifyGlare), Member = "OnRenderFromCache")]
	[CalledBy(Type = typeof(AmplifyGlare), Member = "OnRenderImage")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Matrix4x4), Member = "set_Item")]
	[Calls(Type = typeof(Material), Member = "SetMatrix")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 42)]
	public void UpdateMatrixesForPass(Material material, Vector4[] offsets, Vector4[] weights, float glareIntensity, float rotation)
	{
	}

	[CalledBy(Type = typeof(AmplifyBloomBase), Member = "OnRenderImage")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	[Calls(Type = typeof(AmplifyGlare), Member = "OnRenderFromCache")]
	[Calls(Type = typeof(Gradient), Member = "Evaluate")]
	[Calls(Type = typeof(Color), Member = "Lerp")]
	[Calls(Type = typeof(AmplifyUtils), Member = "GetTempRenderTarget")]
	[Calls(Type = typeof(AmplifyGlare), Member = "UpdateMatrixesForPass")]
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	[Calls(Type = typeof(Vector4), Member = "get_one")]
	[Calls(Type = typeof(Material), Member = "SetVector")]
	[Calls(Type = typeof(RenderTexture), Member = "DiscardContents")]
	[Calls(Type = typeof(AmplifyUtils), Member = "ReleaseTempRenderTarget")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 220)]
	public void OnRenderImage(Material material, RenderTexture source, RenderTexture dest, float cameraRot)
	{
	}
}
