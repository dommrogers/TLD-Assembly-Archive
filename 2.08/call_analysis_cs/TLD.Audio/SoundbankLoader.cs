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

	[Calls(Type = typeof(SoundbankLoader), Member = "LoadSoundBanks")]
	[CallerCount(Count = 0)]
	public void Awake()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SoundbankLoader), Member = "MaybeUnloadOtherEpisodeBanks")]
	[Calls(Type = typeof(SoundbankLoader), Member = "MaybeLoadEpisodeBanks")]
	[Calls(Type = typeof(SoundbankLoader), Member = "MaybeLoadEpisodeBanks")]
	[CalledBy(Type = typeof(EpisodeManager), Member = "SetActiveEpisode")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "LoadEpisode")]
	[CallsUnknownMethods(Count = 6)]
	public void LoadEpisodeBanks(Episode episode)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(GameAudioManager), Member = "DebugLoadAllEpisodeBanks")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_play_timeline")]
	[Calls(Type = typeof(SoundbankLoader), Member = "MaybeLoadEpisodeBanks")]
	[CallerCount(Count = 2)]
	public void DebugLoadAllEpisodeBanks()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AkBankManager), Member = "UnloadBank")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "UnloadActiveEpisode")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadMainMenu")]
	[CallsUnknownMethods(Count = 4)]
	public void UnloadAllEpisodeBanks()
	{
	}

	[CalledBy(Type = typeof(SoundbankLoader), Member = "DebugLoadAllEpisodeBanks")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(SoundbankLoader), Member = "LoadEpisodeBanks")]
	[Calls(Type = typeof(Bank), Member = "Load")]
	[CalledBy(Type = typeof(SoundbankLoader), Member = "LoadEpisodeBanks")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	public void MaybeLoadEpisodeBanks(List<Bank> loadSoundBankList)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Bank), Member = "Unload")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(SoundbankLoader), Member = "LoadEpisodeBanks")]
	[CallsUnknownMethods(Count = 3)]
	private void MaybeUnloadOtherEpisodeBanks(List<Bank> loadSoundBankList)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(SoundbankLoader), Member = "TryLoadSoundbank")]
	[CalledBy(Type = typeof(SoundbankLoader), Member = "Awake")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void LoadSoundBanks(IEnumerable<Bank> list)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Bank), Member = "Load")]
	[CalledBy(Type = typeof(SoundbankLoader), Member = "LoadSoundBanks")]
	[CallsUnknownMethods(Count = 2)]
	private uint TryLoadSoundbank(Bank bank)
	{
		return default(uint);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public SoundbankLoader()
	{
	}
}
