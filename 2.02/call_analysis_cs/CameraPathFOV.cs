using Cpp2ILInjected.CallAnalysis;

public class CameraPathFOV : CameraPathPoint
{
	public float FOV;

	public float Size;

	[Calls(Type = typeof(CameraPathPoint), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public CameraPathFOV()
	{
	}
}
