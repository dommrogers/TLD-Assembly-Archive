using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class IceCrackingWarningTrigger : MonoBehaviour
{
	public LocalizedString m_LocalizedWarningMsg;

	public string m_IceCrackingAudio;

	public float m_FadeInTimeSeconds;

	public float m_FadeOutTimeSeconds;

	public bool m_SetLayerToTriggerIgnoreRaycast;

	[Calls(Type = typeof(vp_Layer), Member = "Set")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void Update()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsUnknownMethods(Count = 7)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "CompareTag")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Calls(Type = typeof(Component), Member = "CompareTag")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void OnTriggerExit(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	public IceCrackingWarningTrigger()
	{
	}
}
