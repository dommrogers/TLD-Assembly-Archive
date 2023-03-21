using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CameraPathPoint : MonoBehaviour
{
	public enum PositionModes
	{
		Free,
		FixedToPoint,
		FixedToPercent
	}

	public PositionModes positionModes;

	public string givenName;

	public string customName;

	public string fullName;

	protected float _percent;

	protected float _animationPercentage;

	public CameraPathControlPoint point;

	public int index;

	public CameraPathControlPoint cpointA;

	public CameraPathControlPoint cpointB;

	public float curvePercentage;

	public Vector3 worldPosition;

	public bool lockPoint;

	public float percent
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0f;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public float rawPercent
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0f;
		}
	}

	public float animationPercentage
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0f;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public string displayName
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "EqualsHelper")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void OnEnable()
	{
	}

	[CalledBy(Type = typeof(CameraPathDelay), Member = ".ctor")]
	[CalledBy(Type = typeof(CameraPathEvent), Member = ".ctor")]
	[CalledBy(Type = typeof(CameraPathFOV), Member = ".ctor")]
	[CalledBy(Type = typeof(CameraPathOrientation), Member = ".ctor")]
	[CalledBy(Type = typeof(CameraPathSpeed), Member = ".ctor")]
	[CalledBy(Type = typeof(CameraPathTilt), Member = ".ctor")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public CameraPathPoint()
	{
	}
}
