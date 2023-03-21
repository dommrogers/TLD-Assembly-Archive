using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.PDID;
using TLD.Serialization;
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
		[CallerCount(Count = 6)]
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
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[CallsUnknownMethods(Count = 11)]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	public void TurnOn()
	{
	}

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

	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallerCount(Count = 0)]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptLight), Member = "GetFadeDistanceValue")]
	[Calls(Type = typeof(ScriptLight), Member = "UpdateLights")]
	[Calls(Type = typeof(ScriptLight), Member = "GetFadeDistanceValue")]
	[Calls(Type = typeof(ScriptLight), Member = "UpdateLights")]
	[Calls(Type = typeof(ScriptLight), Member = "Update_TurnedOff")]
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

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public static void Reset()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallsUnknownMethods(Count = 4)]
	public static string SerializeAll()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(LightDistanceCull), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public static ScriptLight GetScriptLight(Light l)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallsUnknownMethods(Count = 2)]
	public static void DeserializeAll(string text)
	{
	}

	[Calls(Type = typeof(ScriptLight), Member = "GetFadeDistanceValue")]
	[Calls(Type = typeof(ScriptLight), Member = "UpdateLights")]
	[CallerCount(Count = 0)]
	private void Update_FadeOut()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(ScriptLight), Member = "LateUpdate")]
	[CallsUnknownMethods(Count = 4)]
	private void Update_TurnedOff()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void Update_TurnedOn()
	{
	}

	[CalledBy(Type = typeof(ScriptLight), Member = "LateUpdate")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(ScriptLight), Member = "LateUpdate")]
	[CalledBy(Type = typeof(ScriptLight), Member = "Update_FadeOut")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[CallerCount(Count = 3)]
	private void UpdateLights(float fadeValue)
	{
	}

	[CalledBy(Type = typeof(ScriptLight), Member = "Update_FadeOut")]
	[CalledBy(Type = typeof(ScriptLight), Member = "LateUpdate")]
	[CalledBy(Type = typeof(ScriptLight), Member = "LateUpdate")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private float GetFadeDistanceValue()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void StartTimelineFadeout()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private static ScriptLight FindActiveScriptLightById(string guid)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public ScriptLight()
	{
	}
}
