using Cpp2ILInjected.CallAnalysis;

namespace Rewired;

public interface IGamepadTemplate : IControllerTemplate
{
	IControllerTemplateButton actionBottomRow1
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		get;
	}

	IControllerTemplateButton a
	{
		[CallerCount(Count = 101224)]
		[DeduplicatedMethod]
		get;
	}

	IControllerTemplateButton actionBottomRow2
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		get;
	}

	IControllerTemplateButton b
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		get;
	}

	IControllerTemplateButton actionBottomRow3
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		get;
	}

	IControllerTemplateButton c
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		get;
	}

	IControllerTemplateButton actionTopRow1
	{
		[CallerCount(Count = 101224)]
		[DeduplicatedMethod]
		get;
	}

	IControllerTemplateButton x
	{
		[CallerCount(Count = 101224)]
		[DeduplicatedMethod]
		get;
	}

	IControllerTemplateButton actionTopRow2
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		get;
	}

	IControllerTemplateButton y
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		get;
	}

	IControllerTemplateButton actionTopRow3
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		get;
	}

	IControllerTemplateButton z
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		get;
	}

	IControllerTemplateButton leftShoulder1
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		get;
	}

	IControllerTemplateButton leftBumper
	{
		[CallerCount(Count = 101224)]
		[DeduplicatedMethod]
		get;
	}

	IControllerTemplateAxis leftShoulder2
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		get;
	}

	IControllerTemplateAxis leftTrigger
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		get;
	}

	IControllerTemplateButton rightShoulder1
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		get;
	}

	IControllerTemplateButton rightBumper
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		get;
	}

	IControllerTemplateAxis rightShoulder2
	{
		[CallerCount(Count = 101224)]
		[DeduplicatedMethod]
		get;
	}

	IControllerTemplateAxis rightTrigger
	{
		[CallerCount(Count = 101224)]
		[DeduplicatedMethod]
		get;
	}

	IControllerTemplateButton center1
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		get;
	}

	IControllerTemplateButton back
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		get;
	}

	IControllerTemplateButton center2
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		get;
	}

	IControllerTemplateButton start
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		get;
	}

	IControllerTemplateButton center3
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		get;
	}

	IControllerTemplateButton guide
	{
		[CallerCount(Count = 101224)]
		[DeduplicatedMethod]
		get;
	}

	IControllerTemplateThumbStick leftStick
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		get;
	}

	IControllerTemplateThumbStick rightStick
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		get;
	}

	IControllerTemplateDPad dPad
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		get;
	}
}
