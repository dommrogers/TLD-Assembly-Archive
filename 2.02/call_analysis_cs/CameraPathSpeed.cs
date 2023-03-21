using Cpp2ILInjected.CallAnalysis;

public class CameraPathSpeed : CameraPathPoint
{
	public float _speed;

	public float speed
	{
		[CallerCount(Count = 0)]
		get
		{
			return 0f;
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPathPoint), Member = ".ctor")]
	public CameraPathSpeed()
	{
	}
}
