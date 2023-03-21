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
			return 0f;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CameraPathPointList), Member = "get_realNumberOfPoints")]
		[Calls(Type = typeof(Debug), Member = "LogWarning")]
		[CallsDeduplicatedMethods(Count = 1)]
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
			return 0f;
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
			return 0f;
		}
	}

	public bool isPlaying
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
	}

	public float percentage
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0f;
		}
	}

	public bool pingPongGoingForward
	{
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
	}

	public CameraPath cameraPath
	{
		[CalledBy(Type = typeof(CameraPathAnimator), Member = "Play")]
		[CalledBy(Type = typeof(CameraPathAnimator), Member = "GetOrientation")]
		[CalledBy(Type = typeof(CameraPathAnimator), Member = "OnEnable")]
		[CalledBy(Type = typeof(CameraPathAnimator), Member = "UpdateAnimation")]
		[CalledBy(Type = typeof(CameraPathAnimator), Member = "UpdatePointReached")]
		[CalledBy(Type = typeof(CameraPathAnimator), Member = "CheckEvents")]
		[CalledBy(Type = typeof(CameraPathAnimator), Member = "CleanUp")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(Component), Member = "GetComponent")]
		[CallsDeduplicatedMethods(Count = 1)]
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
			return false;
		}
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public orientationModes orientationMode
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
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
			return false;
		}
	}

	public bool isCamera
	{
		[CalledBy(Type = typeof(CameraPathAnimator), Member = "Update")]
		[CalledBy(Type = typeof(CameraPathAnimator), Member = "UpdateAnimation")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	public bool animateSceneObjectInEditor
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Transform), Member = "get_position")]
		[Calls(Type = typeof(Transform), Member = "get_rotation")]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 10)]
		set
		{
		}
	}

	public event AnimationStartedEventHandler AnimationStartedEvent
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	public event AnimationPausedEventHandler AnimationPausedEvent
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	public event AnimationStoppedEventHandler AnimationStoppedEvent
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	public event AnimationFinishedEventHandler AnimationFinishedEvent
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	public event AnimationLoopedEventHandler AnimationLoopedEvent
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	public event AnimationPingPongEventHandler AnimationPingPongEvent
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	public event AnimationPointReachedEventHandler AnimationPointReachedEvent
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	public event AnimationPointReachedWithNumberEventHandler AnimationPointReachedWithNumberEvent
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	public event AnimationCustomEventHandler AnimationCustomEvent
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	[CalledBy(Type = typeof(CameraPathAnimator), Member = "Start")]
	[CalledBy(Type = typeof(CameraPathAnimator), Member = "PlayNextAnimation")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CameraPathAnimator), Member = "get_cameraPath")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void Play()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Stop()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Pause()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPathAnimator), Member = "UpdateAnimationTime")]
	[Calls(Type = typeof(CameraPathAnimator), Member = "UpdatePointReached")]
	[Calls(Type = typeof(CameraPathAnimator), Member = "UpdateAnimation")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Seek(float value)
	{
	}

	[CallerCount(Count = 0)]
	public void Reverse()
	{
	}

	[CalledBy(Type = typeof(CameraPathAnimator), Member = "GetAnimatedOrientation")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(CameraPathAnimator), Member = "get_cameraPath")]
	[Calls(Type = typeof(CameraPath), Member = "ParsePercentage")]
	[Calls(Type = typeof(CameraPathOrientationList), Member = "GetOrientation")]
	[Calls(Type = typeof(CameraPath), Member = "GetPathPosition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Vector3), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	[Calls(Type = typeof(Application), Member = "get_isPlaying")]
	[Calls(Type = typeof(CameraPath), Member = "GetPathDirection")]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	[Calls(Type = typeof(CameraPathAnimator), Member = "GetMouseLook")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(CameraPathTiltList), Member = "GetTilt")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(CameraPath), Member = "GetNearestPoint")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 24)]
	public Quaternion GetOrientation(orientationModes mode, float percent, bool ignoreNormalisation)
	{
		return default(Quaternion);
	}

	[CalledBy(Type = typeof(CameraPathAnimator), Member = "UpdateAnimation")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CameraPathAnimator), Member = "GetOrientation")]
	[Calls(Type = typeof(Mathf), Member = "SmoothStep")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	public Quaternion GetAnimatedOrientation(float percent, bool ignoreNormalisation)
	{
		return default(Quaternion);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Camera), Member = "get_allCameras")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPathAnimator), Member = "get_cameraPath")]
	[Calls(Type = typeof(CameraPathEventList), Member = "add_CameraPathEventPoint")]
	[Calls(Type = typeof(CameraPathDelayList), Member = "add_CameraPathDelayEvent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 19)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPathAnimator), Member = "Play")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPathAnimator), Member = "get_isCamera")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(CameraPathAnimator), Member = "PlayNextAnimation")]
	[Calls(Type = typeof(CameraPathAnimator), Member = "UpdateAnimation")]
	[Calls(Type = typeof(CameraPathAnimator), Member = "UpdatePointReached")]
	[Calls(Type = typeof(CameraPathAnimator), Member = "UpdateAnimationTime")]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[CalledBy(Type = typeof(CameraPathAnimator), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(CameraPathAnimator), Member = "UpdateAnimationTime")]
	[Calls(Type = typeof(CameraPathAnimator), Member = "UpdatePointReached")]
	[Calls(Type = typeof(CameraPathAnimator), Member = "UpdateAnimation")]
	[Calls(Type = typeof(CameraPathAnimator), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private void PlayNextAnimation()
	{
	}

	[CalledBy(Type = typeof(CameraPathAnimator), Member = "Seek")]
	[CalledBy(Type = typeof(CameraPathAnimator), Member = "Update")]
	[CalledBy(Type = typeof(CameraPathAnimator), Member = "PlayNextAnimation")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(CameraPathAnimator), Member = "get_cameraPath")]
	[Calls(Type = typeof(CameraPathPointList), Member = "get_realNumberOfPoints")]
	[Calls(Type = typeof(CameraPath), Member = "ParsePercentage")]
	[Calls(Type = typeof(CameraPathSpeedList), Member = "GetSpeed")]
	[Calls(Type = typeof(CameraPathDelayList), Member = "CheckEase")]
	[Calls(Type = typeof(CameraPath), Member = "GetPathPosition")]
	[Calls(Type = typeof(CameraPathAnimator), Member = "GetAnimatedOrientation")]
	[Calls(Type = typeof(CameraPathAnimator), Member = "get_isCamera")]
	[Calls(Type = typeof(Camera), Member = "get_orthographic")]
	[Calls(Type = typeof(CameraPathFOVList), Member = "GetValue")]
	[Calls(Type = typeof(Camera), Member = "set_orthographicSize")]
	[Calls(Type = typeof(CameraPathEventList), Member = "CheckEvents")]
	[Calls(Type = typeof(CameraPathDelayList), Member = "CheckEvents")]
	[Calls(Type = typeof(Camera), Member = "set_fieldOfView")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 28)]
	private void UpdateAnimation()
	{
	}

	[CalledBy(Type = typeof(CameraPathAnimator), Member = "Seek")]
	[CalledBy(Type = typeof(CameraPathAnimator), Member = "Update")]
	[CalledBy(Type = typeof(CameraPathAnimator), Member = "PlayNextAnimation")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CameraPathAnimator), Member = "get_cameraPath")]
	[Calls(Type = typeof(CameraPath), Member = "get_realNumberOfPoints")]
	[Calls(Type = typeof(CameraPath), Member = "get_Item")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdatePointReached()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPathAnimator), Member = "UpdateAnimationTime")]
	private void UpdateAnimationTime()
	{
	}

	[CalledBy(Type = typeof(CameraPathAnimator), Member = "Seek")]
	[CalledBy(Type = typeof(CameraPathAnimator), Member = "Update")]
	[CalledBy(Type = typeof(CameraPathAnimator), Member = "PlayNextAnimation")]
	[CalledBy(Type = typeof(CameraPathAnimator), Member = "UpdateAnimationTime")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateAnimationTime(bool advance)
	{
	}

	[CalledBy(Type = typeof(CameraPathAnimator), Member = "GetOrientation")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 7)]
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

	[CalledBy(Type = typeof(CameraPathAnimator), Member = "OnDisable")]
	[CalledBy(Type = typeof(CameraPathAnimator), Member = "OnDestroy")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CameraPathAnimator), Member = "get_cameraPath")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(CameraPathEventList), Member = "add_CameraPathEventPoint")]
	[Calls(Type = typeof(CameraPathDelayList), Member = "add_CameraPathDelayEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 18)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public CameraPathAnimator()
	{
	}
}
