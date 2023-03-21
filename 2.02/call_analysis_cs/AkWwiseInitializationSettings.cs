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
			[Calls(Type = typeof(HashSet<>), Member = ".ctor")]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 7)]
			get
			{
				return null;
			}
			[DeduplicatedMethod]
			[CallerCount(Count = 24)]
			set
			{
			}
		}

		[CalledBy(Type = typeof(AkPS4Settings), Member = ".ctor")]
		[CalledBy(Type = typeof(AkSwitchSettings), Member = ".ctor")]
		[CalledBy(Type = typeof(AkXBoxOneSettings), Member = ".ctor")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(List<>), Member = "Contains")]
		[Calls(Type = typeof(List<>), Member = "Add")]
		[Calls(Type = typeof(PlatformSettings), Member = "SetUseGlobalPropertyValue")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		public void IgnorePropertyValue(string propertyPath)
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(List<>), Member = "Contains")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public bool IsPropertyIgnored(string propertyPath)
		{
			return false;
		}

		[CallAnalysisFailed]
		[CalledBy(Type = typeof(CommonPlatformSettings), Member = ".ctor")]
		[CalledBy(Type = typeof(AkLinuxSettings), Member = ".ctor")]
		[CalledBy(Type = typeof(AkMacSettings), Member = ".ctor")]
		[CalledBy(Type = typeof(AkPS4Settings), Member = ".ctor")]
		[CalledBy(Type = typeof(AkSwitchSettings), Member = ".ctor")]
		[CalledBy(Type = typeof(AkWindowsSettings), Member = ".ctor")]
		[CalledBy(Type = typeof(AkXBoxOneSettings), Member = ".ctor")]
		[CallerCount(Count = 7)]
		protected PlatformSettings()
		{
		}

		[CalledBy(Type = typeof(PlatformSettings), Member = "IgnorePropertyValue")]
		[CalledBy(Type = typeof(AkPS4Settings), Member = ".ctor")]
		[CalledBy(Type = typeof(AkSwitchSettings), Member = ".ctor")]
		[CalledBy(Type = typeof(AkXBoxOneSettings), Member = ".ctor")]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(PlatformSettings), Member = "IsUsingGlobalPropertyValue")]
		[Calls(Type = typeof(List<>), Member = "Remove")]
		[Calls(Type = typeof(List<>), Member = "Add")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public void SetUseGlobalPropertyValue(string propertyPath, bool use)
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(PlatformSettings), Member = "IsUsingGlobalPropertyValue")]
		[Calls(Type = typeof(List<>), Member = "Add")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 9)]
		public void SetGlobalPropertyValues(IEnumerable enumerable)
		{
		}

		[CalledBy(Type = typeof(PlatformSettings), Member = "SetUseGlobalPropertyValue")]
		[CalledBy(Type = typeof(PlatformSettings), Member = "SetGlobalPropertyValues")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(List<>), Member = "Contains")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private bool IsUsingGlobalPropertyValue(string propertyPath)
		{
			return false;
		}
	}

	public class CommonPlatformSettings : PlatformSettings
	{
		public AkCommonUserSettings UserSettings;

		public AkCommonAdvancedSettings AdvancedSettings;

		public AkCommonCommSettings CommsSettings;

		[DeduplicatedMethod]
		[CallerCount(Count = 17)]
		protected override AkCommonUserSettings GetUserSettings()
		{
			return null;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 9)]
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

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(PlatformSettings), Member = ".ctor")]
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
			return false;
		}
	}

	public int Count
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0;
		}
	}

	public static AkWwiseInitializationSettings Instance
	{
		[CalledBy(Type = typeof(AkWwiseInitializationSettings), Member = "GetPlatformSettings")]
		[CalledBy(Type = typeof(AkInitializer), Member = "OnEnable")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(ScriptableObject), Member = "CreateInstance")]
		[Calls(Type = typeof(Debug), Member = "LogWarning")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public static AkBasePlatformSettings ActivePlatformSettings
	{
		[CalledBy(Type = typeof(AkBasePathGetter), Member = "GetPlatformBasePath")]
		[CalledBy(Type = typeof(AkBasePathGetter), Member = "GetFullSoundBankPath")]
		[CalledBy(Type = typeof(AkWwiseInitializationSettings), Member = "InitializeSoundEngine")]
		[CalledBy(Type = typeof(AkWwiseInitializationSettings), Member = "ResetSoundEngine")]
		[CalledBy(Type = typeof(AkInitializer), Member = "OnApplicationFocus")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(AkBasePathGetter), Member = "GetPlatformName")]
		[Calls(Type = typeof(AkWwiseInitializationSettings), Member = "GetPlatformSettings")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 17)]
	protected override AkCommonUserSettings GetUserSettings()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 9)]
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

	[CalledBy(Type = typeof(AkWwiseInitializationSettings), Member = "get_ActivePlatformSettings")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AkWwiseInitializationSettings), Member = "get_Instance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "Compare")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private static AkBasePlatformSettings GetPlatformSettings(string platformName)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnEnable()
	{
	}

	[CalledBy(Type = typeof(AkSoundEngineController), Member = "Init")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AkWwiseInitializationSettings), Member = "get_ActivePlatformSettings")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(AkCommunicationSettings), Member = "getCPtr")]
	[Calls(Type = typeof(AkBasePathGetter), Member = "GetSoundbankBasePath")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetBasePath")]
	[Calls(Type = typeof(AkSoundEngineController), Member = "GetDecodedBankFullPath")]
	[Calls(Type = typeof(Application), Member = "get_persistentDataPath")]
	[Calls(Type = typeof(char), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(AkSoundEngine), Member = "AddBasePath")]
	[Calls(Type = typeof(AkCallbackManager), Member = "Init")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(AkWwiseInitializationSettings), Member = "LoadInitBank")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(AkSoundEngine), Member = "Term")]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallsUnknownMethods(Count = 10)]
	public static bool InitializeSoundEngine()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEngine), Member = "ClearBanks")]
	[Calls(Type = typeof(AkWwiseInitializationSettings), Member = "LoadInitBank")]
	[Calls(Type = typeof(AkWwiseInitializationSettings), Member = "get_ActivePlatformSettings")]
	[Calls(Type = typeof(AkCallbackManager), Member = "Init")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static bool ResetSoundEngine(bool isPlaying)
	{
		return false;
	}

	[CalledBy(Type = typeof(AkWwiseInitializationSettings), Member = "InitializeSoundEngine")]
	[CalledBy(Type = typeof(AkWwiseInitializationSettings), Member = "ResetSoundEngine")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AkBankManager), Member = "Reset")]
	[Calls(Type = typeof(AkSoundEngine), Member = "LoadBank")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	private static void LoadInitBank()
	{
	}

	[CalledBy(Type = typeof(AkInitializer), Member = "OnApplicationQuit")]
	[CalledBy(Type = typeof(AkSoundEngineController), Member = "Terminate")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AkSoundEngine), Member = "IsInitialized")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopAll")]
	[Calls(Type = typeof(AkSoundEngine), Member = "ClearBanks")]
	[Calls(Type = typeof(AkSoundEngine), Member = "RenderAudio")]
	[Calls(Type = typeof(AkCallbackManager), Member = "PostCallbacks")]
	[Calls(Type = typeof(AkWwiseInitializationSettings), Member = "SleepForMilliseconds")]
	[Calls(Type = typeof(AkSoundEngine), Member = "Term")]
	[Calls(Type = typeof(AkCallbackManager), Member = "Term")]
	[Calls(Type = typeof(AkBankManager), Member = "Reset")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void TerminateSoundEngine()
	{
	}

	[CalledBy(Type = typeof(AkWwiseInitializationSettings), Member = "TerminateSoundEngine")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(EventWaitHandle), Member = ".ctor")]
	[Calls(Type = typeof(TimeSpan), Member = "FromMilliseconds")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	private static void SleepForMilliseconds(double milliseconds)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 21)]
	public AkWwiseInitializationSettings()
	{
	}
}
