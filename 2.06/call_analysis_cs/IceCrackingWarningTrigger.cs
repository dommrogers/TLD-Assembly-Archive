using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class IceCrackingWarningTrigger : MonoBehaviour
{
	public LocalizedString m_LocalizedWarningMsg;

	public string m_IceCrackingAudio;

	public float m_FadeInTimeSeconds;

	public float m_FadeOutTimeSeconds;

	public bool m_SetLayerToTriggerIgnoreRaycast;

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(vp_Layer), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Component), Member = "CompareTag")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 7)]
	private void OnTriggerEnter(Collider other)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Component), Member = "CompareTag")]
	[CallerCount(Count = 0)]
	private void OnTriggerExit(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	public IceCrackingWarningTrigger()
	{
	}
}
