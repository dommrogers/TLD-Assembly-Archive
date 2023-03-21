using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Timeline;

public class ScriptLight : MonoBehaviour, ITimeControl
{
	public enum ScriptLightState
	{
		Off,
		TurnedOn,
		FadingOut
	}

	private struct LightInfo
	{
		public Light m_Light;

		public float m_StartIntensity;
	}

	public class ScriptLightSaveData
	{
		public ScriptLightState m_State;

		public string m_GUID;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public ScriptLightSaveData()
		{
		}
	}

	public float m_TimelineFadeoutDurationSeconds;

	public bool m_TurnOnOnStart;

	public bool m_FadeoutWithDistance;

	public float m_FadeOutStartDistance;

	public float m_FadeOutEndDistance;

	public List<Light> m_Lights;

	public GameObject m_FadeOutReference;

	private float m_TimerFadeOutDuration;

	private bool m_FadeOutStartTimeRequested;

	private float m_FadeOutStartTime;

	private float m_TimelineFadeValue;

	private float m_DistanceFadeValue;

	private bool m_IsControlledByTimeline;

	private List<LightInfo> m_LightInfos;

	private bool m_IsTimerControlled;

	private float m_TimerControlledValue;

	private float m_TimeElapsed;

	private ScriptLightState m_State;

	private string m_GUID;

	private static List<ScriptLight> s_ActiveScriptLights;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Utils), Member = "GetGuidFromGameObject")]
	[CallsUnknownMethods(Count = 15)]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	public void TurnOn()
	{
	}

	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void SetTime(double time)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void OnControlTimeStart()
	{
	}

	[CallerCount(Count = 0)]
	public void OnControlTimeStop()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	public void Update()
	{
	}

	[Calls(Type = typeof(ScriptLight), Member = "Update_TurnedOff")]
	[Calls(Type = typeof(ScriptLight), Member = "UpdateLights")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(ScriptLight), Member = "GetFadeDistanceValue")]
	[Calls(Type = typeof(ScriptLight), Member = "GetFadeDistanceValue")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptLight), Member = "UpdateLights")]
	public void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	public void StartTimerFadeOut(float fadeoutDuration)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsTurnedOff()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void Reset()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 21)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Utils), Member = "GetGuidFromGameObject")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	public static string SerializeAll()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(LightDistanceCull), Member = "Start")]
	[CallsUnknownMethods(Count = 4)]
	public static ScriptLight GetScriptLight(Light l)
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(ScriptLight), Member = "FindActiveScriptLightById")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public static void DeserializeAll(string text)
	{
	}

	[Calls(Type = typeof(ScriptLight), Member = "UpdateLights")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ScriptLight), Member = "GetFadeDistanceValue")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	private void Update_FadeOut()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[CalledBy(Type = typeof(ScriptLight), Member = "LateUpdate")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void Update_TurnedOff()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void Update_TurnedOn()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(ScriptLight), Member = "LateUpdate")]
	[CalledBy(Type = typeof(ScriptLight), Member = "LateUpdate")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[CalledBy(Type = typeof(ScriptLight), Member = "Update_FadeOut")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	private void UpdateLights(float fadeValue)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(ScriptLight), Member = "Update_FadeOut")]
	[CalledBy(Type = typeof(ScriptLight), Member = "LateUpdate")]
	[CalledBy(Type = typeof(ScriptLight), Member = "LateUpdate")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	private float GetFadeDistanceValue()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void StartTimelineFadeout()
	{
	}

	[CalledBy(Type = typeof(ScriptLight), Member = "DeserializeAll")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ObjectGuidManager), Member = "Lookup")]
	private static ScriptLight FindActiveScriptLightById(string guid)
	{
		return null;
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 12)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public ScriptLight()
	{
	}
}
