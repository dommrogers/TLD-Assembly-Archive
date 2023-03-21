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
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetGuidFromGameObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 5)]
	public string GetGuid()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(SteamPipeEffect), Member = "SetSource")]
	[Calls(Type = typeof(SteamPipe), Member = "ThawPipes")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(SteamPipe), Member = "UpdateSteamPipeValues")]
	[CalledBy(Type = typeof(SteamPipe), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(SteamPipe), Member = "UpdateSteamPipeValues")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private void UpdateSteamPipeValues()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "Approximately")]
	[Calls(Type = typeof(SteamPipe), Member = "MaybePlayOpenCloseAudio")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void InteractValve(float percent = 100f)
	{
	}

	[CalledBy(Type = typeof(SteamPipeManager), Member = "SerializeAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(SteamPipeManager), Member = "DeserializeAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(SteamPipe), Member = "ThawPipes")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(SteamPipe), Member = "InteractValve")]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "SetPipeOpenState")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void MaybePlayOpenCloseAudio()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void MaybePlaySteamFlowAudio()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void MaybeShowFrozenPipe(bool immediate)
	{
	}

	[CalledBy(Type = typeof(SteamPipe), Member = "Start")]
	[CalledBy(Type = typeof(SteamPipe), Member = "Deserialize")]
	[CalledBy(Type = typeof(SteamPipe), Member = "LateUpdate")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(SteamPipeEffect), Member = "Thaw")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private void ThawPipes(bool immediate)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SteamPipe), Member = "UpdateSteamPipeValues")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamPipe), Member = "ThawPipes")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public SteamPipe()
	{
	}
}
