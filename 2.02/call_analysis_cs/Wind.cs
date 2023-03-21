using System;
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

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool PlayerShelteredFromWind()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Campfire), Member = "TooWindyToStart")]
	[CalledBy(Type = typeof(TorchItem), Member = "ShouldBlowOut")]
	[CalledBy(Type = typeof(Fire), Member = "FireShouldBlowOutFromWind")]
	[CalledBy(Type = typeof(ParticleWindForce), Member = "Update")]
	[CalledBy(Type = typeof(Wind), Member = "UpdateWindOcclusion")]
	[CalledBy(Type = typeof(Wind), Member = "UpdateWindOcclusion")]
	[Calls(Type = typeof(Wind), Member = "ShouldIgnoreWindOccluder")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[CalledBy(Type = typeof(OcclusionTest), Member = "CheckOcclusion")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(Wind), Member = "PointInsideWindKiller")]
	[Calls(Type = typeof(Wind), Member = "ShouldIgnoreWindOccluder")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(Wind), Member = "ShouldIgnoreWindOccluder")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	public bool IsPositionOccludedFromWind(Vector3 pos)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Wind), Member = "IsPositionOccludedFromWind")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Wind), Member = "IsPositionOccludedFromWind")]
	[CalledBy(Type = typeof(Wind), Member = "IsPositionOccludedFromWind")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private bool ShouldIgnoreWindOccluder(Collider collider)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Wind), Member = "IsPositionOccludedFromWind")]
	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(PlayerInVehicle), Member = "ExitVehicleAfterFadeOut")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "ExitShelterAfterFadeOut")]
	[CalledBy(Type = typeof(LeanToManager), Member = "ExitLeanToAfterFadeOut")]
	[CalledBy(Type = typeof(Wind), Member = "Update")]
	[Calls(Type = typeof(Wind), Member = "IsPositionOccludedFromWind")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "PanViewCameraIsDetached")]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInNonRuinedShelter")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	public void UpdateWindOcclusion()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Wind), Member = "IsPositionOccludedFromWind")]
	[CallsUnknownMethods(Count = 6)]
	private bool PointInsideWindKiller(Vector3 pos)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Vector3), Member = "get_forward")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Wind), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Wind), Member = "ResetNoise")]
	public void Start()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 12)]
	[CalledBy(Type = typeof(Wind), Member = "Start")]
	[CalledBy(Type = typeof(Wind), Member = "Deserialize")]
	[CalledBy(Type = typeof(Wind), Member = "StartPhase")]
	[CallsUnknownMethods(Count = 12)]
	private void ResetNoise()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "GetDeltaTime")]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[CalledBy(Type = typeof(Wind), Member = "Update")]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[CalledBy(Type = typeof(Wind), Member = "StartPhase")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Wind), Member = "Deserialize")]
	[Calls(Type = typeof(GameManager), Member = "GetDeltaTime")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[Calls(Type = typeof(GameManager), Member = "GetDeltaTime")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	private void UpdateNoise()
	{
	}

	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Wind), Member = "UpdateNoise")]
	[Calls(Type = typeof(Wind), Member = "RefreshSettings")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Wind), Member = "UpdateWindZone")]
	[Calls(Type = typeof(Wind), Member = "UpdateWindOcclusion")]
	[Calls(Type = typeof(Wind), Member = "UpdateWindChill")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Wind), Member = "UpdateProceduralWind")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Wind), Member = "StartRandomPhase")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Repeat")]
	[Calls(Type = typeof(Mathf), Member = "LerpAngle")]
	[Calls(Type = typeof(GameManager), Member = "GetDeltaTime")]
	[Calls(Type = typeof(Wind), Member = "MaybeChangePhase")]
	[Calls(Type = typeof(Wind), Member = "StartRandomPhase")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(GameManager), Member = "IsFrameValidToUpdate")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	public void Update()
	{
	}

	[Calls(Type = typeof(Wind), Member = "ForceStopAudioLoop")]
	[CallerCount(Count = 0)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ToggleGameCameraForBrightness")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallsUnknownMethods(Count = 11)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ToggleGameCameraForBrightness")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[Calls(Type = typeof(Wind), Member = "UpdateNoise")]
	[Calls(Type = typeof(Wind), Member = "RefreshSettings")]
	[Calls(Type = typeof(Wind), Member = "StartPhaseImmediate")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Wind), Member = "ResetNoise")]
	[Calls(Type = typeof(Wind), Member = "Start")]
	public void Deserialize(string text)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Wind), Member = "Update")]
	[CalledBy(Type = typeof(Wind), Member = "Update")]
	[CalledBy(Type = typeof(Wind), Member = "MaybeChangePhase")]
	public void StartRandomPhase(bool forceCalm)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void StartPhase(WindDirection direction, WindStrength strength)
	{
	}

	[CalledBy(Type = typeof(Wind), Member = "ForceImmediateWindChangeBasedOnWeather")]
	[CalledBy(Type = typeof(Weather), Member = "WarmWeatherState")]
	[CalledBy(Type = typeof(Weather), Member = "WarmWeatherState")]
	[CalledBy(Type = typeof(Wind), Member = "StartPhaseImmediate")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "SetWind")]
	[CalledBy(Type = typeof(Wind), Member = "MaybeChangePhase")]
	[CalledBy(Type = typeof(Wind), Member = "MaybeChangePhase")]
	[CalledBy(Type = typeof(Weather), Member = "WarmWeather")]
	[CallsUnknownMethods(Count = 42)]
	[CalledBy(Type = typeof(Wind), Member = "ForceImmediateWindChangeBasedOnWeather")]
	[CalledBy(Type = typeof(Weather), Member = "WarmWeather")]
	[CalledBy(Type = typeof(Wind), Member = "StartPhaseImmediate")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomMode")]
	[CallerCount(Count = 11)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ActiveWindSettings), Member = ".ctor")]
	[Calls(Type = typeof(ActiveWindSettings), Member = ".ctor")]
	[Calls(Type = typeof(Wind), Member = "ResetNoise")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Wind), Member = "RefreshSettings")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(Wind), Member = "UpdateNoise")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "UpdateDecalProjectorLifeTimes")]
	public void StartPhase(WindStrength strength, float angle = -1f)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Wind), Member = "Deserialize")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "SetWind")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ToggleGameCameraForBrightness")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[Calls(Type = typeof(Weather), Member = "WarmBlowingSnow")]
	[Calls(Type = typeof(Wind), Member = "StartPhase")]
	[Calls(Type = typeof(Wind), Member = "DirectionToAngle")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(DebugViewModeManager), Member = "ToggleTexelDensity")]
	public void StartPhaseImmediate(WindDirection direction, WindStrength strength)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Wind), Member = "StartPhase")]
	[Calls(Type = typeof(Weather), Member = "WarmBlowingSnow")]
	[CallsUnknownMethods(Count = 2)]
	public void StartPhaseImmediate(WindStrength strength, float angle = -1f)
	{
	}

	[CalledBy(Type = typeof(Action_StopWindAudio), Member = "OnExecute")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CalledBy(Type = typeof(Wind), Member = "OnDestroy")]
	public void ForceStopAudioLoop()
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "SetWind")]
	[CalledBy(Type = typeof(Wind), Member = "StartPhaseImmediate")]
	[CallerCount(Count = 2)]
	public static float DirectionToAngle(WindDirection direction)
	{
		return default(float);
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
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetSpeedMPH_Base()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public float GetSpeedMPH()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public float GetTargetSpeedMPH()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetWindAngle_Base()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetWindAngle()
	{
		return default(float);
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

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(WeatherParticleManager), Member = "UpdateShaderGlobalsForFoliage")]
	[CalledBy(Type = typeof(WeatherParticleManager), Member = "UpdateShaderGlobalsForFoliage")]
	public float GetWindLift()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetBaseWindChill()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public float GetWindChill()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Wind), Member = "StartPhase")]
	[Calls(Type = typeof(Wind), Member = "StartPhase")]
	public void ForceImmediateWindChangeBasedOnWeather(WeatherStage ws)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(TorchItem), Member = "AttemptToLight")]
	[CalledBy(Type = typeof(MatchesItem), Member = "IgniteDelayed")]
	[CalledBy(Type = typeof(MatchesItem), Member = "UpdateWhileInHands")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	public bool TooWindyForPlayerAction(float thresholdSpeedMPH)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void AddWindKiller(WindKiller wk)
	{
	}

	[CallerCount(Count = 0)]
	public float GetPlayerWindAngle()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Wind), Member = "Update")]
	[Calls(Type = typeof(Wind), Member = "StartPhase")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(Wind), Member = "StartRandomPhase")]
	[Calls(Type = typeof(Weather), Member = "IsBlizzard")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Wind), Member = "StartPhase")]
	private void MaybeChangePhase()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Vector3), Member = "get_right")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Vector3), Member = "get_forward")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis")]
	[Calls(Type = typeof(Wind), Member = "SetWindAccelerationForAllInteractiveCloth")]
	[CalledBy(Type = typeof(Wind), Member = "Update")]
	[CalledBy(Type = typeof(Wind), Member = "Deserialize")]
	[CalledBy(Type = typeof(Wind), Member = "StartPhase")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(GameManager), Member = "GetDeltaTime")]
	[Calls(Type = typeof(GameManager), Member = "GetDeltaTime")]
	[Calls(Type = typeof(GameManager), Member = "GetDeltaTime")]
	[Calls(Type = typeof(Mathf), Member = "Repeat")]
	[Calls(Type = typeof(Utils), Member = "ExpStep")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Vector3), Member = "get_forward")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "ExpStep")]
	private void RefreshSettings()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Wind), Member = "Update")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	private void UpdateWindZone()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateUniStormParticleSystems()
	{
	}

	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInNonRuinedShelter")]
	[CalledBy(Type = typeof(Wind), Member = "Update")]
	[Calls(Type = typeof(Wind), Member = "CalculateWindChill")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Wind), Member = "CalculateWindChill")]
	private void UpdateWindChill()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsNight")]
	[Calls(Type = typeof(Weather), Member = "IsClear")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CalledBy(Type = typeof(Wind), Member = "UpdateWindChill")]
	[CalledBy(Type = typeof(Wind), Member = "UpdateWindChill")]
	[CallsUnknownMethods(Count = 10)]
	private float CalculateWindChill(float airTempCelsius)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Wind), Member = "UpdateProceduralWind")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Wind), Member = "SetWindAccelerationForAllInteractiveCloth")]
	private WindStrength GetStrengthFromSpeed(float normalizedSpeed, out WindSettings ws)
	{
		ws = null;
		return default(WindStrength);
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(InteractiveClothManager), Member = "SetAcceleration")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CalledBy(Type = typeof(Wind), Member = "RefreshSettings")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Wind), Member = "GetStrengthFromSpeed")]
	private void SetWindAccelerationForAllInteractiveCloth()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Wind), Member = "Update")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(Wind), Member = "GetWindAngleRelativeToPlayer")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Wind), Member = "GetStrengthFromSpeed")]
	[Calls(Type = typeof(GameAudioManager), Member = "HasFadedInOnStart")]
	[Calls(Type = typeof(Wind), Member = "PlayProceduralWindAudio")]
	[CallerCount(Count = 1)]
	private void UpdateProceduralWind()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(FirstPersonParticles), Member = "ComputeWindInEmitterSpace")]
	[CalledBy(Type = typeof(AnimatedUVs), Member = "LateUpdate")]
	[CalledBy(Type = typeof(Wind), Member = "UpdateProceduralWind")]
	[Calls(Type = typeof(Utils), Member = "GetAngleDegrees")]
	[CalledBy(Type = typeof(Weather), Member = "GetDebugWeatherText")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(GameManager), Member = "HasPlayerObject")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	public float GetWindAngleRelativeToPlayer()
	{
		return default(float);
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
	[CallsUnknownMethods(Count = 24)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	private uint PlayProceduralWindAudio()
	{
		return default(uint);
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public Wind()
	{
	}
}
