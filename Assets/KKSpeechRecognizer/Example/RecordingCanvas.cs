using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using KKSpeech;

public class RecordingCanvas : MonoBehaviour
{
  //public GameObject testcube;
  public Button startRecordingButton;
  public Text resultText;

  void Start()
  {
    if (SpeechRecognizer.ExistsOnDevice())
    {
      SpeechRecognizerListener listener = GameObject.FindObjectOfType<SpeechRecognizerListener>();
      listener.onAuthorizationStatusFetched.AddListener(OnAuthorizationStatusFetched);
      listener.onAvailabilityChanged.AddListener(OnAvailabilityChange);
      listener.onErrorDuringRecording.AddListener(OnError);
      listener.onErrorOnStartRecording.AddListener(OnError);
      listener.onFinalResults.AddListener(OnFinalResult);
      listener.onPartialResults.AddListener(OnPartialResult);
      listener.onEndOfSpeech.AddListener(OnEndOfSpeech);
      SpeechRecognizer.RequestAccess();
    }
    else
    {
      resultText.text = "Sorry, but this device doesn't support speech recognition";
      startRecordingButton.enabled = false;
    }


  }

  public void OnFinalResult(string result)
  {
    startRecordingButton.GetComponentInChildren<Text>().text = "Start Recording";
    resultText.text = result;
    startRecordingButton.enabled = true;


    //Camera Placer
    if(result == "Exam" || result == "exam")
    {
      FindObjectOfType<CameraPlacer>().exam = true;     
    }

    if(result == "Office" || result == "office")
    {
      FindObjectOfType<CameraPlacer>().office = true;     
    }

    if(result == "kitchen" || result == "Kitchen")
    {
      FindObjectOfType<CameraPlacer>().kitchen = true;     
    }

    if(result == "freeze" || result == "Freeze")
    {
      FindObjectOfType<CameraPlacer>().Freeze = true;     
    }

    if(result == "hide" || result == "Hide")
    {
      FindObjectOfType<CameraPlacer>().hide = true;     
    }

    if(result == "yes" || result == "Yes")
    {
      FindObjectOfType<CameraPlacer>().test = true;     
    }


    //Swap

    if(result == "Office Changed" || result == "office changed" || result == "office Changed" || result == "Office changed")
    {
      FindObjectOfType<GameManaging>().OC = true;
    }

    if(result == "Exam Changed" || result == "exam changed" || result == "exam Changed" || result == "Exam changed")
    {
      FindObjectOfType<GameManaging>().EC = true;
    }

    if(result == "Office Changed" || result == "office changed" || result == "office Changed" || result == "Office changed")
    {
      FindObjectOfType<GameManaging>().KC = true;
    }

        //MaterialSwap

    if (result == "Office Color" || result == "office color" || result == "office Color" || result == "Office color")
    { 
      FindObjectOfType<GameManaging>().OM = true;
    }

    if (result == "Exam Color" || result == "exam color" || result == "exam Color" || result == "Exam color")
    { 
      FindObjectOfType<GameManaging>().EM = true;
    }

    if (result == "Kitchen Color" || result == "kitchen color" || result == "kitchen Color" || result == "Kitchen color")
    { 
      FindObjectOfType<GameManaging>().KM = true;
    }

    //Appear

    if (result == "Office New" || result == "office new" || result == "office New" || result == "Office new")
    { 
      FindObjectOfType<GameManaging>().ON = true;
    }

    if (result == "Kitchen New" || result == "kitchen new" || result == "kitchen New" || result == "Kitchen new")
    { 
      FindObjectOfType<GameManaging>().KN = true;
    }

    if (result == "Exam New" || result == "exam new" || result == "exam New" || result == "Exam new")
    { 
      FindObjectOfType<GameManaging>().EN = true;
    }

    //Disappear

    if (result == "Office Missing" || result == "office missing" || result == "office Missing" || result == "Office missing")
    { 
      FindObjectOfType<GameManaging>().OD = true;
    }

    if (result == "Kitchen Missing" || result == "kitchen missing" || result == "kitchen Missing" || result == "Kitchen missing")
    { 
      FindObjectOfType<GameManaging>().KD = true;
    }

    if (result == "Exam Missing" || result == "exam missing" || result == "exam Missing" || result == "Exam missing")
    { 
      FindObjectOfType<GameManaging>().ED = true;
    }
  }

  public void OnPartialResult(string result)
  {
    resultText.text = result;
  }

  public void OnAvailabilityChange(bool available)
  {
    startRecordingButton.enabled = available;
    if (!available)
    {
      resultText.text = "Speech Recognition not available";
    }
    else
    {
      resultText.text = "Say something :-)";
    }
  }

  public void OnAuthorizationStatusFetched(AuthorizationStatus status)
  {
    switch (status)
    {
      case AuthorizationStatus.Authorized:
        startRecordingButton.enabled = true;
        break;
      default:
        startRecordingButton.enabled = false;
        resultText.text = "Cannot use Speech Recognition, authorization status is " + status;
        break;
    }
  }

  public void OnEndOfSpeech()
  {
    startRecordingButton.GetComponentInChildren<Text>().text = "Start Recording";
  }

  public void OnError(string error)
  {
    Debug.LogError(error);
    startRecordingButton.GetComponentInChildren<Text>().text = "Start Recording";
    startRecordingButton.enabled = true;
  }

  public void OnStartRecordingPressed()
  {
    if (SpeechRecognizer.IsRecording())
    {
#if UNITY_IOS && !UNITY_EDITOR
			SpeechRecognizer.StopIfRecording();
			startRecordingButton.GetComponentInChildren<Text>().text = "Stopping";
			startRecordingButton.enabled = false;
#elif UNITY_ANDROID && !UNITY_EDITOR
			SpeechRecognizer.StopIfRecording();
			startRecordingButton.GetComponentInChildren<Text>().text = "Start Recording";
#endif
    }
    else
    {
      SpeechRecognizer.StartRecording(true);
      startRecordingButton.GetComponentInChildren<Text>().text = "Stop Recording";
      resultText.text = "Wait for K to be done, then press the button.";
    }
  }
}
