using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wind : MonoBehaviour
{
	public float m_OcclusionTestRange;

	public float m_OcclusionTestFOV;

	public float m_OcclusionReduceWindchillPercent;

	public AudioOcclusionLevel m_OcclusionAudioLevel;

	private bool m_PlayerOccluded;

	private Vector3 m_LastTestPosition;

	public const float MAX_GUST = 0.25f;

	public WindSettings[] m_WindSettings;

	public float m_MaxWindMPH;

	public float m_HoursBetweenWindChangeMin;

	public float m_HoursBetweenWindChangeMax;

	public float m_HoursForTransitionMin;

	public float m_HoursForTransitionMax;

	public float m_Gust_NoiseStepSpeed;

	public float m_Gust_NoiseOctave2StepScalar;

	public float m_Gust_NoiseOctave2ResultScalar;

	public float m_LateralBluster_Limit;

	public float m_LateralBluster_NoiseStepSpeed;

	public float m_LateralBluster_NoiseOctave2StepScalar;

	public float m_LateralBluster_NoiseOctave2ResultScalar;

	public float m_VerticalBluster_Limit;

	public float m_VerticalBluster_NoiseStepSpeed;

	public float m_VerticalBluster_NoiseOctave2StepScalar;

	public float m_VerticalBluster_NoiseOctave2ResultScalar;

	private ActiveWindSettings m_ActiveSettings;

	private ActiveWindSettings m_SourceSettings;

	private ActiveWindSettings m_TargetSettings;

	private Vector2 m_Gust_NoisePos1;

	private Vector2 m_Gust_NoiseStepVector1;

	private Vector2 m_Gust_NoisePos2;

	private Vector2 m_Gust_NoiseStepVector2;

	private Vector2 m_LateralBluster_NoisePos1;

	private Vector2 m_LateralBluster_NoiseStepVector1;

	private Vector2 m_LateralBluster_NoisePos2;

	private Vector2 m_LateralBluster_NoiseStepVector2;

	private Vector2 m_VerticalBluster_NoisePos1;

	private Vector2 m_VerticalBluster_NoiseStepVector1;

	private Vector2 m_VerticalBluster_NoisePos2;

	private Vector2 m_VerticalBluster_NoiseStepVector2;

	private WindStrength m_CurrentStrength;

	private float m_CurrentMPH_Base;

	private float m_CurrentAngleDeg_Base;

	private Vector3 m_CurrentDirection_Base;

	private float m_CurrentMPH;

	private float m_CurrentAngleDeg;

	private Vector3 m_CurrentDirection;

	private float m_CurrentPitch;

	private float m_LateralBluster;

	private float m_VerticalBluster;

	private float m_GustScalar;

	private float m_GustScalarAdjusted;

	private float m_TransitionTimeTODSeconds;

	private float m_PhaseElapsedTODSeconds;

	private float m_PhaseDurationHours;

	private float m_BaseWindChill;

	private float m_WindChill;

	private ParticleSystem m_LightSnowParticleSystem;

	private ParticleSystem m_HeavySnowParticleSystem;

	private WindZone m_WindZone;

	private Transform m_WindZoneTransform;

	private List<WindKiller> m_WindKillers;

	public float m_LastWindIntensityBlendSentToWise;

	public float m_LastWindActualSpeedSentToWise;

	public float m_LastWindGustStrengthSentToWise;

	private float m_LastPlayerWindAngleSentToWise;

	private float m_LockedWindSpeed;

	private bool m_NeverCalmWind;

	private bool m_StartHasBeenCalled;

	private uint m_WindLoopAudioInstance;

	private bool m_WindAudioForceStopped;

	private float m_ArtificalWindSpeedIncrease;

	private static WindSaveDataProxy m_WindSaveDataProxy;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool PlayerShelteredFromWind()
	{
		return false;
	}

	[CalledBy(Type = typeof(Wind), Member = "UpdateWindOcclusion")]
	[CalledBy(Type = typeof(OcclusionTest), Member = "CheckOcclusion")]
	[CalledBy(Type = typeof(ParticleWindForce), Member = "Update")]
	[CalledBy(Type = typeof(Fire), Member = "FireShouldBlowOutFromWind")]
	[CalledBy(Type = typeof(TorchItem), Member = "ShouldBlowOut")]
	[CalledBy(Type = typeof(Campfire), Member = "TooWindyToStart")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(Wind), Member = "PointInsideWindKiller")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(Wind), Member = "ShouldIgnoreWindOccluder")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	public bool IsPositionOccludedFromWind(Vector3 pos)
	{
		return false;
	}

	[CalledBy(Type = typeof(Wind), Member = "IsPositionOccludedFromWind")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private bool ShouldIgnoreWindOccluder(Collider collider)
	{
		return false;
	}

	[CalledBy(Type = typeof(Wind), Member = "Update")]
	[CalledBy(Type = typeof(LeanToManager), Member = "ExitLeanToAfterFadeOut")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "ExitShelterAfterFadeOut")]
	[CalledBy(Type = typeof(PlayerInVehicle), Member = "ExitVehicleAfterFadeOut")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInNonRuinedShelter")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "PanViewCameraIsDetached")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Wind), Member = "IsPositionOccludedFromWind")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 20)]
	public void UpdateWindOcclusion()
	{
	}

	[CalledBy(Type = typeof(Wind), Member = "IsPositionOccludedFromWind")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	private bool PointInsideWindKiller(Vector3 pos)
	{
		return false;
	}

	[CalledBy(Type = typeof(Wind), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Wind), Member = "ResetNoise")]
	[Calls(Type = typeof(Vector3), Member = "get_forward")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void Start()
	{
	}

	[CalledBy(Type = typeof(Wind), Member = "Start")]
	[CalledBy(Type = typeof(Wind), Member = "Deserialize")]
	[CalledBy(Type = typeof(Wind), Member = "StartPhase")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 12)]
	private void ResetNoise()
	{
	}

	[CalledBy(Type = typeof(Wind), Member = "Update")]
	[CalledBy(Type = typeof(Wind), Member = "Deserialize")]
	[CalledBy(Type = typeof(Wind), Member = "StartPhase")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(GameManager), Member = "GetDeltaTime")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateNoise()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "IsFrameValidToUpdate")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Wind), Member = "StartRandomPhase")]
	[Calls(Type = typeof(Wind), Member = "MaybeChangePhase")]
	[Calls(Type = typeof(GameManager), Member = "GetDeltaTime")]
	[Calls(Type = typeof(Mathf), Member = "LerpAngle")]
	[Calls(Type = typeof(Mathf), Member = "Repeat")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Wind), Member = "UpdateNoise")]
	[Calls(Type = typeof(Wind), Member = "RefreshSettings")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis")]
	[Calls(Type = typeof(Wind), Member = "UpdateWindOcclusion")]
	[Calls(Type = typeof(Wind), Member = "UpdateWindChill")]
	[Calls(Type = typeof(Wind), Member = "UpdateWindZone")]
	[Calls(Type = typeof(Wind), Member = "UpdateProceduralWind")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 13)]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Wind), Member = "ForceStopAudioLoop")]
	private void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ToggleGameCameraForBrightness")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ToggleGameCameraForBrightness")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Wind), Member = "Start")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(Wind), Member = "StartPhaseImmediate")]
	[Calls(Type = typeof(Wind), Member = "ResetNoise")]
	[Calls(Type = typeof(Wind), Member = "UpdateNoise")]
	[Calls(Type = typeof(Wind), Member = "RefreshSettings")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void Deserialize(string text)
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Wind), Member = "Update")]
	[CalledBy(Type = typeof(Wind), Member = "MaybeChangePhase")]
	[CallerCount(Count = 3)]
	public void StartRandomPhase(bool forceCalm)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void StartPhase(WindDirection direction, WindStrength strength)
	{
	}

	[CalledBy(Type = typeof(Weather), Member = "WarmWeather")]
	[CalledBy(Type = typeof(Weather), Member = "WarmWeatherState")]
	[CalledBy(Type = typeof(Wind), Member = "StartPhaseImmediate")]
	[CalledBy(Type = typeof(Wind), Member = "StartPhaseImmediate")]
	[CalledBy(Type = typeof(Wind), Member = "ForceImmediateWindChangeBasedOnWeather")]
	[CalledBy(Type = typeof(Wind), Member = "MaybeChangePhase")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "SetWind")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(ActiveWindSettings), Member = ".ctor")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(Wind), Member = "ResetNoise")]
	[Calls(Type = typeof(Wind), Member = "UpdateNoise")]
	[Calls(Type = typeof(Wind), Member = "RefreshSettings")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "UpdateDecalProjectorLifeTimes")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 42)]
	public void StartPhase(WindStrength strength, float angle = -1f)
	{
	}

	[CalledBy(Type = typeof(DebugViewModeManager), Member = "ToggleTexelDensity")]
	[CalledBy(Type = typeof(Wind), Member = "Deserialize")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ToggleGameCameraForBrightness")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "SetWind")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Wind), Member = "DirectionToAngle")]
	[Calls(Type = typeof(Wind), Member = "StartPhase")]
	[Calls(Type = typeof(Weather), Member = "WarmBlowingSnow")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void StartPhaseImmediate(WindDirection direction, WindStrength strength)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Wind), Member = "StartPhase")]
	[Calls(Type = typeof(Weather), Member = "WarmBlowingSnow")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void StartPhaseImmediate(WindStrength strength, float angle = -1f)
	{
	}

	[CalledBy(Type = typeof(Wind), Member = "OnDestroy")]
	[CalledBy(Type = typeof(Action_StopWindAudio), Member = "OnExecute")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void ForceStopAudioLoop()
	{
	}

	[CalledBy(Type = typeof(Wind), Member = "StartPhaseImmediate")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "SetWind")]
	[CallerCount(Count = 2)]
	public static float DirectionToAngle(WindDirection direction)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public void AddArtificialWindSpeedIncrease(float increase)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public WindStrength GetStrength()
	{
		return default(WindStrength);
	}

	[CallerCount(Count = 0)]
	public float GetNormalizedIntensity()
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetSpeedMPH_Base()
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public float GetSpeedMPH()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public float GetTargetSpeedMPH()
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetWindAngle_Base()
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetWindAngle()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public Vector3 GetWindDirection_Base()
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	public Vector3 GetWindDirection()
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(WeatherParticleManager), Member = "UpdateShaderGlobalsForFoliage")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public float GetWindLift()
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetBaseWindChill()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public float GetWindChill()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Wind), Member = "StartPhase")]
	public void ForceImmediateWindChangeBasedOnWeather(WeatherStage ws)
	{
	}

	[CalledBy(Type = typeof(MatchesItem), Member = "UpdateWhileInHands")]
	[CalledBy(Type = typeof(MatchesItem), Member = "IgniteDelayed")]
	[CalledBy(Type = typeof(TorchItem), Member = "AttemptToLight")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool TooWindyForPlayerAction(float thresholdSpeedMPH)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void AddWindKiller(WindKiller wk)
	{
	}

	[CallerCount(Count = 0)]
	public float GetPlayerWindAngle()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Wind), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Weather), Member = "IsBlizzard")]
	[Calls(Type = typeof(Wind), Member = "StartRandomPhase")]
	[Calls(Type = typeof(Wind), Member = "StartPhase")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private void MaybeChangePhase()
	{
	}

	[CalledBy(Type = typeof(Wind), Member = "Update")]
	[CalledBy(Type = typeof(Wind), Member = "Deserialize")]
	[CalledBy(Type = typeof(Wind), Member = "StartPhase")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis")]
	[Calls(Type = typeof(Vector3), Member = "get_forward")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(GameManager), Member = "GetDeltaTime")]
	[Calls(Type = typeof(Utils), Member = "ExpStep")]
	[Calls(Type = typeof(Mathf), Member = "Repeat")]
	[Calls(Type = typeof(Vector3), Member = "get_right")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Wind), Member = "SetWindAccelerationForAllInteractiveCloth")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void RefreshSettings()
	{
	}

	[CalledBy(Type = typeof(Wind), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	private void UpdateWindZone()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateUniStormParticleSystems()
	{
	}

	[CalledBy(Type = typeof(Wind), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Wind), Member = "CalculateWindChill")]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInNonRuinedShelter")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private void UpdateWindChill()
	{
	}

	[CalledBy(Type = typeof(Wind), Member = "UpdateWindChill")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsNight")]
	[Calls(Type = typeof(Weather), Member = "IsClear")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	private float CalculateWindChill(float airTempCelsius)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Wind), Member = "SetWindAccelerationForAllInteractiveCloth")]
	[CalledBy(Type = typeof(Wind), Member = "UpdateProceduralWind")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private WindStrength GetStrengthFromSpeed(float normalizedSpeed, out WindSettings ws)
	{
		ws = null;
		return default(WindStrength);
	}

	[CalledBy(Type = typeof(Wind), Member = "RefreshSettings")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(Wind), Member = "GetStrengthFromSpeed")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(InteractiveClothManager), Member = "SetAcceleration")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void SetWindAccelerationForAllInteractiveCloth()
	{
	}

	[CalledBy(Type = typeof(Wind), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "HasFadedInOnStart")]
	[Calls(Type = typeof(Wind), Member = "GetStrengthFromSpeed")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	[Calls(Type = typeof(Wind), Member = "PlayProceduralWindAudio")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(Wind), Member = "GetWindAngleRelativeToPlayer")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private void UpdateProceduralWind()
	{
	}

	[CalledBy(Type = typeof(Weather), Member = "GetDebugWeatherText")]
	[CalledBy(Type = typeof(Wind), Member = "UpdateProceduralWind")]
	[CalledBy(Type = typeof(AnimatedUVs), Member = "LateUpdate")]
	[CalledBy(Type = typeof(FirstPersonParticles), Member = "ComputeWindInEmitterSpace")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(GameManager), Member = "HasPlayerObject")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Utils), Member = "GetAngleDegrees")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public float GetWindAngleRelativeToPlayer()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 9)]
	public void ApplySceneOverrides(SceneWeatherOverride swo)
	{
	}

	[CallerCount(Count = 0)]
	public void LockWindInstant(float mph)
	{
	}

	[CalledBy(Type = typeof(Wind), Member = "UpdateProceduralWind")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 24)]
	private uint PlayProceduralWindAudio()
	{
		return 0u;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public Wind()
	{
	}
}
