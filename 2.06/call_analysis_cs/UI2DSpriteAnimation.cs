using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UI2DSpriteAnimation : MonoBehaviour
{
	protected int framerate;

	public bool ignoreTimeScale;

	public bool loop;

	public Sprite[] frames;

	private SpriteRenderer mUnitySprite;

	private UI2DSprite mNguiSprite;

	private int mIndex;

	private float mUpdate;

	public bool isPlaying
	{
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 59)]
		[DeduplicatedMethod]
		get
		{
			return default(bool);
		}
	}

	public int framesPerSecond
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 11)]
		get
		{
			return default(int);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UI2DSpriteAnimation), Member = "UpdateSprite")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void Play()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void Pause()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UI2DSpriteAnimation), Member = "UpdateSprite")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UI2DSpriteAnimation), Member = "UpdateSprite")]
	public void ResetToBeginning()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UI2DSpriteAnimation), Member = "UpdateSprite")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(UI2DSpriteAnimation), Member = "Play")]
	[CalledBy(Type = typeof(UI2DSpriteAnimation), Member = "Start")]
	[CalledBy(Type = typeof(UI2DSpriteAnimation), Member = "ResetToBeginning")]
	[CalledBy(Type = typeof(UI2DSpriteAnimation), Member = "ResetToBeginning")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 5)]
	private void UpdateSprite()
	{
	}

	[CallerCount(Count = 0)]
	public UI2DSpriteAnimation()
	{
	}
}
