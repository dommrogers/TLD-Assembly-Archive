using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace AmplifyBloom;

[Serializable]
public class AmplifyLensFlare : IAmplifyItem
{
	private const int LUTTextureWidth = 256;

	private float m_overallIntensity;

	private float m_normalizedGhostIntensity;

	private float m_normalizedHaloIntensity;

	private bool m_applyLensFlare;

	private int m_lensFlareGhostAmount;

	private Vector4 m_lensFlareGhostsParams;

	private float m_lensFlareGhostChrDistortion;

	private Gradient m_lensGradient;

	private Texture2D m_lensFlareGradTexture;

	private Color[] m_lensFlareGradColor;

	private Vector4 m_lensFlareHaloParams;

	private float m_lensFlareHaloChrDistortion;

	private int m_lensFlareGaussianBlurAmount;

	public bool ApplyLensFlare
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		get
		{
			return default(bool);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public float OverallIntensity
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public int LensFlareGhostAmount
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		get
		{
			return default(int);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public Vector4 LensFlareGhostsParams
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(Vector4);
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public float LensFlareNormalizedGhostsIntensity
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public float LensFlareGhostsIntensity
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public float LensFlareGhostsDispersal
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public float LensFlareGhostsPowerFactor
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(float);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public float LensFlareGhostsPowerFalloff
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public Gradient LensFlareGradient
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 15)]
		set
		{
		}
	}

	public Vector4 LensFlareHaloParams
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(Vector4);
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public float LensFlareNormalizedHaloIntensity
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(float);
		}
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public float LensFlareHaloIntensity
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		get
		{
			return default(float);
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public float LensFlareHaloWidth
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public float LensFlareHaloPowerFactor
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public float LensFlareHaloPowerFalloff
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public float LensFlareGhostChrDistortion
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		get
		{
			return default(float);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public float LensFlareHaloChrDistortion
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		get
		{
			return default(float);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public int LensFlareGaussianBlurAmount
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		get
		{
			return default(int);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Gradient), Member = "SetKeys")]
	[CalledBy(Type = typeof(AmplifyBloomBase), Member = ".ctor")]
	[CallsUnknownMethods(Count = 31)]
	public AmplifyLensFlare()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "DestroyImmediate")]
	public void Destroy()
	{
	}

	[CalledBy(Type = typeof(AmplifyBloomBase), Member = "Awake")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(Texture2D), Member = "Apply")]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Texture2D), Member = "SetPixels")]
	public void CreateLUTexture()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(AmplifyUtils), Member = "GetTempRenderTarget")]
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	[CalledBy(Type = typeof(AmplifyBloomBase), Member = "OnRenderImage")]
	[CallsUnknownMethods(Count = 7)]
	public RenderTexture ApplyFlare(Material material, RenderTexture source)
	{
		return null;
	}

	[Calls(Type = typeof(Texture2D), Member = "Apply")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Texture2D), Member = "SetPixels")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public void TextureFromGradient()
	{
	}
}
