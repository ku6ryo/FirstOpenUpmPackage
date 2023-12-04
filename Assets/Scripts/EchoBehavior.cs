using UnityEngine;

namespace io.ku6ryo.FirstPackage
{

    public class EchoBehaviour: MonoBehaviour
    {
        public void OnEnable ()
        {
            var echo = new Echo();
            Debug.Log(echo.echo("Hello World!"));
        }
    }
}