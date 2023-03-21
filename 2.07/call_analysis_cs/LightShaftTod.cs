using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LightShaftTod : MonoBehaviour
{
	public enum LightShaftDirection
	{
		NORTH,
		EAST,
		SOUTH,
		WEST,
		NONE
	}

	public bool followTod;

	public bool m_FadeWithViewAngle;

	public Vector2 yMinMax;

	public Vector2 zMinMax;

	public bool useXRotation;

	public LightShaftDirection facingDirection;

	public float m_MaximumIntensity;

	public Light m_Light;

	public GameObject[] m_LightShaft;

	public bool m_UseLightColour;

	private float m_ExternalIntensity;

	private float m_TodIntensity;

	private float yDirection;

	private float tod;

	private float xtemp;

	private float m_Dot;

	private float m_lValOrg;

	private Renderer[] m_LightShaftRenderer;

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LightShaftTod), Member = "UpdateRotation")]
	[Calls(Type = typeof(LightShaftTod), Member = "UpdateMaterial")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[CallsUnknownMethods(Count = 2)]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(LightShaftTod), Member = "Update")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	private void UpdateRotation(float tod)
	{
	}

	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(LightShaftTod), Member = "Update")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[Calls(Type = typeof(LightShaftTod), Member = "CalculateDot")]
	[Calls(Type = typeof(LightShaftTod), Member = "CalculateDot")]
	[Calls(Type = typeof(Light), Member = "get_intensity")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	private void UpdateMaterial()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateLight()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetExternalIntensity(float newIntensity)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void SetTimeOfDayIntensity(float todIntensity)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void SetFollowTimeOfDay(bool followTod)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[CalledBy(Type = typeof(LightShaftTod), Member = "UpdateMaterial")]
	[CalledBy(Type = typeof(LightShaftTod), Member = "UpdateMaterial")]
	[CallsUnknownMethods(Count = 6)]
	private float CalculateDot()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private float AngleDir(Vector3 fwd, Vector3 targetDir, Vector3 up)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public LightShaftTod()
	{
	}
}
