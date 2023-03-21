using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SteamPipe : MonoBehaviour
{
	public float m_SourceFlowValue;

	public float m_ValveOpenPercent;

	public List<SteamPipeSocket> m_Inputs;

	public List<SteamPipe> m_Outputs;

	public List<SteamPipe> m_BleedPipes;

	public List<SteamPipeSocket> m_BleedPipeSockets;

	public float m_UnfrozenFlowValue;

	public GameObject m_FrozenPipe;

	public GameObject m_UnfrozenPipe;

	public SteamPipeEffect[] m_VisualEffectPipes;

	public float m_SteamFlowValueAudio;

	public string m_SteamFlowAudio;

	public string m_SteamFlowOpeningAudio;

	public string m_SteamFlowClosingAudio;

	[NonSerialized]
	public float m_OutputFlowValue;

	[NonSerialized]
	public float m_InternalFlowValue;

	public static bool s_Debug;

	public static string s_DebugSteamPipeByName;

	private SteamPipe m_StartPipe;

	private bool m_MaybeFrozen;

	private uint m_SteamFlowAudioId;

	private uint m_SteamFlowOpeningAudioId;

	private uint m_SteamFlowClosingAudioId;

	private string m_Guid;

	private float m_LastInternalFlowValue;

	private int m_FlowChangeUpdateCounter;

	private int m_FlowSettleFrameCounter;

	public event Action<float> InternalFlowValueChanged
	{
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[CallsDeduplicatedMethods(Count = 1)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	[Calls(Type = typeof(Utils), Member = "GetGuidFromGameObject")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public string GetGuid()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(SteamPipe), Member = "ThawPipes")]
	[Calls(Type = typeof(SteamPipeEffect), Member = "SetSource")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public void OnDestroy()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(SteamPipe), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(SteamPipe), Member = "UpdateSteamPipeValues")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SteamPipe), Member = "UpdateSteamPipeValues")]
	private void UpdateSteamPipeValues()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "Approximately")]
	[Calls(Type = typeof(SteamPipe), Member = "MaybePlayOpenCloseAudio")]
	public void InteractValve(float percent = 100f)
	{
	}

	[CalledBy(Type = typeof(SteamPipeManager), Member = "SerializeAll")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 8)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(SteamPipeManager), Member = "DeserializeAll")]
	[Calls(Type = typeof(SteamPipe), Member = "ThawPipes")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CalledBy(Type = typeof(SteamPipe), Member = "InteractValve")]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "SetPipeOpenState")]
	[CallsUnknownMethods(Count = 4)]
	private void MaybePlayOpenCloseAudio()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	private void MaybePlaySteamFlowAudio()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void MaybeShowFrozenPipe(bool immediate)
	{
	}

	[Calls(Type = typeof(SteamPipeEffect), Member = "Thaw")]
	[CalledBy(Type = typeof(SteamPipe), Member = "LateUpdate")]
	[CalledBy(Type = typeof(SteamPipe), Member = "Deserialize")]
	[CalledBy(Type = typeof(SteamPipe), Member = "Start")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	private void ThawPipes(bool immediate)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SteamPipe), Member = "UpdateSteamPipeValues")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(SteamPipe), Member = "ThawPipes")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsUnknownMethods(Count = 2)]
	private void LateUpdate()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public SteamPipe()
	{
	}
}
