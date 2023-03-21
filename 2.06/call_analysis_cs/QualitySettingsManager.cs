using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using UnityEngine;

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
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(QualitySettingsManager), Member = "CopyQualitySettings")]
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
	[Calls(Type = typeof(QualitySettingsManager), Member = "ClampSliderValuesToRange")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ClampSliderValuesToRange")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ClampSliderValuesToRange")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ClampSliderValuesToRange")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ClampSliderValuesToRange")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ClampSliderValuesToRange")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ClampSliderValuesToRange")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ClampSliderValuesToRange")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ClampSliderValuesToRange")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ClampSliderValuesToRange")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ClampSliderValuesToRange")]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void Start()
	{
	}

	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(QualitySettingsManager), Member = "CopyQualitySettings")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ClampMasterTextureLimit")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ApplyQualitySettings")]
	[CallsUnknownMethods(Count = 2)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	public Quality SetCurrentQualityLevel(Quality quality)
	{
		return default(Quality);
	}

	[CallerCount(Count = 0)]
	public Quality GetCurrentQualityLevel()
	{
		return default(Quality);
	}

	[CallerCount(Count = 23)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	public QualityLevelSettings GetQualitySettings(Quality quality)
	{
		return null;
	}

	[CalledBy(Type = typeof(ParticleDistanceCull), Member = "LateUpdate")]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateAuroraElectrolizers")]
	[CalledBy(Type = typeof(ParticleDistanceCull), Member = "LateUpdate")]
	[CalledBy(Type = typeof(WeatherParticleManager), Member = "LateUpdate_part1")]
	[CalledBy(Type = typeof(LightDistanceCull), Member = "LateUpdate")]
	[CalledBy(Type = typeof(LightQualitySwitch), Member = "SetLocalQuality")]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "Update")]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "Update")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetQualitySettings")]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(LightDistanceCull), Member = "LateUpdate")]
	public QualityLevelSettings GetCurrentQualitySettings()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ApplyQualitySettings")]
	[CalledBy(Type = typeof(GameManager), Member = "Update")]
	public void ApplyCurrentQualitySettings()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetQualitySettings")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ApplyQualitySettings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmSettings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmQuality")]
	[CallsUnknownMethods(Count = 2)]
	public bool SetAndMaybeApplyQuality(Quality quality, bool force)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_fancy")]
	[Calls(Type = typeof(CameraEffects), Member = "ConfigureContrastEnhance")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_fancy")]
	[Calls(Type = typeof(CameraEffects), Member = "ConfigureSSAO")]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "ApplyCurrentQualitySettings")]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "SetAndMaybeApplyQuality")]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "SetDefaultQualityLevel")]
	[CallsUnknownMethods(Count = 31)]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "Deserialize")]
	[Calls(Type = typeof(CameraEffects), Member = "ConfigureSSAO")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_set_quality")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "SetSSAO")]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 29)]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetQualitySettings")]
	[Calls(Type = typeof(FootstepTrail), Member = "OnQualityChange")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "SetPostFx")]
	[Calls(Type = typeof(SnowPatchManager), Member = "AllocateResources")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetHeightmapPixelError")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "SetTextureStreaming")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetLodBias")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "OnQualityChange")]
	public void ApplyQualitySettings(Quality quality)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[Calls(Type = typeof(CameraEffects), Member = "BloomEnable")]
	[CallsUnknownMethods(Count = 36)]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "ApplyQualitySettings")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(CameraEffects), Member = "VignettingEnable")]
	[Calls(Type = typeof(CameraEffects), Member = "ContrastEnhanceEnable")]
	[Calls(Type = typeof(CameraEffects), Member = "BloomEnable")]
	[Calls(Type = typeof(CameraEffects), Member = "VignettingEnable")]
	[Calls(Type = typeof(CameraEffects), Member = "ContrastEnhanceEnable")]
	[Calls(Type = typeof(CameraEffects), Member = "BloomEnable")]
	[Calls(Type = typeof(CameraEffects), Member = "VignettingEnable")]
	[Calls(Type = typeof(CameraEffects), Member = "ContrastEnhanceEnable")]
	[Calls(Type = typeof(CameraEffects), Member = "VignettingEnable")]
	[Calls(Type = typeof(CameraEffects), Member = "BloomEnable")]
	[Calls(Type = typeof(CameraEffects), Member = "BloomEnable")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(CameraEffects), Member = "BloomEnable")]
	[Calls(Type = typeof(CameraEffects), Member = "ContrastEnhanceEnable")]
	[Calls(Type = typeof(CameraEffects), Member = "VignettingEnable")]
	[Calls(Type = typeof(CameraEffects), Member = "ContrastEnhanceEnable")]
	[Calls(Type = typeof(CameraEffects), Member = "ContrastEnhanceEnable")]
	[Calls(Type = typeof(CameraEffects), Member = "BloomEnable")]
	[Calls(Type = typeof(CameraEffects), Member = "ContrastEnhanceEnable")]
	[Calls(Type = typeof(CameraEffects), Member = "VignettingEnable")]
	[Calls(Type = typeof(CameraEffects), Member = "BloomEnable")]
	[Calls(Type = typeof(CameraEffects), Member = "ContrastEnhanceEnable")]
	[Calls(Type = typeof(CameraEffects), Member = "VignettingEnable")]
	[Calls(Type = typeof(CameraEffects), Member = "VignettingEnable")]
	private void SetPostFx(QualityPostFx quality)
	{
	}

	[Calls(Type = typeof(CameraEffects), Member = "ConfigureSSAO")]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "ApplyQualitySettings")]
	[Calls(Type = typeof(CameraEffects), Member = "EnableCameraWeaponPostEffects")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(CameraEffects), Member = "ConfigureSSAO")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
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

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "MaybeSwitchToCustomQuality")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	public bool Match(QualityLevelSettings A, QualityLevelSettings B)
	{
		return default(bool);
	}

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
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "Awake")]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "Awake")]
	private void ClampSliderValuesToRange(QualityLevelSettings settings)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "Awake")]
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
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "Awake")]
	private void ClampMasterTextureLimit(QualityLevelSettings settings)
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "ApplyQualitySettings")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	private float GetLodBias(QualityLodBias quality)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "OverrideTerrainPixelError")]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "ApplyQualitySettings")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	private float GetHeightmapPixelError(Terrain t, QualityTerrainLod quality)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Debug), Member = "ApplyTerrainPixelError")]
	[Calls(Type = typeof(Terrain), Member = "set_heightmapPixelError")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_terrain_setpixelerror")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetQualitySettings")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetHeightmapPixelError")]
	public void OverrideTerrainPixelError(int value)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "ApplyQualitySettings")]
	[CallsUnknownMethods(Count = 6)]
	private void SetTextureStreaming(QualityLevelSettings settings)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsUnknownMethods(Count = 2)]
	private static bool UsingOpenGL()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetQualitySettings")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool DoesQualityRequireRestart(Quality quality)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public QualitySettingsManager()
	{
	}
}
