using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AK.Wwise;
using Audio.SimpleAudio;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using UnityEngine;

public class AkSoundEngine
{
	public delegate ulong GameObjectHashFunction(GameObject gameObject);

	private class AutoObject
	{
		private readonly GameObject gameObject;

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(AkSoundEngine), Member = "RegisterGameObj")]
		[CallsUnknownMethods(Count = 1)]
		public AutoObject(GameObject go)
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(AkSoundEngine), Member = "UnregisterGameObj")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		~AutoObject()
		{
		}
	}

	public const int _WIN32_WINNT = 1538;

	public const int AK_SIMD_ALIGNMENT = 16;

	public const int AK_BUFFER_ALIGNMENT = 16;

	public const int AK_XAUDIO2_FLAGS = 0;

	public const int AK_MAX_PATH = 260;

	public const int AK_BANK_PLATFORM_DATA_ALIGNMENT = 16;

	public const uint AK_INVALID_PLUGINID = uint.MaxValue;

	public const ulong AK_INVALID_GAME_OBJECT = ulong.MaxValue;

	public const uint AK_INVALID_UNIQUE_ID = 0u;

	public const uint AK_INVALID_RTPC_ID = 0u;

	public const uint AK_INVALID_LISTENER_INDEX = uint.MaxValue;

	public const uint AK_INVALID_PLAYING_ID = 0u;

	public const uint AK_DEFAULT_SWITCH_STATE = 0u;

	public const int AK_INVALID_POOL_ID = -1;

	public const int AK_DEFAULT_POOL_ID = -1;

	public const uint AK_INVALID_AUX_ID = 0u;

	public const uint AK_INVALID_FILE_ID = uint.MaxValue;

	public const uint AK_INVALID_DEVICE_ID = uint.MaxValue;

	public const uint AK_INVALID_BANK_ID = 0u;

	public const uint AK_FALLBACK_ARGUMENTVALUE_ID = 0u;

	public const uint AK_INVALID_CHANNELMASK = 0u;

	public const uint AK_INVALID_OUTPUT_DEVICE_ID = 0u;

	public const uint AK_MIXER_FX_SLOT = uint.MaxValue;

	public const ulong AK_DEFAULT_LISTENER_OBJ = 0uL;

	public const uint AK_DEFAULT_PRIORITY = 50u;

	public const uint AK_MIN_PRIORITY = 0u;

	public const uint AK_MAX_PRIORITY = 100u;

	public const uint AK_DEFAULT_BANK_IO_PRIORITY = 50u;

	public const double AK_DEFAULT_BANK_THROUGHPUT = 1048.576;

	public const uint AKCOMPANYID_AUDIOKINETIC = 0u;

	public const uint AK_LISTENERS_MASK_ALL = uint.MaxValue;

	public const int NULL = 0;

	public const int AKCURVEINTERPOLATION_NUM_STORAGE_BIT = 5;

	public const int AK_MAX_LANGUAGE_NAME_SIZE = 32;

	public const int AKCOMPANYID_AUDIOKINETIC_EXTERNAL = 1;

	public const int AKCOMPANYID_MCDSP = 256;

	public const int AKCOMPANYID_WAVEARTS = 257;

	public const int AKCOMPANYID_PHONETICARTS = 258;

	public const int AKCOMPANYID_IZOTOPE = 259;

	public const int AKCOMPANYID_CRANKCASEAUDIO = 261;

	public const int AKCOMPANYID_IOSONO = 262;

	public const int AKCOMPANYID_AUROTECHNOLOGIES = 263;

	public const int AKCOMPANYID_DOLBY = 264;

	public const int AKCOMPANYID_TWOBIGEARS = 265;

	public const int AKCOMPANYID_OCULUS = 266;

	public const int AKCOMPANYID_BLUERIPPLESOUND = 267;

	public const int AKCOMPANYID_ENZIEN = 268;

	public const int AKCOMPANYID_KROTOS = 269;

	public const int AKCOMPANYID_NURULIZE = 270;

	public const int AKCOMPANYID_SUPERPOWERED = 271;

	public const int AKCOMPANYID_GOOGLE = 272;

	public const int AKCOMPANYID_VISISONICS = 277;

	public const int AKCODECID_BANK = 0;

	public const int AKCODECID_PCM = 1;

	public const int AKCODECID_ADPCM = 2;

	public const int AKCODECID_XMA = 3;

	public const int AKCODECID_VORBIS = 4;

	public const int AKCODECID_WIIADPCM = 5;

	public const int AKCODECID_PCMEX = 7;

	public const int AKCODECID_EXTERNAL_SOURCE = 8;

	public const int AKCODECID_XWMA = 9;

	public const int AKCODECID_AAC = 10;

	public const int AKCODECID_FILE_PACKAGE = 11;

	public const int AKCODECID_ATRAC9 = 12;

	public const int AKCODECID_VAG = 13;

	public const int AKCODECID_PROFILERCAPTURE = 14;

	public const int AKCODECID_ANALYSISFILE = 15;

	public const int AKCODECID_MIDI = 16;

	public const int AKCODECID_OPUSNX = 17;

	public const int AKCODECID_CAF = 18;

	public const int AKCODECID_AKOPUS = 19;

	public const int AKPLUGINID_METER = 129;

	public const int AKPLUGINID_RECORDER = 132;

	public const int AKEXTENSIONID_SPATIALAUDIO = 800;

	public const int AKEXTENSIONID_INTERACTIVEMUSIC = 801;

	public const int AK_WAVE_FORMAT_VAG = 65531;

	public const int AK_WAVE_FORMAT_AT9 = 65532;

	public const int AK_WAVE_FORMAT_VORBIS = 65535;

	public const int AK_WAVE_FORMAT_AAC = 43712;

	public const int AK_WAVE_FORMAT_OPUSNX = 12345;

	public const int AK_WAVE_FORMAT_OPUS = 12352;

	public const int WAVE_FORMAT_XMA2 = 358;

	public const int AK_PANNER_NUM_STORAGE_BITS = 3;

	public const int AK_POSSOURCE_NUM_STORAGE_BITS = 3;

	public const int AK_SPAT_NUM_STORAGE_BITS = 3;

	public const int AK_MAX_BITS_METERING_FLAGS = 5;

	public const int AK_OS_STRUCT_ALIGN = 4;

	public const int AK_64B_OS_STRUCT_ALIGN = 8;

	public const bool AK_ASYNC_OPEN_DEFAULT = false;

	public const int AK_COMM_DEFAULT_DISCOVERY_PORT = 24024;

	public const int AK_MIDI_EVENT_TYPE_INVALID = 0;

	public const int AK_MIDI_EVENT_TYPE_NOTE_OFF = 128;

	public const int AK_MIDI_EVENT_TYPE_NOTE_ON = 144;

	public const int AK_MIDI_EVENT_TYPE_NOTE_AFTERTOUCH = 160;

	public const int AK_MIDI_EVENT_TYPE_CONTROLLER = 176;

	public const int AK_MIDI_EVENT_TYPE_PROGRAM_CHANGE = 192;

	public const int AK_MIDI_EVENT_TYPE_CHANNEL_AFTERTOUCH = 208;

	public const int AK_MIDI_EVENT_TYPE_PITCH_BEND = 224;

	public const int AK_MIDI_EVENT_TYPE_SYSEX = 240;

	public const int AK_MIDI_EVENT_TYPE_ESCAPE = 247;

	public const int AK_MIDI_EVENT_TYPE_META = 255;

	public const int AK_MIDI_CC_BANK_SELECT_COARSE = 0;

	public const int AK_MIDI_CC_MOD_WHEEL_COARSE = 1;

	public const int AK_MIDI_CC_BREATH_CTRL_COARSE = 2;

	public const int AK_MIDI_CC_CTRL_3_COARSE = 3;

	public const int AK_MIDI_CC_FOOT_PEDAL_COARSE = 4;

	public const int AK_MIDI_CC_PORTAMENTO_COARSE = 5;

	public const int AK_MIDI_CC_DATA_ENTRY_COARSE = 6;

	public const int AK_MIDI_CC_VOLUME_COARSE = 7;

	public const int AK_MIDI_CC_BALANCE_COARSE = 8;

	public const int AK_MIDI_CC_CTRL_9_COARSE = 9;

	public const int AK_MIDI_CC_PAN_POSITION_COARSE = 10;

	public const int AK_MIDI_CC_EXPRESSION_COARSE = 11;

	public const int AK_MIDI_CC_EFFECT_CTRL_1_COARSE = 12;

	public const int AK_MIDI_CC_EFFECT_CTRL_2_COARSE = 13;

	public const int AK_MIDI_CC_CTRL_14_COARSE = 14;

	public const int AK_MIDI_CC_CTRL_15_COARSE = 15;

	public const int AK_MIDI_CC_GEN_SLIDER_1 = 16;

	public const int AK_MIDI_CC_GEN_SLIDER_2 = 17;

	public const int AK_MIDI_CC_GEN_SLIDER_3 = 18;

	public const int AK_MIDI_CC_GEN_SLIDER_4 = 19;

	public const int AK_MIDI_CC_CTRL_20_COARSE = 20;

	public const int AK_MIDI_CC_CTRL_21_COARSE = 21;

	public const int AK_MIDI_CC_CTRL_22_COARSE = 22;

	public const int AK_MIDI_CC_CTRL_23_COARSE = 23;

	public const int AK_MIDI_CC_CTRL_24_COARSE = 24;

	public const int AK_MIDI_CC_CTRL_25_COARSE = 25;

	public const int AK_MIDI_CC_CTRL_26_COARSE = 26;

	public const int AK_MIDI_CC_CTRL_27_COARSE = 27;

	public const int AK_MIDI_CC_CTRL_28_COARSE = 28;

	public const int AK_MIDI_CC_CTRL_29_COARSE = 29;

	public const int AK_MIDI_CC_CTRL_30_COARSE = 30;

	public const int AK_MIDI_CC_CTRL_31_COARSE = 31;

	public const int AK_MIDI_CC_BANK_SELECT_FINE = 32;

	public const int AK_MIDI_CC_MOD_WHEEL_FINE = 33;

	public const int AK_MIDI_CC_BREATH_CTRL_FINE = 34;

	public const int AK_MIDI_CC_CTRL_3_FINE = 35;

	public const int AK_MIDI_CC_FOOT_PEDAL_FINE = 36;

	public const int AK_MIDI_CC_PORTAMENTO_FINE = 37;

	public const int AK_MIDI_CC_DATA_ENTRY_FINE = 38;

	public const int AK_MIDI_CC_VOLUME_FINE = 39;

	public const int AK_MIDI_CC_BALANCE_FINE = 40;

	public const int AK_MIDI_CC_CTRL_9_FINE = 41;

	public const int AK_MIDI_CC_PAN_POSITION_FINE = 42;

	public const int AK_MIDI_CC_EXPRESSION_FINE = 43;

	public const int AK_MIDI_CC_EFFECT_CTRL_1_FINE = 44;

	public const int AK_MIDI_CC_EFFECT_CTRL_2_FINE = 45;

	public const int AK_MIDI_CC_CTRL_14_FINE = 46;

	public const int AK_MIDI_CC_CTRL_15_FINE = 47;

	public const int AK_MIDI_CC_CTRL_20_FINE = 52;

	public const int AK_MIDI_CC_CTRL_21_FINE = 53;

	public const int AK_MIDI_CC_CTRL_22_FINE = 54;

	public const int AK_MIDI_CC_CTRL_23_FINE = 55;

	public const int AK_MIDI_CC_CTRL_24_FINE = 56;

	public const int AK_MIDI_CC_CTRL_25_FINE = 57;

	public const int AK_MIDI_CC_CTRL_26_FINE = 58;

	public const int AK_MIDI_CC_CTRL_27_FINE = 59;

	public const int AK_MIDI_CC_CTRL_28_FINE = 60;

	public const int AK_MIDI_CC_CTRL_29_FINE = 61;

	public const int AK_MIDI_CC_CTRL_30_FINE = 62;

	public const int AK_MIDI_CC_CTRL_31_FINE = 63;

	public const int AK_MIDI_CC_HOLD_PEDAL = 64;

	public const int AK_MIDI_CC_PORTAMENTO_ON_OFF = 65;

	public const int AK_MIDI_CC_SUSTENUTO_PEDAL = 66;

	public const int AK_MIDI_CC_SOFT_PEDAL = 67;

	public const int AK_MIDI_CC_LEGATO_PEDAL = 68;

	public const int AK_MIDI_CC_HOLD_PEDAL_2 = 69;

	public const int AK_MIDI_CC_SOUND_VARIATION = 70;

	public const int AK_MIDI_CC_SOUND_TIMBRE = 71;

	public const int AK_MIDI_CC_SOUND_RELEASE_TIME = 72;

	public const int AK_MIDI_CC_SOUND_ATTACK_TIME = 73;

	public const int AK_MIDI_CC_SOUND_BRIGHTNESS = 74;

	public const int AK_MIDI_CC_SOUND_CTRL_6 = 75;

	public const int AK_MIDI_CC_SOUND_CTRL_7 = 76;

	public const int AK_MIDI_CC_SOUND_CTRL_8 = 77;

	public const int AK_MIDI_CC_SOUND_CTRL_9 = 78;

	public const int AK_MIDI_CC_SOUND_CTRL_10 = 79;

	public const int AK_MIDI_CC_GENERAL_BUTTON_1 = 80;

	public const int AK_MIDI_CC_GENERAL_BUTTON_2 = 81;

	public const int AK_MIDI_CC_GENERAL_BUTTON_3 = 82;

	public const int AK_MIDI_CC_GENERAL_BUTTON_4 = 83;

	public const int AK_MIDI_CC_REVERB_LEVEL = 91;

	public const int AK_MIDI_CC_TREMOLO_LEVEL = 92;

	public const int AK_MIDI_CC_CHORUS_LEVEL = 93;

	public const int AK_MIDI_CC_CELESTE_LEVEL = 94;

	public const int AK_MIDI_CC_PHASER_LEVEL = 95;

	public const int AK_MIDI_CC_DATA_BUTTON_P1 = 96;

	public const int AK_MIDI_CC_DATA_BUTTON_M1 = 97;

	public const int AK_MIDI_CC_NON_REGISTER_COARSE = 98;

	public const int AK_MIDI_CC_NON_REGISTER_FINE = 99;

	public const int AK_MIDI_CC_ALL_SOUND_OFF = 120;

	public const int AK_MIDI_CC_ALL_CONTROLLERS_OFF = 121;

	public const int AK_MIDI_CC_LOCAL_KEYBOARD = 122;

	public const int AK_MIDI_CC_ALL_NOTES_OFF = 123;

	public const int AK_MIDI_CC_OMNI_MODE_OFF = 124;

	public const int AK_MIDI_CC_OMNI_MODE_ON = 125;

	public const int AK_MIDI_CC_OMNI_MONOPHONIC_ON = 126;

	public const int AK_MIDI_CC_OMNI_POLYPHONIC_ON = 127;

	public const int AK_SPEAKER_FRONT_LEFT = 1;

	public const int AK_SPEAKER_FRONT_RIGHT = 2;

	public const int AK_SPEAKER_FRONT_CENTER = 4;

	public const int AK_SPEAKER_LOW_FREQUENCY = 8;

	public const int AK_SPEAKER_BACK_LEFT = 16;

	public const int AK_SPEAKER_BACK_RIGHT = 32;

	public const int AK_SPEAKER_BACK_CENTER = 256;

	public const int AK_SPEAKER_SIDE_LEFT = 512;

	public const int AK_SPEAKER_SIDE_RIGHT = 1024;

	public const int AK_SPEAKER_TOP = 2048;

	public const int AK_SPEAKER_HEIGHT_FRONT_LEFT = 4096;

	public const int AK_SPEAKER_HEIGHT_FRONT_CENTER = 8192;

	public const int AK_SPEAKER_HEIGHT_FRONT_RIGHT = 16384;

	public const int AK_SPEAKER_HEIGHT_BACK_LEFT = 32768;

	public const int AK_SPEAKER_HEIGHT_BACK_CENTER = 65536;

	public const int AK_SPEAKER_HEIGHT_BACK_RIGHT = 131072;

	public const int AK_SPEAKER_SETUP_MONO = 4;

	public const int AK_SPEAKER_SETUP_0POINT1 = 8;

	public const int AK_SPEAKER_SETUP_1POINT1 = 12;

	public const int AK_SPEAKER_SETUP_STEREO = 3;

	public const int AK_SPEAKER_SETUP_2POINT1 = 11;

	public const int AK_SPEAKER_SETUP_3STEREO = 7;

	public const int AK_SPEAKER_SETUP_3POINT1 = 15;

	public const int AK_SPEAKER_SETUP_4 = 1539;

	public const int AK_SPEAKER_SETUP_4POINT1 = 1547;

	public const int AK_SPEAKER_SETUP_5 = 1543;

	public const int AK_SPEAKER_SETUP_5POINT1 = 1551;

	public const int AK_SPEAKER_SETUP_6 = 1587;

	public const int AK_SPEAKER_SETUP_6POINT1 = 1595;

	public const int AK_SPEAKER_SETUP_7 = 1591;

	public const int AK_SPEAKER_SETUP_7POINT1 = 1599;

	public const int AK_SPEAKER_SETUP_SURROUND = 259;

	public const int AK_SPEAKER_SETUP_DPL2 = 1539;

	public const int AK_SPEAKER_SETUP_HEIGHT_4 = 184320;

	public const int AK_SPEAKER_SETUP_HEIGHT_5 = 192512;

	public const int AK_SPEAKER_SETUP_HEIGHT_ALL = 258048;

	public const int AK_SPEAKER_SETUP_AURO_222 = 22019;

	public const int AK_SPEAKER_SETUP_AURO_8 = 185859;

	public const int AK_SPEAKER_SETUP_AURO_9 = 185863;

	public const int AK_SPEAKER_SETUP_AURO_9POINT1 = 185871;

	public const int AK_SPEAKER_SETUP_AURO_10 = 187911;

	public const int AK_SPEAKER_SETUP_AURO_10POINT1 = 187919;

	public const int AK_SPEAKER_SETUP_AURO_11 = 196103;

	public const int AK_SPEAKER_SETUP_AURO_11POINT1 = 196111;

	public const int AK_SPEAKER_SETUP_AURO_11_740 = 185911;

	public const int AK_SPEAKER_SETUP_AURO_11POINT1_740 = 185919;

	public const int AK_SPEAKER_SETUP_AURO_13_751 = 196151;

	public const int AK_SPEAKER_SETUP_AURO_13POINT1_751 = 196159;

	public const int AK_SPEAKER_SETUP_DOLBY_5_0_2 = 22023;

	public const int AK_SPEAKER_SETUP_DOLBY_5_1_2 = 22031;

	public const int AK_SPEAKER_SETUP_DOLBY_6_0_2 = 22067;

	public const int AK_SPEAKER_SETUP_DOLBY_6_1_2 = 22075;

	public const int AK_SPEAKER_SETUP_DOLBY_6_0_4 = 185907;

	public const int AK_SPEAKER_SETUP_DOLBY_6_1_4 = 185915;

	public const int AK_SPEAKER_SETUP_DOLBY_7_0_2 = 22071;

	public const int AK_SPEAKER_SETUP_DOLBY_7_1_2 = 22079;

	public const int AK_SPEAKER_SETUP_DOLBY_7_0_4 = 185911;

	public const int AK_SPEAKER_SETUP_DOLBY_7_1_4 = 185919;

	public const int AK_SPEAKER_SETUP_ALL_SPEAKERS = 261951;

	public const int AK_IDX_SETUP_FRONT_LEFT = 0;

	public const int AK_IDX_SETUP_FRONT_RIGHT = 1;

	public const int AK_IDX_SETUP_CENTER = 2;

	public const int AK_IDX_SETUP_NOCENTER_BACK_LEFT = 2;

	public const int AK_IDX_SETUP_NOCENTER_BACK_RIGHT = 3;

	public const int AK_IDX_SETUP_NOCENTER_SIDE_LEFT = 4;

	public const int AK_IDX_SETUP_NOCENTER_SIDE_RIGHT = 5;

	public const int AK_IDX_SETUP_WITHCENTER_BACK_LEFT = 3;

	public const int AK_IDX_SETUP_WITHCENTER_BACK_RIGHT = 4;

	public const int AK_IDX_SETUP_WITHCENTER_SIDE_LEFT = 5;

	public const int AK_IDX_SETUP_WITHCENTER_SIDE_RIGHT = 6;

	public const int AK_IDX_SETUP_0_LFE = 0;

	public const int AK_IDX_SETUP_1_CENTER = 0;

	public const int AK_IDX_SETUP_1_LFE = 1;

	public const int AK_IDX_SETUP_2_LEFT = 0;

	public const int AK_IDX_SETUP_2_RIGHT = 1;

	public const int AK_IDX_SETUP_2_LFE = 2;

	public const int AK_IDX_SETUP_3_LEFT = 0;

	public const int AK_IDX_SETUP_3_RIGHT = 1;

	public const int AK_IDX_SETUP_3_CENTER = 2;

	public const int AK_IDX_SETUP_3_LFE = 3;

	public const int AK_IDX_SETUP_4_FRONTLEFT = 0;

	public const int AK_IDX_SETUP_4_FRONTRIGHT = 1;

	public const int AK_IDX_SETUP_4_REARLEFT = 2;

	public const int AK_IDX_SETUP_4_REARRIGHT = 3;

	public const int AK_IDX_SETUP_4_LFE = 4;

	public const int AK_IDX_SETUP_5_FRONTLEFT = 0;

	public const int AK_IDX_SETUP_5_FRONTRIGHT = 1;

	public const int AK_IDX_SETUP_5_CENTER = 2;

	public const int AK_IDX_SETUP_5_REARLEFT = 3;

	public const int AK_IDX_SETUP_5_REARRIGHT = 4;

	public const int AK_IDX_SETUP_5_LFE = 5;

	public const int AK_IDX_SETUP_6_FRONTLEFT = 0;

	public const int AK_IDX_SETUP_6_FRONTRIGHT = 1;

	public const int AK_IDX_SETUP_6_REARLEFT = 2;

	public const int AK_IDX_SETUP_6_REARRIGHT = 3;

	public const int AK_IDX_SETUP_6_SIDELEFT = 4;

	public const int AK_IDX_SETUP_6_SIDERIGHT = 5;

	public const int AK_IDX_SETUP_6_LFE = 6;

	public const int AK_IDX_SETUP_7_FRONTLEFT = 0;

	public const int AK_IDX_SETUP_7_FRONTRIGHT = 1;

	public const int AK_IDX_SETUP_7_CENTER = 2;

	public const int AK_IDX_SETUP_7_REARLEFT = 3;

	public const int AK_IDX_SETUP_7_REARRIGHT = 4;

	public const int AK_IDX_SETUP_7_SIDELEFT = 5;

	public const int AK_IDX_SETUP_7_SIDERIGHT = 6;

	public const int AK_IDX_SETUP_7_LFE = 7;

	public const int AK_SPEAKER_SETUP_0_1 = 8;

	public const int AK_SPEAKER_SETUP_1_0_CENTER = 4;

	public const int AK_SPEAKER_SETUP_1_1_CENTER = 12;

	public const int AK_SPEAKER_SETUP_2_0 = 3;

	public const int AK_SPEAKER_SETUP_2_1 = 11;

	public const int AK_SPEAKER_SETUP_3_0 = 7;

	public const int AK_SPEAKER_SETUP_3_1 = 15;

	public const int AK_SPEAKER_SETUP_FRONT = 7;

	public const int AK_SPEAKER_SETUP_4_0 = 1539;

	public const int AK_SPEAKER_SETUP_4_1 = 1547;

	public const int AK_SPEAKER_SETUP_5_0 = 1543;

	public const int AK_SPEAKER_SETUP_5_1 = 1551;

	public const int AK_SPEAKER_SETUP_6_0 = 1587;

	public const int AK_SPEAKER_SETUP_6_1 = 1595;

	public const int AK_SPEAKER_SETUP_7_0 = 1591;

	public const int AK_SPEAKER_SETUP_7_1 = 1599;

	public const int AK_SPEAKER_SETUP_DEFAULT_PLANE = 1599;

	public const int AK_SUPPORTED_STANDARD_CHANNEL_MASK = 261951;

	public const int AK_STANDARD_MAX_NUM_CHANNELS = 8;

	public const int AK_NUM_SAMPLED_SPHERE_POINTS = 32;

	public const int AK_MAX_NUM_TEXTURE = 4;

	public const int AK_MAX_REFLECT_ORDER = 4;

	public const int AK_MAX_REFLECTION_PATH_LENGTH = 6;

	public const int AK_MAX_SOUND_PROPAGATION_DEPTH = 8;

	public const double AK_DEFAULT_DIFFR_SHADOW_DEGREES = 30.0;

	public const double AK_DEFAULT_DIFFR_SHADOW_ATTEN = 2.0;

	public const double AK_SA_EPSILON = 0.001;

	public const double AK_SA_PLANE_THICKNESS_RATIO = 0.005;

	private static GameObjectHashFunction gameObjectHash;

	public const string Deprecation_2018_1_2 = "This functionality is deprecated as of Wwise v2018.1.2 and will be removed in a future release.";

	public const string Deprecation_2018_1_6 = "This functionality is deprecated as of Wwise v2018.1.6 and will be removed in a future release.";

	public const string Deprecation_2018_1_8 = "This functionality is deprecated as of Wwise v2018.1.8 and will be removed in a future release.";

	private static readonly HashSet<ulong> RegisteredGameObjects;

	public static uint AK_SOUNDBANK_VERSION
	{
		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return default(uint);
		}
	}

	public static ushort AK_INT
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(ushort);
		}
	}

	public static ushort AK_FLOAT
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(ushort);
		}
	}

	public static byte AK_INTERLEAVED
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(byte);
		}
	}

	public static byte AK_NONINTERLEAVED
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(byte);
		}
	}

	public static uint AK_LE_NATIVE_BITSPERSAMPLE
	{
		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return default(uint);
		}
	}

	public static uint AK_LE_NATIVE_SAMPLETYPE
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(uint);
		}
	}

	public static uint AK_LE_NATIVE_INTERLEAVE
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(uint);
		}
	}

	public static byte AK_INVALID_MIDI_CHANNEL
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(byte);
		}
	}

	public static byte AK_INVALID_MIDI_NOTE
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(byte);
		}
	}

	public static float kDefaultMaxPathLength
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(float);
		}
	}

	public static float kMaxDiffraction
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(float);
		}
	}

	public static int g_SpatialAudioPoolId
	{
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return default(int);
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public static GameObjectHashFunction GameObjectHash
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		set
		{
		}
	}

	[Calls(Type = typeof(AkCallbackManager), Member = "SetLastAddedPlayingID")]
	[Calls(Type = typeof(AkCallbackManager.EventCallbackPackage), Member = "Create")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	public static uint DynamicSequenceOpen(GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, AkDynamicSequenceType in_eDynamicSequenceType)
	{
		return default(uint);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AkCallbackManager.EventCallbackPackage), Member = "Create")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(Type = typeof(AkCallbackManager), Member = "SetLastAddedPlayingID")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	public static uint DynamicSequenceOpen(GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie)
	{
		return default(uint);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(Type = typeof(AkCallbackManager), Member = "SetLastAddedPlayingID")]
	public static uint DynamicSequenceOpen(GameObject in_gameObjectID)
	{
		return default(uint);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static AKRESULT DynamicSequenceClose(uint in_playingID)
	{
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static AKRESULT DynamicSequencePlay(uint in_playingID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT DynamicSequencePlay(uint in_playingID, int in_uTransitionDuration)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT DynamicSequencePlay(uint in_playingID)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT DynamicSequencePause(uint in_playingID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve)
	{
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static AKRESULT DynamicSequencePause(uint in_playingID, int in_uTransitionDuration)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT DynamicSequencePause(uint in_playingID)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT DynamicSequenceResume(uint in_playingID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT DynamicSequenceResume(uint in_playingID, int in_uTransitionDuration)
	{
		return default(AKRESULT);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static AKRESULT DynamicSequenceResume(uint in_playingID)
	{
		return default(AKRESULT);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static AKRESULT DynamicSequenceStop(uint in_playingID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT DynamicSequenceStop(uint in_playingID, int in_uTransitionDuration)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT DynamicSequenceStop(uint in_playingID)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT DynamicSequenceBreak(uint in_playingID)
	{
		return default(AKRESULT);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static AKRESULT DynamicSequenceGetPauseTimes(uint in_playingID, out uint out_uTime, out uint out_uDuration)
	{
		System.Runtime.CompilerServices.Unsafe.As<uint, @null>(ref out_uTime) = null;
		System.Runtime.CompilerServices.Unsafe.As<uint, @null>(ref out_uDuration) = null;
		return default(AKRESULT);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AkPlaylist), Member = ".ctor")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "PlayDynamicSequence")]
	[CallsUnknownMethods(Count = 8)]
	public static AkPlaylist DynamicSequenceLockPlaylist(uint in_playingID)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT DynamicSequenceUnlockPlaylist(uint in_playingID)
	{
		return default(AKRESULT);
	}

	[CalledBy(Type = typeof(AkGameObjListenerList), Member = "Remove")]
	[CalledBy(Type = typeof(AkSoundEngineController), Member = "Init")]
	[CalledBy(Type = typeof(AkGameObjListenerList), Member = "Add")]
	[CalledBy(Type = typeof(AkSurfaceReflector), Member = "AddGeometrySet")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(AkSoundEngineController), Member = "ActivateAudio")]
	[CalledBy(Type = typeof(AkAudioListener.DefaultListenerList), Member = "Remove")]
	[CalledBy(Type = typeof(AkGameObj), Member = "OnDestroy")]
	[CalledBy(Type = typeof(AkAudioListener.DefaultListenerList), Member = "Add")]
	[CalledBy(Type = typeof(AkWwiseInitializationSettings), Member = "TerminateSoundEngine")]
	[CalledBy(Type = typeof(AkBankManager.BankHandle), Member = "LogLoadResult")]
	[CalledBy(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICallUserHook")]
	[CalledBy(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 12)]
	public static bool IsInitialized()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT GetAudioSettings(AkAudioSettings out_audioSettings)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public static AkChannelConfig GetSpeakerConfiguration(ulong in_idOutput)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 8)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public static AkChannelConfig GetSpeakerConfiguration()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT GetPanningRule(out int out_ePanningRule, ulong in_idOutput)
	{
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref out_ePanningRule) = null;
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT GetPanningRule(out int out_ePanningRule)
	{
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref out_ePanningRule) = null;
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT SetPanningRule(AkPanningRule in_ePanningRule, ulong in_idOutput)
	{
		return default(AKRESULT);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static AKRESULT SetPanningRule(AkPanningRule in_ePanningRule)
	{
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static AKRESULT GetSpeakerAngles(float[] io_pfSpeakerAngles, ref uint io_uNumAngles, out float out_fHeightAngle, ulong in_idOutput)
	{
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref out_fHeightAngle) = null;
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT GetSpeakerAngles(float[] io_pfSpeakerAngles, ref uint io_uNumAngles, out float out_fHeightAngle)
	{
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref out_fHeightAngle) = null;
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT SetSpeakerAngles(float[] in_pfSpeakerAngles, uint in_uNumAngles, float in_fHeightAngle, ulong in_idOutput)
	{
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static AKRESULT SetSpeakerAngles(float[] in_pfSpeakerAngles, uint in_uNumAngles, float in_fHeightAngle)
	{
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static AKRESULT SetVolumeThreshold(float in_fVolumeThresholdDB)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT SetMaxNumVoicesLimit(ushort in_maxNumberVoices)
	{
		return default(AKRESULT);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT RenderAudio(bool in_bAllowSyncRender)
	{
		return default(AKRESULT);
	}

	[CalledBy(Type = typeof(AkSoundEngineController), Member = "LateUpdate")]
	[CalledBy(Type = typeof(AkSoundEngineController), Member = "ActivateAudio")]
	[CalledBy(Type = typeof(AkInitializer), Member = "LateUpdate")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(AkWwiseInitializationSettings), Member = "TerminateSoundEngine")]
	public static AKRESULT RenderAudio()
	{
		return default(AKRESULT);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static AKRESULT RegisterPluginDLL(string in_DllName, string in_DllPath)
	{
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static AKRESULT RegisterPluginDLL(string in_DllName)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(GameAudioManager), Member = "PlayDynamicSequence")]
	[CalledBy(Type = typeof(NPCVoice), Member = "Play")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "Play")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "Queue")]
	[CallsUnknownMethods(Count = 1)]
	public static uint GetIDFromString(string in_pszString)
	{
		return default(uint);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(AkCallbackManager), Member = "SetLastAddedPlayingID")]
	[Calls(Type = typeof(AkCallbackManager.EventCallbackPackage), Member = "Create")]
	[CalledBy(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	public static uint PostEvent(uint in_eventID, GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources, uint in_PlayingID)
	{
		return default(uint);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(AkCallbackManager), Member = "SetLastAddedPlayingID")]
	[Calls(Type = typeof(AkCallbackManager.EventCallbackPackage), Member = "Create")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	public static uint PostEvent(uint in_eventID, GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources)
	{
		return default(uint);
	}

	[CalledBy(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(AK.Wwise.Event), Member = "Post")]
	[CalledBy(Type = typeof(AK.Wwise.Event), Member = "Post")]
	[CalledBy(Type = typeof(AkAudioInputManager), Member = "PostAudioInputEvent")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "StartNextRequest")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkCallbackManager), Member = "SetLastAddedPlayingID")]
	[Calls(Type = typeof(AkCallbackManager.EventCallbackPackage), Member = "Create")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CalledBy(Type = typeof(NPCVoice), Member = "StartNextRequest")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 6)]
	public static uint PostEvent(uint in_eventID, GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie)
	{
		return default(uint);
	}

	[Calls(Type = typeof(AkCallbackManager), Member = "SetLastAddedPlayingID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	public static uint PostEvent(uint in_eventID, GameObject in_gameObjectID)
	{
		return default(uint);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(Type = typeof(AkCallbackManager.EventCallbackPackage), Member = "Create")]
	[Calls(Type = typeof(AkCallbackManager), Member = "SetLastAddedPlayingID")]
	[CalledBy(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsUnknownMethods(Count = 2)]
	public static uint PostEvent(string in_pszEventName, GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources, uint in_PlayingID)
	{
		return default(uint);
	}

	[CalledBy(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(AkCallbackManager.EventCallbackPackage), Member = "Create")]
	[Calls(Type = typeof(AkCallbackManager), Member = "SetLastAddedPlayingID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	public static uint PostEvent(string in_pszEventName, GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources)
	{
		return default(uint);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(VoiceTracker), Member = "Start")]
	[CalledBy(Type = typeof(AkAudioInputManager), Member = "PostAudioInputEvent")]
	[CalledBy(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CalledBy(Type = typeof(PlayAudioTrigger), Member = "Play")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "PlayAudioEvent")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "PlayVoiceWithPositionTracking")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "PlaySoundWithPositionTracking")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "UpdatePrepare")]
	[CalledBy(Type = typeof(PlayerCough), Member = "MaybeStart")]
	[CalledBy(Type = typeof(Fear), Member = "StartAffliction")]
	[CalledBy(Type = typeof(Anxiety), Member = "StartAffliction")]
	[Calls(Type = typeof(AkCallbackManager), Member = "SetLastAddedPlayingID")]
	[Calls(Type = typeof(AkCallbackManager.EventCallbackPackage), Member = "Create")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(Keypad), Member = "ProcessInteraction")]
	public static uint PostEvent(string in_pszEventName, GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie)
	{
		return default(uint);
	}

	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "ShowPanelAndPause")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "PlayVoiceWithPositionTracking")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CalledBy(Type = typeof(PlayableBehaviourPlayAudio), Member = "PostStopAudioEvent")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "FadeInAudioOnSceneStart")]
	[CalledBy(Type = typeof(PlayableBehaviourPlayAudio), Member = "StopAudio")]
	[CalledBy(Type = typeof(Action_AudioEvent), Member = "OnExecute")]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "Enable")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CalledBy(Type = typeof(MillingMachine), Member = "Update")]
	[CalledBy(Type = typeof(AuroraScreenAudio), Member = "SetState")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "StopPreviousAudio")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "PostAudioEvent")]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "SetState")]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "Update")]
	[CalledBy(Type = typeof(vp_Bullet), Member = "SpawnImpactEffects")]
	[Calls(Type = typeof(AkCallbackManager), Member = "SetLastAddedPlayingID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 18)]
	[CalledBy(Type = typeof(FlashlightItem), Member = "UpdateAudio")]
	public static uint PostEvent(string in_pszEventName, GameObject in_gameObjectID)
	{
		return default(uint);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	public static AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType, GameObject in_gameObjectID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve, uint in_PlayingID)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType, GameObject in_gameObjectID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve)
	{
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[CallerCount(Count = 0)]
	public static AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType, GameObject in_gameObjectID, int in_uTransitionDuration)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType, GameObject in_gameObjectID)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType)
	{
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType, GameObject in_gameObjectID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve, uint in_PlayingID)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType, GameObject in_gameObjectID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType, GameObject in_gameObjectID, int in_uTransitionDuration)
	{
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType, GameObject in_gameObjectID)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallsUnknownMethods(Count = 2)]
	public static AKRESULT PostMIDIOnEvent(uint in_eventID, GameObject in_gameObjectID, AkMIDIPostArray in_pPosts, ushort in_uNumPosts)
	{
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static AKRESULT StopMIDIOnEvent(uint in_eventID, GameObject in_gameObjectID)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT StopMIDIOnEvent(uint in_eventID)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT StopMIDIOnEvent()
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT PinEventInStreamCache(uint in_eventID, char in_uActivePriority, char in_uInactivePriority)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT PinEventInStreamCache(string in_pszEventName, char in_uActivePriority, char in_uInactivePriority)
	{
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static AKRESULT UnpinEventInStreamCache(uint in_eventID)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT UnpinEventInStreamCache(string in_pszEventName)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT GetBufferStatusForPinnedEvent(uint in_eventID, out float out_fPercentBuffered, out int out_bCachePinnedMemoryFull)
	{
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref out_fPercentBuffered) = null;
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref out_bCachePinnedMemoryFull) = null;
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	public static AKRESULT GetBufferStatusForPinnedEvent(string in_pszEventName, out float out_fPercentBuffered, out int out_bCachePinnedMemoryFull)
	{
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref out_fPercentBuffered) = null;
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref out_bCachePinnedMemoryFull) = null;
		return default(AKRESULT);
	}

	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	public static AKRESULT SeekOnEvent(uint in_eventID, GameObject in_gameObjectID, int in_iPosition, bool in_bSeekToNearestMarker, uint in_PlayingID)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT SeekOnEvent(uint in_eventID, GameObject in_gameObjectID, int in_iPosition, bool in_bSeekToNearestMarker)
	{
		return default(AKRESULT);
	}

	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static AKRESULT SeekOnEvent(uint in_eventID, GameObject in_gameObjectID, int in_iPosition)
	{
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	public static AKRESULT SeekOnEvent(string in_pszEventName, GameObject in_gameObjectID, int in_iPosition, bool in_bSeekToNearestMarker, uint in_PlayingID)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT SeekOnEvent(string in_pszEventName, GameObject in_gameObjectID, int in_iPosition, bool in_bSeekToNearestMarker)
	{
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static AKRESULT SeekOnEvent(string in_pszEventName, GameObject in_gameObjectID, int in_iPosition)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT SeekOnEvent(uint in_eventID, GameObject in_gameObjectID, float in_fPercent, bool in_bSeekToNearestMarker, uint in_PlayingID)
	{
		return default(AKRESULT);
	}

	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT SeekOnEvent(uint in_eventID, GameObject in_gameObjectID, float in_fPercent, bool in_bSeekToNearestMarker)
	{
		return default(AKRESULT);
	}

	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static AKRESULT SeekOnEvent(uint in_eventID, GameObject in_gameObjectID, float in_fPercent)
	{
		return default(AKRESULT);
	}

	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT SeekOnEvent(string in_pszEventName, GameObject in_gameObjectID, float in_fPercent, bool in_bSeekToNearestMarker, uint in_PlayingID)
	{
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static AKRESULT SeekOnEvent(string in_pszEventName, GameObject in_gameObjectID, float in_fPercent, bool in_bSeekToNearestMarker)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT SeekOnEvent(string in_pszEventName, GameObject in_gameObjectID, float in_fPercent)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkCallbackManager), Member = "RemoveEventCallbackCookie")]
	public static void CancelEventCallbackCookie(object in_pCookie)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void CancelEventCallbackGameObject(GameObject in_gameObjectID)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkCallbackManager), Member = "RemoveEventCallback")]
	public static void CancelEventCallback(uint in_playingID)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT GetSourcePlayPosition(uint in_PlayingID, out int out_puPosition, bool in_bExtrapolate)
	{
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref out_puPosition) = null;
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "TryGetTimeFromAudio")]
	[CalledBy(Type = typeof(PlayableBehaviourSay), Member = "TryGetCurrentTimelineTimeFromAudio")]
	[CalledBy(Type = typeof(PlayableAssetSay), Member = "TryGetCurrentTimelineTimeFromAudio")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "UpdateActive")]
	[CalledBy(Type = typeof(CinematicManager), Member = "TryGetTimeFromAudio")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "UpdatePlayback")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(CinematicTrack), Member = "UpdateAudioAndMaybeAnimationTime")]
	public static AKRESULT GetSourcePlayPosition(uint in_PlayingID, out int out_puPosition)
	{
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref out_puPosition) = null;
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT GetSourceStreamBuffering(uint in_PlayingID, out int out_buffering, out int out_bIsBuffering)
	{
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref out_buffering) = null;
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref out_bIsBuffering) = null;
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	public static void StopAll(GameObject in_gameObjectID)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(AkWwiseInitializationSettings), Member = "TerminateSoundEngine")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(GameAudioManager), Member = "StopAll")]
	public static void StopAll()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void StopPlayingID(uint in_playingID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 147)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void StopPlayingID(uint in_playingID, int in_uTransitionDuration)
	{
	}

	[CalledBy(Type = typeof(FlashlightItem), Member = "UpdateAudio")]
	[CalledBy(Type = typeof(Fire), Member = "StopFireLoopImmediate")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Wind), Member = "ForceStopAudioLoop")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "StartInspectMode")]
	[CalledBy(Type = typeof(CustomAudioEmitter), Member = "Enable")]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(EmergencyStim), Member = "ApplyEmergencyStimExitEffects")]
	[CalledBy(Type = typeof(AmbientEmitter), Member = "OnDestroy")]
	public static void StopPlayingID(uint in_playingID)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void SetRandomSeed(uint in_uSeed)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void MuteBackgroundMusic(bool in_bMute)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static bool GetBackgroundMusicMute()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static AKRESULT SendPluginCustomGameData(uint in_busID, GameObject in_busObjectID, AkPluginType in_eType, uint in_uCompanyID, uint in_uPluginID, IntPtr in_pData, uint in_uSizeInBytes)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT UnregisterAllGameObj()
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[CalledBy(Type = typeof(AkAmbient), Member = "OnEnable")]
	[CalledBy(Type = typeof(AkAmbient), Member = "OnDisable")]
	[CallsUnknownMethods(Count = 2)]
	public static AKRESULT SetMultiplePositions(GameObject in_GameObjectID, AkPositionArray in_pPositions, ushort in_NumPositions, AkMultiPositionType in_eMultiPositionType)
	{
		return default(AKRESULT);
	}

	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static AKRESULT SetMultiplePositions(GameObject in_GameObjectID, AkPositionArray in_pPositions, ushort in_NumPositions)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[CallsUnknownMethods(Count = 2)]
	public static AKRESULT SetMultiplePositions(GameObject in_GameObjectID, AkChannelEmitterArray in_pPositions, ushort in_NumPositions, AkMultiPositionType in_eMultiPositionType)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[CallsUnknownMethods(Count = 2)]
	public static AKRESULT SetMultiplePositions(GameObject in_GameObjectID, AkChannelEmitterArray in_pPositions, ushort in_NumPositions)
	{
		return default(AKRESULT);
	}

	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT SetScalingFactor(GameObject in_GameObjectID, float in_fAttenuationScalingFactor)
	{
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(AkWwiseInitializationSettings), Member = "TerminateSoundEngine")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(AkWwiseInitializationSettings), Member = "ResetSoundEngine")]
	public static AKRESULT ClearBanks()
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT SetBankLoadIOSettings(float in_fThroughput, char in_priority)
	{
		return default(AKRESULT);
	}

	[CalledBy(Type = typeof(AkBankManager.DecodableBankHandle), Member = "DoLoadBank")]
	[CalledBy(Type = typeof(AkWwiseInitializationSettings), Member = "LoadInitBank")]
	[CalledBy(Type = typeof(AkBankManager.BankHandle), Member = "DoLoadBank")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(SoundbankLoader), Member = "TryLoadSoundbankByName")]
	public static AKRESULT LoadBank(string in_pszString, int in_memPoolId, out uint out_bankID)
	{
		System.Runtime.CompilerServices.Unsafe.As<uint, @null>(ref out_bankID) = null;
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static AKRESULT LoadBank(uint in_bankID, int in_memPoolId)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT LoadBank(IntPtr in_pInMemoryBankPtr, uint in_uInMemoryBankSize, out uint out_bankID)
	{
		System.Runtime.CompilerServices.Unsafe.As<uint, @null>(ref out_bankID) = null;
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT LoadBank(IntPtr in_pInMemoryBankPtr, uint in_uInMemoryBankSize, int in_uPoolForBankMedia, out uint out_bankID)
	{
		System.Runtime.CompilerServices.Unsafe.As<uint, @null>(ref out_bankID) = null;
		return default(AKRESULT);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AkCallbackManager.BankCallbackPackage), Member = ".ctor")]
	[CalledBy(Type = typeof(AkBankManager.AsyncBankHandle), Member = "DoLoadBank")]
	[CallsUnknownMethods(Count = 8)]
	public static AKRESULT LoadBank(string in_pszString, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, int in_memPoolId, out uint out_bankID)
	{
		System.Runtime.CompilerServices.Unsafe.As<uint, @null>(ref out_bankID) = null;
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(AkCallbackManager.BankCallbackPackage), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public static AKRESULT LoadBank(uint in_bankID, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, int in_memPoolId)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AkCallbackManager.BankCallbackPackage), Member = ".ctor")]
	[CallsUnknownMethods(Count = 8)]
	public static AKRESULT LoadBank(IntPtr in_pInMemoryBankPtr, uint in_uInMemoryBankSize, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, out uint out_bankID)
	{
		System.Runtime.CompilerServices.Unsafe.As<uint, @null>(ref out_bankID) = null;
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AkCallbackManager.BankCallbackPackage), Member = ".ctor")]
	[CallsUnknownMethods(Count = 8)]
	public static AKRESULT LoadBank(IntPtr in_pInMemoryBankPtr, uint in_uInMemoryBankSize, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, int in_uPoolForBankMedia, out uint out_bankID)
	{
		System.Runtime.CompilerServices.Unsafe.As<uint, @null>(ref out_bankID) = null;
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT UnloadBank(string in_pszString, IntPtr in_pInMemoryBankPtr, out int out_pMemPoolId)
	{
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref out_pMemPoolId) = null;
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static AKRESULT UnloadBank(string in_pszString, IntPtr in_pInMemoryBankPtr)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT UnloadBank(uint in_bankID, IntPtr in_pInMemoryBankPtr, out int out_pMemPoolId)
	{
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref out_pMemPoolId) = null;
		return default(AKRESULT);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(SoundbankLoader), Member = "TryUnloadSoundbank")]
	[CalledBy(Type = typeof(AkMemBankLoader), Member = "OnDestroy")]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT UnloadBank(uint in_bankID, IntPtr in_pInMemoryBankPtr)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AkCallbackManager.BankCallbackPackage), Member = ".ctor")]
	[CallsUnknownMethods(Count = 8)]
	public static AKRESULT UnloadBank(string in_pszString, IntPtr in_pInMemoryBankPtr, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie)
	{
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(AkBankManager.DecodableBankHandle), Member = "UnloadBank")]
	[CalledBy(Type = typeof(AkBankManager.BankHandle), Member = "UnloadBank")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AkCallbackManager.BankCallbackPackage), Member = ".ctor")]
	public static AKRESULT UnloadBank(uint in_bankID, IntPtr in_pInMemoryBankPtr, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkCallbackManager), Member = "RemoveBankCallback")]
	public static void CancelBankCallbackCookie(object in_pCookie)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, string in_pszString, AkBankContent in_uFlags)
	{
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, string in_pszString)
	{
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, uint in_bankID, AkBankContent in_uFlags)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, uint in_bankID)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AkCallbackManager.BankCallbackPackage), Member = ".ctor")]
	[CallsUnknownMethods(Count = 8)]
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, string in_pszString, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, AkBankContent in_uFlags)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AkCallbackManager.BankCallbackPackage), Member = ".ctor")]
	[CallsUnknownMethods(Count = 8)]
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, string in_pszString, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie)
	{
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(AkCallbackManager.BankCallbackPackage), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, uint in_bankID, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, AkBankContent in_uFlags)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AkCallbackManager.BankCallbackPackage), Member = ".ctor")]
	[CallsUnknownMethods(Count = 8)]
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, uint in_bankID, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT ClearPreparedEvents()
	{
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Buffer), Member = "Memcpy")]
	[Calls(Type = typeof(Marshal), Member = "Copy")]
	[Calls(Type = typeof(string), Member = "ToCharArray")]
	[Calls(Type = typeof(Buffer), Member = "Memcpy")]
	[Calls(Type = typeof(Marshal), Member = "AllocHGlobal")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public static AKRESULT PrepareEvent(AkPreparationType in_PreparationType, string[] in_ppszString, uint in_uNumEvent)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT PrepareEvent(AkPreparationType in_PreparationType, uint[] in_pEventID, uint in_uNumEvent)
	{
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(AkCallbackManager.BankCallbackPackage), Member = ".ctor")]
	[Calls(Type = typeof(Marshal), Member = "Copy")]
	[Calls(Type = typeof(string), Member = "ToCharArray")]
	[Calls(Type = typeof(Buffer), Member = "Memcpy")]
	[Calls(Type = typeof(Marshal), Member = "AllocHGlobal")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Buffer), Member = "Memcpy")]
	public static AKRESULT PrepareEvent(AkPreparationType in_PreparationType, string[] in_ppszString, uint in_uNumEvent, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AkCallbackManager.BankCallbackPackage), Member = ".ctor")]
	[CallsUnknownMethods(Count = 8)]
	public static AKRESULT PrepareEvent(AkPreparationType in_PreparationType, uint[] in_pEventID, uint in_uNumEvent, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static AKRESULT SetMedia(AkSourceSettingsArray in_pSourceSettings, uint in_uNumSourceSettings)
	{
		return default(AKRESULT);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static AKRESULT UnsetMedia(AkSourceSettingsArray in_pSourceSettings, uint in_uNumSourceSettings)
	{
		return default(AKRESULT);
	}

	[Calls(Type = typeof(Marshal), Member = "Copy")]
	[Calls(Type = typeof(Buffer), Member = "Memcpy")]
	[Calls(Type = typeof(string), Member = "ToCharArray")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Marshal), Member = "AllocHGlobal")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Buffer), Member = "Memcpy")]
	public static AKRESULT PrepareGameSyncs(AkPreparationType in_PreparationType, AkGroupType in_eGameSyncType, string in_pszGroupName, string[] in_ppszGameSyncName, uint in_uNumGameSyncs)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT PrepareGameSyncs(AkPreparationType in_PreparationType, AkGroupType in_eGameSyncType, uint in_GroupID, uint[] in_paGameSyncID, uint in_uNumGameSyncs)
	{
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(AkCallbackManager.BankCallbackPackage), Member = ".ctor")]
	[Calls(Type = typeof(Buffer), Member = "Memcpy")]
	[Calls(Type = typeof(Marshal), Member = "Copy")]
	[Calls(Type = typeof(string), Member = "ToCharArray")]
	[Calls(Type = typeof(Buffer), Member = "Memcpy")]
	[Calls(Type = typeof(Marshal), Member = "AllocHGlobal")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	public static AKRESULT PrepareGameSyncs(AkPreparationType in_PreparationType, AkGroupType in_eGameSyncType, string in_pszGroupName, string[] in_ppszGameSyncName, uint in_uNumGameSyncs, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AkCallbackManager.BankCallbackPackage), Member = ".ctor")]
	[CallsUnknownMethods(Count = 8)]
	public static AKRESULT PrepareGameSyncs(AkPreparationType in_PreparationType, AkGroupType in_eGameSyncType, uint in_GroupID, uint[] in_paGameSyncID, uint in_uNumGameSyncs, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie)
	{
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(AkGameObjListenerList), Member = "SetUseDefaultListeners")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[CalledBy(Type = typeof(AkGameObjListenerList), Member = "Add")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallerCount(Count = 2)]
	public static AKRESULT AddListener(GameObject in_emitterGameObj, GameObject in_listenerGameObj)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT RemoveListener(GameObject in_emitterGameObj, GameObject in_listenerGameObj)
	{
		return default(AKRESULT);
	}

	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static AKRESULT AddDefaultListener(GameObject in_listenerGameObj)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT RemoveDefaultListener(GameObject in_listenerGameObj)
	{
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(AkGameObjListenerList), Member = "Refresh")]
	[CalledBy(Type = typeof(AkGameObjListenerList), Member = "SetUseDefaultListeners")]
	[CalledBy(Type = typeof(AkGameObj), Member = "MaybeUpdateAuxValues")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	public static AKRESULT ResetListenersToDefault(GameObject in_emitterGameObj)
	{
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(Type = typeof(AkChannelConfig), Member = "getCPtr")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[CallerCount(Count = 0)]
	public static AKRESULT SetListenerSpatialization(GameObject in_uListenerID, bool in_bSpatialized, AkChannelConfig in_channelConfig, float[] in_pVolumeOffsets)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(Type = typeof(AkChannelConfig), Member = "getCPtr")]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT SetListenerSpatialization(GameObject in_uListenerID, bool in_bSpatialized, AkChannelConfig in_channelConfig)
	{
		return default(AKRESULT);
	}

	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static AKRESULT SetRTPCValue(uint in_rtpcID, float in_value, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT SetRTPCValue(uint in_rtpcID, float in_value, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT SetRTPCValue(uint in_rtpcID, float in_value, GameObject in_gameObjectID, int in_uValueChangeDuration)
	{
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(RTPC), Member = "SetValue")]
	[CalledBy(Type = typeof(AkRTPCPlayableBehaviour), Member = "ProcessFrame")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "SetOutdoorEnvironmentSwitch")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(GameAudioManager), Member = "SetIndoorEnvironmentSwitch")]
	public static AKRESULT SetRTPCValue(uint in_rtpcID, float in_value, GameObject in_gameObjectID)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT SetRTPCValue(uint in_rtpcID, float in_value)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation)
	{
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value, GameObject in_gameObjectID, int in_uValueChangeDuration)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value, GameObject in_gameObjectID)
	{
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value)
	{
		return default(AKRESULT);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static AKRESULT SetRTPCValueByPlayingID(uint in_rtpcID, float in_value, uint in_playingID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT SetRTPCValueByPlayingID(uint in_rtpcID, float in_value, uint in_playingID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT SetRTPCValueByPlayingID(uint in_rtpcID, float in_value, uint in_playingID, int in_uValueChangeDuration)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT SetRTPCValueByPlayingID(uint in_rtpcID, float in_value, uint in_playingID)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT SetRTPCValueByPlayingID(string in_pszRtpcName, float in_value, uint in_playingID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation)
	{
		return default(AKRESULT);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static AKRESULT SetRTPCValueByPlayingID(string in_pszRtpcName, float in_value, uint in_playingID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT SetRTPCValueByPlayingID(string in_pszRtpcName, float in_value, uint in_playingID, int in_uValueChangeDuration)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT SetRTPCValueByPlayingID(string in_pszRtpcName, float in_value, uint in_playingID)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT ResetRTPCValue(uint in_rtpcID, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation)
	{
		return default(AKRESULT);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	public static AKRESULT ResetRTPCValue(uint in_rtpcID, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT ResetRTPCValue(uint in_rtpcID, GameObject in_gameObjectID, int in_uValueChangeDuration)
	{
		return default(AKRESULT);
	}

	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT ResetRTPCValue(uint in_rtpcID, GameObject in_gameObjectID)
	{
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static AKRESULT ResetRTPCValue(uint in_rtpcID)
	{
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	public static AKRESULT ResetRTPCValue(string in_pszRtpcName, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation)
	{
		return default(AKRESULT);
	}

	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT ResetRTPCValue(string in_pszRtpcName, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve)
	{
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	public static AKRESULT ResetRTPCValue(string in_pszRtpcName, GameObject in_gameObjectID, int in_uValueChangeDuration)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT ResetRTPCValue(string in_pszRtpcName, GameObject in_gameObjectID)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT ResetRTPCValue(string in_pszRtpcName)
	{
		return default(AKRESULT);
	}

	[CalledBy(Type = typeof(GameAudioManager), Member = "SetIndoorEnvironmentSwitch")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "SetOutdoorEnvironmentSwitch")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "SetSwearFilterSwitchOnEmitter")]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybePlayInspectModeVoiceOver")]
	[CalledBy(Type = typeof(Switch), Member = "SetValue")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "SetPlayerVoicePersona")]
	[CalledBy(Type = typeof(AkSwitch), Member = "HandleEvent")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "SetCramponsSwitch")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerVoice), Member = "SetPlayerVoicePersona")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "SetFootwearSwitch")]
	[CalledBy(Type = typeof(PlayerManager), Member = "SetSoundSwitch")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "SetCuttingToolSwitch")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "SetMaterialSwitch")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "SetCookingSlotSwitch")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAccessibilityOptions")]
	[CalledBy(Type = typeof(Fire), Member = "PlayStartingFireVoiceEvent")]
	[CalledBy(Type = typeof(Condition), Member = "MaybePlayPlayerInjuredVoiceOver")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 18)]
	[CalledBy(Type = typeof(GameAudioManager), Member = "SetWeaponTypeSwitch")]
	public static AKRESULT SetSwitch(uint in_switchGroup, uint in_switchState, GameObject in_gameObjectID)
	{
		return default(AKRESULT);
	}

	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static AKRESULT SetSwitch(string in_pszSwitchGroup, string in_pszSwitchState, GameObject in_gameObjectID)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT PostTrigger(uint in_triggerID, GameObject in_gameObjectID)
	{
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	public static AKRESULT PostTrigger(string in_pszTrigger, GameObject in_gameObjectID)
	{
		return default(AKRESULT);
	}

	[CalledBy(Type = typeof(GameAudioManager), Member = "SetNoOcclusion")]
	[CalledBy(Type = typeof(AkState), Member = "HandleEvent")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "SendWeatherStateToWise")]
	[CalledBy(Type = typeof(GameManager), Member = "SetAudioModeForLoadedScene")]
	[CalledBy(Type = typeof(GameManager), Member = "SetAudioModeForLoadedScene")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "SetMildOcclusion")]
	[CalledBy(Type = typeof(State), Member = "SetValue")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "SetHeavyOcclusion")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "UpdateAudioOcclusion")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAccessibilityOptions")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(GameAudioManager), Member = "SetMediumOcclusion")]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT SetState(uint in_stateGroup, uint in_state)
	{
		return default(AKRESULT);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT SetState(string in_pszStateGroup, string in_pszState)
	{
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_SetGameObjectAuxSendValues")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[CallerCount(Count = 0)]
	public static AKRESULT SetGameObjectAuxSendValues(GameObject in_gameObjectID, AkAuxSendArray in_aAuxSendValues, uint in_uNumSendValues)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT SetGameObjectOutputBusVolume(GameObject in_emitterObjID, GameObject in_listenerObjID, float in_fControlValue)
	{
		return default(AKRESULT);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static AKRESULT SetActorMixerEffect(uint in_audioNodeID, uint in_uFXIndex, uint in_shareSetID)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT SetBusEffect(uint in_audioNodeID, uint in_uFXIndex, uint in_shareSetID)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT SetBusEffect(string in_pszBusName, uint in_uFXIndex, uint in_shareSetID)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT SetMixer(uint in_audioNodeID, uint in_shareSetID)
	{
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static AKRESULT SetMixer(string in_pszBusName, uint in_shareSetID)
	{
		return default(AKRESULT);
	}

	[Calls(Type = typeof(AkChannelConfig), Member = "getCPtr")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static AKRESULT SetBusConfig(uint in_audioNodeID, AkChannelConfig in_channelConfig)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkChannelConfig), Member = "getCPtr")]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT SetBusConfig(string in_pszBusName, AkChannelConfig in_channelConfig)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT SetObjectObstructionAndOcclusion(GameObject in_EmitterID, GameObject in_ListenerID, float in_fObstructionLevel, float in_fOcclusionLevel)
	{
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	public static AKRESULT SetMultipleObstructionAndOcclusion(GameObject in_EmitterID, GameObject in_uListenerID, AkObstructionOcclusionValuesArray in_fObstructionOcclusionValues, uint in_uNumOcclusionObstruction)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT StartOutputCapture(string in_CaptureFileName)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT StopOutputCapture()
	{
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	public static AKRESULT AddOutputCaptureMarker(string in_MarkerText)
	{
		return default(AKRESULT);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static AKRESULT StartProfilerCapture(string in_CaptureFileName)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT StopProfilerCapture()
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT RemoveOutput(ulong in_idOutput)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static ulong GetOutputID(uint in_idShareset, uint in_idDevice)
	{
		return default(ulong);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	public static ulong GetOutputID(string in_szShareSet, uint in_idDevice)
	{
		return default(ulong);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static AKRESULT SetBusDevice(uint in_idBus, uint in_idNewDevice)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_SetBusDevice__SWIG_1")]
	public static AKRESULT SetBusDevice(string in_BusName, string in_DeviceName)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT SetOutputVolume(ulong in_idOutput, float in_fVolume)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT Suspend(bool in_bRenderAnyway)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT Suspend()
	{
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static AKRESULT WakeupFromSuspend()
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static uint GetBufferTick()
	{
		return default(uint);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSegmentInfo), Member = "getCPtr")]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT GetPlayingSegmentInfo(uint in_PlayingID, AkSegmentInfo out_segmentInfo, bool in_bExtrapolate)
	{
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AkSegmentInfo), Member = "getCPtr")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static AKRESULT GetPlayingSegmentInfo(uint in_PlayingID, AkSegmentInfo out_segmentInfo)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, GameObject in_gameObjID, uint in_audioNodeID, bool in_bIsBus)
	{
		return default(AKRESULT);
	}

	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, GameObject in_gameObjID, uint in_audioNodeID)
	{
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, GameObject in_gameObjID)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, GameObject in_gameObjID, uint in_audioNodeID, bool in_bIsBus)
	{
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	public static AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, GameObject in_gameObjID, uint in_audioNodeID)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, GameObject in_gameObjID)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID)
	{
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel)
	{
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static int GetTimeStamp()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static uint GetNumNonZeroBits(uint in_uWord)
	{
		return default(uint);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkThreadProperties), Member = "getCPtr")]
	[CallsUnknownMethods(Count = 1)]
	public static void AkGetDefaultHighPriorityThreadProperties(AkThreadProperties out_threadProperties)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static uint ResolveDialogueEvent(uint in_eventID, uint[] in_aArgumentValues, uint in_uNumArguments, uint in_idSequence)
	{
		return default(uint);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static uint ResolveDialogueEvent(uint in_eventID, uint[] in_aArgumentValues, uint in_uNumArguments)
	{
		return default(uint);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT GetDialogueEventCustomPropertyValue(uint in_eventID, uint in_uPropID, out int out_iValue)
	{
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref out_iValue) = null;
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT GetDialogueEventCustomPropertyValue(uint in_eventID, uint in_uPropID, out float out_fValue)
	{
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref out_fValue) = null;
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkTransform), Member = "getCPtr")]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT GetPosition(GameObject in_GameObjectID, AkTransform out_rPosition)
	{
		return default(AKRESULT);
	}

	[Calls(Type = typeof(AkTransform), Member = "getCPtr")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	public static AKRESULT GetListenerPosition(GameObject in_uIndex, AkTransform out_rPosition)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT GetRTPCValue(uint in_rtpcID, GameObject in_gameObjectID, uint in_playingID, out float out_rValue, ref int io_rValueType)
	{
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref out_rValue) = null;
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT GetRTPCValue(string in_pszRtpcName, GameObject in_gameObjectID, uint in_playingID, out float out_rValue, ref int io_rValueType)
	{
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref out_rValue) = null;
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	public static AKRESULT GetSwitch(uint in_switchGroup, GameObject in_gameObjectID, out uint out_rSwitchState)
	{
		System.Runtime.CompilerServices.Unsafe.As<uint, @null>(ref out_rSwitchState) = null;
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT GetSwitch(string in_pstrSwitchGroupName, GameObject in_GameObj, out uint out_rSwitchState)
	{
		System.Runtime.CompilerServices.Unsafe.As<uint, @null>(ref out_rSwitchState) = null;
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static AKRESULT GetState(uint in_stateGroup, out uint out_rState)
	{
		System.Runtime.CompilerServices.Unsafe.As<uint, @null>(ref out_rState) = null;
		return default(AKRESULT);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static AKRESULT GetState(string in_pstrStateGroupName, out uint out_rState)
	{
		System.Runtime.CompilerServices.Unsafe.As<uint, @null>(ref out_rState) = null;
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_GetGameObjectAuxSendValues")]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT GetGameObjectAuxSendValues(GameObject in_gameObjectID, AkAuxSendArray out_paAuxSendValues, ref uint io_ruNumSendValues)
	{
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	public static AKRESULT GetGameObjectDryLevelValue(GameObject in_EmitterID, GameObject in_ListenerID, out float out_rfControlValue)
	{
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref out_rfControlValue) = null;
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT GetObjectObstructionAndOcclusion(GameObject in_EmitterID, GameObject in_ListenerID, out float out_rfObstructionLevel, out float out_rfOcclusionLevel)
	{
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref out_rfObstructionLevel) = null;
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref out_rfOcclusionLevel) = null;
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static AKRESULT QueryAudioObjectIDs(uint in_eventID, ref uint io_ruNumItems, AkObjectInfoArray out_aObjectInfos)
	{
		return default(AKRESULT);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public static AKRESULT QueryAudioObjectIDs(string in_pszEventName, ref uint io_ruNumItems, AkObjectInfoArray out_aObjectInfos)
	{
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static AKRESULT GetPositioningInfo(uint in_ObjectID, AkPositioningInfo out_rPositioningInfo)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallsUnknownMethods(Count = 1)]
	public static bool GetIsGameObjectActive(GameObject in_GameObjId)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallsUnknownMethods(Count = 1)]
	public static float GetMaxRadius(GameObject in_GameObjId)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static uint GetEventIDFromPlayingID(uint in_playingID)
	{
		return default(uint);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static ulong GetGameObjectFromPlayingID(uint in_playingID)
	{
		return default(ulong);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallsUnknownMethods(Count = 2)]
	public static AKRESULT GetPlayingIDsFromGameObject(GameObject in_GameObjId, ref uint io_ruNumIDs, uint[] out_aPlayingIDs)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT GetCustomPropertyValue(uint in_ObjectID, uint in_uPropID, out int out_iValue)
	{
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref out_iValue) = null;
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static AKRESULT GetCustomPropertyValue(uint in_ObjectID, uint in_uPropID, out float out_fValue)
	{
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref out_fValue) = null;
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void AK_SPEAKER_SETUP_FIX_LEFT_TO_CENTER(ref uint io_uChannelMask)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void AK_SPEAKER_SETUP_FIX_REAR_TO_SIDE(ref uint io_uChannelMask)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void AK_SPEAKER_SETUP_CONVERT_TO_SUPPORTED(ref uint io_uChannelMask)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static byte ChannelMaskToNumChannels(uint in_uChannelMask)
	{
		return default(byte);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static uint ChannelMaskFromNumChannels(uint in_uNumChannels)
	{
		return default(uint);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static byte ChannelBitToIndex(uint in_uChannelBit, uint in_uChannelMask)
	{
		return default(byte);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static bool HasSurroundChannels(uint in_uChannelMask)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static bool HasStrictlyOnePairOfSurroundChannels(uint in_uChannelMask)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static bool HasSideAndRearChannels(uint in_uChannelMask)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static bool HasHeightChannels(uint in_uChannelMask)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static uint BackToSideChannels(uint in_uChannelMask)
	{
		return default(uint);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static uint StdChannelIndexToDisplayIndex(AkChannelOrdering in_eOrdering, uint in_uChannelMask, uint in_uChannelIdx)
	{
		return default(uint);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static int GetPoolID()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT RegisterEmitter(GameObject in_gameObjectID, AkEmitterSettings in_settings)
	{
		return default(AKRESULT);
	}

	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static AKRESULT UnregisterEmitter(GameObject in_gameObjectID)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallsUnknownMethods(Count = 2)]
	public static AKRESULT SetEmitterAuxSendValues(GameObject in_gameObjectID, AkAuxSendArray in_pAuxSends, uint in_uNumAux)
	{
		return default(AKRESULT);
	}

	[Calls(Type = typeof(AkImageSourceSettings), Member = "getCPtr")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static AKRESULT SetImageSource(uint in_srcID, AkImageSourceSettings in_info, uint in_AuxBusID, ulong in_roomID, GameObject in_gameObjectID)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkImageSourceSettings), Member = "getCPtr")]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT SetImageSource(uint in_srcID, AkImageSourceSettings in_info, uint in_AuxBusID, ulong in_roomID)
	{
		return default(AKRESULT);
	}

	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static AKRESULT RemoveImageSource(uint in_srcID, uint in_AuxBusID, GameObject in_gameObjectID)
	{
		return default(AKRESULT);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static AKRESULT RemoveImageSource(uint in_srcID, uint in_AuxBusID)
	{
		return default(AKRESULT);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static AKRESULT RemoveGeometry(ulong in_SetID)
	{
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(AkVector), Member = "getCPtr")]
	[Calls(Type = typeof(AkVector), Member = "getCPtr")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	public static AKRESULT QueryReflectionPaths(GameObject in_gameObjectID, AkVector out_listenerPos, AkVector out_emitterPos, AkReflectionPathInfoArray out_aPaths, out uint io_uArraySize)
	{
		System.Runtime.CompilerServices.Unsafe.As<uint, @null>(ref io_uArraySize) = null;
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT RemoveRoom(ulong in_RoomID)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT RemovePortal(ulong in_PortalID)
	{
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static AKRESULT SetGameObjectInRoom(GameObject in_gameObjectID, ulong in_CurrentRoomID)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT SetEmitterObstructionAndOcclusion(GameObject in_gameObjectID, float in_fObstruction, float in_fOcclusion)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT SetPortalObstructionAndOcclusion(ulong in_PortalID, float in_fObstruction, float in_fOcclusion)
	{
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static void SetErrorLogger(AkLogger.ErrorLoggerInteropDelegate logger)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void SetErrorLogger()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static void SetAudioInputCallbacks(AkAudioInputManager.AudioSamplesInteropDelegate getAudioSamples, AkAudioInputManager.AudioFormatInteropDelegate getAudioFormat)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT Init(AkInitializationSettings settings)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT InitSpatialAudio(AkSpatialAudioInitSettings settings)
	{
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkCommunicationSettings), Member = "getCPtr")]
	public static AKRESULT InitCommunication(AkCommunicationSettings settings)
	{
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(AkWwiseInitializationSettings), Member = "TerminateSoundEngine")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(AkWwiseInitializationSettings), Member = "InitializeSoundEngine")]
	public static void Term()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_RegisterGameObjInternal")]
	public static AKRESULT RegisterGameObjInternal(GameObject in_GameObj)
	{
		return default(AKRESULT);
	}

	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_UnregisterGameObjInternal")]
	public static AKRESULT UnregisterGameObjInternal(GameObject in_GameObj)
	{
		return default(AKRESULT);
	}

	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_RegisterGameObjInternal_WithName")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static AKRESULT RegisterGameObjInternal_WithName(GameObject in_GameObj, string in_pszObjName)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(AkBankManager.DecodableBankHandle), Member = "DoLoadBank")]
	[CalledBy(Type = typeof(AkBankManager.DecodableBankHandle), Member = "DoLoadBank")]
	[CalledBy(Type = typeof(AkWwiseInitializationSettings), Member = "InitializeSoundEngine")]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT SetBasePath(string in_pszBasePath)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT SetCurrentLanguage(string in_pszAudioSrcPath)
	{
		return default(AKRESULT);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static AKRESULT LoadFilePackage(string in_pszFilePackageName, out uint out_uPackageID, int in_memPoolID)
	{
		System.Runtime.CompilerServices.Unsafe.As<uint, @null>(ref out_uPackageID) = null;
		return default(AKRESULT);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(AkWwiseInitializationSettings), Member = "InitializeSoundEngine")]
	[CalledBy(Type = typeof(AkWwiseInitializationSettings), Member = "InitializeSoundEngine")]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT AddBasePath(string in_pszBasePath)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT SetGameName(string in_GameName)
	{
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static AKRESULT SetDecodedBankPath(string in_DecodedPath)
	{
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static AKRESULT LoadAndDecodeBank(string in_pszString, bool in_bSaveDecodedBank, out uint out_bankID)
	{
		System.Runtime.CompilerServices.Unsafe.As<uint, @null>(ref out_bankID) = null;
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT LoadAndDecodeBankFromMemory(IntPtr in_BankData, uint in_BankDataSize, bool in_bSaveDecodedBank, string in_DecodedBankName, bool in_bIsLanguageSpecific, out uint out_bankID)
	{
		System.Runtime.CompilerServices.Unsafe.As<uint, @null>(ref out_bankID) = null;
		return default(AKRESULT);
	}

	[CalledBy(Type = typeof(AkMemBankLoader), Member = "LoadLocalizedBank")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StringFromIntPtrOSString")]
	[CalledBy(Type = typeof(AkBankManager.DecodableBankHandle), Member = ".ctor")]
	[CalledBy(Type = typeof(AkMemBankLoader), Member = "Start")]
	[CallsUnknownMethods(Count = 1)]
	public static string GetCurrentLanguage()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static AKRESULT UnloadFilePackage(uint in_uPackageID)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT UnloadAllFilePackages()
	{
		return default(AKRESULT);
	}

	[CalledBy(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_SetObjectPosition")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	public static AKRESULT SetObjectPosition(GameObject in_GameObjectID, float PosX, float PosY, float PosZ, float FrontX, float FrontY, float FrontZ, float TopX, float TopY, float TopZ)
	{
		return default(AKRESULT);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_GetSourceMultiplePlayPositions")]
	[CallerCount(Count = 0)]
	public static AKRESULT GetSourceMultiplePlayPositions(uint in_PlayingID, uint[] out_audioNodeID, uint[] out_mediaID, int[] out_msTime, ref uint io_pcPositions, bool in_bExtrapolate)
	{
		return default(AKRESULT);
	}

	[CalledBy(Type = typeof(AkGameObjListenerList), Member = "Init")]
	[CalledBy(Type = typeof(AkGameObjListenerList), Member = "SetUseDefaultListeners")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(AkGameObj), Member = "MaybeUpdateAuxValues")]
	[CalledBy(Type = typeof(AkGameObjListenerList), Member = "Refresh")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallerCount(Count = 4)]
	public static AKRESULT SetListeners(GameObject in_emitterGameObj, ulong[] in_pListenerGameObjs, uint in_uNumListeners)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT SetDefaultListeners(ulong[] in_pListenerObjs, uint in_uNumListeners)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkOutputSettings), Member = "getCPtr")]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT AddOutput(AkOutputSettings in_Settings, out ulong out_pDeviceID, ulong[] in_pListenerIDs, uint in_uNumListeners)
	{
		System.Runtime.CompilerServices.Unsafe.As<ulong, @null>(ref out_pDeviceID) = null;
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AkStreamMgrSettings), Member = "getCPtr")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void GetDefaultStreamSettings(AkStreamMgrSettings out_settings)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkDeviceSettings), Member = "getCPtr")]
	[CallsUnknownMethods(Count = 1)]
	public static void GetDefaultDeviceSettings(AkDeviceSettings out_settings)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkMusicSettings), Member = "getCPtr")]
	[CallsUnknownMethods(Count = 1)]
	public static void GetDefaultMusicSettings(AkMusicSettings out_settings)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkInitSettings), Member = "getCPtr")]
	public static void GetDefaultInitSettings(AkInitSettings out_settings)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AkPlatformInitSettings), Member = "getCPtr")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void GetDefaultPlatformInitSettings(AkPlatformInitSettings out_settings)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static uint GetMajorMinorVersion()
	{
		return default(uint);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static uint GetSubminorBuildVersion()
	{
		return default(uint);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static uint GetDeviceIDFromName(string in_szToken)
	{
		return default(uint);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StringFromIntPtrWString")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static string GetWindowsDeviceName(int index, out uint out_uDeviceID)
	{
		System.Runtime.CompilerServices.Unsafe.As<uint, @null>(ref out_uDeviceID) = null;
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(Type = typeof(AkPathParams), Member = "getCPtr")]
	[CallsUnknownMethods(Count = 2)]
	public static AKRESULT QueryIndirectPaths(GameObject in_gameObjectID, AkPathParams arg1, AkReflectionPathInfoArray paths, uint numPaths)
	{
		return default(AKRESULT);
	}

	[Calls(Type = typeof(AkPathParams), Member = "getCPtr")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallsUnknownMethods(Count = 2)]
	public static AKRESULT QuerySoundPropagationPaths(GameObject in_gameObjectID, AkPathParams arg1, AkPropagationPathInfoArray paths, uint numPaths)
	{
		return default(AKRESULT);
	}

	[Calls(Type = typeof(AkPathParams), Member = "getCPtr")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static AKRESULT QueryDiffractionPaths(GameObject in_gameObjectID, AkPathParams arg1, AkDiffractionPathInfoArray paths, uint numPaths)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkTransform), Member = "getCPtr")]
	[Calls(Type = typeof(AkVector), Member = "getCPtr")]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT SetRoomPortal(ulong in_PortalID, AkTransform Transform, AkVector Extent, bool bEnabled, ulong FrontRoom, ulong BackRoom)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CalledBy(Type = typeof(AkRoom), Member = "OnEnable")]
	[CallsUnknownMethods(Count = 4)]
	public static AKRESULT SetRoom(ulong in_RoomID, AkRoomParams in_roomParams, string in_pName)
	{
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static AKRESULT RegisterSpatialAudioListener(GameObject in_gameObjectID)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CalledBy(Type = typeof(AkSpatialAudioListener.SpatialAudioListenerList), Member = "Refresh")]
	[CalledBy(Type = typeof(AkSpatialAudioListener.SpatialAudioListenerList), Member = "Refresh")]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT UnregisterSpatialAudioListener(GameObject in_gameObjectID)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static AKRESULT SetGeometry(ulong in_GeomSetID, AkTriangleArray Triangles, uint NumTriangles, AkVertexArray Vertices, uint NumVertices, AkAcousticSurfaceArray Surfaces, uint NumSurfaces, bool EnableDiffraction, bool EnableDiffractionOnBoundaryEdges)
	{
		return default(AKRESULT);
	}

	[CalledBy(Type = typeof(AkMusicSyncCallbackInfo), Member = "get_userCueName")]
	[CalledBy(Type = typeof(AkCommunicationSettings), Member = "get_szAppNetworkName")]
	[CalledBy(Type = typeof(AkMarkerCallbackInfo), Member = "get_strLabel")]
	[CalledBy(Type = typeof(AkAcousticSurface), Member = "get_strName")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	public static string StringFromIntPtrString(IntPtr ptr)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(AkSoundEngine), Member = "GetWindowsDeviceName")]
	[CalledBy(Type = typeof(AkSoundEngine), Member = "StringFromIntPtrOSString")]
	[CallsUnknownMethods(Count = 2)]
	public static string StringFromIntPtrWString(IntPtr ptr)
	{
		return null;
	}

	[CalledBy(Type = typeof(AkMonitoringCallbackInfo), Member = "get_message")]
	[CalledBy(Type = typeof(AkInitSettings), Member = "get_szPluginDLLPath")]
	[CalledBy(Type = typeof(AkExternalSourceInfo), Member = "get_szFile")]
	[CalledBy(Type = typeof(AkSoundEngine), Member = "GetCurrentLanguage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StringFromIntPtrWString")]
	public static string StringFromIntPtrOSString(IntPtr ptr)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	[CallsUnknownMethods(Count = 1)]
	private static ulong InternalGameObjectHash(GameObject gameObject)
	{
		return default(ulong);
	}

	[CallerCount(Count = 155)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static ulong GetAkGameObjectID(GameObject gameObject)
	{
		return default(ulong);
	}

	[Calls(Type = typeof(AkSoundEngine), Member = "PostRegisterGameObjUserHook")]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_RegisterGameObjInternal")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	public static AKRESULT RegisterGameObj(GameObject gameObject)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_RegisterGameObjInternal_WithName")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostRegisterGameObjUserHook")]
	[CalledBy(Type = typeof(AkSoundEngine), Member = "AutoRegister")]
	[CalledBy(Type = typeof(AutoObject), Member = ".ctor")]
	[CalledBy(Type = typeof(AkGameObj), Member = "Register")]
	public static AKRESULT RegisterGameObj(GameObject gameObject, string name)
	{
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(AutoObject), Member = "Finalize")]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_UnregisterGameObjInternal")]
	[CalledBy(Type = typeof(AkGameObj), Member = "OnDestroy")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	public static AKRESULT UnregisterGameObj(GameObject gameObject)
	{
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_SetObjectPosition")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	public static AKRESULT SetObjectPosition(GameObject gameObject, Transform transform)
	{
		return default(AKRESULT);
	}

	[CalledBy(Type = typeof(AkGameObj), Member = "MaybeUpdateObjectPosition")]
	[CalledBy(Type = typeof(AkGameObj), Member = "Awake")]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_SetObjectPosition")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	public static AKRESULT SetObjectPosition(GameObject gameObject, Vector3 position, Vector3 forward, Vector3 up)
	{
		return default(AKRESULT);
	}

	[Obsolete]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(AkExternalSourceInfoArray), Member = ".ctor")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsUnknownMethods(Count = 9)]
	public static uint PostEvent(uint eventId, GameObject gameObject, uint flags, AkCallbackManager.EventCallback callback, object cookie, uint numSources, AkExternalSourceInfo externalSources, uint playingId)
	{
		return default(uint);
	}

	[Calls(Type = typeof(AkExternalSourceInfoArray), Member = ".ctor")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Obsolete]
	public static uint PostEvent(uint eventId, GameObject gameObject, uint flags, AkCallbackManager.EventCallback callback, object cookie, uint numSources, AkExternalSourceInfo externalSources)
	{
		return default(uint);
	}

	[Obsolete]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(AkExternalSourceInfoArray), Member = ".ctor")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsUnknownMethods(Count = 9)]
	public static uint PostEvent(string eventName, GameObject gameObject, uint flags, AkCallbackManager.EventCallback callback, object cookie, uint numSources, AkExternalSourceInfo externalSources, uint playingId)
	{
		return default(uint);
	}

	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(AkExternalSourceInfoArray), Member = ".ctor")]
	[Obsolete]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallerCount(Count = 0)]
	public static uint PostEvent(string eventName, GameObject gameObject, uint flags, AkCallbackManager.EventCallback callback, object cookie, uint numSources, AkExternalSourceInfo externalSources)
	{
		return default(uint);
	}

	[CallerCount(Count = 132)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AkSoundEngine), Member = "IsInRegisteredList")]
	[Calls(Type = typeof(AkSoundEngine), Member = "IsInitialized")]
	[Calls(Type = typeof(AkSoundEngine), Member = "AutoRegister")]
	public static void PreGameObjectAPICall(GameObject gameObject, ulong id)
	{
	}

	[Calls(Type = typeof(AkSoundEngine), Member = "AutoRegister")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "IsInRegisteredList")]
	[Calls(Type = typeof(AkSoundEngine), Member = "IsInitialized")]
	private static void PreGameObjectAPICallUserHook(GameObject gameObject, ulong id)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(AkSoundEngine), Member = "RegisterGameObj")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(AkSoundEngine), Member = "RegisterGameObj")]
	private static void PostRegisterGameObjUserHook(AKRESULT result, GameObject gameObject, ulong id)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static void PostUnregisterGameObjUserHook(AKRESULT result, GameObject gameObject, ulong id)
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICallUserHook")]
	[CalledBy(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(Type = typeof(AkSoundEngine), Member = "RegisterGameObj")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private static void AutoRegister(GameObject gameObject, ulong id)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CalledBy(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICallUserHook")]
	[CalledBy(Type = typeof(AkSoundEngine), Member = "IsGameObjectRegistered")]
	[CallsUnknownMethods(Count = 13)]
	private static bool IsInRegisteredList(ulong id)
	{
		return default(bool);
	}

	[Calls(Type = typeof(AkSoundEngine), Member = "IsInRegisteredList")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static bool IsGameObjectRegistered(GameObject in_gameObject)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public AkSoundEngine()
	{
	}
}
