using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AkWwiseInitializationSettings : AkCommonPlatformSettings
{
	public abstract class PlatformSettings : AkCommonPlatformSettings
	{
		private List<string> IgnorePropertyNameList;

		private List<string> GlobalPropertyNameList;

		private HashSet<string> _GlobalPropertyHashSet;

		public HashSet<string> GlobalPropertyHashSet
		{
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallsUnknownMethods(Count = 7)]
			get
			{
				return null;
			}
			[DeduplicatedMethod]
			[CallerCount(Count = 20)]
			set
			{
			}
		}

		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 4)]
		[Calls(Type = typeof(PlatformSettings), Member = "SetUseGlobalPropertyValue")]
		[CalledBy(Type = typeof(AkPS4Settings), Member = ".ctor")]
		[CalledBy(Type = typeof(AkSwitchSettings), Member = ".ctor")]
		[CalledBy(Type = typeof(AkSwitchSettings), Member = ".ctor")]
		[CalledBy(Type = typeof(AkXBoxOneSettings), Member = ".ctor")]
		[CallsUnknownMethods(Count = 2)]
		public void IgnorePropertyValue(string propertyPath)
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		public bool IsPropertyIgnored(string propertyPath)
		{
			return default(bool);
		}

		[CallAnalysisFailed]
		[CallerCount(Count = 7)]
		[CalledBy(Type = typeof(CommonPlatformSettings), Member = ".ctor")]
		[CalledBy(Type = typeof(AkLinuxSettings), Member = ".ctor")]
		[CalledBy(Type = typeof(AkMacSettings), Member = ".ctor")]
		[CalledBy(Type = typeof(AkPS4Settings), Member = ".ctor")]
		[CalledBy(Type = typeof(AkSwitchSettings), Member = ".ctor")]
		[CalledBy(Type = typeof(AkWindowsSettings), Member = ".ctor")]
		[CalledBy(Type = typeof(AkXBoxOneSettings), Member = ".ctor")]
		protected PlatformSettings()
		{
		}

		[CalledBy(Type = typeof(AkSwitchSettings), Member = ".ctor")]
		[CalledBy(Type = typeof(AkXBoxOneSettings), Member = ".ctor")]
		[CalledBy(Type = typeof(AkXBoxOneSettings), Member = ".ctor")]
		[CalledBy(Type = typeof(AkXBoxOneSettings), Member = ".ctor")]
		[CalledBy(Type = typeof(AkSwitchSettings), Member = ".ctor")]
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(PlatformSettings), Member = "IgnorePropertyValue")]
		[Calls(Type = typeof(PlatformSettings), Member = "IsUsingGlobalPropertyValue")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallerCount(Count = 7)]
		[CalledBy(Type = typeof(AkPS4Settings), Member = ".ctor")]
		public void SetUseGlobalPropertyValue(string propertyPath, bool use)
		{
		}

		[Calls(Type = typeof(PlatformSettings), Member = "IsUsingGlobalPropertyValue")]
		[CallsUnknownMethods(Count = 9)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		public void SetGlobalPropertyValues(IEnumerable enumerable)
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(PlatformSettings), Member = "SetGlobalPropertyValues")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(PlatformSettings), Member = "SetUseGlobalPropertyValue")]
		private bool IsUsingGlobalPropertyValue(string propertyPath)
		{
			return default(bool);
		}
	}

	public class CommonPlatformSettings : PlatformSettings
	{
		public AkCommonUserSettings UserSettings;

		public AkCommonAdvancedSettings AdvancedSettings;

		public AkCommonCommSettings CommsSettings;

		[DeduplicatedMethod]
		[CallerCount(Count = 15)]
		protected override AkCommonUserSettings GetUserSettings()
		{
			return null;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		protected override AkCommonAdvancedSettings GetAdvancedSettings()
		{
			return null;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		protected override AkCommonCommSettings GetCommsSettings()
		{
			return null;
		}

		[Calls(Type = typeof(PlatformSettings), Member = ".ctor")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public CommonPlatformSettings()
		{
		}
	}

	public List<string> PlatformSettingsNameList;

	public List<PlatformSettings> PlatformSettingsList;

	public List<string> InvalidReferencePlatforms;

	public AkCommonUserSettings UserSettings;

	public AkCommonAdvancedSettings AdvancedSettings;

	public AkCommonCommSettings CommsSettings;

	private static readonly string[] AllGlobalValues;

	private static AkWwiseInitializationSettings m_Instance;

	private static AkBasePlatformSettings m_ActivePlatformSettings;

	public bool IsValid
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return default(bool);
		}
	}

	public int Count
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(int);
		}
	}

	public static AkWwiseInitializationSettings Instance
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(Debug), Member = "LogWarning")]
		[CalledBy(Type = typeof(AkWwiseInitializationSettings), Member = "GetPlatformSettings")]
		[CalledBy(Type = typeof(AkInitializer), Member = "OnEnable")]
		get
		{
			return null;
		}
	}

	public static AkBasePlatformSettings ActivePlatformSettings
	{
		[CalledBy(Type = typeof(AkWwiseInitializationSettings), Member = "InitializeSoundEngine")]
		[CalledBy(Type = typeof(AkWwiseInitializationSettings), Member = "ResetSoundEngine")]
		[CalledBy(Type = typeof(AkWwiseInitializationSettings), Member = "InitializeSoundEngine")]
		[CalledBy(Type = typeof(AkWwiseInitializationSettings), Member = "InitializeSoundEngine")]
		[CalledBy(Type = typeof(AkWwiseInitializationSettings), Member = "InitializeSoundEngine")]
		[CalledBy(Type = typeof(AkWwiseInitializationSettings), Member = "InitializeSoundEngine")]
		[CalledBy(Type = typeof(AkInitializer), Member = "OnApplicationFocus")]
		[CalledBy(Type = typeof(AkBasePathGetter), Member = "GetFullSoundBankPath")]
		[Calls(Type = typeof(AkWwiseInitializationSettings), Member = "GetPlatformSettings")]
		[Calls(Type = typeof(AkBasePathGetter), Member = "GetPlatformName")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 9)]
		[CalledBy(Type = typeof(AkBasePathGetter), Member = "GetPlatformBasePath")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	protected override AkCommonUserSettings GetUserSettings()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 8)]
	protected override AkCommonAdvancedSettings GetAdvancedSettings()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected override AkCommonCommSettings GetCommsSettings()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(AkWwiseInitializationSettings), Member = "get_ActivePlatformSettings")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "Compare")]
	[Calls(Type = typeof(AkWwiseInitializationSettings), Member = "get_Instance")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private static AkBasePlatformSettings GetPlatformSettings(string platformName)
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnEnable()
	{
	}

	[Calls(Type = typeof(AkSoundEngine), Member = "AddBasePath")]
	[CalledBy(Type = typeof(AkSoundEngineController), Member = "Init")]
	[Calls(Type = typeof(AkSoundEngine), Member = "Term")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(AkWwiseInitializationSettings), Member = "LoadInitBank")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(AkCallbackManager), Member = "Init")]
	[Calls(Type = typeof(AkWwiseInitializationSettings), Member = "get_ActivePlatformSettings")]
	[Calls(Type = typeof(AkSoundEngine), Member = "AddBasePath")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(AkWwiseInitializationSettings), Member = "get_ActivePlatformSettings")]
	[Calls(Type = typeof(AkSoundEngineController), Member = "GetDecodedBankFullPath")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetBasePath")]
	[Calls(Type = typeof(AkBasePathGetter), Member = "GetSoundbankBasePath")]
	[Calls(Type = typeof(AkCommunicationSettings), Member = "getCPtr")]
	[Calls(Type = typeof(AkWwiseInitializationSettings), Member = "get_ActivePlatformSettings")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(AkWwiseInitializationSettings), Member = "get_ActivePlatformSettings")]
	[Calls(Type = typeof(AkWwiseInitializationSettings), Member = "get_ActivePlatformSettings")]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Application), Member = "get_persistentDataPath")]
	public static bool InitializeSoundEngine()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AkCallbackManager), Member = "Init")]
	[Calls(Type = typeof(AkWwiseInitializationSettings), Member = "LoadInitBank")]
	[Calls(Type = typeof(AkWwiseInitializationSettings), Member = "get_ActivePlatformSettings")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEngine), Member = "ClearBanks")]
	public static bool ResetSoundEngine(bool isPlaying)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(AkWwiseInitializationSettings), Member = "ResetSoundEngine")]
	[CalledBy(Type = typeof(AkWwiseInitializationSettings), Member = "InitializeSoundEngine")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(AkBankManager), Member = "Reset")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AkSoundEngine), Member = "LoadBank")]
	private static void LoadInitBank()
	{
	}

	[CalledBy(Type = typeof(AkSoundEngineController), Member = "Terminate")]
	[CalledBy(Type = typeof(AkInitializer), Member = "OnApplicationQuit")]
	[Calls(Type = typeof(AkBankManager), Member = "Reset")]
	[Calls(Type = typeof(AkCallbackManager), Member = "Term")]
	[Calls(Type = typeof(AkCallbackManager), Member = "PostCallbacks")]
	[Calls(Type = typeof(AkSoundEngine), Member = "Term")]
	[Calls(Type = typeof(AkWwiseInitializationSettings), Member = "SleepForMilliseconds")]
	[Calls(Type = typeof(AkWwiseInitializationSettings), Member = "SleepForMilliseconds")]
	[Calls(Type = typeof(AkSoundEngine), Member = "RenderAudio")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkCallbackManager), Member = "PostCallbacks")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopAll")]
	[Calls(Type = typeof(AkSoundEngine), Member = "ClearBanks")]
	[Calls(Type = typeof(AkSoundEngine), Member = "IsInitialized")]
	public static void TerminateSoundEngine()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(EventWaitHandle), Member = ".ctor")]
	[Calls(Type = typeof(TimeSpan), Member = "FromMilliseconds")]
	[CalledBy(Type = typeof(AkWwiseInitializationSettings), Member = "TerminateSoundEngine")]
	[CalledBy(Type = typeof(AkWwiseInitializationSettings), Member = "TerminateSoundEngine")]
	[CallsUnknownMethods(Count = 10)]
	private static void SleepForMilliseconds(double milliseconds)
	{
	}

	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	public AkWwiseInitializationSettings()
	{
	}
}
