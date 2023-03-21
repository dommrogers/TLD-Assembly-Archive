using System;
using Cpp2ILInjected.CallAnalysis;

public class AkWindowsSettings : AkWwiseInitializationSettings.PlatformSettings
{
	[Serializable]
	public class PlatformAdvancedSettings : AkCommonAdvancedSettings
	{
		public enum AudioAPI
		{
			None = 0,
			Wasapi = 1,
			XAudio2 = 2,
			DirectSound = 4,
			Default = -1
		}

		public AudioAPI m_AudioAPI;

		public bool m_GlobalFocus;

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		public override void CopyTo(AkPlatformInitSettings settings)
		{
		}

		[CallerCount(Count = 0)]
		public PlatformAdvancedSettings()
		{
		}
	}

	public AkCommonUserSettings UserSettings;

	public PlatformAdvancedSettings AdvancedSettings;

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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkWwiseInitializationSettings.PlatformSettings), Member = ".ctor")]
	[DeduplicatedMethod]
	public AkWindowsSettings()
	{
	}
}
