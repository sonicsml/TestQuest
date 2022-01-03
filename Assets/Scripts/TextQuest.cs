using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class TextQuest : MonoBehaviour
{
  #region Variables

  public Text ContenLabel;
  public Step InitStep;

  private Step _currentStep;

  #endregion

  #region Unity lifecycle

  private void Start()
  {
    _currentStep = InitStep;
    ContenLabel.text = _currentStep.Content;
  }

  private void Update()
  {
    int nextStepNumber = GetStepNumber();
    if (nextStepNumber == -1)
    {
      return;
    }

    SetStep(nextStepNumber);

    if (Input.GetKeyDown(KeyCode.Alpha1))
    {
//      SetStep(_currentStep.FirstStep);
    }

    if (Input.GetKeyDown(KeyCode.Alpha2))
    {
//      SetStep(_currentStep.SecondStep);
    }
  }

  #endregion

  #region Private methods

  private void SetStep(Step nextStep)
  {
    if (nextStep == null)
    {
      return;
    }

    _currentStep = nextStep;
    ContenLabel.text = _currentStep.Content;
  }

  private void SetStep(int nextStepNumberIndex)
  {
    if (IsValidIndex(nextStepNumberIndex))
    {
      return;
    }

    Step nextStep = _currentStep.Steps[nextStepNumberIndex];
    SetStep(nextStep);
  }

  private bool IsValidIndex(int nextStepNumberIndex)
  {
    return nextStepNumberIndex < 0 || nextStepNumberIndex > _currentStep.Steps.Length - 1;
  }

  private int GetStepNumber()
  {
    if (Input.GetKeyDown(KeyCode.Alpha1))
    {
      return 0;
    }

    if (Input.GetKeyDown(KeyCode.Alpha2))
    {
      return 1;
    }

    if (Input.GetKeyDown(KeyCode.Alpha3))
    {
      return 2;
    }

    if (Input.GetKeyDown(KeyCode.Alpha4))
    {
      return 3;
    }

    if (Input.GetKeyDown(KeyCode.Alpha5))
    {
      return 4;
    }

    return -1;
  }

  #endregion
}