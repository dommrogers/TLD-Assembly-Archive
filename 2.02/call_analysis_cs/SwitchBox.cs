using Cpp2ILInjected.CallAnalysis;
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

	public string m_DisplayName
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LocalizedString), Member = "Text")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(SwitchBox), Member = "UpdateLights")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(SwitchBox), Member = "UpdateHandle")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
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

	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(SwitchBox), Member = "UpdateLights")]
	[Calls(Type = typeof(SwitchBox), Member = "UpdateHandle")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	private void Update()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[CalledBy(Type = typeof(SwitchBox), Member = "Awake")]
	[CalledBy(Type = typeof(SwitchBox), Member = "Update")]
	[CallsUnknownMethods(Count = 22)]
	private void UpdateLights()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(SwitchBox), Member = "Update")]
	[CalledBy(Type = typeof(SwitchBox), Member = "Awake")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles")]
	private void UpdateHandle(float lerpTime)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[CallsUnknownMethods(Count = 4)]
	public bool ProcessInteraction()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void TurnOn()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsUnknownMethods(Count = 3)]
	private void TurnOff()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[CallsUnknownMethods(Count = 1)]
	public string GetHoverText()
	{
		return null;
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void TurnAudioOn()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsUnknownMethods(Count = 3)]
	private void TurnAudioOff()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(SwitchBoxManager), Member = "SerializeAll")]
	[CallsUnknownMethods(Count = 4)]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SwitchBoxManager), Member = "DeserializeAll")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public SwitchBox()
	{
	}
}
