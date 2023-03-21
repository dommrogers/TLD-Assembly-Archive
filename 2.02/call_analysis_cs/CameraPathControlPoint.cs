using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CameraPathControlPoint : MonoBehaviour
{
	public string givenName;

	public string customName;

	public string fullName;

	private Vector3 _position;

	private bool _splitControlPoints;

	private Vector3 _forwardControlPoint;

	private Vector3 _backwardControlPoint;

	private Vector3 _pathDirection;

	public int index;

	public float percentage;

	public float normalisedPercentage;

	public Vector3 localPosition
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		get
		{
			return default(Vector3);
		}
		[CalledBy(Type = typeof(CameraPath), Member = "AddPoint")]
		[CalledBy(Type = typeof(CameraPath), Member = "Init")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(Quaternion), Member = "Inverse")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		set
		{
		}
	}

	public Vector3 worldPosition
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CameraPathControlPoint), Member = "LocalToWorldPosition")]
		get
		{
			return default(Vector3);
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CameraPathControlPoint), Member = "WorldToLocalPosition")]
		set
		{
		}
	}

	public Vector3 forwardControlPointWorld
	{
		[CalledBy(Type = typeof(CameraPath), Member = "GetPathPosition")]
		[CalledBy(Type = typeof(CameraPath), Member = "RecalculateStoredValues")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CameraPathControlPoint), Member = "get_forwardControlPoint")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		get
		{
			return default(Vector3);
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CameraPathControlPoint), Member = "set_forwardControlPoint")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		set
		{
		}
	}

	public Vector3 forwardControlPoint
	{
		[CalledBy(Type = typeof(CameraPathControlPoint), Member = "get_forwardControlPointWorld")]
		[CalledBy(Type = typeof(CameraPathOrientationList), Member = "AddOrientation")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		get
		{
			return default(Vector3);
		}
		[CalledBy(Type = typeof(CameraPath), Member = "Init")]
		[CalledBy(Type = typeof(CameraPathControlPoint), Member = "set_forwardControlPointWorld")]
		[CalledBy(Type = typeof(CameraPathControlPoint), Member = "CopyData")]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(Quaternion), Member = "Inverse")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		set
		{
		}
	}

	public Vector3 forwardControlPointLocal
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		get
		{
			return default(Vector3);
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Quaternion), Member = "Inverse")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		set
		{
		}
	}

	public Vector3 backwardControlPointWorld
	{
		[CalledBy(Type = typeof(CameraPath), Member = "GetPathPosition")]
		[CalledBy(Type = typeof(CameraPath), Member = "RecalculateStoredValues")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CameraPathControlPoint), Member = "get_backwardControlPoint")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		get
		{
			return default(Vector3);
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CameraPathControlPoint), Member = "set_backwardControlPoint")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		set
		{
		}
	}

	public Vector3 backwardControlPoint
	{
		[CalledBy(Type = typeof(CameraPathControlPoint), Member = "get_backwardControlPointWorld")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		get
		{
			return default(Vector3);
		}
		[CalledBy(Type = typeof(CameraPathControlPoint), Member = "set_backwardControlPointWorld")]
		[CalledBy(Type = typeof(CameraPathControlPoint), Member = "CopyData")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Quaternion), Member = "Inverse")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		set
		{
		}
	}

	public bool splitControlPoints
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public Vector3 trackDirection
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(Vector3);
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Vector3), Member = "get_zero")]
		[Calls(Type = typeof(Vector3), Member = "get_normalized")]
		[CallsDeduplicatedMethods(Count = 1)]
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

	[CalledBy(Type = typeof(CameraPathControlPoint), Member = "set_worldPosition")]
	[CalledBy(Type = typeof(CameraPathControlPoint), Member = "CopyData")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Quaternion), Member = "Inverse")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	public Vector3 WorldToLocalPosition(Vector3 _worldPosition)
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(CameraPath), Member = "RemovePoint")]
	[CalledBy(Type = typeof(CameraPath), Member = "GetPathPosition")]
	[CalledBy(Type = typeof(CameraPath), Member = "RecalculateStoredValues")]
	[CalledBy(Type = typeof(CameraPathControlPoint), Member = "get_worldPosition")]
	[CalledBy(Type = typeof(CameraPathControlPoint), Member = "CopyData")]
	[CalledBy(Type = typeof(CameraPathPointList), Member = "RecalculatePoints")]
	[CallerCount(Count = 22)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	public Vector3 LocalToWorldPosition(Vector3 _localPosition)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPathControlPoint), Member = "LocalToWorldPosition")]
	[Calls(Type = typeof(CameraPathControlPoint), Member = "WorldToLocalPosition")]
	[Calls(Type = typeof(CameraPathControlPoint), Member = "set_forwardControlPoint")]
	[Calls(Type = typeof(CameraPathControlPoint), Member = "set_backwardControlPoint")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void CopyData(CameraPathControlPoint to)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "get_forward")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public CameraPathControlPoint()
	{
	}
}
