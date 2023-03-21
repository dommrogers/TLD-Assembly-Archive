using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using NodeCanvas.Tasks.Conditions;
using Steamworks;
using SuperSplines;
using TLD.AddressableAssets;
using TLD.Gameplay;
using TLD.Gear;
using TLD.Logging;
using TLD.News;
using TLD.SaveState;
using TLD.Scenes;
using TLD.Serialization;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Analytics;
using UnityEngine.Networking;
using UnityEngine.Playables;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class Utils : MonoBehaviour
{
	public enum GameOverResult
	{
		Failed,
		Success
	}

	public enum ExecuteCmdOptions
	{
		None,
		ReturnStandardOutput,
		LogErrorOutput
	}

	public delegate void ExecuteCmdCallback(string stdout);

	public enum SystemMetrics
	{
		MouseButtonsSwapped = 23
	}

	public struct OBB
	{
		public Vector3 c;

		public Vector3[] u;

		public Vector3 e;
	}

	private struct Coords
	{
		public int x;

		public int z;
	}

	private enum PatchHeightCheckState
	{
		NotChecked,
		Queued,
		Set
	}

	private struct FastSplineNode
	{
		public Vector3 m_Position;

		public Quaternion m_Rotation;

		public double m_PosInSpline;

		public double m_Length;

		[CallerCount(Count = 0)]
		public FastSplineNode(Vector3 pos, Quaternion rot)
		{
		}

		[CallerCount(Count = 0)]
		public void Reset()
		{
		}
	}

	public struct FastSpline
	{
		public struct LengthData
		{
			public NativeArray<double> m_SubSegmentLength;

			public NativeArray<double> m_SubSegmentPosition;

			public double m_Length;

			[CallerCount(Count = 1)]
			[CallsDeduplicatedMethods(Count = 2)]
			[Calls(Type = typeof(UnsafeUtility), Member = "Free")]
			[Calls(Type = typeof(UnsafeUtility), Member = "Free")]
			[CalledBy(Type = typeof(FastSpline), Member = "Dispose")]
			[CallsUnknownMethods(Count = 12)]
			public void Dispose()
			{
			}

			[CalledBy(Type = typeof(FastSpline), Member = "Allocate")]
			[CallAnalysisFailed]
			[CallerCount(Count = 1)]
			public void Calculate(ref FastSpline spline)
			{
			}

			[CallerCount(Count = 0)]
			private void SetupSplinePositions(ref FastSpline spline)
			{
			}
		}

		public enum TangentMode
		{
			UseNormalizedTangents,
			UseTangents,
			UseNodeForwardVector
		}

		public enum InterpolationMode
		{
			Hermite,
			Bezier,
			BSpline,
			Linear
		}

		public static readonly double[] HermiteMatrix;

		public static readonly double[] BezierMatrix;

		public static readonly double[] BSplineMatrix;

		public static readonly double[] LinearMatrix;

		public InterpolationMode m_InterpolationMode;

		public TangentMode m_TangentMode;

		public float m_Tension;

		public bool m_AutoClose;

		public int m_InterpolationAccuracy;

		private NativeArray<FastSplineNode> m_SplineNodesInternal;

		private NativeArray<double> m_SplineMatrix;

		public LengthData m_LengthData;

		public bool AutoClose
		{
			[CallerCount(Count = 0)]
			get
			{
				return default(bool);
			}
		}

		public int Step
		{
			[CallerCount(Count = 0)]
			get
			{
				return default(int);
			}
		}

		public int ControlNodeCount
		{
			[CallerCount(Count = 0)]
			get
			{
				return default(int);
			}
		}

		public double InvertedAccuracy
		{
			[CallerCount(Count = 0)]
			get
			{
				return default(double);
			}
		}

		private bool IsBezier
		{
			[CallerCount(Count = 0)]
			get
			{
				return default(bool);
			}
		}

		public bool HasNodes
		{
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			get
			{
				return default(bool);
			}
		}

		public int SegmentCount
		{
			[CallerCount(Count = 0)]
			get
			{
				return default(int);
			}
		}

		[CallerCount(Count = 0)]
		private FastSplineNode GetNode(int idxNode, int idxOffset)
		{
			return default(FastSplineNode);
		}

		[CallerCount(Count = 0)]
		public int MaxNodeIndex()
		{
			return default(int);
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FastSpline), Member = "GetPositionInternal")]
		[Calls(Type = typeof(FastSpline), Member = "GetPositionInternal")]
		[CallsUnknownMethods(Count = 1)]
		private double GetSegmentLengthInternal(int idxFirstPoint, double startValue, double endValue, double step)
		{
			return default(double);
		}

		[CallsUnknownMethods(Count = 6)]
		[CalledBy(Type = typeof(SplineManager), Member = "UnRegisterStaticSplineAudioClip")]
		[CalledBy(Type = typeof(SplineAudioClip), Member = "Terminate")]
		[CalledBy(Type = typeof(SplineAudioClip), Member = "OnDestroy")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(LengthData), Member = "Dispose")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(UnsafeUtility), Member = "Free")]
		public void Dispose()
		{
		}

		[CalledBy(Type = typeof(FastSpline), Member = "GetSegmentLengthInternal")]
		[CalledBy(Type = typeof(Utils), Member = "GetClosestPointParamOnSegmentIntern")]
		[CalledBy(Type = typeof(FastSpline), Member = "GetSegmentLengthInternal")]
		[CalledBy(Type = typeof(Utils), Member = "GetPositionOnSpline")]
		[Calls(Type = typeof(FastSpline), Member = "RecalcVectors")]
		[Calls(Type = typeof(FastSpline), Member = "GetAdjacentNodes")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(FastSpline), Member = "InterpolatePosition")]
		public Vector3 GetPositionInternal(SegmentParameter sParam)
		{
			return default(Vector3);
		}

		[CallerCount(Count = 1)]
		[CalledBy(Type = typeof(FastSpline), Member = "GetPositionInternal")]
		private Vector3 InterpolatePosition(double t, Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3)
		{
			return default(Vector3);
		}

		[CallerCount(Count = 1)]
		[CalledBy(Type = typeof(FastSpline), Member = "GetPositionInternal")]
		private void GetAdjacentNodes(SegmentParameter sParam, out FastSplineNode node0, out FastSplineNode node1, out FastSplineNode node2, out FastSplineNode node3)
		{
			System.Runtime.CompilerServices.Unsafe.As<FastSplineNode, @null>(ref node0) = null;
			System.Runtime.CompilerServices.Unsafe.As<FastSplineNode, @null>(ref node1) = null;
			System.Runtime.CompilerServices.Unsafe.As<FastSplineNode, @null>(ref node2) = null;
			System.Runtime.CompilerServices.Unsafe.As<FastSplineNode, @null>(ref node3) = null;
		}

		[CalledBy(Type = typeof(FastSpline), Member = "GetPositionInternal")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
		[Calls(Type = typeof(Vector3), Member = "Normalize")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Vector3), Member = "Normalize")]
		private void RecalcVectors(FastSplineNode node0, FastSplineNode node1, ref Vector3 P2, ref Vector3 P3)
		{
		}

		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Utils), Member = "GetValidNodesCount")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(SplineNode), Member = "get_Rotation")]
		[Calls(Type = typeof(LengthData), Member = "Calculate")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
		[CalledBy(Type = typeof(SplineAudioClip), Member = "Initialize")]
		[CalledBy(Type = typeof(Utils), Member = "CreateFastSpline")]
		[CallsUnknownMethods(Count = 4)]
		public void Allocate(Spline spline, NativeArray<double> matrix)
		{
		}
	}

	public struct SegmentParameter
	{
		public double m_NormalizedParam;

		public int m_NormalizedIndex;

		[CallerCount(Count = 0)]
		public SegmentParameter(int index, double param)
		{
		}
	}

	public struct Subtitle
	{
		public string m_LocId;

		public bool m_IsUnkownSpeaker;

		public uint m_StartFrame;

		public uint m_EndFrame;
	}

	private sealed class _003CWebRequest_003Ed__334 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string url;

		public Action<UnityWebRequest> onFailure;

		public Action<UnityWebRequest> onSuccess;

		private UnityWebRequest _003Cresponse_003E5__2;

		private float _003CtimeoutTime_003E5__3;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 44)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 44)]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CWebRequest_003Ed__334(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[CallerCount(Count = 1)]
		[CalledBy(Type = typeof(_003CWebRequest_003Ed__334), Member = "MoveNext")]
		[CallsUnknownMethods(Count = 4)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Calls(Type = typeof(UnityWebRequest), Member = "SendWebRequest")]
		[Calls(Type = typeof(UnityWebRequest), Member = "Get")]
		[Calls(Type = typeof(Utils), Member = "PreValidatRequest")]
		[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_isDone")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_error")]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_error")]
		[CallsDeduplicatedMethods(Count = 6)]
		[Calls(Type = typeof(_003CWebRequest_003Ed__334), Member = "System.IDisposable.Dispose")]
		[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
		[CallsUnknownMethods(Count = 16)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 5)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	private sealed class _003CWebRequest_003Ed__335 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string url;

		public Action<UnityWebRequest> onFailure;

		public WWWForm form;

		public Action<UnityWebRequest> onSuccess;

		private UnityWebRequest _003Cresponse_003E5__2;

		private float _003CtimeoutTime_003E5__3;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 44)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 44)]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CWebRequest_003Ed__335(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[CallerCount(Count = 1)]
		[CalledBy(Type = typeof(_003CWebRequest_003Ed__335), Member = "MoveNext")]
		[CallsUnknownMethods(Count = 4)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Calls(Type = typeof(UnityWebRequest), Member = "SetupPost")]
		[Calls(Type = typeof(UnityWebRequest), Member = "SendWebRequest")]
		[Calls(Type = typeof(Utils), Member = "PreValidatRequest")]
		[CallsUnknownMethods(Count = 22)]
		[Calls(Type = typeof(_003CWebRequest_003Ed__335), Member = "System.IDisposable.Dispose")]
		[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
		[Calls(Type = typeof(UnityWebRequest), Member = ".ctor")]
		[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_isDone")]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_error")]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_error")]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallerCount(Count = 0)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		private void _003C_003Em__Finally1()
		{
		}

		[CallsUnknownMethods(Count = 5)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[DebuggerHidden]
		[CallerCount(Count = 0)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	private sealed class _003CWebRequestPut_003Ed__336 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string url;

		public Action<UnityWebRequest> onFailure;

		public byte[] data;

		public Dictionary<string, string> httpHeaders;

		public Action<UnityWebRequest> onSuccess;

		private UnityWebRequest _003Cresponse_003E5__2;

		private float _003CtimeoutTime_003E5__3;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 44)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DeduplicatedMethod]
			[DebuggerHidden]
			[CallerCount(Count = 44)]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CWebRequestPut_003Ed__336(int _003C_003E1__state)
		{
		}

		[CallerCount(Count = 0)]
		[DebuggerHidden]
		[CallsUnknownMethods(Count = 4)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[CallAnalysisFailed]
		private bool MoveNext()
		{
			return default(bool);
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 5)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	public static bool s_AnalyticsInitialized;

	private static readonly LogFilter s_LoadingFilter;

	public static bool s_UseAudioStaticCheck;

	private static Dictionary<string, string> s_CommandLineArgs;

	public const float MENU_MOVEMENT_AFTER_FIFTEEN = 0.02f;

	public const float MENU_MOVEMENT_AFTER_FIVE = 0.1f;

	public const float MENU_MOVEMENT_DELAY = 0.2f;

	public const float MENU_MOVEMENT_FIRSTDELAY = 0.5f;

	public const float DOUBLECLICK_MaxTime = 0.5f;

	public static int m_PhysicalCollisionLayerMask;

	public static int m_WeaponProjectileCollisionLayerMask;

	public static bool m_InspectModeActive;

	public static Vector3[] EMPTY_VECTOR3_ARRAY;

	private static Vector3 m_InspectRestorePos;

	private static Quaternion m_InspectRestoreRot;

	private static Vector3 m_InspectOriginalLocalScale;

	private static Transform m_InspectCachedParent;

	private static ShadowCastingMode m_InspectRestoreCastsShadows;

	private static int m_MenuMoveHorizontalRepeatCount;

	private static int m_MenuMoveVerticalRepeatCount;

	private static int m_MenuMoveVerticalRightStickRepeatCount;

	private static int m_MenuMoveHorizontalRightStickRepeatCount;

	private static float m_MenuMoveHorizontalTimeAllowed;

	private static float m_MenuMoveVerticalTimeAllowed;

	private static float m_MenuMoveVerticalRightStickTimeAllowed;

	private static float m_MenuMoveHorizontalRightStickTimeAllowed;

	private static float m_MenuAxisDeadzone;

	private const float HIGHER_PRECISION_FIXED_PHYS_TIMESTEP = 0.03f;

	private const float NORNAL_PRECISION_FIXED_PHYS_TIMESTEP = 0.04f;

	private static float m_MenuMoveHorizontalRightStickAccumulated;

	private static float m_MenuMoveHorizontalRightStickThreshold;

	public static float m_SteamControllerMenuScrollSensitivity;

	public static bool s_DebugVerbose;

	private static string[] s_ByteFormatSuffixes;

	private static int[] s_SHAIds;

	private static int[] s_SHBIds;

	private static int s_SHCId;

	public const float PI2 = (float)Math.PI * 2f;

	public const float HALFPI = (float)Math.PI / 2f;

	public const string s_MissionMapMarkerLabel = "MissionMapMarker";

	private static HashSet<string> s_MissionMapMarkerIDs;

	private static HashSet<string> s_MissionIds;

	private static HashSet<string> s_MissionObjectiveIds;

	private const int MAX_RAYCAST_HITS = 32;

	private static RaycastHit[] s_RaycastHits;

	public static bool s_ShadowsEnabled;

	public static bool s_SpecularEnabled;

	private static ShadowQuality s_ShadowMode;

	private static bool s_ForceFlatLighting;

	private static RaycastHit[] m_PatchCoefficientRaycastResults;

	private const int NUM_PATCH_HEIGHT_X_COORDS = 5;

	private const int NUM_PATCH_HEIGHT_Z_COORDS = 5;

	private static float[,] s_PatchHeights;

	private static PatchHeightCheckState[,] s_PatchHeightCheckStates;

	private static Queue<Coords> s_CoordsQueue;

	private static Material s_ClearBlitMaterial;

	public const int SUBTITLE_FRAMESPERSECOND = 24;

	public const int WEB_REQUEST_TIMEOUT = 30;

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(Analytics), Member = "get_enabled")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmPrivacySettings")]
	[CallsUnknownMethods(Count = 9)]
	public static void EnableAnalytics(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Analytics), Member = "get_enabled")]
	public static bool AreAnalyticsEnabled()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "SendCustomAnalyticsEventWithSeed")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(Analytics), Member = "get_enabled")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[CallsDeduplicatedMethods(Count = 4)]
	public static void SendDailyAnalyticsEvent(string eventName, Dictionary<string, object> eventData)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[CalledBy(Type = typeof(GameManager), Member = "HandlePlayerDeath")]
	[CalledBy(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "MarkObjectiveComplete")]
	[CalledBy(Type = typeof(ConditionOverTimeBuff), Member = "Apply")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "MarkMissionComplete")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "AddMission")]
	[CalledBy(Type = typeof(WellFed), Member = "WellFedStart")]
	[CalledBy(Type = typeof(FreezingBuff), Member = "Apply")]
	[CalledBy(Type = typeof(FatigueBuff), Member = "Apply")]
	[CalledBy(Type = typeof(ConditionRestBuff), Member = "Apply")]
	[CalledBy(Type = typeof(Log), Member = "AddAffliction")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "AddObjective")]
	[CalledBy(Type = typeof(EnergyBoost), Member = "ApplyEnergyBoost")]
	[CalledBy(Type = typeof(Weather), Member = "UpdateAndMaybeSendAnalytics")]
	[CallerCount(Count = 17)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Analytics), Member = "get_enabled")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(Utils), Member = "SendCustomAnalyticsEventWithSeed")]
	[CalledBy(Type = typeof(EmergencyStim), Member = "ApplyEmergencyStim")]
	[CalledBy(Type = typeof(EmergencyStim), Member = "ApplyEmergencyStim")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	public static void SendGameplayAnalyticsEvent(string eventName, Dictionary<string, object> eventData)
	{
	}

	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[Calls(Type = typeof(AnalyticsEvent), Member = "Custom")]
	[Calls(Type = typeof(AnalyticsEvent), Member = "AddCustomEventData")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Analytics), Member = "get_enabled")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	public static void SendGameStartAnalyticsEvent(RegionSpecification region)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ShowPanel")]
	[Calls(Type = typeof(AnalyticsEvent), Member = "Custom")]
	[Calls(Type = typeof(AnalyticsEvent), Member = "AddCustomEventData")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Analytics), Member = "get_enabled")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	public static void SendGameOverAnalyticsEvent(GameOverResult gameOverResult)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(CustomExperienceMode), Member = "SendAnalytics")]
	[CalledBy(Type = typeof(CustomExperienceMode), Member = "SendAnalytics")]
	[CalledBy(Type = typeof(CustomExperienceMode), Member = "SendAnalytics")]
	[CalledBy(Type = typeof(CustomExperienceMode), Member = "SendAnalytics")]
	[CalledBy(Type = typeof(CustomExperienceMode), Member = "SendAnalytics")]
	[CalledBy(Type = typeof(CustomExperienceMode), Member = "SendAnalytics")]
	[CalledBy(Type = typeof(CustomExperienceMode), Member = "SendAnalytics")]
	[CalledBy(Type = typeof(CustomExperienceMode), Member = "SendAnalytics")]
	[CalledBy(Type = typeof(CustomExperienceMode), Member = "SendAnalytics")]
	[CalledBy(Type = typeof(CustomExperienceMode), Member = "SendAnalytics")]
	[CalledBy(Type = typeof(Utils), Member = "SendGameplayAnalyticsEvent")]
	[CalledBy(Type = typeof(Utils), Member = "SendDailyAnalyticsEvent")]
	[CalledBy(Type = typeof(FeatEnabledTracker), Member = "SendAnalytics")]
	[CalledBy(Type = typeof(FeatEnabledTracker), Member = "SendAnalytics")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "UpdateAnalytics")]
	[Calls(Type = typeof(Utils), Member = "SendCustomAnalyticsEvent")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 16)]
	[CalledBy(Type = typeof(CustomExperienceMode), Member = "SendAnalytics")]
	public static void SendCustomAnalyticsEventWithSeed(string eventName, Dictionary<string, object> eventData)
	{
	}

	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[Calls(Type = typeof(AnalyticsEvent), Member = "Custom")]
	[Calls(Type = typeof(AnalyticsEvent), Member = "Custom")]
	[CallsDeduplicatedMethods(Count = 20)]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetQualitySettings")]
	[Calls(Type = typeof(Analytics), Member = "get_enabled")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AnalyticsEvent), Member = "Custom")]
	public static void SendQualitySettingsAnalyticsEvent()
	{
	}

	[CalledBy(Type = typeof(BadgeUIInfo), Member = "SendBadgeInfoAnalyticsEvent")]
	[CalledBy(Type = typeof(Utils), Member = "SendCustomAnalyticsEventWithSeed")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "SendAnalytics")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "SendAnalytics")]
	[CalledBy(Type = typeof(BadgeUIInfo), Member = "SendBadgeInfoAnalyticsEvent")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "SendAnalytics")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(AnalyticsEvent), Member = "Custom")]
	[Calls(Type = typeof(Analytics), Member = "get_enabled")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	public static void SendCustomAnalyticsEvent(string eventName, Dictionary<string, object> eventData)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SelectRegionItem), Member = "IsAnyAnimationInProgress")]
	[CalledBy(Type = typeof(SelectRegionItem), Member = "IsAnyAnimationInProgress")]
	[CalledBy(Type = typeof(SelectRegionItem), Member = "IsAnyAnimationInProgress")]
	[CalledBy(Type = typeof(SelectRegionItem), Member = "IsAnyAnimationInProgress")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "IsAnyAnimationInProgress")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "IsAnyAnimationInProgress")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "IsAnyAnimationInProgress")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "IsAnyAnimationInProgress")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "IsAnyAnimationInProgress")]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "IsAnyAnimationInProgress")]
	public static bool IsAnimationStatePlaying(Animator animator, AnimationStateRef animStateRef, int layerIndex = 0)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool IsAnimationStatePlaying(Animator animator, string stateName, int layerIndex = 0)
	{
		return default(bool);
	}

	[CallerCount(Count = 8)]
	[Calls(Type = typeof(TextureCache), Member = "GetAddressableTexture")]
	[CalledBy(Type = typeof(Utils), Member = "GetInventoryGridIconTextureNonNull")]
	[CalledBy(Type = typeof(Utils), Member = "GetInventoryGridIconTextureNonNull")]
	[CalledBy(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[CalledBy(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[CalledBy(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[CalledBy(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[CalledBy(Type = typeof(Utils), Member = "GetInventoryIconTextureFromPrefabName")]
	[CalledBy(Type = typeof(Utils), Member = "GetInventoryIconTextureFromPrefabName")]
	public static Texture2D GetInventoryGridIconTexture(string name)
	{
		return null;
	}

	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTexture")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTexture")]
	[CallerCount(Count = 24)]
	public static Texture2D GetInventoryGridIconTextureNonNull(string name)
	{
		return null;
	}

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(TextureCache), Member = "GetAddressableTexture")]
	[CalledBy(Type = typeof(UILargeTexture), Member = "OnEnable")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	public static Texture2D GetLargeTexture(string name)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextureCache), Member = "GetAddressableTexture")]
	public static Texture2D GetLoadingBackgroundTexture(string name)
	{
		return null;
	}

	[CalledBy(Type = typeof(Utils), Member = "GetGearCoverflowDamageTexture")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Utils), Member = "GetGearCoverflowBlendTexture")]
	[CalledBy(Type = typeof(Utils), Member = "GetGearCoverflowTexture")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(GearItemCoverflow), Member = "SetDamageTextures")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CalledBy(Type = typeof(GearItemCoverflow), Member = "SetDamageTextures")]
	[Calls(Type = typeof(TextureCache), Member = "CacheTexture")]
	private static Texture2D GetAddressableTexture(AssetReferenceTexture2D assetReference)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextureCache), Member = "GetAddressableTexture")]
	private static Texture2D GetAddressableTexture(string name)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(RenderObjectInstance), Member = "IsRenderObjectInstanceChild")]
	[Calls(Type = typeof(Utils), Member = "IsChildOfDynamicObj")]
	[CallsUnknownMethods(Count = 2)]
	public static bool CheckIfAkGameObjIsStatic(AkGameObj akGameObj)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Utils), Member = "IsChildOfDynamicObj")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	private static bool IsDynamicObj(GameObject obj)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Utils), Member = "IsDynamicObj")]
	[CalledBy(Type = typeof(Utils), Member = "CheckIfAkGameObjIsStatic")]
	[CallsUnknownMethods(Count = 4)]
	private static bool IsChildOfDynamicObj(AkGameObj obj)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public static string ExecuteCmd(string commandArguments, bool returnOutput)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static string ExecuteCmdFromDir(string commandArguments, ExecuteCmdOptions options, string workingDirectory)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static IEnumerator ExecuteCmd(string commandArguments, ExecuteCmdOptions options, ExecuteCmdCallback callback)
	{
		return null;
	}

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "Initialize")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyCommandLineParameters")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyCommandLineParameters")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyCommandLineParameters")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyCommandLineParameters")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "PlayIntroMovie")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "ShouldReplacePathEntry")]
	[Calls(Type = typeof(Utils), Member = "SanitizeCommandLineArgName")]
	[Calls(Type = typeof(Utils), Member = "EnsureCommandLineArgsAreLoaded")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyCommandLineParameters")]
	public static bool IsCommandLineArgumentPresent(string arg)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateNewGame")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Utils), Member = "GetCommandLineValue")]
	[CalledBy(Type = typeof(Utils), Member = "GetCommandLineValue")]
	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateNewGame")]
	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateNewGame")]
	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateNewGame")]
	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateNewGame")]
	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateNewGame")]
	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateNewGame")]
	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateLoadingSave")]
	[Calls(Type = typeof(Utils), Member = "SanitizeCommandLineArgName")]
	[Calls(Type = typeof(Utils), Member = "EnsureCommandLineArgsAreLoaded")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 10)]
	public static bool GetCommandLineValue(string arg, out string value)
	{
		value = null;
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetCommandLineValue")]
	[Calls(Type = typeof(int), Member = "TryParse")]
	public static bool GetCommandLineValue(string arg, out int value)
	{
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref value) = null;
		return default(bool);
	}

	[Calls(Type = typeof(Utils), Member = "GetCommandLineValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static bool GetCommandLineValue<TEnum>(string arg, out TEnum value) where TEnum : struct
	{
		System.Runtime.CompilerServices.Unsafe.As<TEnum, @null>(ref value) = null;
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Process), Member = "GetCurrentProcess")]
	[Calls(Type = typeof(Process), Member = "get_StartInfo")]
	[Calls(Type = typeof(ExternalProcess), Member = "RunCommand")]
	public static void QuitAndRunApplication(string applicationPath, string commandArguments)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private static void QuitOrStopPlayMode()
	{
	}

	[CallsUnknownMethods(Count = 20)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Process), Member = ".ctor")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enum), Member = "IsDefined")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Process), Member = "set_StartInfo")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(InvalidEnumArgumentException), Member = ".ctor")]
	private static Process GetProcessForExecuteCmd(string commandArguments, string workingPath, ExecuteCmdOptions options)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(Utils), Member = "ParseCommandLineArgs")]
	[CallsUnknownMethods(Count = 1)]
	public static void OverrideCommandLineWithTestArgs(string testCommandLine)
	{
	}

	[CalledBy(Type = typeof(Utils), Member = "GetCommandLineValue")]
	[CalledBy(Type = typeof(Utils), Member = "IsCommandLineArgumentPresent")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "ParseCommandLineArgs")]
	private static void EnsureCommandLineArgsAreLoaded()
	{
	}

	[CalledBy(Type = typeof(Utils), Member = "GetCommandLineValue")]
	[CalledBy(Type = typeof(Utils), Member = "IsCommandLineArgumentPresent")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Utils), Member = "ParseCommandLineArgs")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	private static string SanitizeCommandLineArgName(string keyName)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(Utils), Member = "EnsureCommandLineArgsAreLoaded")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Split")]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread")]
	[Calls(Type = typeof(Utils), Member = "SanitizeCommandLineArgName")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Thread), Member = "GetCurrentCultureNoAppX")]
	[CalledBy(Type = typeof(Utils), Member = "OverrideCommandLineWithTestArgs")]
	private static Dictionary<string, string> ParseCommandLineArgs(string[] args)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static void Init()
	{
	}

	[Calls(Type = typeof(Guid), Member = "ToString")]
	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Interop), Member = "GetRandomBytes")]
	public static string GetGuid()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Array), Member = "GetValue")]
	[Calls(Type = typeof(Array), Member = "get_Length")]
	[Calls(Type = typeof(Enum), Member = "GetValues")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[DeduplicatedMethod]
	public static T GetRandomEnum<T>()
	{
		return (T)null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static string GetTimeSurvivedString()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "UpdateProfileAfterChallengeComplete")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "GetExpandedDurationString")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "SetTimeSurvivedLabel")]
	[CalledBy(Type = typeof(Panel_Log), Member = "GetSurvivalRecordSummaryText")]
	[CalledBy(Type = typeof(SandboxRecord), Member = "GetSurvivalRecordSummaryText")]
	[CallsUnknownMethods(Count = 1)]
	public static string GetTimeSurvivedString(float time)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "RefreshHoverIconText")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "RefreshDescriptionPage")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "RefreshLabels")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "RefreshEstimatedDurationLabel")]
	[CalledBy(Type = typeof(Panel_Log), Member = "GetStringForNeed")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RefreshChanceSuccessLabel")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Update")]
	[CalledBy(Type = typeof(NPC_NeedTracker), Member = "GetStringForNeed")]
	[CalledBy(Type = typeof(SpecialEvent), Member = "SetDailyTimerLabel")]
	[CalledBy(Type = typeof(ThreeDaysOfNight), Member = "SetDailyTimerLabel")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "RefreshFireDurationLabel")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateGearItem")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CalledBy(Type = typeof(FireplaceInteraction), Member = "GetHoverText")]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "RefreshFireDurationLabel")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(MissionObjectiveEntry), Member = "MaybeUpdateTimerObjectiveUI")]
	[CalledBy(Type = typeof(JumpData), Member = "ToString")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "GetHoverText")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "GetHoverText")]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static string GetDurationString(int durationMinutes)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 85)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public static string GetExpandedDurationString(int durationMinutes)
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(int), Member = "ToString")]
	public static string GetDurationStringRounded(int durationMinutes)
	{
		return null;
	}

	[CalledBy(Type = typeof(PlayableBehaviourChangeTOD), Member = "OnBehaviourPlay")]
	[Calls(Type = typeof(int), Member = "TryParse")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(StartSettings), Member = "SetLockedTime")]
	[CalledBy(Type = typeof(PlayableBehaviourChangeTOD), Member = "OnBehaviourPlay")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_set_time")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_force_sleep_length")]
	[Calls(Type = typeof(int), Member = "TryParse")]
	[Calls(Type = typeof(string), Member = "Split")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_lighting_preview")]
	public static bool TryParseTOD(string todString, out float normalizedTOD)
	{
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref normalizedTOD) = null;
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetRegionForScene")]
	public static string GetHardcodedRegionForLocation(string location)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Exists")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "ShowTutorialPopupRequest")]
	public static string GetTitleString(string locID)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Map), Member = "GetIndexOfCurrentScene")]
	[CalledBy(Type = typeof(Log), Member = "AddCurrentRegion")]
	[CalledBy(Type = typeof(Log), Member = "AddLocation")]
	[Calls(Type = typeof(LoadScene), Member = "GetSceneToLoad")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	public static string InferOutdoorSceneName(bool considerForceNextSceneLoadTrigger = false)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 6)]
	public static string GetFullObjectName(GameObject go)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[CallerCount(Count = 51)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	public static GameObject GetChildGameObject(GameObject fromGameObject, string withName, bool includeInactive = false)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Utils), Member = "GetChildGameObjectWithNameContaining")]
	[CalledBy(Type = typeof(PlayableBehaviourSyncTransform), Member = "FindTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObjectWithNameContaining")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	public static GameObject GetChildGameObjectWithNameContaining(GameObject fromGameObject, string withName, bool includeInactive = false)
	{
		return null;
	}

	[CalledBy(Type = typeof(GearItem), Member = "MaybeFallIntoWater")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Utils), Member = "GetChildGameObjectByTag")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InitializeObjectToPlace")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObjectByTag")]
	[CallerCount(Count = 3)]
	public static GameObject GetChildGameObjectByTag(GameObject fromGameObject, string tag, bool includeInactive = false)
	{
		return null;
	}

	[CalledBy(Type = typeof(Utils), Member = "GetChildGameObject")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public static GameObject GetChildGameObject(GameObject fromGameObject, string withName1, string withName2, bool includeInactive = false)
	{
		return null;
	}

	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "PlayerSparkParticlesOnSpecific")]
	[CallerCount(Count = 1)]
	public static GameObject ForceGetChildGameObject(GameObject fromGameObject, string withName)
	{
		return null;
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(GearItem), Member = "InitializeInteraction")]
	[CalledBy(Type = typeof(MapDetailManager), Member = "UnlockMapDetailObjectsNearPosition")]
	[CalledBy(Type = typeof(MapDetailManager), Member = "UnlockMapDetailObjectsNearPosition")]
	[CallsUnknownMethods(Count = 4)]
	public static bool IsChildOfParent(GameObject child, GameObject parent)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static GameObject FindTopParentWithCollider(GameObject child)
	{
		return null;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectUnderCrosshairs")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectUnderCrosshairs")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectUnderCrosshairs")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectUnderCrosshairs")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectUnderCrosshairs")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectUnderCrosshairs")]
	public static GameObject GetTopParentWithLayer(GameObject child, int childLayer)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public static T GetComponentOnSelfOrParent<T>(GameObject obj) where T : UnityEngine.Component
	{
		return null;
	}

	[Calls(Type = typeof(Scene), Member = "GetRootGameObjects")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static List<T> FindObjectsOfTypeInScene<T>(Scene scene, bool includeInactive = false) where T : UnityEngine.Component
	{
		return null;
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ObjectToPlaceOverlapsWithObjectsThatBlockPlacement")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InitializeObjectToPlace")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InitializeObjectToPlace")]
	[CallsUnknownMethods(Count = 4)]
	public static bool AreCollidersActiveAndEnabled(List<Collider> cs)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "ObjectToPlaceIsOnBrokenIce")]
	[CalledBy(Type = typeof(PlayerManager), Member = "BedrollOnIce")]
	[CalledBy(Type = typeof(PlayerManager), Member = "LeanToNotOnGroundSnow")]
	[CalledBy(Type = typeof(PlayerManager), Member = "SnowShelterNotOnGroundSnow")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(PhysicsScene), Member = "SphereCast")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(GearItem), Member = "MaybeFallIntoWater")]
	public static Collider GetColliderUnderPosition(Vector3 pos)
	{
		return null;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "OnLandFromFall")]
	[CalledBy(Type = typeof(Inventory), Member = "PositionAndRotateScatteredItem")]
	[CalledBy(Type = typeof(FootStepSounds), Member = "AddMoveDistance")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerManager), Member = "CalculateGhostedMeshValidPosition")]
	[CalledBy(Type = typeof(GearItem), Member = "StickToGroundAndOrientOnSlope")]
	[Calls(Type = typeof(PhysicsScene), Member = "SphereCast")]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdateAnim")]
	[Calls(Type = typeof(Utils), Member = "GetMaterialTagForObjectAtPosition")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeUpdateStandingOnMaterialTag")]
	public static string GetMaterialTagUnderPosition(Vector3 pos)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Utils), Member = "GetMaterialTagUnderPosition")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DoPositionCheck")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "PlaceFootstep")]
	[CalledBy(Type = typeof(StoneItem), Member = "OnCollisionEnter")]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "HandleCollisionWithObject")]
	[CalledBy(Type = typeof(ArrowItem), Member = "HandleCollisionWithObject")]
	[CalledBy(Type = typeof(ArrowItem), Member = "HandleCollisionWithObject")]
	[CalledBy(Type = typeof(NoiseMakerEffects), Member = "LeaveScorchMark")]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "HandleCollisionWithObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(BreakableIce), Member = "IsIceBroken")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(vp_Bullet), Member = "SpawnImpactEffects")]
	public static string GetMaterialTagForObjectAtPosition(GameObject obj, Vector3 pos)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(TorchItem), Member = "DisableRendering")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "DisableRendering")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(FlareItem), Member = "DisableRendering")]
	public static void DisableRendering(GameObject go)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(FlareItem), Member = "Update")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "Update")]
	[CalledBy(Type = typeof(TorchItem), Member = "Update")]
	public static void EnableRendering(GameObject go)
	{
	}

	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(Directory), Member = "Exists")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_save_view")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Directory), Member = "CreateDirectory")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "GetFileStream")]
	[CallerCount(Count = 1)]
	public static void SaveView(string name)
	{
	}

	[CallsUnknownMethods(Count = 26)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_restore_view")]
	[Calls(Type = typeof(StreamReader), Member = ".ctor")]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
	[Calls(Type = typeof(FlyMode), Member = "Warp")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(File), Member = "Exists")]
	public static void RestoreView(string name)
	{
	}

	[CallerCount(Count = 0)]
	public static float CelsiusToFahrenheit(float celsius)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public static float FahrenheitToCelsius(float fahrenheit)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public static float KilogramsToPounds(float kg)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public static float LitersToGallons(float liters)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static int GallonsToOunces(float gallons)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	public static float KmToMile(float km)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public static float MeterToFeet(float meter)
	{
		return default(float);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 20)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static float DistanceToMainCamera(Vector3 pos)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Dysentery), Member = "UpdateRemedyItems")]
	[CalledBy(Type = typeof(HarvestRepairMaterial), Member = "ShowLiquidFractionalStack")]
	[CalledBy(Type = typeof(HarvestRepairMaterial), Member = "ShowLiquidFractionalStack")]
	[CalledBy(Type = typeof(HarvestRepairMaterial), Member = "ShowLiquid")]
	[CalledBy(Type = typeof(CraftingRequirementMaterial), Member = "EnableForKerosene")]
	[CalledBy(Type = typeof(Dysentery), Member = "UpdateRemedyItems")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Utils), Member = "ToStringTwoDigitFloor")]
	[Calls(Type = typeof(Utils), Member = "ToStringTwoDigitFloor")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static string GetLiquidQuantityStringWithUnits(MeasurementUnits units, float liters)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Utils), Member = "GetWeightOneDecimalPlaceWithUnitsString")]
	[CalledBy(Type = typeof(Utils), Member = "GetWeightOneDecimalPlaceWithUnitsString")]
	[Calls(Type = typeof(string), Member = "Remove")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	public static string ToStringOneDigitFloor(float value)
	{
		return null;
	}

	[CalledBy(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Utils), Member = "GetWeightTwoDecimalPlacesWithUnitsString")]
	[CalledBy(Type = typeof(Utils), Member = "GetWeightTwoDecimalPlacesWithUnitsString")]
	[CalledBy(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[CalledBy(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnits")]
	[Calls(Type = typeof(string), Member = "Remove")]
	[CalledBy(Type = typeof(CraftingRequirementMaterial), Member = "EnableForGunpowder")]
	[CalledBy(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnits")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallerCount(Count = 7)]
	public static string ToStringTwoDigitFloor(float value)
	{
		return null;
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "ToStringTwoDigitFloor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 53)]
	[Calls(Type = typeof(Utils), Member = "ToStringTwoDigitFloor")]
	public static string GetLiquidQuantityStringWithUnitsNoOunces(MeasurementUnits units, float liters)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CalledBy(Type = typeof(CraftingRequirementMaterial), Member = "EnableForKerosene")]
	[CallsUnknownMethods(Count = 2)]
	public static string GetLiquidQuantityString(MeasurementUnits units, float liters)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateWaterRemedyUI")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshRefuelPanel")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "Refresh")]
	[CalledBy(Type = typeof(MissionObjectiveEntry), Member = "MaybeUpdateCounterUI")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshRefuelPanel")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(MissionObjectiveEntry), Member = "MaybeUpdateCounterUI")]
	public static string GetLiquidQuantityStringNoOunces(MeasurementUnits units, float liters)
	{
		return null;
	}

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnCook")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "ExecuteCook")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InitLabelsForGear")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnDrinkWaterComplete")]
	public static string GetLiquidQualityString(LiquidQuality quality)
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	public static string GetFormattedDistance(MeasurementUnits units, float meters)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateDebugCompass")]
	[CallsUnknownMethods(Count = 3)]
	public static string GetCompassBearingAndDistance(Vector3 start, Vector3 end, out float angle, out float distance)
	{
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref angle) = null;
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref distance) = null;
		return null;
	}

	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public static string GetTemperatureString(float temperatureCelsius, bool deltaTemperature, bool roundToNearestDegree, bool showPlusSign)
	{
		return null;
	}

	[CallerCount(Count = 64)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	public static bool RollChance(float percent)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "TransferMeatFromCarcassToInventory")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "RefreshSelected")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateWeightAndConditionLabels")]
	[CalledBy(Type = typeof(MissionsProgressBar), Member = "Refresh")]
	[CalledBy(Type = typeof(MissionsProgressBar), Member = "Refresh")]
	[CalledBy(Type = typeof(MissionObjectiveEntry), Member = "MaybeUpdateCounterUI")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "ToStringOneDigitFloor")]
	[Calls(Type = typeof(Utils), Member = "ToStringOneDigitFloor")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static string GetWeightOneDecimalPlaceWithUnitsString(MeasurementUnits units, float weightKG)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateGearItem")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "RefreshSelectedBlueprint")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "UpdateSelectedGear")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateFilteredInventoryList")]
	[CalledBy(Type = typeof(CraftingRequirementMaterial), Member = "EnableForGunpowder")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateFilteredInventoryList")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "HarvestSuccessful")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InitLabelsForGear")]
	[CalledBy(Type = typeof(GearItem), Member = "GetTextToDisplayWhenSelected")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateFilteredInventoryList")]
	[CalledBy(Type = typeof(StartFireSelectionRow), Member = "Update")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateWeightDisplay")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateGearItemDescription")]
	[CalledBy(Type = typeof(InventoryGridItem), Member = "UpdateConditionDisplay")]
	[CalledBy(Type = typeof(HarvestRepairMaterial), Member = "ShowPowder")]
	[CalledBy(Type = typeof(HarvestRepairMaterial), Member = "ShowPowder")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "ToStringTwoDigitFloor")]
	[Calls(Type = typeof(Utils), Member = "ToStringTwoDigitFloor")]
	[CallerCount(Count = 17)]
	[CalledBy(Type = typeof(StartFireSelectionRow), Member = "Update")]
	public static string GetWeightTwoDecimalPlacesWithUnitsString(MeasurementUnits units, float weightKG)
	{
		return null;
	}

	[CalledBy(Type = typeof(BreakDown), Member = "StickSurfaceObjectsToGround")]
	[CalledBy(Type = typeof(Action_SpawnPropAndTriggerAnim), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_SpawnObjectOnPlayer), Member = "MaybeSpawnProp")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "MaybeAddSpawnedPropToInventory")]
	[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "MaybeSpawnProp")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[CallsDeduplicatedMethods(Count = 4)]
	public static void SetObjectAndChildrenLayer(GameObject go, int layer, int preserveLayer)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(BreakDown), Member = "ProcessRaycastResults")]
	[CallsUnknownMethods(Count = 3)]
	public static bool IsChild(GameObject parent, GameObject child)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(GearItem), Member = "Drop")]
	[CalledBy(Type = typeof(PumpkinPieSpecialItem), Member = "Hide")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitInspectGearMode")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitMeshPlacement")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PrepareGhostedObject")]
	[CalledBy(Type = typeof(Inventory), Member = "HideInventoryItem")]
	[CalledBy(Type = typeof(FirstPersonWeapon), Member = "SpawnReloadBulletPrefab")]
	[CalledBy(Type = typeof(Inventory), Member = "HideInventoryItem")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "StartCooking")]
	[CalledBy(Type = typeof(Utils), Member = "ExitInspectForGearItem")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerManager), Member = "InstantiateCopyOfThrownObject")]
	[CalledBy(Type = typeof(Utils), Member = "ShowInspectForGearItem")]
	[CalledBy(Type = typeof(BowItem), Member = "MaybeSpawnArrow")]
	[CalledBy(Type = typeof(BowItem), Member = "ShootArrow")]
	[CallerCount(Count = 16)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(BowItem), Member = "OnDequip")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(GameObject), Member = "get_tag")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_tag")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[Calls(Type = typeof(GameObject), Member = "set_tag")]
	[Calls(Type = typeof(GameObject), Member = "set_tag")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public static void ChangeLayersForGearItem(GameObject gameObject, int newLayer)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "PositionIsOnscreen")]
	public static bool PositionIsOnscreen(Vector3 pos)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Utils), Member = "PositionIsOnscreen")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "SpawnObjectAttempt")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "MaybeDestroyAfterDeserialize")]
	[CalledBy(Type = typeof(ArrowItem), Member = "LateUpdate")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "RemoveActiveSpawns")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeImposter")]
	[CalledBy(Type = typeof(BearEncounter), Member = "SpawnObjectAttempt")]
	[CallerCount(Count = 10)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(SpawnRegion), Member = "SpawnPositionOnScreenTooClose")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFlee")]
	[CalledBy(Type = typeof(BaseAi), Member = "GetSpeedFromMecanimBone")]
	public static bool PositionIsOnscreen(Vector3 pos, float adjustViewport)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public static float GetPlayerEyeHeight()
	{
		return default(float);
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CalledBy(Type = typeof(HuntedPart2WaypointController), Member = "ShouldDoWanderPause")]
	[CalledBy(Type = typeof(Action_SpawnHuntedChallengeBear), Member = "SpawnChallengeBearNearPlayer")]
	[CalledBy(Type = typeof(Utils), Member = "PositionIsInLOSOfPlayer")]
	[CallsUnknownMethods(Count = 2)]
	public static Vector3 GetPlayerEyePosition()
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(OpenClose), Member = "PlayAnimInReverse")]
	[CalledBy(Type = typeof(OpenClose), Member = "Open")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "RemoveActiveSpawns")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "SpawnPositionOnScreenTooClose")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFlee")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Utils), Member = "GetPlayerEyePosition")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(AiUtils), Member = "PositionVisible")]
	public static bool PositionIsInLOSOfPlayer(Vector3 pos)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshStatusLabels")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "RefreshStatusLabels")]
	[CalledBy(Type = typeof(GearItem), Member = "GetColorStringBasedOnCondition")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "GetHoverText")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "GetHoverText")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "GetHoverText")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "GetHoverText")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "GetHoverText")]
	[CalledBy(Type = typeof(Encumber), Member = "GetCapacityString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(Encumber), Member = "GetCapacityString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "AddMenuItem")]
	[CalledBy(Type = typeof(Encumber), Member = "GetCapacityString")]
	[CallsUnknownMethods(Count = 3)]
	public static string GetStringFromColor(Color col)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static Color GetColorWithAlpha(Color source, float alpha)
	{
		return default(Color);
	}

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(GearItemCoverflow), Member = "SetDamageTextures")]
	[CalledBy(Type = typeof(GearItemCoverflow), Member = "SetGearItem")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetAddressableTexture")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public static Texture2D GetGearCoverflowTexture(GearItem gi)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetAddressableTexture")]
	[CallsUnknownMethods(Count = 1)]
	public static Texture2D GetGearCoverflowDamageTexture(GearItem gi)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetAddressableTexture")]
	[CallsUnknownMethods(Count = 1)]
	public static Texture2D GetGearCoverflowBlendTexture(GearItem gi)
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTexture")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTexture")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTexture")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTexture")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GameManager), Member = "GetConditionTable")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 38)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static Texture2D GetInventoryIconTexture(GearItem gi)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest_MenuItem), Member = "MaybeRefreshTexture")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateGearItem")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "RefreshTextures")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	public static Texture2D GetInventoryIconTexture(GearItem gi, float conditionPercent)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshCheckmarks")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "SetItemsNeeded")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateRemedyUI")]
	[CalledBy(Type = typeof(GearMessage), Member = "ShowNextMessageInQueue")]
	[CalledBy(Type = typeof(GearSelectCoverflow), Member = "SetGearItemIcon")]
	[CalledBy(Type = typeof(GearSelectCoverflow), Member = "SetGearItem")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTexture")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "RefreshSelected")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTexture")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(string), Member = "Substring")]
	public static Texture2D GetInventoryIconTextureFromPrefabName(string prefabName, bool opened = false)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static Texture2D GetInventoryBGTexture(GearItem gi)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public static TType GetComponentInChildren<TType>(GameObject objRoot) where TType : UnityEngine.Component
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateFeatMarkerSprites")]
	[CalledBy(Type = typeof(Utils), Member = "FindTimelineDynamicBinding")]
	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(Utils), Member = "FindChildRecursive")]
	[CalledBy(Type = typeof(PlayableBehaviourSyncTransform), Member = "FindTransform")]
	[CalledBy(Type = typeof(PlayableBehaviourSetFPAnchor), Member = "FindAnchor")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "CameraPan")]
	[CalledBy(Type = typeof(Panel_SnowShelterBuild), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateFeatMarkerSprites")]
	[CalledBy(Type = typeof(Utils), Member = "GetInspectModePivot")]
	[CalledBy(Type = typeof(Panel_LeanToBuild), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "CameraPan")]
	[CalledBy(Type = typeof(Weather), Member = "Start")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Utils), Member = "FindChildRecursive")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "Find")]
	[CallerCount(Count = 13)]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "CameraPan")]
	public static Transform FindChildRecursive(Transform trans, string childName)
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static GameObject CreateOrFindGameObjectFromPath(string path)
	{
		return null;
	}

	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsUnknownMethods(Count = 44)]
	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "GetCamera")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Scene), Member = "GetRootGameObjects")]
	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "CreateAnimatedCamera")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(string), Member = "Split")]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	public static GameObject CreateOrFindGameObjectFromPath(string path, Transform root)
	{
		return null;
	}

	[CalledBy(Type = typeof(Inventory), Member = "GearInInventory")]
	[CalledBy(Type = typeof(Inventory), Member = "GearInInventoryAtCondition")]
	[CalledBy(Type = typeof(Inventory), Member = "GetNonRuinedItem")]
	[CalledBy(Type = typeof(Inventory), Member = "GearInInventory")]
	[CalledBy(Type = typeof(GearItemObjectExtensions), Member = "NumGearInList")]
	[CalledBy(Type = typeof(GearItemObjectExtensions), Member = "GetBestGearItemWithName")]
	[CalledBy(Type = typeof(Inventory), Member = "GetLowestConditionGearThatMatchesName")]
	[CalledBy(Type = typeof(GearItemObjectExtensions), Member = "GetMeasurableTotalByTypeInList")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(GearItemObject), Member = ".ctor")]
	[CalledBy(Type = typeof(Inventory), Member = "GetHighestConditionGearThatMatchesName")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "DeserializeAll")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InstantiateItemAtLocation")]
	[CalledBy(Type = typeof(GearManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(GearManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(BlueprintItemUnlock), Member = "Unlock")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "LastIndexOf")]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallerCount(Count = 17)]
	[CalledBy(Type = typeof(Inventory), Member = "AddGear")]
	public static string SanitizePrefabName(string prefabName)
	{
		return null;
	}

	[CalledBy(Type = typeof(BreakDown), Member = "SpawnYieldObjectsAndStickToGround")]
	[CalledBy(Type = typeof(BreakDown), Member = "SpawnYieldObjectsAndStickToGround")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	public static float StickItemToGroundAtLocation(GameObject go, Vector3 location, float randomRadius = 1f)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(Utils), Member = "SaveView")]
	[Calls(Type = typeof(System.IO.FileSystem), Member = "SetAttributes")]
	[Calls(Type = typeof(StreamWriter), Member = ".ctor")]
	[Calls(Type = typeof(FileInfo), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FileSystemInfo), Member = "EnsureDataInitialized")]
	public static StreamWriter GetFileStream(string path)
	{
		return null;
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "Start")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ResetGameSettingsToNormal")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashCameraReturnToStart")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashGetupDelayCamera")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashCameraInterpolateToPartner")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyFOV")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Start")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "UpdateZoom")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "SnapZoom")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "UpdateZoom")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "UpdateZoom")]
	[Calls(Type = typeof(Camera), Member = "set_fieldOfView")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "SnapZoom")]
	public static void SetCameraFOVSafe(Camera cam, float fov)
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "ShouldIgnoreNavigationInput")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "MaybeFlagMovmentPressedOnEnable")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Navigate")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "ShouldIgnoreNavigationInput")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "MaybeFlagMovmentPressedOnEnable")]
	[Calls(Type = typeof(InputManager), Member = "GetMenuNavigationPrimary")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Update")]
	[Calls(Type = typeof(InputManager), Member = "GetMenuNavigationSecondary")]
	[Calls(Type = typeof(InputManager), Member = "GetMenuNavigationSecondary")]
	[Calls(Type = typeof(InputManager), Member = "GetMenuNavigationPrimary")]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Enable")]
	public static bool GetMovementPressed(MonoBehaviour context, bool useSecondary)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(InputManager), Member = "GetMenuNavigationPrimary")]
	[Calls(Type = typeof(InputManager), Member = "GetMenuNavigationSecondary")]
	[CallerCount(Count = 29)]
	[CallsDeduplicatedMethods(Count = 3)]
	public static float GetMenuMovementHorizontal(MonoBehaviour context, bool useSecondary = true, bool useTimer = true)
	{
		return default(float);
	}

	[CallerCount(Count = 39)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "GetMenuNavigationPrimary")]
	[Calls(Type = typeof(InputManager), Member = "GetMenuNavigationSecondary")]
	[Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup")]
	[CallsUnknownMethods(Count = 2)]
	public static float GetMenuMovementVertical(MonoBehaviour context, bool useSecondary = true, bool useTimer = true)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(DetailedStatsView), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateGamepadControls")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTrustList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsExamineCollectible")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsStats")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoScrollListScrolLRight")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateCollectibleNote")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsWhatIKnowList")]
	[Calls(Type = typeof(Utils), Member = "AdjustVerticalMoveWithTimer")]
	[Calls(Type = typeof(InputManager), Member = "GetCameraMovementGamepad")]
	[Calls(Type = typeof(InputManager), Member = "GetCameraMovementMouse")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "IsSteamControllerActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(Panel_List<, >), Member = "HandleInput")]
	public static float GetMenuMovementVerticalRightStick(MonoBehaviour context, bool useTimer = true, bool useTimerForCameraMouse = false)
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Utils), Member = "GetMenuMovementVerticalRightStick")]
	[CallsUnknownMethods(Count = 2)]
	public static float AdjustVerticalMoveWithTimer(float movement)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTrustList")]
	[Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup")]
	[Calls(Type = typeof(InputManager), Member = "GetCameraMovementGamepad")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "IsSteamControllerActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "GetCameraMovementMouse")]
	public static float GetMenuMovementHorizontalRightStick(MonoBehaviour context, bool useTimer = true)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterLeftPressed")]
	public static bool GetMenuMovementFilterLeft(MonoBehaviour context)
	{
		return default(bool);
	}

	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterRightPressed")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static bool GetMenuMovementFilterRight(MonoBehaviour context)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool GetMenuMovementAllowed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void UpdateMenuMovementDelay()
	{
	}

	[CalledBy(Type = typeof(Panel_Loading), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(BootUpdate), Member = "Start")]
	public static string GetPressAnyKeyString()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static bool ShouldDestroyWornOutGear(GearItem gi)
	{
		return default(bool);
	}

	[CallerCount(Count = 205)]
	public static bool IsGamepadActive()
	{
		return default(bool);
	}

	[CallerCount(Count = 65)]
	public static bool IsMouseActive()
	{
		return default(bool);
	}

	[Calls(Type = typeof(InputManager), Member = "GetSprintDown")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(InputManager), Member = "GetRadialButtonHeldDown")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "MaybeUpdateRotationAction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "RotateCurrentPlaceable")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "RotatePlaceMesh")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	public static float InputControlRotate(MonoBehaviour context, float rotationDegreesPerSecond, float mouseWheelRotationDegrees)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[CallsUnknownMethods(Count = 11)]
	public static void LightPositionFixUp(Transform lightT, float lightLift)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallerCount(Count = 385)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	public static void SetActive(GameObject go, bool active)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Collider), Member = "get_enabled")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InitializeObjectToPlace")]
	[CallsUnknownMethods(Count = 6)]
	public static Collider GetLargestCollider(GameObject go)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(MapDetailManager), Member = "UnlockMapDetailObjectsNearPosition")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "SpawnObjectAttempt")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "SetObjectToSpawnBoundingRadius")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(BearEncounter), Member = "Awake")]
	public static Renderer GetLargestBoundsRenderer(GameObject go)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static Vector2 GetVector2WithDeadzone(Vector2 input, float deadzone)
	{
		return default(Vector2);
	}

	[CallerCount(Count = 0)]
	public static Vector2 GetVector2WithZerodSmallAxis(Vector2 input)
	{
		return default(Vector2);
	}

	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateExamineCollectible")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "EnterInspectGearMode")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateGearItem")]
	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "InspectPrevGearItem")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "MaybeHandleGearItemPlacement")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeEnableInspectModeMesh")]
	[Calls(Type = typeof(GearItem), Member = "DisablePhysics")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "SetActive")]
	[Calls(Type = typeof(GearItem), Member = "UpdateDamageShader")]
	[Calls(Type = typeof(Utils), Member = "UpdateTransformFromInspectAndCamera")]
	[CallsDeduplicatedMethods(Count = 20)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Utils), Member = "ChangeLayersForGearItem")]
	public static void ShowInspectForGearItem(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateDisplayText")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "MaybeHandleGearItemPlacement")]
	[CalledBy(Type = typeof(Panel_CanOpening), Member = "Update")]
	[CalledBy(Type = typeof(Panel_CanOpening), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "ExecuteCook")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateDisplayText")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "ExitInspectGearMode")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CallsUnknownMethods(Count = 22)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateGearItem")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Refresh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 14)]
	[CallsDeduplicatedMethods(Count = 21)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "ChangeLayersForGearItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(SnareItem), Member = "SetState")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Inventory), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Renderer), Member = "set_shadowCastingMode")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeDisableInspectModeMesh")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	public static void ExitInspectForGearItem(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(InspectGearController), Member = "Update")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateGearTransformForInspection")]
	[Calls(Type = typeof(Utils), Member = "FindChildRecursive")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static bool GetInspectModePivot(Inspect inspect, out Vector3 pivot)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref pivot) = null;
		return default(bool);
	}

	[CalledBy(Type = typeof(Log), Member = "AddCurrentRegion")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public static string GetRegionSpriteNameFromSaveSlotInfo(string saveSlotLocation)
	{
		return null;
	}

	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(Log), Member = "AddCurrentRegion")]
	[CalledBy(Type = typeof(Log), Member = "AddLocation")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(Action_SpawnHuntedChallengeBear), Member = "SpawnChallengeBearNearPlayer")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public static bool SceneIsTransition(string sceneName)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetNameForScene")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "GenerateLocationList")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetRegionForScene")]
	public static string GetCurrentRegion()
	{
		return null;
	}

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "MaybeDestroyAfterDeserialize")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "Reset")]
	[CalledBy(Type = typeof(SceneMusicManager), Member = "Awake")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Reset")]
	public static bool IsSceneTransition()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Action_DestroySelectedPlayerItems), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_GiveBackPlayerItems), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_WhiteoutGearRequirements), Member = "OnUpdate")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Container), Member = "GetWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	public static GearItem[] GetGearItemsStoredInSceneByPlayer(bool includeContainers = true)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	public static float GetNumCaloriesInGearItems(GearItem[] gearItems)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	private static byte ToByte(float f)
	{
		return default(byte);
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "GetSurvivalRecordSummaryText")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[CalledBy(Type = typeof(SandboxRecord), Member = "GetSurvivalRecordSummaryText")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	public static string ColorToHex(Color color)
	{
		return null;
	}

	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(WeatherSet), Member = "ReportHoursOfBlizzardForDay")]
	[CalledBy(Type = typeof(WeatherSet), Member = "ReportHoursOfBlizzardForDay")]
	[CalledBy(Type = typeof(WeatherSetData), Member = "ReportHoursOfBlizzardForDay")]
	[CalledBy(Type = typeof(WeatherSetData), Member = "ReportHoursOfBlizzardForDay")]
	[CallsUnknownMethods(Count = 1)]
	public static float GetFirstDayLengthInHours()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsUnknownMethods(Count = 1)]
	public static bool DisableGUIPanCamera()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Transform), Member = "Translate")]
	[CalledBy(Type = typeof(Utils), Member = "ShowInspectForGearItem")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(PlayerManager), Member = "SetGearTransformForInspection")]
	[Calls(Type = typeof(Transform), Member = "Rotate")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	public static void UpdateTransformFromInspectAndCamera(Transform transform, vp_FPSCamera camera, Inspect inspect, Vector3 originalScale)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[CallsUnknownMethods(Count = 1)]
	public static bool StringAllNullTerminators(string s)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private static void CreateStreamWriter()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private static void CloseStreamWriter()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public static void Log(string line)
	{
	}

	[CallerCount(Count = 28)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Rigidbody), Member = "set_isKinematic")]
	[Calls(Type = typeof(Rigidbody), Member = "set_collisionDetectionMode")]
	[Calls(Type = typeof(Rigidbody), Member = "set_collisionDetectionMode")]
	[Calls(Type = typeof(Rigidbody), Member = "set_isKinematic")]
	[Calls(Type = typeof(MatchTransform), Member = "EnableCollidersForAllActive")]
	[CallsUnknownMethods(Count = 3)]
	public static void SetIsKinematic(Rigidbody rb, bool enable)
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(MatchTransform), Member = "EnableCollidersForAllActive")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "EnableEquipped")]
	[CallsUnknownMethods(Count = 2)]
	public static void UseHigherPrecisionTimestep(bool enable)
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public static void DebugBulletHit(Vector3 p1, Vector3 p2)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void EnableDebugProjectiles(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public static bool IsVector3NaN(Vector3 v)
	{
		return default(bool);
	}

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern int GetSystemMetrics(SystemMetrics smIndex);

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static bool IsDevelopmentBuild()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static GearItem GetGearItemFromObject(GameObject go)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(FPSLogger.LogData), Member = "FormatForWrite")]
	[CalledBy(Type = typeof(FPSLogger.LogData), Member = "FormatForWrite")]
	[CalledBy(Type = typeof(FPSLogger.LogData), Member = "FormatForWrite")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(FPSLogger.LogData), Member = "FormatForWrite")]
	public static string GetFormattedBytes(double bytes)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSize")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSize")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSize")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSize")]
	[CalledBy(Type = typeof(DetailedStatsView), Member = "Start")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildWhatIKnowList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSize")]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(ContainerUI), Member = "Initialize")]
	[CalledBy(Type = typeof(ConsoleSlider), Member = "Start")]
	[Calls(Type = typeof(GenericSimpleScrollbarSpawner), Member = "Initialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(ContainerUI), Member = "Initialize")]
	public static UISlider GetSliderForScrollbar(GameObject scrollbar)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Milling), Member = "RefreshSelected")]
	[CalledBy(Type = typeof(CraftingRequirementTime), Member = "Enable")]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "RefreshCraftingTimeDisplay")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "TrimEnd")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallerCount(Count = 3)]
	public static string FormatDisplayTimeMinutes(int minutes, bool includeUnits)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(NewsCarousel), Member = "OnItemButtonClicked")]
	[CalledBy(Type = typeof(NewsCarousel), Member = "UpdateActiveCarousel")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessPrivacyMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnViewPrivacyPolicy")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnClickCommunicationButton")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Application), Member = "OpenURL")]
	[Calls(Type = typeof(SteamFriends), Member = "ActivateGameOverlayToWebPage")]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	public static void OpenURL(string url)
	{
	}

	[Calls(Type = typeof(SphericalHarmonicsL2), Member = "get_Item")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "RenderDynamicDecal")]
	[Calls(Type = typeof(SphericalHarmonicsL2), Member = "get_Item")]
	[Calls(Type = typeof(SphericalHarmonicsL2), Member = "get_Item")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(SphericalHarmonicsL2), Member = "get_Item")]
	[Calls(Type = typeof(SphericalHarmonicsL2), Member = "get_Item")]
	[Calls(Type = typeof(SphericalHarmonicsL2), Member = "get_Item")]
	[Calls(Type = typeof(SphericalHarmonicsL2), Member = "get_Item")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(SphericalHarmonicsL2), Member = "get_Item")]
	[Calls(Type = typeof(SphericalHarmonicsL2), Member = "get_Item")]
	[Calls(Type = typeof(SphericalHarmonicsL2), Member = "get_Item")]
	[Calls(Type = typeof(SphericalHarmonicsL2), Member = "get_Item")]
	[Calls(Type = typeof(SphericalHarmonicsL2), Member = "get_Item")]
	public static void SetSHCoefficients(Vector3 position, CommandBuffer commandBuffer)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static int Modulo(int x, int m)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	public static float Ramp(float t)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static float XZDistance(Vector3 a, Vector3 b)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static float XZMagnitude(Vector3 vec)
	{
		return default(float);
	}

	[CallerCount(Count = 148)]
	public static bool Approximately(float a, float b, float epsilon = 0.0001f)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "Update")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "Update")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "Update")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "Update")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "Update")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "Update")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "Update")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "Update")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "Update")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "Update")]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "Update")]
	public static bool IsZero(float a, float epsilon = 0.0001f)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public static bool Approximately(double a, double b, double epsilon = 0.0001)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public static bool IsZero(double a, double epsilon = 0.0001)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	public static Vector3 GetDirectionVector(Vector3 from, Vector3 to)
	{
		return default(Vector3);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	public static float AngleDir(Vector3 fwd, Vector3 targetDir, Vector3 up)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Action_FaceTarget), Member = "GetTurnSpeed")]
	[CalledBy(Type = typeof(Action_FaceTarget), Member = "OnUpdate")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAnimationParameters")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetTurnSpeedAnimationParameter")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Wind), Member = "GetWindAngleRelativeToPlayer")]
	public static float GetAngleDegrees(Vector3 v1, Vector3 v2)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	public static Vector3 GetFlatVector(Vector3 v1)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "CalculateSlopeUnderPosition")]
	public static float CalculateSlopeUnderPosition(Vector3 pos)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(FootStepSounds), Member = "SetPlayerInclineRTPC")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Utils), Member = "CalculateSlopeUnderPosition")]
	[CalledBy(Type = typeof(Sprains), Member = "MaybeSprainWhileMoving")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeFleeOnSlope")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(PhysicsScene), Member = "SphereCast")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 4)]
	public static float CalculateSlopeUnderPosition(Vector3 pos, int ignoreMask)
	{
		return default(float);
	}

	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[CalledBy(Type = typeof(CarcassSite), Member = "StickToGroundAndOrientOnSlope")]
	[CalledBy(Type = typeof(GearItem), Member = "StickToGroundAndOrientOnSlope")]
	[CalledBy(Type = typeof(BodyCarry), Member = "StickBodyToGroundAtPlayersFeet")]
	[CalledBy(Type = typeof(Inventory), Member = "PositionAndRotateScatteredItem")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdatePlayerTransformForHunted2Dragging")]
	[CallsUnknownMethods(Count = 4)]
	public static Quaternion GetOrientationOnSlope(Transform t, Vector3 groundNormal)
	{
		return default(Quaternion);
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Utils), Member = "OrientedBoundingBoxesOverlap")]
	[Calls(Type = typeof(Vector3), Member = "get_Item")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_Item")]
	[Calls(Type = typeof(Vector3), Member = "get_Item")]
	public static bool TestOBBOBB(OBB a, OBB b)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Transform), Member = "get_lossyScale")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "Overlaps")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ObjectToPlaceOverlapsWithInteractiveProp")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ObjectToPlaceOverlapsLeanTo")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ObjectToPlaceOverlapsSnowShelter")]
	[Calls(Type = typeof(Utils), Member = "TestOBBOBB")]
	[Calls(Type = typeof(Transform), Member = "get_lossyScale")]
	[Calls(Type = typeof(Transform), Member = "get_lossyScale")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(BoxCollider), Member = "get_center")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[CallsDeduplicatedMethods(Count = 23)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(BoxCollider), Member = "get_size")]
	public static bool OrientedBoundingBoxesOverlap(GameObject a, GameObject b)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "BeginClimbing")]
	[CallsUnknownMethods(Count = 1)]
	public static Vector3 NearestPointInfinite(Vector3 lineStart, Vector3 lineEnd, Vector3 point)
	{
		return default(Vector3);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(SnowDepthCapsuleRecord), Member = "GetDepthFracAtPosition")]
	public static Vector3 NearestPoint(Vector3 lineStart, Vector3 lineEnd, Vector3 point)
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(DebugUtils), Member = "ShowFrustum")]
	[CalledBy(Type = typeof(DebugUtils), Member = "ShowFrustum")]
	[CallerCount(Count = 2)]
	public static Vector3 Plane3Intersect(Plane p1, Plane p2, Plane p3)
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(Condition_VisibilityTest), Member = "OnCheck")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 1)]
	public static bool SphereIntersectsCone(Vector3 sphereCentre, float sphereRadius, Vector3 conePoint, Vector3 coneUnitAxis, float coneAngle)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static float Berp(float start, float end, float value)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static float Bounce(float x, int num = 8)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static float Sway(float x, int num = 8)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public static float AlmostIdentity(float val, float threshold, float thresholdVal)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static float Impulse(float t, float span)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public static float CubicPulse(float t, float centre, float falloffDist)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static float ExpStep(float t, float exp, float pow)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static float Parabola(float t, float pow)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static float PowCurve(float t, float scale, float powA, float powB)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public static float SmoothMinExp(float a, float b, float k)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public static float SmoothMinPoly(float a, float b, float k)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public static float SmoothMinPow(float a, float b, float k)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public static float EaseInCubic(float t, float duration)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public static float EaseOutCubic(float t, float duration)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public static float EaseInOutCubic(float t, float duration)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public static float EaseOutBounce(float t, float duration)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public static float ExpFilterWeight(float deltaTime, float timeConstant)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(PlayerStunned), Member = "UpdateLowHealthStagger")]
	[CalledBy(Type = typeof(PlayerStunned), Member = "UpdateLowHealthStagger")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "GetAdjustedViewAngles")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "UpdatePosition")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "GetPositionOnRope")]
	[CalledBy(Type = typeof(Wind), Member = "RefreshSettings")]
	[CalledBy(Type = typeof(Condition), Member = "ApplyLowHealthStagger")]
	[CalledBy(Type = typeof(Condition), Member = "ApplyLowHealthStagger")]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(Wind), Member = "RefreshSettings")]
	public static float ExpStep(float prevFilt, float next, float deltaTime, float timeConstant)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public static float ExpStep(float prevFilt, float next, float deltaTime, float timeConstant, float maxVel)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "LerpAngle")]
	public static float ExpStepAngle(float prevFilt, float next, float deltaTime, float timeConstant)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public static Vector2 ExpStep(Vector2 prevFilt, Vector2 next, float deltaTime, float timeConstant)
	{
		return default(Vector2);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector2), Member = "get_normalized")]
	[CallsUnknownMethods(Count = 1)]
	public static Vector2 ExpStep(Vector2 prevFilt, Vector2 next, float deltaTime, float timeConstant, float maxVel)
	{
		return default(Vector2);
	}

	[CallerCount(Count = 0)]
	public static Vector3 ExpStep(Vector3 prevFilt, Vector3 next, float deltaTime, float timeConstant)
	{
		return default(Vector3);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public static Vector3 ExpStep(Vector3 prevFilt, Vector3 next, float deltaTime, float timeConstant, float maxVel)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Quaternion ExpStep(Quaternion prevFilt, Quaternion next, float deltaTime, float timeConstant)
	{
		return default(Quaternion);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Quaternion ExpStepSlerp(Quaternion prevFilt, Quaternion next, float deltaTime, float timeConstant)
	{
		return default(Quaternion);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static float ShortestAngle(float targetAngle, float sourceAngle)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(Utils), Member = "GetPatchHeightAtPosition")]
	[CalledBy(Type = typeof(Utils), Member = "GetPatchHeightAtPosition")]
	[CalledBy(Type = typeof(Utils), Member = "GetPatchHeightAtPosition")]
	[CalledBy(Type = typeof(Utils), Member = "GetPatchHeightAtPosition")]
	[CalledBy(Type = typeof(Utils), Member = "GetPatchHeightAtPosition")]
	[CalledBy(Type = typeof(Utils), Member = "GetPatchHeightAtPosition")]
	[CalledBy(Type = typeof(Utils), Member = "GetPatchHeightAtPosition")]
	[CalledBy(Type = typeof(DebugUtils), Member = "ShowHermitePatch")]
	[CalledBy(Type = typeof(Utils), Member = "GetPatchHeightAtPosition")]
	[CalledBy(Type = typeof(DebugUtils), Member = "ShowHermitePatch")]
	[CalledBy(Type = typeof(DebugUtils), Member = "ShowHermitePatch")]
	[CalledBy(Type = typeof(DebugUtils), Member = "ShowHermitePatch")]
	[CalledBy(Type = typeof(DebugUtils), Member = "ShowHermitePatch")]
	[CallerCount(Count = 14)]
	[CalledBy(Type = typeof(Utils), Member = "GetPatchHeightAtPosition")]
	public static float CalcHermite(float p0, float m0, float p1, float m1, float t)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(Utils), Member = "GetPatchHeightTangentAtPosition")]
	[CalledBy(Type = typeof(Utils), Member = "GetPatchHeightTangentAtPosition")]
	[CalledBy(Type = typeof(Utils), Member = "GetPatchHeightTangentAtPosition")]
	[CalledBy(Type = typeof(Utils), Member = "GetPatchHeightTangentAtPosition")]
	[CalledBy(Type = typeof(Utils), Member = "GetPatchHeightTangentAtPosition")]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(Utils), Member = "GetPatchHeightTangentAtPosition")]
	[CalledBy(Type = typeof(Utils), Member = "GetPatchHeightTangentAtPosition")]
	[CalledBy(Type = typeof(Utils), Member = "GetPatchHeightTangentAtPosition")]
	[CalledBy(Type = typeof(Utils), Member = "GetPatchHeightTangentAtPosition")]
	public static float CalcHermiteTangent(float p0, float m0, float p1, float m1, float t)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "ComputeSqrDistanceToNearest")]
	[CallsUnknownMethods(Count = 1)]
	public static Vector2 GeneratePoissonSample(List<Vector2> samples, int maxCandidates)
	{
		return default(Vector2);
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Utils), Member = "GeneratePoissonSample")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CallerCount(Count = 1)]
	public static float ComputeSqrDistanceToNearest(List<Vector2> samples, Vector2 candidate)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public static float DistanceSqr(Vector2 a, Vector2 b)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public static float DistanceSqr(Vector3 a, Vector3 b)
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static float Sqr(float a)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public static float FastSqrDist2DJob(float4 a, float4 b)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(GearItem), Member = "MaybeAddToLostAndFound")]
	[Calls(Type = typeof(Utils), Member = "TestAabbAxis")]
	[Calls(Type = typeof(Utils), Member = "TestAabbAxis")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "TestAabbAxis")]
	public static bool AabbOverlap(Bounds a, Bounds b, out Vector3 axis, out float distance)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref axis) = null;
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref distance) = null;
		return default(bool);
	}

	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Utils), Member = "AabbOverlap")]
	[CalledBy(Type = typeof(Utils), Member = "AabbOverlap")]
	[CalledBy(Type = typeof(Utils), Member = "AabbOverlap")]
	public static bool TestAabbAxis(Vector3 axis, Bounds a, Bounds b, ref Vector3 minimumTranslationAxis, ref float minimumTranslationDistanceSqr)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BipedMoveAgent), Member = "MoveToWeight")]
	[CalledBy(Type = typeof(SpotLightController), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(SpotLightController), Member = "UpdateTarget")]
	public static float MoveToValue(float currentValue, float desiredValue, float speed)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(Action_MissionUpdateTexture), Member = "get_info")]
	[CalledBy(Type = typeof(Action_MissionMarkComplete), Member = "get_info")]
	[CalledBy(Type = typeof(Action_MissionUpdateTimer), Member = "get_info")]
	[CalledBy(Type = typeof(Action_MissionUpdateDesc), Member = "get_info")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Action_MissionAddNew), Member = "get_info")]
	[Calls(Type = typeof(Utils), Member = "MaybePopulateMissionIds")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Action_MissionUpdateName), Member = "get_info")]
	public static bool MissionIDExists(string missionID)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Action_ObjectiveToggleInvisible), Member = "get_info")]
	[CalledBy(Type = typeof(Action_ObjectiveCompleteMain), Member = "get_info")]
	[CalledBy(Type = typeof(Action_ObjectiveUpdateTimer), Member = "get_info")]
	[CalledBy(Type = typeof(Action_ObjectiveUpdateDesc), Member = "get_info")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Condition_ObjectiveCompleted), Member = "get_info")]
	[Calls(Type = typeof(Utils), Member = "MaybePopulateMissionIds")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Action_ObjectiveAddNew), Member = "get_info")]
	public static bool ObjectiveIDExists(string objectiveID)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Action_RemoveMissionMarkerFromMap), Member = "get_info")]
	[CalledBy(Type = typeof(Action_RevealMapLocation), Member = "get_info")]
	[Calls(Type = typeof(Utils), Member = "MaybePopulateMissionMapMarkerList")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Action_AddMissionMarkerToMap), Member = "get_info")]
	public static bool MissionMapMarkerIDExists(string markerID)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CalledBy(Type = typeof(Utils), Member = "MissionMapMarkerIDExists")]
	[CallsUnknownMethods(Count = 18)]
	private static void MaybePopulateMissionMapMarkerList()
	{
	}

	[CalledBy(Type = typeof(Utils), Member = "ObjectiveIDExists")]
	[CallsUnknownMethods(Count = 38)]
	[Calls(Type = typeof(MissionInfo), Member = "ReleaseAllMissionInfos")]
	[CalledBy(Type = typeof(Utils), Member = "MissionIDExists")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MissionInfo), Member = "GetAllMissionInfos")]
	private static void MaybePopulateMissionIds()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectUnderCrosshairs")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[CalledBy(Type = typeof(Elevator), Member = "GetInteractedDoor")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	public static bool RaycastNearest(Vector3 origin, Vector3 direction, out RaycastHit hit, float maxDistance, int layerMask)
	{
		System.Runtime.CompilerServices.Unsafe.As<RaycastHit, @null>(ref hit) = null;
		return default(bool);
	}

	[Calls(Type = typeof(Texture2D), Member = "Apply")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	[Calls(Type = typeof(Texture2D), Member = "GetPixelBilinear")]
	[Calls(Type = typeof(Texture2D), Member = "SetPixel")]
	[CallsUnknownMethods(Count = 7)]
	public static Texture2D GetBilinearScaledTexture(Texture2D source, int targetWidth, int targetHeight)
	{
		return null;
	}

	[CalledBy(Type = typeof(AnimationEvents), Member = "DoEnableObject")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(AnimationEvents), Member = "EventHide")]
	[CalledBy(Type = typeof(CinematicAssets), Member = "LoadTransientProp")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	public static void DisableRenderers(GameObject parent)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "EventShow")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoEnableObject")]
	[CallsUnknownMethods(Count = 2)]
	public static void EnableRenderers(GameObject parent)
	{
	}

	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "Update")]
	[Calls(Type = typeof(Utils), Member = "SetAmbientLightScaled")]
	[CallerCount(Count = 1)]
	public static void SetAmbientLight(Color ambientColor)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(RenderSettings), Member = "get_ambientProbe")]
	[Calls(Type = typeof(Color), Member = "get_linear")]
	[CalledBy(Type = typeof(TodAmbientLight), Member = "SetAmbientLightValue")]
	[CalledBy(Type = typeof(Utils), Member = "SetAmbientLight")]
	[CallsUnknownMethods(Count = 6)]
	public static void SetAmbientLightScaled(Color ambientColor, float probeScalar)
	{
	}

	[Calls(Type = typeof(GL), Member = "TexCoord3")]
	[Calls(Type = typeof(GL), Member = "TexCoord3")]
	[Calls(Type = typeof(Graphics), Member = "SetRenderTarget")]
	[Calls(Type = typeof(GL), Member = "TexCoord3")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[Calls(Type = typeof(GL), Member = "TexCoord3")]
	[Calls(Type = typeof(Shader), Member = "Find")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	public static void ClearWithFullScreenQuad(RenderTexture target, Color clearColor)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(SnowPatch), Member = "GeneratePatchCoefficients")]
	[CalledBy(Type = typeof(SnowPatch), Member = "Initialize")]
	[CalledBy(Type = typeof(SnowImprintCustom), Member = "Reposition")]
	[Calls(Type = typeof(Utils), Member = "ClampPatchCoefficients")]
	[Calls(Type = typeof(Utils), Member = "RaycastForTag")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(Utils), Member = "RaycastForTag")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	public static void GeneratePatchCoefficients(Transform transform, Vector3 minPos, Vector3 maxPos, string tag, ref Vector3[] hermiteCoefficients, out Vector3 heightInfo)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref heightInfo) = null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SnowPatch), Member = "GetPatchHeightAtPosition")]
	[Calls(Type = typeof(Utils), Member = "CalcHermite")]
	[Calls(Type = typeof(Utils), Member = "CalcHermite")]
	[Calls(Type = typeof(Utils), Member = "CalcHermite")]
	[Calls(Type = typeof(Utils), Member = "CalcHermite")]
	[Calls(Type = typeof(Utils), Member = "CalcHermite")]
	[Calls(Type = typeof(Utils), Member = "CalcHermite")]
	[Calls(Type = typeof(Utils), Member = "CalcHermite")]
	[Calls(Type = typeof(Utils), Member = "CalcHermite")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "CalcHermite")]
	public static float GetPatchHeightAtPosition(Vector3 p, Vector3[] hermiteCoefficients)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SnowPatch), Member = "AddImprint")]
	[CalledBy(Type = typeof(SnowPatch), Member = "GetPatchHeightTangentAtPosition")]
	[Calls(Type = typeof(Utils), Member = "CalcHermiteTangent")]
	[Calls(Type = typeof(Utils), Member = "CalcHermiteTangent")]
	[Calls(Type = typeof(Utils), Member = "CalcHermiteTangent")]
	[Calls(Type = typeof(Utils), Member = "CalcHermiteTangent")]
	[Calls(Type = typeof(Utils), Member = "CalcHermiteTangent")]
	[Calls(Type = typeof(Utils), Member = "CalcHermiteTangent")]
	[Calls(Type = typeof(Utils), Member = "CalcHermiteTangent")]
	[Calls(Type = typeof(Utils), Member = "CalcHermiteTangent")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "CalcHermiteTangent")]
	public static float GetPatchHeightTangentAtPosition(Vector3 p, Vector3[] hermiteCoefficients)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(Utils), Member = "GenerateGridMeshQuadrantSet")]
	[CalledBy(Type = typeof(SnowPatchManager), Member = "Start")]
	[CallsUnknownMethods(Count = 9)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Mesh), Member = "set_triangles")]
	public static Mesh BuildGridMeshXZ(Vector2 dims, int vertsX, int vertsY, float uvMin = 0f, float uvMax = 1f)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "BuildGridMeshXZ")]
	[Calls(Type = typeof(Utils), Member = "BuildMeshForGridQuadrantSubset")]
	[CallsUnknownMethods(Count = 11)]
	public static Mesh[] GenerateGridMeshQuadrantSet(Vector3 dims, int edgeVerts, int textureRes, float boundsYSize)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_enable_shadows")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "ApplyShadows")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_enable_shadows")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_Debug), Member = "ApplyShadows")]
	public static void EnableShadows(bool enabled)
	{
	}

	[CallsUnknownMethods(Count = 105)]
	[CalledBy(Type = typeof(Utils), Member = "GenerateGridMeshQuadrantSet")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowKeyNotFoundException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowKeyNotFoundException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowKeyNotFoundException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowKeyNotFoundException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowKeyNotFoundException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[Calls(Type = typeof(Mesh), Member = "get_triangles")]
	[Calls(Type = typeof(Mesh), Member = "set_triangles")]
	[Calls(Type = typeof(Mesh), Member = "DefaultDimensionForChannel")]
	[Calls(Type = typeof(Mesh), Member = "DefaultDimensionForChannel")]
	[Calls(Type = typeof(Mesh), Member = "DefaultDimensionForChannel")]
	[Calls(Type = typeof(Mesh), Member = "DefaultDimensionForChannel")]
	[Calls(Type = typeof(Mesh), Member = "get_triangles")]
	[Calls(Type = typeof(Mesh), Member = "DefaultDimensionForChannel")]
	[Calls(Type = typeof(Mesh), Member = "DefaultDimensionForChannel")]
	[CallsDeduplicatedMethods(Count = 23)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mesh), Member = "DefaultDimensionForChannel")]
	private static Mesh BuildMeshForGridQuadrantSubset(int mask, Mesh refMesh, float minUV)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Utils), Member = "GeneratePatchCoefficients")]
	[CalledBy(Type = typeof(Utils), Member = "GeneratePatchCoefficients")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Component), Member = "CompareTag")]
	private static bool RaycastForTag(string tag, Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask)
	{
		System.Runtime.CompilerServices.Unsafe.As<RaycastHit, @null>(ref hitInfo) = null;
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "CheckHeightAgainstCoords")]
	[Calls(Type = typeof(Utils), Member = "CheckHeightAgainstCoords")]
	[Calls(Type = typeof(Utils), Member = "CheckHeightAgainstCoords")]
	[Calls(Type = typeof(Utils), Member = "CheckHeightAgainstCoords")]
	[CalledBy(Type = typeof(Utils), Member = "GeneratePatchCoefficients")]
	private static void ClampPatchCoefficients(float centerY, float maxDelta)
	{
	}

	[CalledBy(Type = typeof(Utils), Member = "ClampPatchCoefficients")]
	[CalledBy(Type = typeof(Utils), Member = "ClampPatchCoefficients")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Utils), Member = "ClampPatchCoefficients")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Utils), Member = "ClampPatchCoefficients")]
	[CallerCount(Count = 4)]
	private static float CheckHeightAgainstCoords(float py, float maxDelta, int x, int z)
	{
		return default(float);
	}

	[CallerCount(Count = 43)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	public static string SerializeObject(object obj)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 406)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static T DeserializeObject<T>(string text) where T : new()
	{
		return (T)null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FastSpline), Member = "Allocate")]
	[CallsUnknownMethods(Count = 1)]
	public static FastSpline CreateFastSpline(Spline spline, NativeArray<double> matrix)
	{
		return default(FastSpline);
	}

	[Calls(Type = typeof(Utils), Member = "GetClosestPointParamOnSegmentIntern")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetClosestPointParamOnSegmentIntern")]
	public static float GetClosestPointParamOnSpline(Vector3 position, ref FastSpline spline)
	{
		return default(float);
	}

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "RecalculateParameter")]
	[Calls(Type = typeof(FastSpline), Member = "GetPositionInternal")]
	[CalledBy(Type = typeof(SplineManager.FastSplineJob), Member = "Execute")]
	[CalledBy(Type = typeof(SplineManager.FastSplineJob), Member = "Execute")]
	[CalledBy(Type = typeof(Utils), Member = "GetClosestPointParamOnSpline")]
	[CalledBy(Type = typeof(Utils), Member = "GetClosestPointParamOnSpline")]
	private static float GetClosestPointParamOnSegmentIntern(Vector3 point, float start, float end, float step, ref FastSpline spline)
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "RecalculateParameter")]
	[Calls(Type = typeof(FastSpline), Member = "GetPositionInternal")]
	[CalledBy(Type = typeof(SplineManager.FastSplineJob), Member = "Execute")]
	public static Vector3 GetPositionOnSpline(ref FastSpline spline, float param)
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(FastSpline), Member = "Allocate")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SplineAudioClip), Member = "Awake")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public static int GetValidNodesCount(Spline spline)
	{
		return default(int);
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Utils), Member = "GetClosestPointParamOnSegmentIntern")]
	[CalledBy(Type = typeof(Utils), Member = "GetPositionOnSpline")]
	private static SegmentParameter RecalculateParameter(double param, ref FastSpline spline)
	{
		return default(SegmentParameter);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "ParseSubtitles")]
	public static uint ParseSubtitles(string filename, ref Subtitle[] subtitles)
	{
		return default(uint);
	}

	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Utils), Member = "ParseSubtitles")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "PlayMovieFromFullPath")]
	[Calls(Type = typeof(StreamReader), Member = ".ctor")]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "ParseSubtitles")]
	public static uint ParseSubtitles(string filename, ref Subtitle[] subtitles, ref long frameRate)
	{
		return default(uint);
	}

	[CalledBy(Type = typeof(CinematicTrack), Member = "LoadCinematicAsync")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "ParseSubtitles")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnCinematicPlay")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "EventDisplaySubtitles")]
	public static uint ParseSubtitles(TextAsset asset, ref Subtitle[] subtitles)
	{
		return default(uint);
	}

	[CalledBy(Type = typeof(Utils), Member = "ParseSubtitles")]
	[Calls(Type = typeof(Utils), Member = "ParseSubtitles")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextAsset), Member = "DecodeString")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(StringReader), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public static uint ParseSubtitles(TextAsset asset, ref Subtitle[] subtitles, ref long frameRate)
	{
		return default(uint);
	}

	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(Utils), Member = "ParseSubtitles")]
	[CalledBy(Type = typeof(Utils), Member = "ParseSubtitles")]
	[Calls(Type = typeof(Localization), Member = "Exists")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "Split")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Exists")]
	private static uint ParseSubtitles(TextReader reader, ref Subtitle[] subtitles, ref long frameRate, string errorName)
	{
		return default(uint);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static uint GetNextEndOrStartFrame(uint frame, Subtitle[] subtitles, uint numSubtitles)
	{
		return default(uint);
	}

	[CalledBy(Type = typeof(MoviePlayer), Member = "UpdatePlayback")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "UpdatePlaying")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoUpdate")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematic")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_Subtitles), Member = "ShowSubtitles")]
	public static void UpdateSubtitles(uint frame, Subtitle[] subtitles, uint numSubtitles)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static uint GetSubtitleFrame(float currentTimeSeconds, long frameRate = 24L)
	{
		return default(uint);
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematic")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "UpdatePlaying")]
	[CallsUnknownMethods(Count = 3)]
	public static float GetNextSkipTime(float currentTimeSeconds, Subtitle[] subtitles, uint numSubtitles, long frameRate = 24L)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "AddSavesOfTypeToMenu")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public static string GetTimeSinceText(TimeSpan timeSince)
	{
		return null;
	}

	[CalledBy(Type = typeof(Action_QueueLoadScreenHint), Member = "get_info")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Action_ForceCustomLoadScreen), Member = "get_info")]
	[CalledBy(Type = typeof(Action_ForceCustomLoadScreen), Member = "get_info")]
	[CalledBy(Type = typeof(Action_QueueLoadScreenHint), Member = "get_info")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Action_QueueLoadScreenHint), Member = "get_info")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Substring")]
	public static string LocKeyPreview(string myKey, bool stripLineBreaks, int clampLength)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(TLD_SetControllerStateTrack), Member = "DoDynamicBinding")]
	[CalledBy(Type = typeof(TLD_SayTrack), Member = "DoDynamicBinding")]
	[CalledBy(Type = typeof(TLD_AudioTrack), Member = "DoDynamicBinding")]
	[CalledBy(Type = typeof(TLD_AnimationTrack), Member = "DoDynamicBinding")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(TLD_ActivationTrack), Member = "DoDynamicBinding")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "GetGameObjectOverride")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Utils), Member = "FindChildRecursive")]
	public static GameObject FindTimelineDynamicBinding(string trackName, PlayableDirector director, string missionObjectId, string childObjectName = "")
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static bool IsAllowedToAccessNetwork()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(NewsCarousel), Member = "RetrieveNewsFromServer")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(NewsCarousel), Member = "DownloadTexture")]
	[CalledBy(Type = typeof(WebUtils), Member = "DownloadData")]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager.EnumerateFilesOperation), Member = "WebRequestEnumerateFiles")]
	[CallerCount(Count = 4)]
	[IteratorStateMachine(typeof(_003CWebRequest_003Ed__334))]
	public static IEnumerator WebRequest(string url, Action<UnityWebRequest> onSuccess, Action<UnityWebRequest> onFailure = null)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CWebRequest_003Ed__335))]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager.DeleteOperation), Member = "WebRequestDeleteData")]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager.UploadOperation), Member = "WebRequestBeginUploadData")]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager.UploadOperation), Member = "WebRequestCommitUpload")]
	[CallsUnknownMethods(Count = 6)]
	public static IEnumerator WebRequest(string url, WWWForm form, Action<UnityWebRequest> onSuccess, Action<UnityWebRequest> onFailure = null)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager.UploadOperation), Member = "WebRequestUploadData")]
	[IteratorStateMachine(typeof(_003CWebRequestPut_003Ed__336))]
	[CallerCount(Count = 1)]
	public static IEnumerator WebRequestPut(string url, byte[] data, Dictionary<string, string> httpHeaders, Action<UnityWebRequest> onSuccess, Action<UnityWebRequest> onFailure = null)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CalledBy(Type = typeof(_003CWebRequest_003Ed__334), Member = "MoveNext")]
	[CalledBy(Type = typeof(_003CWebRequest_003Ed__335), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 1)]
	private static bool PreValidatRequest(ref string url)
	{
		return default(bool);
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public Utils()
	{
	}
}
