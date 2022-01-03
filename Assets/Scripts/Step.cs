using UnityEngine;
  public class Step : MonoBehaviour
  {
    [TextArea(minLines:6, maxLines:10)]
    public string Content;

    public Step[] Steps;
//    public Step FirstStep;
//    public Step SecondStep;
  }