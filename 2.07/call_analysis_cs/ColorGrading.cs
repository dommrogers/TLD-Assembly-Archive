using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
using UnityEngine;
using UnityStandardAssets.ImageEffects;

public class ColorGrading : PostEffectsBase
{
	[Serializable]
	public class PosBlendInfo
	{
		public Vector3 m_Position;

		public Vector2 m_EdgeFadePower;

		public bool m_IsCamSpace;

		public float m_NoiseStepSpeed;

		public Texture2D m_EdgeEffectLut;

		public Texture2D m_ScreenTintLut;

		public float m_EdgeIntensity;

		public float m_TintIntensity;

		public float m_TintIntensityTarget;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public PosBlendInfo()
		{
		}
	}

	private enum ScreenTintClient
	{
		None,
		Pain,
		Warm,
		Freeze,
		Aux
	}

	private enum LutShaderPass
	{
		TODBlend,
		TODBlendCheap,
		ApplyAdjustments,
		SimpleBlend
	}

	private enum GradingShaderPass
	{
		StandardColorGrade,
		GradeWithPosBlend1,
		GradeWithPosBlend2
	}

	private PanelReference<Panel_ActionsRadial> m_ActionsRadial;

	public Shader m_ImageShader;

	public Material m_LutBlendMaterial;

	public Texture2D m_DefaultLUT;

	public Texture2D m_PainEffectLUT;

	public Texture2D m_NoiseTexture;

	public Vector4 m_NoiseParams;

	public bool m_NoiseRandomize;

	public float m_HdrScalar;

	public float m_Saturation;

	public float m_Gamma;

	public float m_Contrast;

	public bool m_DebugColorScalar;

	public float m_ColorScalar;

	public Texture2D m_AuxiliaryLUT;

	public float m_AuxiliaryBlend;

	public bool m_ShowWarmingEffect;

	public bool m_DebugFreezing;

	public bool m_DebugWarming;

	public PosBlendInfo m_FreezingEffect;

	public PosBlendInfo m_WarmingEffect;

	public float m_ShowFreezingEdgeArrowCount;

	public float m_ShowFreezingTintArrowCount;

	public float m_FreezingTintColdStart;

	public float m_FreezingTintColdMax;

	public float m_GammaLimitLow;

	public float m_GammaLimitHigh;

	public float m_PainEffectIntensity;

	public float m_PainEffectIntensityTarget;

	private Material m_ImageEffectMaterial;

	private Material m_CustomLUTBlendMaterial;

	private int m_Tex1AId;

	private int m_Tex1BId;

	private int m_Tex2AId;

	private int m_Tex2BId;

	private int m_TexAuxId;

	private int m_TexExtraId;

	private int m_BlendAmountsId;

	private int m_AdjustmentsId;

	private int m_LUTTexId;

	private int m_NoiseTexId;

	private int m_NoiseParamsId;

	private int m_HDRScalarId;

	private int[] m_LUTPosBlendIds;

	private int[] m_PosBlendPosIds;

	private int[] m_PosBlendInfoIds;

	private Vector4 m_BlendRecord;

	private Vector4 m_AdjustmentRecord;

	private Vector2 m_WarmingNoise;

	private Vector2 m_WarmingNoiseStep;

	private Vector2 m_FreezingNoise;

	private Vector2 m_FreezingNoiseStep;

	private LutShaderPass m_LUTBlendMainShaderPass;

	private Texture2D m_Lut1A;

	private Texture2D m_Lut1B;

	private Texture2D m_Lut2A;

	private Texture2D m_Lut2B;

	private float m_BrightnessSetting;

	private RenderTexture[] m_RenderTextures;

	private ScreenTintClient m_ScreenTintLastClient;

	private ScreenTintClient m_ScreenTintTransitionClient;

	private float m_ScreenTintTransitionTimer;

	private float m_ScreenTintTransitionDuration;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostEffectsBase), Member = "CheckSupport")]
	[Calls(Type = typeof(PostEffectsBase), Member = "CheckShaderAndCreateMaterial")]
	[Calls(Type = typeof(PostEffectsBase), Member = "ReportAutoDisable")]
	public override bool CheckResources()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(ColorGrading), Member = "UpdateLUTMaterialForTOD")]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallsUnknownMethods(Count = 20)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "DestroyImmediate")]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ColorGrading), Member = "GetModifiedGamma")]
	[CallsUnknownMethods(Count = 2)]
	public void Configure()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetDefaultGamma()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ColorGrading), Member = "GetModifiedGamma")]
	[CallsUnknownMethods(Count = 2)]
	public void ConfigureForInterior()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ColorGrading), Member = "GetModifiedGamma")]
	[CallsUnknownMethods(Count = 2)]
	public void ConfigureForExterior()
	{
	}

	[CalledBy(Type = typeof(ColorGrading), Member = "OnEnable")]
	[CalledBy(Type = typeof(ColorGrading), Member = "ConfigureLUTMaterialForInterior")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 3)]
	public void UpdateLUTMaterialForTOD(Texture2D lut1A, Texture2D lut1B, Texture2D lut2A, Texture2D lut2B, float blend1, float blend2, float blendCombine)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ColorGrading), Member = "UpdateLUTMaterialForTOD")]
	public void ConfigureLUTMaterialForInterior(Texture2D customLUT)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void UpdateMaterialForAuxiliaryBlend(Texture2D lut, float blend)
	{
	}

	[CalledBy(Type = typeof(ColorGrading), Member = "OnRenderImage")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 11)]
	private void PrepareForPositionalBlend(PosBlendInfo pb, RenderTexture rt, int i, float noise, RenderTexture screen)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ColorGrading), Member = "GetModifiedGamma")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ColorGrading), Member = "HandleScreenTint")]
	[Calls(Type = typeof(RenderTexture), Member = "GetCompatibleFormat")]
	[Calls(Type = typeof(RenderTexture), Member = "GetTemporaryImpl")]
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[Calls(Type = typeof(ColorGrading), Member = "PrepareForPositionalBlend")]
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 26)]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[CalledBy(Type = typeof(ColorGrading), Member = "HandleScreenTint")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private void GetLUTAndBlendForClient(ScreenTintClient client, out Texture2D lut, out float blend)
	{
		lut = null;
		blend = default(float);
	}

	[CalledBy(Type = typeof(ColorGrading), Member = "OnRenderImage")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ColorGrading), Member = "GetLUTAndBlendForClient")]
	[Calls(Type = typeof(RenderTexture), Member = "GetCompatibleFormat")]
	[Calls(Type = typeof(RenderTexture), Member = "GetTemporaryImpl")]
	[Calls(Type = typeof(Texture), Member = "set_wrapMode")]
	[Calls(Type = typeof(Texture), Member = "set_anisoLevel")]
	[Calls(Type = typeof(Material), Member = "SetVector")]
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 3)]
	private RenderTexture HandleScreenTint(RenderTexture screen)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetBrightnessSetting()
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetBrightnessSetting(float val)
	{
	}

	[CalledBy(Type = typeof(ColorGrading), Member = "Configure")]
	[CalledBy(Type = typeof(ColorGrading), Member = "ConfigureForInterior")]
	[CalledBy(Type = typeof(ColorGrading), Member = "ConfigureForExterior")]
	[CalledBy(Type = typeof(ColorGrading), Member = "Update")]
	[CallerCount(Count = 4)]
	private float GetModifiedGamma()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 4)]
	private void OnCopyFrom(ColorGrading src)
	{
	}

	[CallerCount(Count = 0)]
	public ColorGrading()
	{
	}
}
