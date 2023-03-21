using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CameraPathAnimator : MonoBehaviour
{
	public enum animationModes
	{
		once,
		loop,
		reverse,
		reverseLoop,
		pingPong,
		still
	}

	public enum orientationModes
	{
		custom,
		target,
		mouselook,
		followpath,
		reverseFollowpath,
		followTransform,
		twoDimentions,
		fixedOrientation,
		none
	}

	public delegate void AnimationStartedEventHandler();

	public delegate void AnimationPausedEventHandler();

	public delegate void AnimationStoppedEventHandler();

	public delegate void AnimationFinishedEventHandler();

	public delegate void AnimationLoopedEventHandler();

	public delegate void AnimationPingPongEventHandler();

	public delegate void AnimationPointReachedEventHandler();

	public delegate void AnimationCustomEventHandler(string eventName);

	public delegate void AnimationPointReachedWithNumberEventHandler(int pointNumber);

	public float minimumCameraSpeed;

	public Transform orientationTarget;

	private CameraPath _cameraPath;

	public bool playOnStart;

	public Transform animationObject;

	private Camera animationObjectCamera;

	private bool _isCamera;

	private bool _playing;

	public animationModes animationMode;

	private orientationModes _orientationMode;

	public bool smoothOrientationModeChanges;

	public float orientationModeLerpTime;

	private float _orientationModeLerpTimer;

	private orientationModes _previousOrientationMode;

	private float pingPongDirection;

	public Vector3 fixedOrientaion;

	public Vector3 fixedPosition;

	public bool normalised;

	private bool _dynamicNormalisation;

	public float editorPercentage;

	private float _pathTime;

	private float _pathSpeed;

	private float _percentage;

	private float _lastPercentage;

	public float nearestOffset;

	private float _delayTime;

	public float startPercent;

	public bool animateFOV;

	public Vector3 targetModeUp;

	public float sensitivity;

	public float minX;

	public float maxX;

	private bool _animateSceneObjectInEditor;

	public Vector3 animatedObjectStartPosition;

	public Quaternion animatedObjectStartRotation;

	public float pathSpeed
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
		[Calls(Type = typeof(Debug), Member = "LogWarning")]
		[Calls(Type = typeof(CameraPathPointList), Member = "get_realNumberOfPoints")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		set
		{
		}
	}

	public float animationTime
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Debug), Member = "LogWarning")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public float currentTime
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
	}

	public bool isPlaying
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public float percentage
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(float);
		}
	}

	public bool pingPongGoingForward
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public CameraPath cameraPath
	{
		[CallerCount(Count = 27)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		get
		{
			return null;
		}
	}

	public bool dynamicNormalisation
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public orientationModes orientationMode
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		get
		{
			return default(orientationModes);
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	private bool isReversed
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public bool isCamera
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(CameraPathAnimator), Member = "UpdateAnimation")]
		[CalledBy(Type = typeof(CameraPathAnimator), Member = "Update")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[CallerCount(Count = 2)]
		get
		{
			return default(bool);
		}
	}

	public bool animateSceneObjectInEditor
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(bool);
		}
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 10)]
		[Calls(Type = typeof(Transform), Member = "get_rotation")]
		[Calls(Type = typeof(Transform), Member = "get_position")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public event AnimationStartedEventHandler AnimationStartedEvent
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		add
		{
		}
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		remove
		{
		}
	}

	public event AnimationPausedEventHandler AnimationPausedEvent
	{
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		add
		{
		}
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CompilerGenerated]
		remove
		{
		}
	}

	public event AnimationStoppedEventHandler AnimationStoppedEvent
	{
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		add
		{
		}
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CompilerGenerated]
		remove
		{
		}
	}

	public event AnimationFinishedEventHandler AnimationFinishedEvent
	{
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		remove
		{
		}
	}

	public event AnimationLoopedEventHandler AnimationLoopedEvent
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		add
		{
		}
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		remove
		{
		}
	}

	public event AnimationPingPongEventHandler AnimationPingPongEvent
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		add
		{
		}
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		remove
		{
		}
	}

	public event AnimationPointReachedEventHandler AnimationPointReachedEvent
	{
		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CompilerGenerated]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallerCount(Count = 0)]
		add
		{
		}
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		remove
		{
		}
	}

	public event AnimationPointReachedWithNumberEventHandler AnimationPointReachedWithNumberEvent
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		add
		{
		}
		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		remove
		{
		}
	}

	public event AnimationCustomEventHandler AnimationCustomEvent
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		remove
		{
		}
	}

	[CalledBy(Type = typeof(CameraPathAnimator), Member = "Start")]
	[Calls(Type = typeof(CameraPathAnimator), Member = "get_cameraPath")]
	[Calls(Type = typeof(CameraPathAnimator), Member = "get_cameraPath")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(CameraPathAnimator), Member = "PlayNextAnimation")]
	public void Play()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Stop()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Pause()
	{
	}

	[Calls(Type = typeof(CameraPathAnimator), Member = "UpdateAnimation")]
	[Calls(Type = typeof(CameraPathAnimator), Member = "UpdatePointReached")]
	[Calls(Type = typeof(CameraPathAnimator), Member = "UpdateAnimationTime")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Seek(float value)
	{
	}

	[CallerCount(Count = 0)]
	public void Reverse()
	{
	}

	[Calls(Type = typeof(CameraPath), Member = "GetPathDirection")]
	[Calls(Type = typeof(CameraPathAnimator), Member = "get_cameraPath")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(CameraPath), Member = "GetNearestPoint")]
	[Calls(Type = typeof(CameraPathTiltList), Member = "GetTilt")]
	[Calls(Type = typeof(CameraPath), Member = "ParsePercentage")]
	[Calls(Type = typeof(CameraPathAnimator), Member = "get_cameraPath")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	[Calls(Type = typeof(CameraPath), Member = "GetPathDirection")]
	[Calls(Type = typeof(CameraPathAnimator), Member = "get_cameraPath")]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(CameraPathTiltList), Member = "GetTilt")]
	[Calls(Type = typeof(CameraPath), Member = "ParsePercentage")]
	[Calls(Type = typeof(CameraPath), Member = "ParsePercentage")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(CameraPathAnimator), Member = "get_cameraPath")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Vector3), Member = "get_forward")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(CameraPath), Member = "GetPathPosition")]
	[Calls(Type = typeof(CameraPathAnimator), Member = "get_cameraPath")]
	[Calls(Type = typeof(CameraPathAnimator), Member = "get_cameraPath")]
	[Calls(Type = typeof(CameraPathAnimator), Member = "get_cameraPath")]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	[CallsUnknownMethods(Count = 24)]
	[CalledBy(Type = typeof(CameraPathAnimator), Member = "GetAnimatedOrientation")]
	[CalledBy(Type = typeof(CameraPathAnimator), Member = "GetAnimatedOrientation")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(CameraPathAnimator), Member = "get_cameraPath")]
	[Calls(Type = typeof(CameraPath), Member = "ParsePercentage")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(CameraPathAnimator), Member = "get_cameraPath")]
	[Calls(Type = typeof(CameraPathOrientationList), Member = "GetOrientation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Vector3), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	[Calls(Type = typeof(Application), Member = "get_isPlaying")]
	[Calls(Type = typeof(CameraPathAnimator), Member = "get_cameraPath")]
	[Calls(Type = typeof(CameraPath), Member = "GetPathDirection")]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	[Calls(Type = typeof(CameraPathAnimator), Member = "GetMouseLook")]
	[Calls(Type = typeof(CameraPathAnimator), Member = "get_cameraPath")]
	[Calls(Type = typeof(CameraPath), Member = "GetPathDirection")]
	[Calls(Type = typeof(CameraPath), Member = "GetPathPosition")]
	public Quaternion GetOrientation(orientationModes mode, float percent, bool ignoreNormalisation)
	{
		return default(Quaternion);
	}

	[Calls(Type = typeof(CameraPathAnimator), Member = "GetOrientation")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(CameraPathAnimator), Member = "GetOrientation")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Mathf), Member = "SmoothStep")]
	[CalledBy(Type = typeof(CameraPathAnimator), Member = "UpdateAnimation")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	public Quaternion GetAnimatedOrientation(float percent, bool ignoreNormalisation)
	{
		return default(Quaternion);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Camera), Member = "get_allCameras")]
	private void Awake()
	{
	}

	[Calls(Type = typeof(CameraPathAnimator), Member = "get_cameraPath")]
	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(CameraPathDelayList), Member = "add_CameraPathDelayEvent")]
	[Calls(Type = typeof(CameraPathAnimator), Member = "get_cameraPath")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(CameraPathEventList), Member = "add_CameraPathEventPoint")]
	private void OnEnable()
	{
	}

	[Calls(Type = typeof(CameraPathAnimator), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CameraPathAnimator), Member = "get_isCamera")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(CameraPathAnimator), Member = "PlayNextAnimation")]
	[Calls(Type = typeof(CameraPathAnimator), Member = "UpdateAnimation")]
	[Calls(Type = typeof(CameraPathAnimator), Member = "UpdatePointReached")]
	[Calls(Type = typeof(CameraPathAnimator), Member = "UpdateAnimationTime")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void Update()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void LateUpdate()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPathAnimator), Member = "CleanUp")]
	private void OnDisable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPathAnimator), Member = "CleanUp")]
	private void OnDestroy()
	{
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(CameraPathAnimator), Member = "UpdateAnimationTime")]
	[Calls(Type = typeof(CameraPathAnimator), Member = "UpdatePointReached")]
	[Calls(Type = typeof(CameraPathAnimator), Member = "UpdateAnimation")]
	[Calls(Type = typeof(CameraPathAnimator), Member = "Play")]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(CameraPathAnimator), Member = "Update")]
	private void PlayNextAnimation()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(CameraPathAnimator), Member = "get_isCamera")]
	[Calls(Type = typeof(Camera), Member = "get_orthographic")]
	[Calls(Type = typeof(CameraPath), Member = "ParsePercentage")]
	[Calls(Type = typeof(CameraPathFOVList), Member = "GetValue")]
	[Calls(Type = typeof(Camera), Member = "set_orthographicSize")]
	[Calls(Type = typeof(CameraPathAnimator), Member = "get_cameraPath")]
	[Calls(Type = typeof(CameraPath), Member = "ParsePercentage")]
	[Calls(Type = typeof(CameraPathEventList), Member = "CheckEvents")]
	[Calls(Type = typeof(CameraPathAnimator), Member = "GetAnimatedOrientation")]
	[Calls(Type = typeof(CameraPathDelayList), Member = "CheckEvents")]
	[Calls(Type = typeof(CameraPathFOVList), Member = "GetValue")]
	[CallsUnknownMethods(Count = 28)]
	[Calls(Type = typeof(Camera), Member = "set_fieldOfView")]
	[CalledBy(Type = typeof(CameraPathAnimator), Member = "PlayNextAnimation")]
	[CalledBy(Type = typeof(CameraPathAnimator), Member = "Update")]
	[CalledBy(Type = typeof(CameraPathAnimator), Member = "Seek")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(CameraPath), Member = "ParsePercentage")]
	[Calls(Type = typeof(CameraPath), Member = "GetPathPosition")]
	[Calls(Type = typeof(CameraPathAnimator), Member = "get_cameraPath")]
	[Calls(Type = typeof(CameraPathDelayList), Member = "CheckEase")]
	[Calls(Type = typeof(CameraPathAnimator), Member = "get_cameraPath")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(CameraPathPointList), Member = "get_realNumberOfPoints")]
	[Calls(Type = typeof(CameraPathAnimator), Member = "get_cameraPath")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CameraPathSpeedList), Member = "GetSpeed")]
	[Calls(Type = typeof(CameraPathDelayList), Member = "CheckEase")]
	[Calls(Type = typeof(CameraPathAnimator), Member = "get_cameraPath")]
	[Calls(Type = typeof(CameraPath), Member = "ParsePercentage")]
	[Calls(Type = typeof(CameraPath), Member = "ParsePercentage")]
	private void UpdateAnimation()
	{
	}

	[CalledBy(Type = typeof(CameraPathAnimator), Member = "PlayNextAnimation")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(CameraPathAnimator), Member = "Update")]
	[CalledBy(Type = typeof(CameraPathAnimator), Member = "Seek")]
	[Calls(Type = typeof(CameraPathAnimator), Member = "get_cameraPath")]
	[Calls(Type = typeof(CameraPath), Member = "get_Item")]
	[Calls(Type = typeof(CameraPathAnimator), Member = "get_cameraPath")]
	[Calls(Type = typeof(CameraPath), Member = "get_realNumberOfPoints")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CameraPathAnimator), Member = "get_cameraPath")]
	private void UpdatePointReached()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPathAnimator), Member = "UpdateAnimationTime")]
	private void UpdateAnimationTime()
	{
	}

	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(CameraPathAnimator), Member = "UpdateAnimationTime")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CalledBy(Type = typeof(CameraPathAnimator), Member = "Seek")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(CameraPathAnimator), Member = "Update")]
	[CalledBy(Type = typeof(CameraPathAnimator), Member = "PlayNextAnimation")]
	private void UpdateAnimationTime(bool advance)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[CalledBy(Type = typeof(CameraPathAnimator), Member = "GetOrientation")]
	[CallsUnknownMethods(Count = 7)]
	[CallsDeduplicatedMethods(Count = 8)]
	private Quaternion GetMouseLook()
	{
		return default(Quaternion);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPathAnimator), Member = "get_cameraPath")]
	[Calls(Type = typeof(CameraPath), Member = "ParsePercentage")]
	[Calls(Type = typeof(CameraPathEventList), Member = "CheckEvents")]
	[Calls(Type = typeof(CameraPathDelayList), Member = "CheckEvents")]
	[CallsUnknownMethods(Count = 1)]
	private void CheckEvents()
	{
	}

	[Calls(Type = typeof(CameraPathAnimator), Member = "get_cameraPath")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CameraPathAnimator), Member = "get_cameraPath")]
	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(CameraPathAnimator), Member = "OnDestroy")]
	[CalledBy(Type = typeof(CameraPathAnimator), Member = "OnDisable")]
	[Calls(Type = typeof(CameraPathDelayList), Member = "add_CameraPathDelayEvent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(CameraPathEventList), Member = "add_CameraPathEventPoint")]
	[Calls(Type = typeof(CameraPathAnimator), Member = "get_cameraPath")]
	private void CleanUp()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnDelayEvent(float time)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnCustomEvent(string eventName)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public CameraPathAnimator()
	{
	}
}
