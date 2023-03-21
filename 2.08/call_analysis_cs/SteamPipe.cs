using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
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
		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 3)]
		remove
		{
		}
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	public void Awake()
	{
	}

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public string GetGuid()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(SteamPipeEffect), Member = "SetSource")]
	[Calls(Type = typeof(SteamPipe), Member = "ThawPipes")]
	[CallsUnknownMethods(Count = 3)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnDestroy()
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(SteamPipe), Member = "Update")]
	[Calls(Type = typeof(SteamPipe), Member = "UpdateSteamPipeValues")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(SteamPipe), Member = "UpdateSteamPipeValues")]
	private void UpdateSteamPipeValues()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	public void InteractValve(float percent = 100f)
	{
	}

	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SteamPipe), Member = "ThawPipes")]
	[CalledBy(Type = typeof(SteamPipeManager), Member = "DeserializeAll")]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void MaybePlayOpenCloseAudio()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	private void MaybePlaySteamFlowAudio()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void MaybeShowFrozenPipe(bool immediate)
	{
	}

	[CalledBy(Type = typeof(SteamPipe), Member = "Start")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SteamPipe), Member = "LateUpdate")]
	[CalledBy(Type = typeof(SteamPipe), Member = "Deserialize")]
	[Calls(Type = typeof(SteamPipeEffect), Member = "Thaw")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	private void ThawPipes(bool immediate)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SteamPipe), Member = "UpdateSteamPipeValues")]
	[CallsUnknownMethods(Count = 1)]
	private void Update()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(SteamPipe), Member = "ThawPipes")]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	public SteamPipe()
	{
	}
}
