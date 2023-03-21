using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.UI;

namespace Microsoft.Xbox;

public class Gdk : MonoBehaviour
{
	public delegate void OnGameSaveLoadedHandler(object sender, GameSaveLoadedArgs e);

	public delegate void OnErrorHandler(object sender, ErrorEventArgs e);

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<string, int> _003C_003E9__21_0;

		public static Func<char, bool> _003C_003E9__21_1;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal int _003CValidateGuid_003Eb__21_0(string str)
		{
			return default(int);
		}

		[Calls(Type = typeof(System.SpanHelpers), Member = "IndexOf")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CValidateGuid_003Eb__21_1(char c)
		{
			return default(bool);
		}
	}

	public string scid;

	public bool signInOnStart;

	public Text gamertagLabel;

	private static Gdk _xboxHelpers;

	private static bool _initialized;

	private static Dictionary<int, string> _hresultToFriendlyErrorLookup;

	private string _lastScid;

	private const int _100PercentAchievementProgress = 100;

	private const string _GameSaveContainerName = "x_game_save_default_container";

	private const string _GameSaveBlobName = "x_game_save_default_blob";

	private const int _MaxAssociatedProductsToRetrieve = 25;

	public static Gdk Helpers
	{
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(Gdk), Member = "Succeeded")]
		[CalledBy(Type = typeof(Gdk), Member = "Succeeded")]
		[CalledBy(Type = typeof(Gdk), Member = "Succeeded")]
		[CalledBy(Type = typeof(GameSaveSampleLogic), Member = "Load")]
		[CalledBy(Type = typeof(GameSaveSampleLogic), Member = "Load")]
		[CalledBy(Type = typeof(GameSaveSampleLogic), Member = "Load")]
		[CalledBy(Type = typeof(UnlockAchievementSampleLogic), Member = "UnlockAchievement")]
		[Calls(Type = typeof(Gdk), Member = "_Initialize")]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 8)]
		[CalledBy(Type = typeof(GameSaveSampleLogic), Member = "Save")]
		get
		{
			return null;
		}
	}

	public event OnGameSaveLoadedHandler OnGameSaveLoaded
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		remove
		{
		}
	}

	public event OnErrorHandler OnError
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Gdk), Member = "OnValidate")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	private bool ValidateGuid(string guid)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Gdk), Member = "ValidateGuid")]
	[CallsUnknownMethods(Count = 2)]
	private void OnValidate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Gdk), Member = "_Initialize")]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Gdk), Member = "Start")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CalledBy(Type = typeof(Gdk), Member = "get_Helpers")]
	private void _Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private void InitializeHresultToFriendlyErrorLookup()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void SignIn()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void Save(byte[] data)
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public void LoadSaveData()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void UnlockAchievement(string achievementId)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Gdk), Member = "get_Helpers")]
	[Calls(Type = typeof(Gdk), Member = "get_Helpers")]
	[Calls(Type = typeof(Gdk), Member = "get_Helpers")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	protected static bool Succeeded(int hresult, string operationFriendlyName)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public Gdk()
	{
	}
}
