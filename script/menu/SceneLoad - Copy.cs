using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SceneLoad : MonoBehaviour
{
    public Slider progressbar;
    private void Start()
{
    StartCoroutine(LoadScene());
}
IEnumerator LoadScene()
{
    yield return null;
    AsyncOperation operation = SceneManager.LoadSceneAsync("stage"); 
                                                                    
    float timer = 3f;

    while (!operation.isDone)
    {
        yield return null;

        timer += Time.deltaTime;
        if (operation.progress < 0.9f)
        {
            progressbar.value = Mathf.Lerp(operation.progress, 1f, timer);
            if (progressbar.value >= operation.progress)
                timer = 0f;
        }
        else
        {
            progressbar.value = Mathf.Lerp(progressbar.value, 1f, timer);
            if (progressbar.value >= 0.99f)
                operation.allowSceneActivation = true;
        }

    }
}

       

}
