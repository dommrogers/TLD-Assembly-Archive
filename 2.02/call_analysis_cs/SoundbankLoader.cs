using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SoundbankLoader : MonoBehaviour
{
	[Serializable]
	public struct EpisodeBankInfo
	{
		public Episode m_Episode;

		public List<string> m_SoundBanks;
	}

	public List<string> m_CommonSoundBanks;

	public List<EpisodeBankInfo> m_EpisodeBankInfo;

	public bool m_LoadAllEpisodeBanksTEMP;

	private const string SOUNDBANK_EXTENTION = ".bnk";

	private bool m_BanksLoaded;

	private bool m_HasLoadedEpisode;

	private Dictionary<string, uint> m_LoadedEpisodeByBankName;

	private Episode m_LoadedEpisode;

	[Calls(Type = typeof(SoundbankLoader), Member = "LoadSoundBanks")]
	[CallerCount(Count = 0)]
	public void Awake()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SoundbankLoader), Member = "MaybeUnloadOtherEpisodeBanks")]
	[Calls(Type = typeof(SoundbankLoader), Member = "MaybeLoadEpisodeBanks")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[CalledBy(Type = typeof(EpisodeManager), Member = "SetActiveEpisode")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "LoadEpisode")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(SoundbankLoader), Member = "MaybeLoadEpisodeBanks")]
	[CallerCount(Count = 2)]
	public void LoadEpisodeBanks(Episode episode)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(GameAudioManager), Member = "DebugLoadAllEpisodeBanks")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_play_timeline")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SoundbankLoader), Member = "MaybeLoadEpisodeBanks")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	public void DebugLoadAllEpisodeBanks()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(GameAudioManager), Member = "UnloadActiveEpisode")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(SoundbankLoader), Member = "TryUnloadSoundbank")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void UnloadAllEpisodeBanks()
	{
	}

	[Calls(Type = typeof(SoundbankLoader), Member = "TryLoadSoundbankByName")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(SoundbankLoader), Member = "DebugLoadAllEpisodeBanks")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(SoundbankLoader), Member = "LoadEpisodeBanks")]
	[CalledBy(Type = typeof(SoundbankLoader), Member = "LoadEpisodeBanks")]
	public void MaybeLoadEpisodeBanks(List<string> loadSoundBankList)
	{
	}

	[CalledBy(Type = typeof(SoundbankLoader), Member = "LoadEpisodeBanks")]
	[Calls(Type = typeof(SoundbankLoader), Member = "TryUnloadSoundbank")]
	[CallsUnknownMethods(Count = 20)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	private void MaybeUnloadOtherEpisodeBanks(List<string> loadSoundBankList)
	{
	}

	[Calls(Type = typeof(SoundbankLoader), Member = "TryUnloadSoundbank")]
	[CallsUnknownMethods(Count = 5)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	private void UnloadEpisodeBank(string bankName)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(SoundbankLoader), Member = "Awake")]
	[Calls(Type = typeof(SoundbankLoader), Member = "TryLoadSoundbankByName")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	private void LoadSoundBanks(IEnumerable<string> list)
	{
	}

	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(SoundbankLoader), Member = "MaybeLoadEpisodeBanks")]
	[CalledBy(Type = typeof(SoundbankLoader), Member = "LoadSoundBanks")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	[Calls(Type = typeof(AkSoundEngine), Member = "LoadBank")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	private uint TryLoadSoundbankByName(string bankName)
	{
		return default(uint);
	}

	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(AkSoundEngine), Member = "UnloadBank")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(SoundbankLoader), Member = "UnloadAllEpisodeBanks")]
	[CalledBy(Type = typeof(SoundbankLoader), Member = "MaybeUnloadOtherEpisodeBanks")]
	[CalledBy(Type = typeof(SoundbankLoader), Member = "UnloadEpisodeBank")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Concat")]
	private void TryUnloadSoundbank(uint bankID)
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 27)]
	[CallerCount(Count = 0)]
	public SoundbankLoader()
	{
	}
}
