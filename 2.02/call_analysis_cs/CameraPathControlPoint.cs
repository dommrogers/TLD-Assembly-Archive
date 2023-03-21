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
		[CallsDeduplicatedMethods(Count = 3)]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
		[CallsUnknownMethods(Count = 3)]
		get
		{
			return default(Vector3);
		}
		[CalledBy(Type = typeof(CameraPath), Member = "Init")]
		[CallsUnknownMethods(Count = 3)]
		[CalledBy(Type = typeof(CameraPath), Member = "Init")]
		[CalledBy(Type = typeof(CameraPath), Member = "Init")]
		[CalledBy(Type = typeof(CameraPath), Member = "Init")]
		[CalledBy(Type = typeof(CameraPath), Member = "AddPoint")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
		[CallerCount(Count = 5)]
		[CallsDeduplicatedMethods(Count = 3)]
		[Calls(Type = typeof(Quaternion), Member = "Inverse")]
		set
		{
		}
	}

	public Vector3 worldPosition
	{
		[Calls(Type = typeof(CameraPathControlPoint), Member = "LocalToWorldPosition")]
		[CallerCount(Count = 0)]
		get
		{
			return default(Vector3);
		}
		[Calls(Type = typeof(CameraPathControlPoint), Member = "WorldToLocalPosition")]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public Vector3 forwardControlPointWorld
	{
		[CallsDeduplicatedMethods(Count = 3)]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CameraPathControlPoint), Member = "get_forwardControlPoint")]
		[CalledBy(Type = typeof(CameraPath), Member = "RecalculateStoredValues")]
		[CallsUnknownMethods(Count = 3)]
		[CalledBy(Type = typeof(CameraPath), Member = "RecalculateStoredValues")]
		[CalledBy(Type = typeof(CameraPath), Member = "GetPathPosition")]
		get
		{
			return default(Vector3);
		}
		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(CameraPathControlPoint), Member = "set_forwardControlPoint")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public Vector3 forwardControlPoint
	{
		[CalledBy(Type = typeof(CameraPathOrientationList), Member = "AddOrientation")]
		[CalledBy(Type = typeof(CameraPathControlPoint), Member = "get_forwardControlPointWorld")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		[CalledBy(Type = typeof(CameraPathOrientationList), Member = "AddOrientation")]
		get
		{
			return default(Vector3);
		}
		[CalledBy(Type = typeof(CameraPathControlPoint), Member = "set_forwardControlPointWorld")]
		[CalledBy(Type = typeof(CameraPath), Member = "Init")]
		[CalledBy(Type = typeof(CameraPath), Member = "Init")]
		[CalledBy(Type = typeof(CameraPath), Member = "Init")]
		[CalledBy(Type = typeof(CameraPath), Member = "Init")]
		[CallsDeduplicatedMethods(Count = 3)]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
		[Calls(Type = typeof(Quaternion), Member = "Inverse")]
		[CallsUnknownMethods(Count = 3)]
		[CalledBy(Type = typeof(CameraPathControlPoint), Member = "CopyData")]
		[CallerCount(Count = 6)]
		set
		{
		}
	}

	public Vector3 forwardControlPointLocal
	{
		[CallsDeduplicatedMethods(Count = 3)]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
		[CallsUnknownMethods(Count = 3)]
		[CallerCount(Count = 0)]
		get
		{
			return default(Vector3);
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Quaternion), Member = "Inverse")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
		[CallsUnknownMethods(Count = 3)]
		[CallsDeduplicatedMethods(Count = 3)]
		set
		{
		}
	}

	public Vector3 backwardControlPointWorld
	{
		[CalledBy(Type = typeof(CameraPath), Member = "RecalculateStoredValues")]
		[CallsUnknownMethods(Count = 3)]
		[CalledBy(Type = typeof(CameraPath), Member = "RecalculateStoredValues")]
		[CalledBy(Type = typeof(CameraPath), Member = "GetPathPosition")]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 3)]
		[Calls(Type = typeof(CameraPathControlPoint), Member = "get_backwardControlPoint")]
		get
		{
			return default(Vector3);
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[Calls(Type = typeof(CameraPathControlPoint), Member = "set_backwardControlPoint")]
		[CallsUnknownMethods(Count = 3)]
		set
		{
		}
	}

	public Vector3 backwardControlPoint
	{
		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallerCount(Count = 1)]
		[CalledBy(Type = typeof(CameraPathControlPoint), Member = "get_backwardControlPointWorld")]
		get
		{
			return default(Vector3);
		}
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		[CalledBy(Type = typeof(CameraPathControlPoint), Member = "CopyData")]
		[CalledBy(Type = typeof(CameraPathControlPoint), Member = "set_backwardControlPointWorld")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
		[Calls(Type = typeof(Quaternion), Member = "Inverse")]
		[CallerCount(Count = 2)]
		set
		{
		}
	}

	public bool splitControlPoints
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(bool);
		}
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
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
		[Calls(Type = typeof(Vector3), Member = "get_normalized")]
		[Calls(Type = typeof(Vector3), Member = "get_zero")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string displayName
	{
		[Calls(Type = typeof(string), Member = "EqualsHelper")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private void OnEnable()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(CameraPathControlPoint), Member = "CopyData")]
	[CalledBy(Type = typeof(CameraPathControlPoint), Member = "set_worldPosition")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Quaternion), Member = "Inverse")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	public Vector3 WorldToLocalPosition(Vector3 _worldPosition)
	{
		return default(Vector3);
	}

	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CallerCount(Count = 22)]
	[CallsUnknownMethods(Count = 6)]
	public Vector3 LocalToWorldPosition(Vector3 _localPosition)
	{
		return default(Vector3);
	}

	[Calls(Type = typeof(CameraPathControlPoint), Member = "WorldToLocalPosition")]
	[Calls(Type = typeof(CameraPathControlPoint), Member = "LocalToWorldPosition")]
	[Calls(Type = typeof(CameraPathControlPoint), Member = "set_forwardControlPoint")]
	[Calls(Type = typeof(CameraPathControlPoint), Member = "set_backwardControlPoint")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void CopyData(CameraPathControlPoint to)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_forward")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public CameraPathControlPoint()
	{
	}
}
