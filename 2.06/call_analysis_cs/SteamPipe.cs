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
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 2)]
		add
		{
		}
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		remove
		{
		}
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 11)]
	public string GetGuid()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(SteamPipeEffect), Member = "SetSource")]
	[Calls(Type = typeof(SteamPipe), Member = "ThawPipes")]
	[CallsUnknownMethods(Count = 3)]
	private void Start()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void OnDestroy()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(SteamPipe), Member = "UpdateSteamPipeValues")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(SteamPipe), Member = "UpdateSteamPipeValues")]
	[CalledBy(Type = typeof(SteamPipe), Member = "Update")]
	[CallsUnknownMethods(Count = 12)]
	private void UpdateSteamPipeValues()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	public void InteractValve(float percent = 100f)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(SteamPipeManager), Member = "SerializeAll")]
	[CallsUnknownMethods(Count = 6)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(SteamPipeManager), Member = "DeserializeAll")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SteamPipe), Member = "ThawPipes")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	private void MaybePlayOpenCloseAudio()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	private void MaybePlaySteamFlowAudio()
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	private void MaybeShowFrozenPipe(bool immediate)
	{
	}

	[CalledBy(Type = typeof(SteamPipe), Member = "LateUpdate")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(SteamPipeEffect), Member = "Thaw")]
	[CalledBy(Type = typeof(SteamPipe), Member = "Start")]
	[CalledBy(Type = typeof(SteamPipe), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 2)]
	private void ThawPipes(bool immediate)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SteamPipe), Member = "UpdateSteamPipeValues")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(SteamPipe), Member = "ThawPipes")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	public SteamPipe()
	{
	}
}
