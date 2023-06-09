using System;
using Cpp2ILInjected.CallAnalysis;

[Serializable]
public class AkCommonOutputSettings
{
	public enum PanningRule
	{
		Speakers,
		Headphones
	}

	[Serializable]
	public class ChannelConfiguration
	{
		public enum ChannelConfigType
		{
			Anonymous,
			Standard,
			Ambisonic
		}

		public enum ChannelMask
		{
			NONE = 0,
			FRONT_LEFT = 1,
			FRONT_RIGHT = 2,
			FRONT_CENTER = 4,
			LOW_FREQUENCY = 8,
			BACK_LEFT = 16,
			BACK_RIGHT = 32,
			BACK_CENTER = 256,
			SIDE_LEFT = 512,
			SIDE_RIGHT = 1024,
			TOP = 2048,
			HEIGHT_FRONT_LEFT = 4096,
			HEIGHT_FRONT_CENTER = 8192,
			HEIGHT_FRONT_RIGHT = 16384,
			HEIGHT_BACK_LEFT = 32768,
			HEIGHT_BACK_CENTER = 65536,
			HEIGHT_BACK_RIGHT = 131072,
			SETUP_MONO = 4,
			SETUP_0POINT1 = 8,
			SETUP_1POINT1 = 12,
			SETUP_STEREO = 3,
			SETUP_2POINT1 = 11,
			SETUP_3STEREO = 7,
			SETUP_3POINT1 = 15,
			SETUP_4 = 1539,
			SETUP_4POINT1 = 1547,
			SETUP_5 = 1543,
			SETUP_5POINT1 = 1551,
			SETUP_6 = 1587,
			SETUP_6POINT1 = 1595,
			SETUP_7 = 1591,
			SETUP_7POINT1 = 1599,
			SETUP_SURROUND = 259,
			SETUP_DPL2 = 1539,
			SETUP_HEIGHT_4 = 184320,
			SETUP_HEIGHT_5 = 192512,
			SETUP_HEIGHT_ALL = 258048,
			SETUP_AURO_222 = 22019,
			SETUP_AURO_8 = 185859,
			SETUP_AURO_9 = 185863,
			SETUP_AURO_9POINT1 = 185871,
			SETUP_AURO_10 = 187911,
			SETUP_AURO_10POINT1 = 187919,
			SETUP_AURO_11 = 196103,
			SETUP_AURO_11POINT1 = 196111,
			SETUP_AURO_11_740 = 185911,
			SETUP_AURO_11POINT1_740 = 185919,
			SETUP_AURO_13_751 = 196151,
			SETUP_AURO_13POINT1_751 = 196159,
			SETUP_DOLBY_5_0_2 = 22023,
			SETUP_DOLBY_5_1_2 = 22031,
			SETUP_DOLBY_6_0_2 = 22067,
			SETUP_DOLBY_6_1_2 = 22075,
			SETUP_DOLBY_6_0_4 = 185907,
			SETUP_DOLBY_6_1_4 = 185915,
			SETUP_DOLBY_7_0_2 = 22071,
			SETUP_DOLBY_7_1_2 = 22079,
			SETUP_DOLBY_7_0_4 = 185911,
			SETUP_DOLBY_7_1_4 = 185919,
			SETUP_ALL_SPEAKERS = 261951
		}

		public ChannelConfigType m_ChannelConfigType;

		public ChannelMask m_ChannelMask;

		public uint m_NumberOfChannels;

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 6)]
		public void CopyTo(AkChannelConfig config)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public ChannelConfiguration()
		{
		}
	}

	public string m_AudioDeviceShareset;

	public uint m_DeviceID;

	public PanningRule m_PanningRule;

	public ChannelConfiguration m_ChannelConfig;

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(AkCommonUserSettings), Member = "CopyTo")]
	[CallerCount(Count = 1)]
	public void CopyTo(AkOutputSettings settings)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public AkCommonOutputSettings()
	{
	}
}
