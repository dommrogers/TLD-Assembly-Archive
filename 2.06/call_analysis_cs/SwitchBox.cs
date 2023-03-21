using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using UnityEngine;

public class SwitchBox : MonoBehaviour
{
	public LocalizedString m_LocalizedDisplayName;

	public SwitchToggleState m_SwitchToggleState;

	public bool m_IsLocked;

	public float m_AuroraThreshold;

	public GameObject m_BoxBase;

	public GameObject m_PowerLever;

	public Light m_LightOn;

	public Light m_LightOff;

	public float m_TransitionTime;

	public float m_NeedleAngle;

	public string m_LoopAudio;

	public string m_TurnOffAudio;

	private float m_Timer;

	private Vector3 m_NeedleOn;

	private Vector3 m_NeedleOff;

	private Renderer m_SwitchBox;

	private uint m_LoopAudioID;

	private bool m_UpdateImmediate;

	private static SwitchBoxSaveDataProxy s_SwitchBoxSaveDataProxy;

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(SwitchBox), Member = "UpdateLights")]
	[Calls(Type = typeof(SwitchBox), Member = "UpdateHandle")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetState(SwitchToggleState state)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void SetLocked(bool isLocked)
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	private void Update()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[CalledBy(Type = typeof(SwitchBox), Member = "Awake")]
	[CallsUnknownMethods(Count = 7)]
	private void UpdateLights()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SwitchBox), Member = "Awake")]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private void UpdateHandle(float lerpTime)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 2)]
	public void PerformInteraction()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void TurnOn()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallsUnknownMethods(Count = 1)]
	private void TurnOff()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 1)]
	private void TurnAudioOn()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	private void TurnAudioOff()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 2)]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(SwitchBoxManager), Member = "DeserializeAll")]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	public SwitchBox()
	{
	}
}
