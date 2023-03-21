using System;
using System.Collections.Generic;
using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Audio;

public class SoundbankLoader : MonoBehaviour
{
	[Serializable]
	public struct EpisodeBankInfo
	{
		public Episode m_Episode;

		public List<Bank> m_Banks;
	}

	public List<Bank> m_CommonBanks;

	public List<EpisodeBankInfo> m_EpisodeBankInfo;

	public bool m_LoadAllEpisodeBanksTEMP;

	private bool m_BanksLoaded;

	private bool m_HasLoadedEpisode;

	private List<Bank> m_LoadedEpisodeBanks;

	private Episode m_LoadedEpisode;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SoundbankLoader), Member = "LoadSoundBanks")]
	public void Awake()
	{
	}

	[CalledBy(Type = typeof(EpisodeManager), Member = "SetActiveEpisode")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "LoadEpisode")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SoundbankLoader), Member = "MaybeUnloadOtherEpisodeBanks")]
	[Calls(Type = typeof(SoundbankLoader), Member = "MaybeLoadEpisodeBanks")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CallsUnknownMethods(Count = 19)]
	public void LoadEpisodeBanks(Episode episode)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_play_timeline")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "DebugLoadAllEpisodeBanks")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SoundbankLoader), Member = "MaybeLoadEpisodeBanks")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CallsUnknownMethods(Count = 8)]
	public void DebugLoadAllEpisodeBanks()
	{
	}

	[CalledBy(Type = typeof(GameAudioManager), Member = "UnloadActiveEpisode")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadMainMenu")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(AkBankManager), Member = "UnloadBank")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public void UnloadAllEpisodeBanks()
	{
	}

	[CalledBy(Type = typeof(SoundbankLoader), Member = "LoadEpisodeBanks")]
	[CalledBy(Type = typeof(SoundbankLoader), Member = "DebugLoadAllEpisodeBanks")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Bank), Member = "Load")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public void MaybeLoadEpisodeBanks(List<Bank> loadSoundBankList)
	{
	}

	[CalledBy(Type = typeof(SoundbankLoader), Member = "LoadEpisodeBanks")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Bank), Member = "Unload")]
	[Calls(Type = typeof(List<>), Member = "RemoveAt")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeUnloadOtherEpisodeBanks(List<Bank> loadSoundBankList)
	{
	}

	[CalledBy(Type = typeof(SoundbankLoader), Member = "Awake")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SoundbankLoader), Member = "TryLoadSoundbank")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private void LoadSoundBanks(IEnumerable<Bank> list)
	{
	}

	[CalledBy(Type = typeof(SoundbankLoader), Member = "LoadSoundBanks")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Bank), Member = "Load")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private uint TryLoadSoundbank(Bank bank)
	{
		return 0u;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 18)]
	public SoundbankLoader()
	{
	}
}
