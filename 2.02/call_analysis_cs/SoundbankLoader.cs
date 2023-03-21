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
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 18)]
	public void LoadEpisodeBanks(Episode episode)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_play_timeline")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "DebugLoadAllEpisodeBanks")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SoundbankLoader), Member = "MaybeLoadEpisodeBanks")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public void DebugLoadAllEpisodeBanks()
	{
	}

	[CalledBy(Type = typeof(GameAudioManager), Member = "UnloadActiveEpisode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(SoundbankLoader), Member = "TryUnloadSoundbank")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public void UnloadAllEpisodeBanks()
	{
	}

	[CalledBy(Type = typeof(SoundbankLoader), Member = "LoadEpisodeBanks")]
	[CalledBy(Type = typeof(SoundbankLoader), Member = "DebugLoadAllEpisodeBanks")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(SoundbankLoader), Member = "TryLoadSoundbankByName")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public void MaybeLoadEpisodeBanks(List<string> loadSoundBankList)
	{
	}

	[CalledBy(Type = typeof(SoundbankLoader), Member = "LoadEpisodeBanks")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[Calls(Type = typeof(SoundbankLoader), Member = "TryUnloadSoundbank")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 20)]
	private void MaybeUnloadOtherEpisodeBanks(List<string> loadSoundBankList)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SoundbankLoader), Member = "TryUnloadSoundbank")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private void UnloadEpisodeBank(string bankName)
	{
	}

	[CalledBy(Type = typeof(SoundbankLoader), Member = "Awake")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SoundbankLoader), Member = "TryLoadSoundbankByName")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private void LoadSoundBanks(IEnumerable<string> list)
	{
	}

	[CalledBy(Type = typeof(SoundbankLoader), Member = "MaybeLoadEpisodeBanks")]
	[CalledBy(Type = typeof(SoundbankLoader), Member = "LoadSoundBanks")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	[Calls(Type = typeof(AkSoundEngine), Member = "LoadBank")]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private uint TryLoadSoundbankByName(string bankName)
	{
		return 0u;
	}

	[CalledBy(Type = typeof(SoundbankLoader), Member = "UnloadAllEpisodeBanks")]
	[CalledBy(Type = typeof(SoundbankLoader), Member = "MaybeUnloadOtherEpisodeBanks")]
	[CalledBy(Type = typeof(SoundbankLoader), Member = "UnloadEpisodeBank")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AkSoundEngine), Member = "UnloadBank")]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void TryUnloadSoundbank(uint bankID)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 27)]
	public SoundbankLoader()
	{
	}
}
