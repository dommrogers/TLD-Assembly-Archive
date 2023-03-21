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
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 13)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
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
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void Reset()
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetObjectGuidFromGO")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 13)]
	public static string SerializeAll()
	{
		return null;
	}

	[CalledBy(Type = typeof(LightDistanceCull), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static ScriptLight GetScriptLight(Light l)
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public static void DeserializeAll(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptLight), Member = "GetFadeDistanceValue")]
	[Calls(Type = typeof(ScriptLight), Member = "UpdateLights")]
	private void Update_FadeOut()
	{
	}

	[CalledBy(Type = typeof(ScriptLight), Member = "LateUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	private void Update_TurnedOff()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void Update_TurnedOn()
	{
	}

	[CalledBy(Type = typeof(ScriptLight), Member = "LateUpdate")]
	[CalledBy(Type = typeof(ScriptLight), Member = "Update_FadeOut")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	private void UpdateLights(float fadeValue)
	{
	}

	[CalledBy(Type = typeof(ScriptLight), Member = "LateUpdate")]
	[CalledBy(Type = typeof(ScriptLight), Member = "Update_FadeOut")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	private float GetFadeDistanceValue()
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void StartTimelineFadeout()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsUnknownMethods(Count = 1)]
	private static ScriptLight FindActiveScriptLightById(string guid)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 8)]
	public ScriptLight()
	{
	}
}
