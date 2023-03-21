using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class QualitySettingsManager : MonoBehaviour
{
	public QualityLevelSettings m_QualityPresetLow;

	public QualityLevelSettings m_QualityPresetMedium;

	public QualityLevelSettings m_QualityPresetHigh;

	public QualityLevelSettings m_QualityPresetUltra;

	public QualityLevelSettings m_QualityPresetFancy;

	public QualityLevelSettings m_QualityPresetXboxOne;

	public QualityLevelSettings m_QualityPresetPS4;

	public QualityLevelSettings m_QualityPresetXboxOneX;

	public QualityLevelSettings m_QualityPresetPS4Pro;

	public QualityLevelSettings m_QualityPresetSwitch;

	public QualityLevelSettings m_QualityPresetSwitchBoost;

	public const float m_ShadowDrawDistanceMin = 20f;

	public const float m_ShadowDrawDistanceMax = 250f;

	public const float m_TreeDrawDistanceMin = 500f;

	public const float m_TreeDrawDistanceMax = 3000f;

	public const float m_TreeBillboardDistanceMin = 50f;

	public const float m_TreeBillboardDistanceMax = 800f;

	public const float m_GroundDetailsDrawDistanceMin = 20f;

	public const float m_GroundDetailsDrawDistanceMax = 250f;

	public const float m_GroundDetailsDensityMin = 0f;

	public const float m_GroundDetailsDensityMax = 100f;

	public const int MIN_SYSTEM_RAM_FOR_FULLRES_TEXTURES_MB = 4096;

	public const int MAX_HEIGHTMAP_PIXEL_ERROR = 200;

	private LodBias m_SceneLodBias;

	private static QualitySettingsManagerSaveData m_QualitySettingsManagerSaveData;

	private static Quality m_CurrentQuality;

	private static QualityLevelSettings m_QualityCustom;

	private static bool s_RestartPending;

	private static int s_PendingMasterTextureLimit;

	[Calls(Type = typeof(QualitySettingsManager), Member = "ClampMasterTextureLimit")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ClampMasterTextureLimit")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ClampMasterTextureLimit")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ClampMasterTextureLimit")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ClampMasterTextureLimit")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ClampMasterTextureLimit")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ClampMasterTextureLimit")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ClampMasterTextureLimit")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ClampMasterTextureLimit")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ClampMasterTextureLimit")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "CopyQualitySettings")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ClampMasterTextureLimit")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ClampSliderValuesToRange")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ClampSliderValuesToRange")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ClampSliderValuesToRange")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ClampSliderValuesToRange")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ClampSliderValuesToRange")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ClampSliderValuesToRange")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ClampSliderValuesToRange")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ClampSliderValuesToRange")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ClampSliderValuesToRange")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ClampSliderValuesToRange")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ClampSliderValuesToRange")]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 2)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(QualitySettingsManager), Member = "CopyQualitySettings")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ClampMasterTextureLimit")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "DeserializeSettings")]
	[CallsUnknownMethods(Count = 3)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyCommandLineParameters")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RestoreLegacyQualityLevel")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "DeserializeSettings")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	public Quality SetCurrentQualityLevel(Quality quality)
	{
		return default(Quality);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public Quality GetCurrentQualityLevel()
	{
		return default(Quality);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "DoesQualityRequireRestart")]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "ApplyQualitySettings")]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "SetAndMaybeApplyQuality")]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "GetCurrentQualitySettings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshSettings")]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "OverrideTerrainPixelError")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshQualitySettings")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessQualityMenu")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 8)]
	public QualityLevelSettings GetQualitySettings(Quality quality)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetQualitySettings")]
	[CallerCount(Count = 21)]
	public QualityLevelSettings GetCurrentQualitySettings()
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ApplyQualitySettings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[CalledBy(Type = typeof(GameManager), Member = "Update")]
	public void ApplyCurrentQualitySettings()
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_fancy")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_set_quality")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_fancy")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ApplyQualitySettings")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetQualitySettings")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmQuality")]
	public bool SetAndMaybeApplyQuality(Quality quality, bool force)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 59)]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "SetDefaultQualityLevel")]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "SetAndMaybeApplyQuality")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(CameraEffects), Member = "ConfigureContrastEnhance")]
	[Calls(Type = typeof(CameraEffects), Member = "ConfigureSSAO")]
	[Calls(Type = typeof(CameraEffects), Member = "ConfigureSSAO")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "SetPostFx")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "SetSSAO")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetLodBias")]
	[Calls(Type = typeof(QualitySettings), Member = "set_shadowCascades")]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "ApplyCurrentQualitySettings")]
	[Calls(Type = typeof(Terrain), Member = "set_drawInstanced")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 28)]
	[Calls(Type = typeof(SnowPatchManager), Member = "AllocateResources")]
	[Calls(Type = typeof(FootstepTrail), Member = "OnQualityChange")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetQualitySettings")]
	[Calls(Type = typeof(Terrain), Member = "set_treeBillboardDistance")]
	[Calls(Type = typeof(Terrain), Member = "set_detailObjectDensity")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetHeightmapPixelError")]
	[Calls(Type = typeof(Terrain), Member = "set_heightmapPixelError")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(QualitySettings), Member = "set_shadowCascades")]
	public void ApplyQualitySettings(Quality quality)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ApplyQualitySettings")]
	public void SetDefaultQualityLevel()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool SystemShouldUseLowGraphicsQuality()
	{
		return default(bool);
	}

	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "ApplyQualitySettings")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[Calls(Type = typeof(CameraEffects), Member = "SetAntiAliasingMode")]
	[CallsUnknownMethods(Count = 99)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	private void SetPostFx(QualityPostFx quality)
	{
	}

	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "ApplyQualitySettings")]
	[Calls(Type = typeof(CameraEffects), Member = "EnableCameraWeaponPostEffects")]
	[Calls(Type = typeof(CameraEffects), Member = "ConfigureSSAO")]
	[Calls(Type = typeof(CameraEffects), Member = "ConfigureSSAO")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CameraEffects), Member = "EnableCameraWeaponPostEffects")]
	public void SetSSAO(QualitySSAO quality)
	{
	}

	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "MaybeSwitchToCustomQuality")]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "Awake")]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 1)]
	public void CopyQualitySettings(QualityLevelSettings dest, QualityLevelSettings source)
	{
	}

	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "MaybeSwitchToCustomQuality")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	public bool Match(QualityLevelSettings A, QualityLevelSettings B)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(QualitySettingsManager), Member = "Awake")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "Awake")]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "Awake")]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "Awake")]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "Awake")]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "Awake")]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "Awake")]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "Awake")]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "Awake")]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "Awake")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "Awake")]
	private void ClampSliderValuesToRange(QualityLevelSettings settings)
	{
	}

	[CalledBy(Type = typeof(QualitySettingsManager), Member = "Awake")]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "Awake")]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "Awake")]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "Awake")]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "Awake")]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "Awake")]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "Awake")]
	[CallerCount(Count = 12)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "Awake")]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "Awake")]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "Awake")]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "Awake")]
	private void ClampMasterTextureLimit(QualityLevelSettings settings)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "ApplyQualitySettings")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LodBias), Member = "GetDefaultLodBias")]
	private float GetLodBias(QualityLodBias quality)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "OverrideTerrainPixelError")]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "ApplyQualitySettings")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(HeightmapPixelError), Member = "GetDefaultPixelError")]
	[CallsDeduplicatedMethods(Count = 4)]
	private float GetHeightmapPixelError(Terrain t, QualityTerrainLod quality)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Terrain), Member = "set_heightmapPixelError")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_terrain_setpixelerror")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "ApplyTerrainPixelError")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetHeightmapPixelError")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetQualitySettings")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Terrain), Member = "set_heightmapPixelError")]
	public void OverrideTerrainPixelError(int value)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 6)]
	private void SetTextureStreaming(QualityLevelSettings settings)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsUnknownMethods(Count = 2)]
	private static bool UsingOpenGL()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetQualitySettings")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private bool DoesQualityRequireRestart(Quality quality)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public QualitySettingsManager()
	{
	}
}
