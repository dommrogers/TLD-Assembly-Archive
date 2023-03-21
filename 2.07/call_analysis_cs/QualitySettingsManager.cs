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

	[Calls(Type = typeof(QualitySettingsManager), Member = "ClampSliderValuesToRange")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ClampSliderValuesToRange")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ClampSliderValuesToRange")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ClampSliderValuesToRange")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ClampSliderValuesToRange")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ClampSliderValuesToRange")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ClampSliderValuesToRange")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ClampSliderValuesToRange")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ClampSliderValuesToRange")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ClampSliderValuesToRange")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ClampSliderValuesToRange")]
	private void Awake()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[Calls(Type = typeof(QualitySettingsManager), Member = "ApplyQualitySettings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnAfterDeserialization")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
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

	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateAuroraElectrolizers")]
	[CalledBy(Type = typeof(ParticleDistanceCull), Member = "LateUpdate")]
	[CalledBy(Type = typeof(ParticleDistanceCull), Member = "LateUpdate")]
	[CalledBy(Type = typeof(LightQualitySwitch), Member = "SetLocalQuality")]
	[CalledBy(Type = typeof(LightDistanceCull), Member = "LateUpdate")]
	[CalledBy(Type = typeof(WeatherParticleManager), Member = "LateUpdate_part1")]
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

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmQuality")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmSettings")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetQualitySettings")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ApplyQualitySettings")]
	public bool SetAndMaybeApplyQuality(Quality quality, bool force)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(QualitySettingsManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "SetDefaultQualityLevel")]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "SetAndMaybeApplyQuality")]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "ApplyCurrentQualitySettings")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_set_quality")]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_fancy")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnAfterDeserialization")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_fancy")]
	[CallAnalysisFailed]
	public void ApplyQualitySettings(Quality quality)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ApplyQualitySettings")]
	[CallsUnknownMethods(Count = 1)]
	public void SetDefaultQualityLevel()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static bool SystemShouldUseLowGraphicsQuality()
	{
		return default(bool);
	}

	[Calls(Type = typeof(CameraEffects), Member = "VignettingEnable")]
	[CallsUnknownMethods(Count = 26)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(CameraEffects), Member = "VignettingEnable")]
	[Calls(Type = typeof(CameraEffects), Member = "ContrastEnhanceEnable")]
	[Calls(Type = typeof(CameraEffects), Member = "BloomEnable")]
	[Calls(Type = typeof(CameraEffects), Member = "VignettingEnable")]
	[Calls(Type = typeof(CameraEffects), Member = "ContrastEnhanceEnable")]
	[Calls(Type = typeof(CameraEffects), Member = "BloomEnable")]
	[Calls(Type = typeof(CameraEffects), Member = "ContrastEnhanceEnable")]
	[Calls(Type = typeof(CameraEffects), Member = "BloomEnable")]
	[Calls(Type = typeof(CameraEffects), Member = "ContrastEnhanceEnable")]
	[Calls(Type = typeof(CameraEffects), Member = "BloomEnable")]
	[Calls(Type = typeof(CameraEffects), Member = "VignettingEnable")]
	[Calls(Type = typeof(CameraEffects), Member = "ContrastEnhanceEnable")]
	[Calls(Type = typeof(CameraEffects), Member = "BloomEnable")]
	[Calls(Type = typeof(CameraEffects), Member = "SetAntiAliasingMode")]
	[Calls(Type = typeof(CameraEffects), Member = "VignettingEnable")]
	[Calls(Type = typeof(CameraEffects), Member = "ContrastEnhanceEnable")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraEffects), Member = "BloomEnable")]
	private void SetPostFx(QualityPostFx quality)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(CameraEffects), Member = "EnableCameraWeaponPostEffects")]
	[Calls(Type = typeof(CameraEffects), Member = "ConfigureSSAO")]
	[Calls(Type = typeof(CameraEffects), Member = "EnableCameraWeaponPostEffects")]
	[Calls(Type = typeof(CameraEffects), Member = "ConfigureSSAO")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	public void SetSSAO(QualitySSAO quality)
	{
	}

	[CallerCount(Count = 0)]
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

	[CalledBy(Type = typeof(QualitySettingsManager), Member = "Awake")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "Awake")]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "Awake")]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "Awake")]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "Awake")]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "Awake")]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "Awake")]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "Awake")]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "Awake")]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "Awake")]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "Awake")]
	private void ClampSliderValuesToRange(QualityLevelSettings settings)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void ClampMasterTextureLimit(QualityLevelSettings settings)
	{
	}

	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 1)]
	private float GetLodBias(QualityLodBias quality)
	{
		return default(float);
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(QualitySettingsManager), Member = "OverrideTerrainPixelError")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	private float GetHeightmapPixelError(Terrain t, QualityTerrainLod quality)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_terrain_setpixelerror")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "ApplyTerrainPixelError")]
	[Calls(Type = typeof(Terrain), Member = "set_heightmapPixelError")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetQualitySettings")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetHeightmapPixelError")]
	public void OverrideTerrainPixelError(int value)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	private void SetTextureStreaming(QualityLevelSettings settings)
	{
	}

	[Calls(Type = typeof(string), Member = "Contains")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private static bool UsingOpenGL()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetQualitySettings")]
	[CallsUnknownMethods(Count = 2)]
	private bool DoesQualityRequireRestart(Quality quality)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public QualitySettingsManager()
	{
	}
}
