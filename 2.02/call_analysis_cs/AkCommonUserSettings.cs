using System;
using System.IO;
using Cpp2ILInjected.CallAnalysis;

[Serializable]
public class AkCommonUserSettings : AkSettingsValidationHandler
{
	[Serializable]
	public class SpatialAudioSettings
	{
		public enum DiffractionFlags
		{
			UseBuiltInParam = 1,
			UseObstruction = 2,
			CalcEmitterVirtualPosition = 8
		}

		public uint m_PoolSize;

		public uint m_MaxSoundPropagationDepth;

		public DiffractionFlags m_DiffractionFlags;

		[CallerCount(Count = 0)]
		public SpatialAudioSettings()
		{
		}
	}

	public string m_BasePath;

	public string m_StartupLanguage;

	public uint m_PreparePoolSize;

	public int m_CallbackManagerBufferSize;

	public bool m_EngineLogging;

	public uint m_MaximumNumberOfMemoryPools;

	public uint m_MaximumNumberOfPositioningPaths;

	public uint m_DefaultPoolSize;

	public float m_MemoryCutoffThreshold;

	public uint m_CommandQueueSize;

	public uint m_SamplesPerFrame;

	public AkCommonOutputSettings m_MainOutputSettings;

	public float m_StreamingLookAheadRatio;

	public uint m_StreamManagerPoolSize;

	public uint m_SampleRate;

	public uint m_LowerEnginePoolSize;

	public float m_LowerEngineMemoryCutoffThreshold;

	public ushort m_NumberOfRefillsInVoice;

	public SpatialAudioSettings m_SpatialAudioSettings;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void CopyTo(AkMemSettings settings)
	{
	}

	[CalledBy(Type = typeof(AkCommonUserSettings), Member = "CopyTo")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "CreateString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	protected static string GetPluginPath()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkInitSettings), Member = "get_settingsMainOutput")]
	[Calls(Type = typeof(AkCommonOutputSettings), Member = "CopyTo")]
	[Calls(Type = typeof(AkCommonUserSettings), Member = "GetPluginPath")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 8)]
	public virtual void CopyTo(AkInitSettings settings)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void CopyTo(AkMusicSettings settings)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void CopyTo(AkStreamMgrSettings settings)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public virtual void CopyTo(AkDeviceSettings settings)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 5)]
	public virtual void CopyTo(AkPlatformInitSettings settings)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	public virtual void CopyTo(AkSpatialAudioInitSettings settings)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public virtual void CopyTo(AkUnityPlatformSpecificSettings settings)
	{
	}

	[CallerCount(Count = 0)]
	public override void Validate()
	{
	}

	[CalledBy(Type = typeof(AkPS4Settings), Member = ".ctor")]
	[CalledBy(Type = typeof(AkXBoxOneSettings), Member = ".ctor")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public AkCommonUserSettings()
	{
	}
}
