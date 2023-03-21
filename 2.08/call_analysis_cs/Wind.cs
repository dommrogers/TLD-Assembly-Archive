using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wind : MonoBehaviour
{
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

	public float m_OcclusionTestRange;

	public float m_OcclusionTestFOV;

	public float m_OcclusionReduceWindchillPercent;

	public AudioOcclusionLevel m_OcclusionAudioLevel;

	private bool m_PlayerOccluded;

	private Vector3 m_LastTestPosition;

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Wind), Member = "ResetNoise")]
	[CalledBy(Type = typeof(Wind), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 2)]
	public void Start()
	{
	}

	[CalledBy(Type = typeof(Wind), Member = "Deserialize")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 12)]
	[CalledBy(Type = typeof(Wind), Member = "Start")]
	[CalledBy(Type = typeof(Wind), Member = "StartPhase")]
	[CallsUnknownMethods(Count = 12)]
	private void ResetNoise()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "GetDeltaTime")]
	[CalledBy(Type = typeof(Wind), Member = "Update")]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[CalledBy(Type = typeof(Wind), Member = "StartPhase")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Wind), Member = "Deserialize")]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[Calls(Type = typeof(GameManager), Member = "GetDeltaTime")]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "GetDeltaTime")]
	private void UpdateNoise()
	{
	}

	[Calls(Type = typeof(Wind), Member = "RefreshSettings")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Wind), Member = "UpdateProceduralWind")]
	[Calls(Type = typeof(Wind), Member = "UpdateWindZone")]
	[Calls(Type = typeof(Wind), Member = "UpdateWindChill")]
	[Calls(Type = typeof(Wind), Member = "UpdateWindOcclusion")]
	[Calls(Type = typeof(Wind), Member = "StartRandomPhase")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Wind), Member = "UpdateNoise")]
	[Calls(Type = typeof(GameManager), Member = "GetDeltaTime")]
	[Calls(Type = typeof(Wind), Member = "MaybeChangePhase")]
	[Calls(Type = typeof(Wind), Member = "StartRandomPhase")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(GameManager), Member = "IsFrameValidToUpdate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActiveWindSettings), Member = "SetBlended")]
	public void Update()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void OnDestroy()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ToggleGameCameraForBrightness")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ToggleGameCameraForBrightness")]
	[Calls(Type = typeof(Wind), Member = "StartPhaseImmediate")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Wind), Member = "RefreshSettings")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[Calls(Type = typeof(Wind), Member = "ResetNoise")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Wind), Member = "UpdateNoise")]
	[Calls(Type = typeof(Wind), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 4)]
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

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public void StartPhase(WindDirection direction, WindStrength strength)
	{
	}

	[CalledBy(Type = typeof(Weather), Member = "WarmWeatherState")]
	[CalledBy(Type = typeof(Weather), Member = "WarmWeatherState")]
	[CalledBy(Type = typeof(Wind), Member = "StartPhaseImmediate")]
	[CalledBy(Type = typeof(Wind), Member = "StartPhaseImmediate")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "SetWind")]
	[CalledBy(Type = typeof(Wind), Member = "ForceImmediateWindChangeBasedOnWeather")]
	[CalledBy(Type = typeof(Wind), Member = "MaybeChangePhase")]
	[CalledBy(Type = typeof(Wind), Member = "MaybeChangePhase")]
	[CalledBy(Type = typeof(Weather), Member = "WarmWeather")]
	[CalledBy(Type = typeof(Wind), Member = "ForceImmediateWindChangeBasedOnWeather")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Weather), Member = "WarmWeather")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Wind), Member = "RefreshSettings")]
	[Calls(Type = typeof(Wind), Member = "UpdateNoise")]
	[Calls(Type = typeof(Wind), Member = "ResetNoise")]
	[Calls(Type = typeof(ActiveWindSettings), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(ActiveWindSettings), Member = ".ctor")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "UpdateDecalProjectorLifeTimes")]
	public void StartPhase(WindStrength strength, float angle = -1f)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "SetWind")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ToggleGameCameraForBrightness")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(Wind), Member = "Deserialize")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Weather), Member = "WarmBlowingSnow")]
	[Calls(Type = typeof(Wind), Member = "StartPhase")]
	[Calls(Type = typeof(Wind), Member = "DirectionToAngle")]
	[CalledBy(Type = typeof(DebugViewModeManager), Member = "ToggleTexelDensity")]
	public void StartPhaseImmediate(WindDirection direction, WindStrength strength)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Weather), Member = "WarmBlowingSnow")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Wind), Member = "StartPhase")]
	public void StartPhaseImmediate(WindStrength strength, float angle = -1f)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	public void ForceStopAudioLoop()
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Wind), Member = "StartPhaseImmediate")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "SetWind")]
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
	[CallerCount(Count = 0)]
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

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
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

	[CallerCount(Count = 0)]
	public float GetWindLift()
	{
		return default(float);
	}

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

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(TorchItem), Member = "AttemptToLight")]
	[CalledBy(Type = typeof(MatchesItem), Member = "IgniteDelayed")]
	[CalledBy(Type = typeof(MatchesItem), Member = "UpdateWhileInHands")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallerCount(Count = 3)]
	public bool TooWindyForPlayerAction(float thresholdSpeedMPH)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void AddWindKiller(WindKiller wk)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetPlayerWindAngle()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(Wind), Member = "Update")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(Wind), Member = "StartPhase")]
	[Calls(Type = typeof(Wind), Member = "StartRandomPhase")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Wind), Member = "StartPhase")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	private void MaybeChangePhase()
	{
	}

	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Wind), Member = "StartPhase")]
	[CalledBy(Type = typeof(Wind), Member = "Deserialize")]
	[CalledBy(Type = typeof(Wind), Member = "Update")]
	[Calls(Type = typeof(Wind), Member = "SetWindAccelerationForAllInteractiveCloth")]
	[Calls(Type = typeof(Utils), Member = "ExpStep")]
	[Calls(Type = typeof(GameManager), Member = "GetDeltaTime")]
	[Calls(Type = typeof(Utils), Member = "ExpStep")]
	[Calls(Type = typeof(GameManager), Member = "GetDeltaTime")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "GetDeltaTime")]
	private void RefreshSettings()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(Wind), Member = "Update")]
	private void UpdateWindZone()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void UpdateUniStormParticleSystems()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Wind), Member = "CalculateWindChill")]
	[Calls(Type = typeof(Wind), Member = "CalculateWindChill")]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInNonRuinedShelter")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CalledBy(Type = typeof(Wind), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateWindChill()
	{
	}

	[Calls(Type = typeof(Weather), Member = "IsClear")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Wind), Member = "UpdateWindChill")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TimeOfDay), Member = "IsDay")]
	[CalledBy(Type = typeof(Wind), Member = "UpdateWindChill")]
	private float CalculateWindChill(float airTempCelsius)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(Wind), Member = "UpdateProceduralWind")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Wind), Member = "SetWindAccelerationForAllInteractiveCloth")]
	[CallsUnknownMethods(Count = 3)]
	private WindStrength GetStrengthFromSpeed(float normalizedSpeed, out WindSettings ws)
	{
		ws = null;
		return default(WindStrength);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Wind), Member = "RefreshSettings")]
	[Calls(Type = typeof(InteractiveClothManager), Member = "SetAcceleration")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Wind), Member = "GetStrengthFromSpeed")]
	private void SetWindAccelerationForAllInteractiveCloth()
	{
	}

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Wind), Member = "Update")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(Wind), Member = "GetWindAngleRelativeToPlayer")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Wind), Member = "GetStrengthFromSpeed")]
	[Calls(Type = typeof(GameAudioManager), Member = "HasFadedInOnStart")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Wind), Member = "PlayProceduralWindAudio")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	private void UpdateProceduralWind()
	{
	}

	[CalledBy(Type = typeof(Weather), Member = "GetDebugWeatherText")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(FirstPersonParticles), Member = "ComputeWindInEmitterSpace")]
	[CalledBy(Type = typeof(AnimatedUVs), Member = "LateUpdate")]
	[CalledBy(Type = typeof(Wind), Member = "UpdateProceduralWind")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(GameManager), Member = "HasPlayerObject")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "GetAngleDegrees")]
	public float GetWindAngleRelativeToPlayer()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void ApplySceneOverrides(SceneWeatherOverrideData swo)
	{
	}

	[CallerCount(Count = 0)]
	public void LockWindInstant(float mph)
	{
	}

	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CalledBy(Type = typeof(Wind), Member = "UpdateProceduralWind")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	private uint PlayProceduralWindAudio()
	{
		return default(uint);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool PlayerShelteredFromWind()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Campfire), Member = "TooWindyToStart")]
	[CalledBy(Type = typeof(TorchItem), Member = "ShouldBlowOut")]
	[CalledBy(Type = typeof(TorchItem), Member = "Update")]
	[CalledBy(Type = typeof(Fire), Member = "FireShouldBlowOutFromWind")]
	[CalledBy(Type = typeof(ParticleWindForce), Member = "Update")]
	[CalledBy(Type = typeof(OcclusionTest), Member = "CheckOcclusion")]
	[CalledBy(Type = typeof(Wind), Member = "UpdateWindOcclusion")]
	[CalledBy(Type = typeof(Wind), Member = "UpdateWindOcclusion")]
	[Calls(Type = typeof(Wind), Member = "ShouldIgnoreWindOccluder")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(Wind), Member = "ShouldIgnoreWindOccluder")]
	[Calls(Type = typeof(Wind), Member = "ShouldIgnoreWindOccluder")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(Wind), Member = "PointInsideWindKiller")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	public bool IsPositionOccludedFromWind(Vector3 pos)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Wind), Member = "IsPositionOccludedFromWind")]
	[CalledBy(Type = typeof(Wind), Member = "IsPositionOccludedFromWind")]
	[CalledBy(Type = typeof(Wind), Member = "IsPositionOccludedFromWind")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Contains")]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool ShouldIgnoreWindOccluder(Collider collider)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(LeanToManager), Member = "ExitLeanToAfterFadeOut")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(PlayerInVehicle), Member = "ExitVehicleAfterFadeOut")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "ExitShelterAfterFadeOut")]
	[CalledBy(Type = typeof(Wind), Member = "Update")]
	[Calls(Type = typeof(Wind), Member = "IsPositionOccludedFromWind")]
	[Calls(Type = typeof(Wind), Member = "IsPositionOccludedFromWind")]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInNonRuinedShelter")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "PanViewCameraIsDetached")]
	public void UpdateWindOcclusion()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Wind), Member = "IsPositionOccludedFromWind")]
	private bool PointInsideWindKiller(Vector3 pos)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public Wind()
	{
	}
}
